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

        public virtual async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri)
        {
            return await ExecuteAsyncImpl(httpMethod, uri);
        }

        public virtual async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, Stream body)
        {
            return await ExecuteAsyncImpl(httpMethod, uri, body == null
                ? null
                : new StreamContent(body));
        }

        public virtual async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, byte[] body)
        {
            return await ExecuteAsyncImpl(httpMethod, uri, body == null
                ? null
                : new ByteArrayContent(body));
        }

        public virtual async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, string body)
        {
            return await ExecuteAsyncImpl(httpMethod, uri, body == null
                ? null
                : new StringContent(body, Encoding.UTF8, "application/json"));
        }

        public virtual HttpResponseMessage Execute(string httpMethod, string uri)
        {
            return ExecuteAwait(httpMethod, uri).Result;
        }

        public virtual HttpResponseMessage Execute(string httpMethod, string uri, Stream body)
        {
            return ExecuteAwait(httpMethod, uri, body == null
                ? null
                : new StreamContent(body)).Result;
        }

        public virtual HttpResponseMessage Execute(string httpMethod, string uri, byte[] body)
        {
            return ExecuteAwait(httpMethod, uri, body == null
                ? null
                : new ByteArrayContent(body)).Result;
        }

        public virtual HttpResponseMessage Execute(string httpMethod, string uri, string body)
        {
            return ExecuteAwait(httpMethod, uri, body == null
                ? null
                : new StringContent(body, Encoding.UTF8, "application/json")).Result;
        }

        private async Task<HttpResponseMessage> ExecuteAwait(string httpMethod, string uri, HttpContent content = null)
        {
            var client = mConnectionPool.GetClient();
            using (var message = new HttpRequestMessage(new HttpMethod(httpMethod), uri))
            {
                message.Content = content;
                return await client.SendAsync(message).ConfigureAwait(false);
            }
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
