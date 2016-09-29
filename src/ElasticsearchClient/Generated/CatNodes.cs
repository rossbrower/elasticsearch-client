using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-nodes.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CatNodes(Func<CatNodesParameters, CatNodesParameters> options = null)
        {
            var uri = "/_cat/nodes";
            if (options != null)
            {
                uri = options.Invoke(new CatNodesParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-nodes.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatNodesAsync(Func<CatNodesParameters, CatNodesParameters> options = null)
        {
            var uri = "/_cat/nodes";
            if (options != null)
            {
                uri = options.Invoke(new CatNodesParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}