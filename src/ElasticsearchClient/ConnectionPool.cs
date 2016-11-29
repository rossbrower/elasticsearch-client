using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    /// <summary>
    /// Retries requests if exceptions are thrown and maintains a list of known good and bad uris.
    /// </summary>
    public class ConnectionPool : IConnection
    {
        private readonly HashSet<int> mFailureIds;
        private readonly HashSet<int> mSuccessIds;
        private readonly ReaderWriterLockSlim mLock;
        private readonly HttpClient[] mClients;
        private readonly IDispatcher mDispatcher;
        private readonly bool mRandomize;
        private readonly Random mRandom;

        /// <summary>
        /// Create a new ConnectionPool.
        /// </summary>
        /// <param name="uris">The list of uris to use in the pool.</param>
        /// <param name="dispatcher">Optional dispatcher implementation. If null, <see cref="Dispatcher"/> will be used.</param>
        /// <param name="randomize">Whether to randomize the list of uris on each request.</param>
        /// <param name="authenticationOptions">Optional authentication options for use with Shield.</param>
        public ConnectionPool(IEnumerable<string> uris, IDispatcher dispatcher = null, bool randomize = true, 
            AuthenticationOptions authenticationOptions = null)
        {
            mDispatcher = dispatcher ?? new Dispatcher();
            mFailureIds = new HashSet<int>();
            mSuccessIds = new HashSet<int>();
            mLock = new ReaderWriterLockSlim();
            mRandomize = randomize;
            if (randomize)
            {
                mRandom = new Random();
            }
            var uriArray = uris.ToArray();
            mClients = new HttpClient[uriArray.Length];
            for (var i = 0; i < uriArray.Length; i++)
            {
                var client = new HttpClient { BaseAddress = new Uri(uriArray[i]) };
                if (authenticationOptions != null)
                {
                    var bytes = Encoding.UTF8.GetBytes($"{authenticationOptions.Username}:{authenticationOptions.Password}");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                        Convert.ToBase64String(bytes));
                }
                mClients[i] = client;
                mSuccessIds.Add(i);
            }
        }

        /// <summary>
        /// Send a message to the given URI using the specified HTTP method.
        /// </summary>
        /// <param name="httpMethod">The HTTP method to use.</param>
        /// <param name="uri">The URI.</param>
        /// <returns>A Task which contains the response.</returns>
        public async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri)
        {
            return await ExecuteImpl(httpMethod, uri).ConfigureAwait(false);
        }

        /// <summary>
        /// Send a message to the given URI using the specified HTTP method and content.
        /// </summary>
        /// <param name="httpMethod">The HTTP method to use.</param>
        /// <param name="uri">The URI.</param>
        /// <param name="body">The content of the request as a Stream.</param>
        /// <returns>A Task which contains the response.</returns>
        public async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, Stream body)
        {
            byte[] content;
            using (var ms = new MemoryStream())
            {
                body.Position = 0;
                await body.CopyToAsync(ms).ConfigureAwait(false);
                content = ms.ToArray();
            }
            return await ExecuteAsync(httpMethod, uri, content).ConfigureAwait(false);
        }

        /// <summary>
        /// Send a message to the given URI using the specified HTTP method and content.
        /// </summary>
        /// <param name="httpMethod">The HTTP method to use.</param>
        /// <param name="uri">The URI.</param>
        /// <param name="body">The content of the request as a byte array.</param>
        /// <returns>A Task which contains the response.</returns>
        public async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, byte[] body)
        {
            return await ExecuteImpl(httpMethod, uri, () => new ByteArrayContent(body)).ConfigureAwait(false);
        }

        /// <summary>
        /// Send a message to the given URI using the specified HTTP method and content.
        /// </summary>
        /// <param name="httpMethod">The HTTP method to use.</param>
        /// <param name="uri">The URI.</param>
        /// <param name="body">The content of the request as a string.</param>
        /// <returns>A Task which contains the response.</returns>
        public async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, string body)
        {
            return await ExecuteImpl(httpMethod, uri, () => new StringContent(body)).ConfigureAwait(false);
        }

        /// <summary>
        /// Send a message to the given URI using the specified HTTP method.
        /// </summary>
        /// <param name="httpMethod">The HTTP method to use.</param>
        /// <param name="uri">The URI.</param>
        /// <returns>A <see cref="Task"/> which contains the response.</returns>
        public HttpResponseMessage Execute(string httpMethod, string uri)
        {
            return ExecuteAsync(httpMethod, uri).Result;
        }

        /// <summary>
        /// Send a message to the given URI using the specified HTTP method and content.
        /// </summary>
        /// <param name="httpMethod">The HTTP method to use.</param>
        /// <param name="uri">The URI.</param>
        /// <param name="body">The content of the request as a <see cref="Stream"/>.</param>
        /// <returns>The response.</returns>
        public HttpResponseMessage Execute(string httpMethod, string uri, Stream body)
        {
            return ExecuteAsync(httpMethod, uri, body).Result;
        }

        /// <summary>
        /// Send a message to the given URI using the specified HTTP method and content.
        /// </summary>
        /// <param name="httpMethod">The HTTP method to use.</param>
        /// <param name="uri">The URI.</param>
        /// <param name="body">The content of the request as a byte array.</param>
        /// <returns>The response.</returns>
        public HttpResponseMessage Execute(string httpMethod, string uri, byte[] body)
        {
            return ExecuteAsync(httpMethod, uri, body).Result;
        }

        /// <summary>
        /// Send a message to the given URI using the specified HTTP method. and content.
        /// </summary>
        /// <param name="httpMethod">The HTTP method to use.</param>
        /// <param name="uri">The URI.</param>
        /// <param name="body">The content of the request as a string.</param>
        /// <returns>The response.</returns>
        public HttpResponseMessage Execute(string httpMethod, string uri, string body)
        {
            return ExecuteAsync(httpMethod, uri, body).Result;
        }

        /// <summary>
        /// Dispose the pool and all of its resources.
        /// </summary>
        public void Dispose()
        {
            mLock.Dispose();
            foreach (var httpClient in mClients)
            {
                httpClient.Dispose();
            }
        }

        private async Task<HttpResponseMessage> ExecuteImpl(string httpMethod, string uri, Func<HttpContent> contentFunc = null)
        {
            Exception exception = null;
            foreach (var clientId in GetSuccessIds())
            {
                try
                {
                    var resp = await mDispatcher.ExecuteAsync(mClients[clientId], httpMethod, uri, contentFunc?.Invoke()).ConfigureAwait(false);
                    if (resp.StatusCode == HttpStatusCode.ServiceUnavailable)
                    {
                        continue;
                    }
                    return resp;
                }
                catch (Exception e)
                {
                    exception = e;
                    RecordFailure(clientId);
                }
            }
            foreach (var clientId in GetFailureIds())
            {
                try
                {
                    var resp = await mDispatcher.ExecuteAsync(mClients[clientId], httpMethod, uri, contentFunc?.Invoke()).ConfigureAwait(false);
                    if (resp.StatusCode == HttpStatusCode.ServiceUnavailable)
                    {
                        continue;
                    }
                    RecordSuccess(clientId);
                    return resp;
                }
                catch (Exception e)
                {
                    exception = e;
                }
            }
            throw exception ?? new InvalidOperationException("No clients available to service the request.");
        }

        private int[] GetSuccessIds()
        {
            int[] ids;
            mLock.EnterReadLock();
            try
            {
                ids = new int[mSuccessIds.Count];
                mSuccessIds.CopyTo(ids);
            }
            finally
            {
                mLock.ExitReadLock();
            }
            if (mRandomize)
            {
                var n = ids.Length;
                while (n > 1)
                {
                    var k = mRandom.Next(n--);
                    var temp = ids[n];
                    ids[n] = ids[k];
                    ids[k] = temp;
                }
            }
            return ids;
        }

        private int[] GetFailureIds()
        {
            mLock.EnterReadLock();
            try
            {
                var ids = new int[mFailureIds.Count];
                mFailureIds.CopyTo(ids);
                return ids;
            }
            finally
            {
                mLock.ExitReadLock();
            }
        }

        private void RecordFailure(int clientId)
        {
            mLock.EnterWriteLock();
            try
            {
                mSuccessIds.Remove(clientId);
                mFailureIds.Add(clientId);
            }
            finally 
            {
                mLock.ExitWriteLock();
            }
        }

        private void RecordSuccess(int clientId)
        {
            mLock.EnterWriteLock();
            try
            {
                mFailureIds.Remove(clientId);
                mSuccessIds.Add(clientId);
            }
            finally
            {
                mLock.ExitWriteLock();
            }
        }
    }
}
