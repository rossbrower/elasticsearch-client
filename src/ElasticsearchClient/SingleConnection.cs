using System;
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

        public virtual async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri,
            HttpContent content = null)
        {
            return await mDispatcher.ExecuteAsync(mClient, httpMethod, uri, content);
        }

        public HttpResponseMessage Execute(string httpMethod, string uri, HttpContent content = null)
        {
            return mDispatcher.Execute(mClient, httpMethod, uri, content);
        }

        public void Dispose()
        {
            mClient.Dispose();
        }
    }
}
