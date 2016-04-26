using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
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

        public ConnectionPool(IEnumerable<string> uris, IDispatcher dispatcher = null, bool randomize = false)
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
                mClients[i] = new HttpClient {BaseAddress = new Uri(uriArray[i])};
                mSuccessIds.Add(i);
            }
        }

        public async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri)
        {
            return await ExecuteImpl(httpMethod, uri);
        }

        public async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, Stream body)
        {
            byte[] content;
            using (var ms = new MemoryStream())
            {
                body.Position = 0;
                await body.CopyToAsync(ms);
                content = ms.ToArray();
            }
            return await ExecuteAsync(httpMethod, uri, content);
        }

        public async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, byte[] body)
        {
            return await ExecuteImpl(httpMethod, uri, () => new ByteArrayContent(body));
        }

        public async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, string body)
        {
            return await ExecuteImpl(httpMethod, uri, () => new StringContent(body));
        }

        public HttpResponseMessage Execute(string httpMethod, string uri)
        {
            return ExecuteAsync(httpMethod, uri).Result;
        }

        public HttpResponseMessage Execute(string httpMethod, string uri, Stream body)
        {
            return ExecuteAsync(httpMethod, uri, body).Result;
        }

        public HttpResponseMessage Execute(string httpMethod, string uri, byte[] body)
        {
            return ExecuteAsync(httpMethod, uri, body).Result;
        }

        public HttpResponseMessage Execute(string httpMethod, string uri, string body)
        {
            return ExecuteAsync(httpMethod, uri, body).Result;
        }

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
                    return await mDispatcher.ExecuteAsync(mClients[clientId], httpMethod, uri, contentFunc?.Invoke());
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
                    var resp = await mDispatcher.ExecuteAsync(mClients[clientId], httpMethod, uri, contentFunc?.Invoke());
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
