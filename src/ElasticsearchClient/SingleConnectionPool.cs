using System;
using System.Net.Http;

namespace Elasticsearch.Client
{
    /// <summary>
    /// Single connection client.
    /// No failure detection provided.
    /// </summary>
    public class SingleConnectionPool : ConnectionPoolBase, IDisposable
    {
        private readonly HttpClient mClient;

        public SingleConnectionPool(string uri = "http://localhost:9200")
        {
            mClient = new HttpClient {BaseAddress = new Uri(uri)};
        }

        public override HttpClient GetClient()
        {
            return mClient;
        }

        public void Dispose()
        {
            mClient.Dispose();
        }
    }
}
