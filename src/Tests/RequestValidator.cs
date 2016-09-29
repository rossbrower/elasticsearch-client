using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Elasticsearch.Client.Tests
{
    public static class RequestValidator
    {
        public static void Validate(Func<ElasticsearchClient, HttpResponseMessage> func,
            string expectedMethod, string expectedUri)
        {
            var dispatcher = new RequestValidatorDispatcher(expectedMethod, expectedUri);
            func(new ElasticsearchClient(new SingleConnection(dispatcher: dispatcher)));
        }

        private class RequestValidatorDispatcher : IDispatcher
        {
            private readonly string mExpectedMethod;
            private readonly string mExpectedUri;
            private readonly Action<HttpContent> mContentValidator;

            internal RequestValidatorDispatcher(string expectedMethod, string expectedUri, 
                Action<HttpContent> contentValidator = null)
            {
                mExpectedMethod = expectedMethod;
                mExpectedUri = expectedUri;
                mContentValidator = contentValidator;
            }

            public Task<HttpResponseMessage> ExecuteAsync(HttpClient client, string httpMethod, string uri, HttpContent content = null)
            {
                Assert.AreEqual(mExpectedMethod, httpMethod);
                Assert.AreEqual(mExpectedUri, uri);
                mContentValidator?.Invoke(content);
                return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK));
            }
        }
    }
}
