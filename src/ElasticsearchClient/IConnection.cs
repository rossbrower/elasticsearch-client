using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    /// <summary>
    /// Abstracts the implementation for composing requests.
    /// See <see cref="ConnectionPool"/> and <see cref="SingleConnection"/>.
    /// </summary>
    public interface IConnection : IDisposable
    {
        /// <summary>
        /// Send a message to the given URI using the specified HTTP method.
        /// </summary>
        /// <param name="httpMethod">The HTTP method to use.</param>
        /// <param name="uri">The URI.</param>
        /// <returns>A Task which contains the response.</returns>
        Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri);

        /// <summary>
        /// Send a message to the given URI using the specified HTTP method and content.
        /// </summary>
        /// <param name="httpMethod">The HTTP method to use.</param>
        /// <param name="uri">The URI.</param>
        /// <param name="body">The content of the request as a Stream.</param>
        /// <returns>A Task which contains the response.</returns>
        Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, Stream body);

        /// <summary>
        /// Send a message to the given URI using the specified HTTP method and content.
        /// </summary>
        /// <param name="httpMethod">The HTTP method to use.</param>
        /// <param name="uri">The URI.</param>
        /// <param name="body">The content of the request as a byte array.</param>
        /// <returns>A Task which contains the response.</returns>
        Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, byte[] body);

        /// <summary>
        /// Send a message to the given URI using the specified HTTP method and content.
        /// </summary>
        /// <param name="httpMethod">The HTTP method to use.</param>
        /// <param name="uri">The URI.</param>
        /// <param name="body">The content of the request as a string.</param>
        /// <returns>A Task which contains the response.</returns>
        Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, string body);

        /// <summary>
        /// Send a message to the given URI using the specified HTTP method.
        /// </summary>
        /// <param name="httpMethod">The HTTP method to use.</param>
        /// <param name="uri">The URI.</param>
        /// <returns>A <see cref="Task"/> which contains the response.</returns>
        HttpResponseMessage Execute(string httpMethod, string uri);

        /// <summary>
        /// Send a message to the given URI using the specified HTTP method and content.
        /// </summary>
        /// <param name="httpMethod">The HTTP method to use.</param>
        /// <param name="uri">The URI.</param>
        /// <param name="body">The content of the request as a <see cref="Stream"/>.</param>
        /// <returns>The response.</returns>
        HttpResponseMessage Execute(string httpMethod, string uri, Stream body);

        /// <summary>
        /// Send a message to the given URI using the specified HTTP method and content.
        /// </summary>
        /// <param name="httpMethod">The HTTP method to use.</param>
        /// <param name="uri">The URI.</param>
        /// <param name="body">The content of the request as a byte array.</param>
        /// <returns>The response.</returns>
        HttpResponseMessage Execute(string httpMethod, string uri, byte[] body);

        /// <summary>
        /// Send a message to the given URI using the specified HTTP method. and content.
        /// </summary>
        /// <param name="httpMethod">The HTTP method to use.</param>
        /// <param name="uri">The URI.</param>
        /// <param name="body">The content of the request as a string.</param>
        /// <returns>The response.</returns>
        HttpResponseMessage Execute(string httpMethod, string uri, string body);
    }
}
