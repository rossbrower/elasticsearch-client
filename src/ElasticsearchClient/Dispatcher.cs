using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public class Dispatcher : IDispatcher
    {
        public async Task<HttpResponseMessage> ExecuteAsync(HttpClient client, string httpMethod, string uri,
            HttpContent content = null)
        {
            return await client.SendAsync(
                new HttpRequestMessage(new HttpMethod(httpMethod), uri)
                {
                    Content = content
                }).ConfigureAwait(false);
        }
    }
}
