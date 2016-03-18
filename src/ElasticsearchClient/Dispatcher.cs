using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public class Dispatcher : IDispatcher
    {
        public async Task<HttpResponseMessage> Execute(HttpClient client, string httpMethod, string uri,
            HttpContent content = null, bool synchronous = false)
        {
            using (var message = new HttpRequestMessage(new HttpMethod(httpMethod), uri))
            {
                message.Content = content;
                if (synchronous)
                {
                    return await client.SendAsync(message).ConfigureAwait(false);
                }
                return await client.SendAsync(message);
            }
        }
    }
}
