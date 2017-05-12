using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-stats.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage NodesStats(Func<NodesStatsParameters, NodesStatsParameters> options = null)
        {
            var uri = "/_nodes/stats";
            if (options != null)
            {
                uri = options.Invoke(new NodesStatsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-stats.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> NodesStatsAsync(Func<NodesStatsParameters, NodesStatsParameters> options = null)
        {
            var uri = "/_nodes/stats";
            if (options != null)
            {
                uri = options.Invoke(new NodesStatsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-stats.html"/></summary>
        ///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage NodesStats(string node_id, Func<NodesStatsParameters, NodesStatsParameters> options = null)
        {
            var uri = string.Format("/_nodes/{0}/stats", node_id);
            if (options != null)
            {
                uri = options.Invoke(new NodesStatsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-stats.html"/></summary>
        ///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> NodesStatsAsync(string node_id, Func<NodesStatsParameters, NodesStatsParameters> options = null)
        {
            var uri = string.Format("/_nodes/{0}/stats", node_id);
            if (options != null)
            {
                uri = options.Invoke(new NodesStatsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-stats.html"/></summary>
        ///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</param>
        ///<param name="metric">Limit the information returned to the specified metrics</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage NodesStats(string node_id, string metric, Func<NodesStatsParameters, NodesStatsParameters> options = null)
        {
            var uri = string.Format("/_nodes/{0}/stats/{1}", node_id, metric);
            if (options != null)
            {
                uri = options.Invoke(new NodesStatsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-stats.html"/></summary>
        ///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</param>
        ///<param name="metric">Limit the information returned to the specified metrics</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> NodesStatsAsync(string node_id, string metric, Func<NodesStatsParameters, NodesStatsParameters> options = null)
        {
            var uri = string.Format("/_nodes/{0}/stats/{1}", node_id, metric);
            if (options != null)
            {
                uri = options.Invoke(new NodesStatsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-stats.html"/></summary>
        ///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</param>
        ///<param name="metric">Limit the information returned to the specified metrics</param>
        ///<param name="index_metric">Limit the information returned for `indices` metric to the specific index metrics. Isn't used if `indices` (or `all`) metric isn't specified.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage NodesStats(string node_id, string metric, string index_metric, Func<NodesStatsParameters, NodesStatsParameters> options = null)
        {
            var uri = string.Format("/_nodes/{0}/stats/{1}/{index_1}", node_id, metric, index_metric);
            if (options != null)
            {
                uri = options.Invoke(new NodesStatsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-stats.html"/></summary>
        ///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</param>
        ///<param name="metric">Limit the information returned to the specified metrics</param>
        ///<param name="index_metric">Limit the information returned for `indices` metric to the specific index metrics. Isn't used if `indices` (or `all`) metric isn't specified.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> NodesStatsAsync(string node_id, string metric, string index_metric, Func<NodesStatsParameters, NodesStatsParameters> options = null)
        {
            var uri = string.Format("/_nodes/{0}/stats/{1}/{index_1}", node_id, metric, index_metric);
            if (options != null)
            {
                uri = options.Invoke(new NodesStatsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}