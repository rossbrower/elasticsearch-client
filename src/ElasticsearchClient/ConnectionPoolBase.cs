using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public abstract class ConnectionPoolBase : IConnectionPool
    {
        public abstract HttpClient GetClient();

        public async Task<HttpResponseMessage> Execute(string httpMethod, string uri,
            HttpContent content = null, bool synchronous = false)
        {
            var client = GetClient();
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
