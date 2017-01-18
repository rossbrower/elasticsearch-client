using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/"/></summary>
        public HttpResponseMessage Info()
        {
            var uri = "/";
            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/"/></summary>
        public async Task<HttpResponseMessage> InfoAsync()
        {
            var uri = "/";
            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}