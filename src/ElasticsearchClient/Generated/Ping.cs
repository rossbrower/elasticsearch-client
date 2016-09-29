using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/"/></summary>
        public HttpResponseMessage Ping()
        {
            var uri = "/";
            return mConnection.Execute("HEAD", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/"/></summary>
        public async Task<HttpResponseMessage> PingAsync()
        {
            var uri = "/";
            return await mConnection.ExecuteAsync("HEAD", uri);
        }
    }
}