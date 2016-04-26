
namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        private readonly IConnection mConnection;

        public ElasticsearchClient(IConnection connection)
        {
            mConnection = connection;
        }
    }
}
