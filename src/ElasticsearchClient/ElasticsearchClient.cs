using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        private readonly IConnection mConnection;

        public ElasticsearchClient(IConnection connection)
        {
            mConnection = connection;
        }

        private async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri)
        {
            return await mConnection.Execute(httpMethod, uri);
        }

        private async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, Stream body)
        {
            return await mConnection.Execute(httpMethod, uri, body == null
                ? null
                : new StreamContent(body));
        }

        private async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, byte[] body)
        {
            return await mConnection.Execute(httpMethod, uri, body == null
                ? null
                : new ByteArrayContent(body));
        }

        private async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, string body)
        {
            return await mConnection.Execute(httpMethod, uri, body == null
                ? null
                : new StringContent(body, Encoding.UTF8, "application/json"));
        }

        private HttpResponseMessage Execute(string httpMethod, string uri)
        {
            return mConnection.Execute(httpMethod, uri, synchronous: true).Result;
        }

        private HttpResponseMessage Execute(string httpMethod, string uri, Stream body)
        {
            return mConnection.Execute(httpMethod, uri, body == null
                ? null
                : new StreamContent(body), true).Result;
        }

        private HttpResponseMessage Execute(string httpMethod, string uri, byte[] body)
        {
            return mConnection.Execute(httpMethod, uri, body == null
                ? null
                : new ByteArrayContent(body), true).Result;
        }

        private HttpResponseMessage Execute(string httpMethod, string uri, string body)
        {
            return mConnection.Execute(httpMethod, uri, body == null
                ? null
                : new StringContent(body, Encoding.UTF8, "application/json"), true).Result;
        }
    }
}
