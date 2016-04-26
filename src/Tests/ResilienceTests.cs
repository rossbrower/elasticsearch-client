using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
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
                await Task.WhenAll(Enumerable.Range(0, 100).Select(asi => client.ClusterHealthAsync()));
            }
        }

        [Fact]
        public async Task ConnectionPoolRandomFailures()
        {
            var uris = new[] {"http://localhost:9200"};
            var query = Encoding.UTF8.GetBytes("{\"match_all\":{}}");
            using (var pool = new ConnectionPool(uris, new ExceptionDispatcher()))
            {
                var client = new ElasticsearchClient(pool);
                await Task.WhenAll(Enumerable.Range(0, 1000).Select(async i =>
                {
                    try
                    {
                        return await client.SearchPostAsync(query);
                    }
                    catch (RandomException)
                    {
                        return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                        {
                            ReasonPhrase = "Random!"
                        };
                    }
                }));
            }
        }

        private class ExceptionDispatcher : IDispatcher
        {
            private readonly Random mRandom;

            public ExceptionDispatcher()
            {
                mRandom = new Random();
            }

            public async Task<HttpResponseMessage> ExecuteAsync(HttpClient client, string httpMethod, string uri,
                HttpContent content = null)
            {
                var message = new HttpRequestMessage(new HttpMethod(httpMethod), uri)
                {
                    Content = content
                };
                if (mRandom.Next(20) == 1)
                {
                    throw new RandomException();
                }
                return await client.SendAsync(message).ConfigureAwait(false);
            }
        }

        private class RandomException : Exception
        {
        }
    }
}
