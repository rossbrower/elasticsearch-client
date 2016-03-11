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
            return await mConnectionPool.Execute(httpMethod, uri);
        }

        private async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, Stream body)
        {
            return await mConnectionPool.Execute(httpMethod, uri, body == null
                ? null
                : new StreamContent(body));
        }

        private async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, byte[] body)
        {
            return await mConnectionPool.Execute(httpMethod, uri, body == null
                ? null
                : new ByteArrayContent(body));
        }

        private async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, string body)
        {
            return await mConnectionPool.Execute(httpMethod, uri, body == null
                ? null
                : new StringContent(body, Encoding.UTF8, "application/json"));
        }

        private HttpResponseMessage Execute(string httpMethod, string uri)
        {
            return mConnectionPool.Execute(httpMethod, uri, synchronous: true).Result;
        }

        private HttpResponseMessage Execute(string httpMethod, string uri, Stream body)
        {
            return mConnectionPool.Execute(httpMethod, uri, body == null
                ? null
                : new StreamContent(body), true).Result;
        }

        private HttpResponseMessage Execute(string httpMethod, string uri, byte[] body)
        {
            return mConnectionPool.Execute(httpMethod, uri, body == null
                ? null
                : new ByteArrayContent(body), true).Result;
        }

        private HttpResponseMessage Execute(string httpMethod, string uri, string body)
        {
            return mConnectionPool.Execute(httpMethod, uri, body == null
                ? null
                : new StringContent(body, Encoding.UTF8, "application/json"), true).Result;
        }
    }
}
