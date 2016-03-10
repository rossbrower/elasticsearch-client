using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Elasticsearch.Client.Tests
{
    public static class RequestValidator
    {
        public static void Validate(Func<ElasticsearchClient, HttpResponseMessage> func,
            string expectedMethod, string expectedUri)
        {
            func(new RequestValidatorClient(expectedMethod, expectedUri));
        }

        private class RequestValidatorClient : ElasticsearchClient
        {
            private readonly string mExpectedMethod;
            private readonly string mExpectedUri;

            internal RequestValidatorClient(string expectedMethod, string expectedUri) : base(null)
            {
                mExpectedMethod = expectedMethod;
                mExpectedUri = expectedUri;
            }

            public override Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri)
            {
                return Validate(httpMethod, uri);
            }

            public override Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, Stream body)
            {
                return Validate(httpMethod, uri);
            }

            public override Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, byte[] body)
            {
                return Validate(httpMethod, uri);
            }

            public override Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, string body)
            {
                return Validate(httpMethod, uri);
            }

            public override HttpResponseMessage Execute(string httpMethod, string uri)
            {
                return Validate(httpMethod, uri).Result;
            }

            public override HttpResponseMessage Execute(string httpMethod, string uri, Stream body)
            {
                return Validate(httpMethod, uri).Result;
            }

            public override HttpResponseMessage Execute(string httpMethod, string uri, byte[] body)
            {
                return Validate(httpMethod, uri).Result;
            }

            public override HttpResponseMessage Execute(string httpMethod, string uri, string body)
            {
                return Validate(httpMethod, uri).Result;
            }

            private Task<HttpResponseMessage> Validate(string httpMethod, string uri)
            {
                Assert.Equal(mExpectedMethod, httpMethod);
                Assert.Equal(mExpectedUri, uri);
                return Task.FromResult<HttpResponseMessage>(null);
            }
        }
    }
}
