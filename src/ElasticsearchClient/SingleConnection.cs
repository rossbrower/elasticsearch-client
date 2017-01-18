using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    /// <summary>
    /// Single connection client.
    /// No failure detection provided.
    /// </summary>
    public class SingleConnection : IConnection
    {
        private readonly IDispatcher mDispatcher;
        private readonly HttpClient mClient;

        /// <summary>
        /// Create a new SingleConnection.
        /// </summary>        
        /// <param name="uri">Optional uri of the node.</param>
        /// <param name="dispatcher">Optional dispatcher implementation. If null, <see cref="Dispatcher"/> will be used.</param>
        /// <param name="authenticationOptions">Optional authentication options for use with Shield.</param>
        public SingleConnection(string uri = "http://localhost:9200", IDispatcher dispatcher = null,
            AuthenticationOptions authenticationOptions = null)
        {
            mDispatcher = dispatcher ?? new Dispatcher();
            mClient = new HttpClient {BaseAddress = new Uri(uri)};
            if (authenticationOptions != null)
            {
                var bytes = Encoding.UTF8.GetBytes($"{authenticationOptions.Username}:{authenticationOptions.Password}");
                mClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                    Convert.ToBase64String(bytes));
            }
        }

        /// <summary>
        /// Dispose the connection.
        /// </summary>
        public void Dispose()
        {
            mClient.Dispose();
        }

        /// <summary>
        /// Send a message to the given URI using the specified HTTP method.
        /// </summary>
        /// <param name="httpMethod">The HTTP method to use.</param>
        /// <param name="uri">The URI.</param>
        /// <returns>A Task which contains the response.</returns>
        public async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri)
        {
            return await mDispatcher.ExecuteAsync(mClient, httpMethod, uri).ConfigureAwait(false);
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
            if (body == null)
            {
                return await mDispatcher.ExecuteAsync(mClient, httpMethod, uri).ConfigureAwait(false);
            }
            return await mDispatcher.ExecuteAsync(mClient, httpMethod, uri, new StreamContent(body)).ConfigureAwait(false);
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
            if (body == null)
            {
                return await mDispatcher.ExecuteAsync(mClient, httpMethod, uri).ConfigureAwait(false);
            }
            return await mDispatcher.ExecuteAsync(mClient, httpMethod, uri, new ByteArrayContent(body)).ConfigureAwait(false);
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
            if (body == null)
            {
                return await mDispatcher.ExecuteAsync(mClient, httpMethod, uri).ConfigureAwait(false);
            }
            return await mDispatcher.ExecuteAsync(mClient, httpMethod, uri, new StringContent(body)).ConfigureAwait(false);
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
    }
}
