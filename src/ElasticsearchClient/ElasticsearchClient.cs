
namespace Elasticsearch.Client
{
    /// <summary>
    /// Sends requests to the Elasticsearch cluster and returns responses.
    /// </summary>
    public partial class ElasticsearchClient
    {
        private readonly IConnection mConnection;

        /// <summary>
        /// Construct a new instance using the given <see cref="IConnection"/> implementation.
        /// See <see cref="ConnectionPool"/> and <see cref="SingleConnection"/>
        /// </summary>
        /// <param name="connection"></param>
        public ElasticsearchClient(IConnection connection)
        {
            mConnection = connection;
        }
    }
}
