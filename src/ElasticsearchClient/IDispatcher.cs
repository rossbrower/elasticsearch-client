using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public interface IDispatcher
    {
        Task<HttpResponseMessage> ExecuteAsync(HttpClient client, string httpMethod, string uri,
            HttpContent content = null);

        HttpResponseMessage Execute(HttpClient client, string httpMethod, string uri,
            HttpContent content = null);
    }
}
