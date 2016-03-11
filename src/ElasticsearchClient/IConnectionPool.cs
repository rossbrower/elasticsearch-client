using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public interface IConnectionPool
    {
        Task<HttpResponseMessage> Execute(string httpMethod, string uri,
            HttpContent content = null, bool synchronous = false);
    }
}
