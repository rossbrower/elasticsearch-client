using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-info.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage NodesInfo(Func<NodesInfoParameters, NodesInfoParameters> options = null)
        {
            var uri = "/_nodes";
            if (options != null)
            {
                uri = options.Invoke(new NodesInfoParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-info.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> NodesInfoAsync(Func<NodesInfoParameters, NodesInfoParameters> options = null)
        {
            var uri = "/_nodes";
            if (options != null)
            {
                uri = options.Invoke(new NodesInfoParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-info.html"/></summary>
        ///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage NodesInfo(string node_id, Func<NodesInfoParameters, NodesInfoParameters> options = null)
        {
            var uri = string.Format("/_nodes/{0}", node_id);
            if (options != null)
            {
                uri = options.Invoke(new NodesInfoParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-info.html"/></summary>
        ///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> NodesInfoAsync(string node_id, Func<NodesInfoParameters, NodesInfoParameters> options = null)
        {
            var uri = string.Format("/_nodes/{0}", node_id);
            if (options != null)
            {
                uri = options.Invoke(new NodesInfoParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-info.html"/></summary>
        ///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</param>
        ///<param name="metric">A comma-separated list of metrics you wish returned. Leave empty to return all.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage NodesInfo(string node_id, string metric, Func<NodesInfoParameters, NodesInfoParameters> options = null)
        {
            var uri = string.Format("/_nodes/{0}/{1}", node_id, metric);
            if (options != null)
            {
                uri = options.Invoke(new NodesInfoParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-info.html"/></summary>
        ///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</param>
        ///<param name="metric">A comma-separated list of metrics you wish returned. Leave empty to return all.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> NodesInfoAsync(string node_id, string metric, Func<NodesInfoParameters, NodesInfoParameters> options = null)
        {
            var uri = string.Format("/_nodes/{0}/{1}", node_id, metric);
            if (options != null)
            {
                uri = options.Invoke(new NodesInfoParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}