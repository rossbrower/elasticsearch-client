using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public interface IConnection : IDisposable
    {
        Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri,
            HttpContent content = null);

        HttpResponseMessage Execute(string httpMethod, string uri,
            HttpContent content = null);
    }
}
