using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        private readonly IConnectionPool mConnectionPool;

        public ElasticsearchClient(IConnectionPool pool)
        {
            mConnectionPool = pool;
        }

        private async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri)
        {
            return await ExecuteAsyncImpl(httpMethod, uri);
        }

        private async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, Stream body)
        {
            return await ExecuteAsyncImpl(httpMethod, uri, body == null
                ? null
                : new StreamContent(body));
        }

        private async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, byte[] body)
        {
            return await ExecuteAsyncImpl(httpMethod, uri, body == null
                ? null
                : new ByteArrayContent(body));
        }

        private async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, string body)
        {
            return await ExecuteAsyncImpl(httpMethod, uri, body == null
                ? null
                : new StringContent(body, Encoding.UTF8, "application/json"));
        }

        private HttpResponseMessage Execute(string httpMethod, string uri)
        {
            return ExecuteAsync(httpMethod, uri).Result;
        }

        private HttpResponseMessage Execute(string httpMethod, string uri, Stream body)
        {
            return ExecuteAsync(httpMethod, uri, body).Result;
        }

        private HttpResponseMessage Execute(string httpMethod, string uri, byte[] body)
        {
            return ExecuteAsync(httpMethod, uri, body).Result;
        }

        private HttpResponseMessage Execute(string httpMethod, string uri, string body)
        {
            return ExecuteAsync(httpMethod, uri, body).Result;
        }

        private async Task<HttpResponseMessage> ExecuteAsyncImpl(string httpMethod, string uri, HttpContent content = null)
        {
            var client = mConnectionPool.GetClient();
            using (var message = new HttpRequestMessage(new HttpMethod(httpMethod), uri))
            {
                message.Content = content;
                return await client.SendAsync(message);
            }
        }
    }
}
