using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-stats.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClusterStats(Func<ClusterStatsParameters, ClusterStatsParameters> options = null)
        {
            var uri = "/_cluster/stats";
            if (options != null)
            {
                uri = options.Invoke(new ClusterStatsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-stats.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClusterStatsAsync(Func<ClusterStatsParameters, ClusterStatsParameters> options = null)
        {
            var uri = "/_cluster/stats";
            if (options != null)
            {
                uri = options.Invoke(new ClusterStatsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-stats.html"/></summary>
        ///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClusterStats(string node_id, Func<ClusterStatsParameters, ClusterStatsParameters> options = null)
        {
            var uri = string.Format("/_cluster/stats/nodes/{0}", node_id);
            if (options != null)
            {
                uri = options.Invoke(new ClusterStatsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-stats.html"/></summary>
        ///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClusterStatsAsync(string node_id, Func<ClusterStatsParameters, ClusterStatsParameters> options = null)
        {
            var uri = string.Format("/_cluster/stats/nodes/{0}", node_id);
            if (options != null)
            {
                uri = options.Invoke(new ClusterStatsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}