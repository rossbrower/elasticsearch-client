using System;
using System.Net.Http;

namespace Elasticsearch.Client
{
    public class SingleConnectionPool : IConnectionPool
    {
        private readonly HttpClient mClient;

        public SingleConnectionPool(string uri = "http://localhost:9200")
        {
            mClient = new HttpClient {BaseAddress = new Uri(uri)};
        }

        public HttpClient GetClient()
        {
            return mClient;
        }
    }
}
