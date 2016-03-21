using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public class Dispatcher : IDispatcher
    {
        public async Task<HttpResponseMessage> ExecuteAsync(HttpClient client, string httpMethod, string uri,
            HttpContent content = null)
        {
            using (var message = new HttpRequestMessage(new HttpMethod(httpMethod), uri))
            {
                message.Content = content;
                return await client.SendAsync(message).ConfigureAwait(false);
            }
        }

        public HttpResponseMessage Execute(HttpClient client, string httpMethod, string uri, HttpContent content = null)
        {
            return ExecuteAsync(client, httpMethod, uri, content).Result;
        }
    }
}
