using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-hot-threads.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage NodesHotThreads(Func<NodesHotThreadsParameters, NodesHotThreadsParameters> options = null)
        {
            var uri = "/_cluster/nodes/hotthreads";
            if (options != null)
            {
                uri = options.Invoke(new NodesHotThreadsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-hot-threads.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> NodesHotThreadsAsync(Func<NodesHotThreadsParameters, NodesHotThreadsParameters> options = null)
        {
            var uri = "/_cluster/nodes/hotthreads";
            if (options != null)
            {
                uri = options.Invoke(new NodesHotThreadsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-hot-threads.html"/></summary>
        ///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage NodesHotThreads(string node_id, Func<NodesHotThreadsParameters, NodesHotThreadsParameters> options = null)
        {
            var uri = $"{"/_cluster/nodes/{0}/hotthreads"}";
            if (options != null)
            {
                uri = options.Invoke(new NodesHotThreadsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-hot-threads.html"/></summary>
        ///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> NodesHotThreadsAsync(string node_id, Func<NodesHotThreadsParameters, NodesHotThreadsParameters> options = null)
        {
            var uri = $"{"/_cluster/nodes/{0}/hotthreads"}";
            if (options != null)
            {
                uri = options.Invoke(new NodesHotThreadsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}