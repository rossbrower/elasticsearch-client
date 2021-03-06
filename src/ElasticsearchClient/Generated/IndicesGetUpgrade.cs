using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-upgrade.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesGetUpgrade(Func<IndicesGetUpgradeParameters, IndicesGetUpgradeParameters> options = null)
        {
            var uri = "/_upgrade";
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetUpgradeParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-upgrade.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesGetUpgradeAsync(Func<IndicesGetUpgradeParameters, IndicesGetUpgradeParameters> options = null)
        {
            var uri = "/_upgrade";
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetUpgradeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-upgrade.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesGetUpgrade(string index, Func<IndicesGetUpgradeParameters, IndicesGetUpgradeParameters> options = null)
        {
            var uri = string.Format("/{0}/_upgrade", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetUpgradeParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-upgrade.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesGetUpgradeAsync(string index, Func<IndicesGetUpgradeParameters, IndicesGetUpgradeParameters> options = null)
        {
            var uri = string.Format("/{0}/_upgrade", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetUpgradeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}