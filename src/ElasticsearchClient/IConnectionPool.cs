using System.Net.Http;

namespace Elasticsearch.Client
{
    public interface IConnectionPool
    {
        HttpClient GetClient();
    }
}
