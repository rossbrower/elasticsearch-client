using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Elasticsearch.Client.Tests
{
    public class ResilienceTests
    {
        [Fact]
        public async Task ConnectionPoolBadUris()
        {
            var uris = new[] {"http://localhost:7777", "http://localhost:9200", "http://local.foo"};
            using (var pool = new ConnectionPool(uris))
            {
                var client = new ElasticsearchClient(pool);
                for (int i = 0; i < 100; i++)
                {
                    client.ClusterHealth();
                }
                await Task.WhenAll(Enumerable.Range(0, 100).Select(asi => client.ClusterHealthAsync()));
            }
        }

        [Fact]
        public async Task ConnectionPoolRandomFailures()
        {
            var exception = new HttpRequestException("Fail!");
            var uris = new[] {"http://localhost:7777", "http://localhost:9200", "http://local.foo"};
            using (var pool = new ConnectionPool(uris, new ExceptionDispatcher<HttpRequestException>(exception)))
            {
                var client = new ElasticsearchClient(pool);
                for (int i = 0; i < 1000; i++)
                {
                    client.ClusterHealth();
                }
                await Task.WhenAll(Enumerable.Range(0, 1000).Select(i => client.ClusterHealthAsync()));
            }
        }        

        private class ExceptionDispatcher<T>: IDispatcher where T: Exception
        {
            private readonly Random mRandom;
            private readonly T mException;

            public ExceptionDispatcher(T exception)
            {
                mException = exception;
                mRandom = new Random();
            }

            public HttpResponseMessage Execute(HttpClient client, string httpMethod, string uri, HttpContent content = null)
            {
                if (mRandom.Next(20) == 1)
                {
                    throw mException;
                }
                return new HttpResponseMessage(HttpStatusCode.OK);
            }

            public Task<HttpResponseMessage> ExecuteAsync(HttpClient client, string httpMethod, string uri, HttpContent content = null)
            {
                return Task.FromResult(Execute(client, httpMethod, uri, content));
            }
        }
    }
}
