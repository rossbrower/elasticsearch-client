using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cat-allocation.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CatAllocation(Func<CatAllocationParameters, CatAllocationParameters> options = null)
        {
            var uri = "/_cat/allocation";
            if (options != null)
            {
                uri = options.Invoke(new CatAllocationParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cat-allocation.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatAllocationAsync(Func<CatAllocationParameters, CatAllocationParameters> options = null)
        {
            var uri = "/_cat/allocation";
            if (options != null)
            {
                uri = options.Invoke(new CatAllocationParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cat-allocation.html"/></summary>
        ///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CatAllocation(string node_id, Func<CatAllocationParameters, CatAllocationParameters> options = null)
        {
            var uri = string.Format("/_cat/allocation/{0}", node_id);
            if (options != null)
            {
                uri = options.Invoke(new CatAllocationParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cat-allocation.html"/></summary>
        ///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatAllocationAsync(string node_id, Func<CatAllocationParameters, CatAllocationParameters> options = null)
        {
            var uri = string.Format("/_cat/allocation/{0}", node_id);
            if (options != null)
            {
                uri = options.Invoke(new CatAllocationParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}