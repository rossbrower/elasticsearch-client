using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    /// <summary>
    /// Abstracts the actual sending of an HTTP request to enable offline testing or alternative implementations. 
    /// Used by <see cref="ConnectionPool"/> and <see cref="SingleConnection"/>
    /// </summary>
    public interface IDispatcher
    {
        /// <summary>
        /// Send a request to the given client.
        /// </summary>
        /// <param name="client">The client to use to send the request.</param>
        /// <param name="httpMethod">The HTTP method to use for the request.</param>
        /// <param name="uri">The URI to use for the request.</param>
        /// <param name="content">The content (if any) to send with the request.</param>
        /// <returns></returns>
        Task<HttpResponseMessage> ExecuteAsync(HttpClient client, string httpMethod, string uri,
            HttpContent content = null);
    }
}
