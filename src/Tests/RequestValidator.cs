using System;
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
            func(new ElasticsearchClient(new RequestValidatorPool(expectedMethod, expectedUri)));
        }

        private class RequestValidatorPool : IConnection
        {
            private readonly string mExpectedMethod;
            private readonly string mExpectedUri;
            private readonly Action<HttpContent> mContentValidator;

            internal RequestValidatorPool(string expectedMethod, string expectedUri, 
                Action<HttpContent> contentValidator = null)
            {
                mExpectedMethod = expectedMethod;
                mExpectedUri = expectedUri;
                mContentValidator = contentValidator;
            }

            public Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, HttpContent content = null)
            {
                return Task.FromResult(Execute(httpMethod, uri, content));
            }

            public HttpResponseMessage Execute(string httpMethod, string uri, HttpContent content = null)
            {
                Assert.Equal(mExpectedMethod, httpMethod);
                Assert.Equal(mExpectedUri, uri);
                mContentValidator?.Invoke(content);
                return null;
            }

            public void Dispose()
            {
            }
        }
    }
}
