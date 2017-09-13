using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-usage.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage NodesUsage(Func<NodesUsageParameters, NodesUsageParameters> options = null)
        {
            var uri = "/_nodes/usage";
            if (options != null)
            {
                uri = options.Invoke(new NodesUsageParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-usage.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> NodesUsageAsync(Func<NodesUsageParameters, NodesUsageParameters> options = null)
        {
            var uri = "/_nodes/usage";
            if (options != null)
            {
                uri = options.Invoke(new NodesUsageParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-usage.html"/></summary>
        ///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage NodesUsage(string node_id, Func<NodesUsageParameters, NodesUsageParameters> options = null)
        {
            var uri = string.Format("/_nodes/{0}/usage", node_id);
            if (options != null)
            {
                uri = options.Invoke(new NodesUsageParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-usage.html"/></summary>
        ///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> NodesUsageAsync(string node_id, Func<NodesUsageParameters, NodesUsageParameters> options = null)
        {
            var uri = string.Format("/_nodes/{0}/usage", node_id);
            if (options != null)
            {
                uri = options.Invoke(new NodesUsageParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-usage.html"/></summary>
        ///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</param>
        ///<param name="metric">Limit the information returned to the specified metrics</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage NodesUsage(string node_id, string metric, Func<NodesUsageParameters, NodesUsageParameters> options = null)
        {
            var uri = string.Format("/_nodes/{0}/usage/{1}", node_id, metric);
            if (options != null)
            {
                uri = options.Invoke(new NodesUsageParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-usage.html"/></summary>
        ///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</param>
        ///<param name="metric">Limit the information returned to the specified metrics</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> NodesUsageAsync(string node_id, string metric, Func<NodesUsageParameters, NodesUsageParameters> options = null)
        {
            var uri = string.Format("/_nodes/{0}/usage/{1}", node_id, metric);
            if (options != null)
            {
                uri = options.Invoke(new NodesUsageParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}