using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/indices-upgrade.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesUpgrade(Func<IndicesUpgradeParameters, IndicesUpgradeParameters> options = null)
        {
            var uri = "/_upgrade";
            if (options != null)
            {
                uri = options.Invoke(new IndicesUpgradeParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/indices-upgrade.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesUpgradeAsync(Func<IndicesUpgradeParameters, IndicesUpgradeParameters> options = null)
        {
            var uri = "/_upgrade";
            if (options != null)
            {
                uri = options.Invoke(new IndicesUpgradeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/indices-upgrade.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesUpgrade(string index, Func<IndicesUpgradeParameters, IndicesUpgradeParameters> options = null)
        {
            var uri = string.Format("/{0}/_upgrade", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesUpgradeParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/indices-upgrade.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesUpgradeAsync(string index, Func<IndicesUpgradeParameters, IndicesUpgradeParameters> options = null)
        {
            var uri = string.Format("/{0}/_upgrade", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesUpgradeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }
    }
}