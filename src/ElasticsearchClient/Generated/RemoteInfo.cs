using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-remote-info.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage RemoteInfo(Func<RemoteInfoParameters, RemoteInfoParameters> options = null)
        {
            var uri = "/_remote/info";
            if (options != null)
            {
                uri = options.Invoke(new RemoteInfoParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-remote-info.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> RemoteInfoAsync(Func<RemoteInfoParameters, RemoteInfoParameters> options = null)
        {
            var uri = "/_remote/info";
            if (options != null)
            {
                uri = options.Invoke(new RemoteInfoParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}