using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public interface IConnection : IDisposable
    {
        Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri);

        Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, Stream body);

        Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, byte[] body);

        Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, string body);

        HttpResponseMessage Execute(string httpMethod, string uri);

        HttpResponseMessage Execute(string httpMethod, string uri, Stream body);

        HttpResponseMessage Execute(string httpMethod, string uri, byte[] body);

        HttpResponseMessage Execute(string httpMethod, string uri, string body);
    }
}
