using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    /// <summary>
    /// Base implementation for connections.
    /// </summary>
    public abstract class ConnectionBase : IConnection
    {
        private readonly IDispatcher mDispatcher;

        /// <summary>
        /// Create an instance.
        /// </summary>
        /// <param name="dispatcher">Optional dispatcher. If null, <see cref="Dispatcher"/> will be used.</param>
        protected ConnectionBase(IDispatcher dispatcher = null)
        {
            mDispatcher = dispatcher ?? new Dispatcher();
        }

        protected abstract HttpClient GetClient();

        public virtual async Task<HttpResponseMessage> Execute(string httpMethod, string uri,
            HttpContent content = null, bool synchronous = false)
        {
            var client = GetClient();
            return await mDispatcher.Execute(client, httpMethod, uri, content, synchronous);
        }

        public virtual void Dispose()
        {            
        }
    }
}
