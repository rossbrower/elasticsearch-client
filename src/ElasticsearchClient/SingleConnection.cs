using System;
using System.IO;
using System.Net.Http;
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
        /// <param name="dispatcher">Optional dispatcher.</param>
        public SingleConnection(string uri = "http://localhost:9200", IDispatcher dispatcher = null)
        {
            mDispatcher = dispatcher ?? new Dispatcher();
            mClient = new HttpClient {BaseAddress = new Uri(uri)};
        }

        public void Dispose()
        {
            mClient.Dispose();
        }

        public async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri)
        {
            return await mDispatcher.ExecuteAsync(mClient, httpMethod, uri);
        }

        public async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, Stream body)
        {
            if (body == null)
            {
                return await mDispatcher.ExecuteAsync(mClient, httpMethod, uri);
            }
            return await mDispatcher.ExecuteAsync(mClient, httpMethod, uri, new StreamContent(body));
        }

        public async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, byte[] body)
        {
            if (body == null)
            {
                return await mDispatcher.ExecuteAsync(mClient, httpMethod, uri);
            }
            return await mDispatcher.ExecuteAsync(mClient, httpMethod, uri, new ByteArrayContent(body));
        }

        public async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, string body)
        {
            if (body == null)
            {
                return await mDispatcher.ExecuteAsync(mClient, httpMethod, uri);
            }
            return await mDispatcher.ExecuteAsync(mClient, httpMethod, uri, new StringContent(body));
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
    }
}
