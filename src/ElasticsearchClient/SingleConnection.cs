using System;
using System.Net.Http;

namespace Elasticsearch.Client
{
    /// <summary>
    /// Single connection client.
    /// No failure detection provided.
    /// </summary>
    public class SingleConnection : ConnectionBase, IDisposable
    {
        private readonly HttpClient mClient;

        /// <summary>
        /// Create a new SingleConnection.
        /// </summary>        
        /// <param name="uri">Optional uri of the node.</param>
        /// <param name="dispatcher">Optional dispatcher.</param>
        public SingleConnection(string uri = "http://localhost:9200", IDispatcher dispatcher = null)
            : base(dispatcher)
        {
            mClient = new HttpClient {BaseAddress = new Uri(uri)};
        }

        protected override HttpClient GetClient()
        {
            return mClient;
        }

        public void Dispose()
        {
            mClient.Dispose();
        }
    }
}
