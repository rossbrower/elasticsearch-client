using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
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
                var responses = await Task.WhenAll(Enumerable.Range(0, 100).Select(asi => client.ClusterHealthAsync()));
                PrintResults(responses);
            }
        }

        [Fact]
        public async Task ConnectionPoolRandomFailures()
        {
            var uris = new[] {"http://localhost:9200", "http://localhost:9200" , "http://localhost:9200" };
            using (var pool = new ConnectionPool(uris, new ExceptionDispatcher(new Dispatcher()), true))
            {
                var client = new ElasticsearchClient(pool);
                var responses = await Task.WhenAll(Enumerable.Range(0, 1000).Select(async i =>
                {
                    try
                    {
                        return await client.SearchPostAsync();
                    }
                    catch (RandomException)
                    {
                        return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                        {
                            ReasonPhrase = "Random!"
                        };
                    }
                    catch (InvalidOperationException)
                    {
                        return new HttpResponseMessage(HttpStatusCode.NotFound)
                        {
                            ReasonPhrase = "No Servers"
                        };
                    }
                }));
                PrintResults(responses);
            }
        }

        [Fact]
        public async Task DispatcherTooManyRequestsRetry()
        {
            var client = new TooManyRequestsClient();
            var dispatcher = new Dispatcher(10);
            var responses = await Task.WhenAll(Enumerable.Range(0, 1000)
                .Select(asi => dispatcher.ExecuteAsync(client, "GET", "http://nowhere")));
            PrintResults(responses);
        }

        private static void PrintResults(HttpResponseMessage[] responses)
        {
            foreach (var group in responses.GroupBy(r => r.StatusCode))
            {
                Debug.WriteLine($"{group.Key}: {group.Count()}");   
            }
        }

        private class ExceptionDispatcher : IDispatcher
        {
            private readonly Random mRandom;
            private readonly IDispatcher mBaseDispatcher;

            public ExceptionDispatcher(IDispatcher baseDispatcher)
            {
                mRandom = new Random();
                mBaseDispatcher = baseDispatcher;
            }

            public async Task<HttpResponseMessage> ExecuteAsync(HttpClient client, string httpMethod, string uri,
                HttpContent content = null)
            {
                var rand = mRandom.Next(20);
                switch (rand)
                {
                    case 1: throw new RandomException();
                    case 2: return new HttpResponseMessage(HttpStatusCode.ServiceUnavailable);
                }
                return await mBaseDispatcher.ExecuteAsync(client, httpMethod, uri, content).ConfigureAwait(false);
            }
        }

        private class RandomException : Exception
        {
        }

        private class TooManyRequestsClient: HttpClient
        {
            private readonly Random mRandom;

            public TooManyRequestsClient()
            {
                mRandom = new Random();
            }

            public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                var rand = mRandom.Next(2);
                if (rand == 1)
                {
                    return Task.FromResult(new HttpResponseMessage((HttpStatusCode) 429));
                }
                return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK));
            }
        }
    }
}
