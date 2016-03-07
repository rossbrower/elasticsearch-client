//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Elasticsearch.Client
{
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    
    
    public partial class ElasticsearchClient
    {
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-hot-threads.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage NodesHotThreads(Func<NodesHotThreadsParameters, NodesHotThreadsParameters> options = null)
        {
            string uri = "/_cluster/nodes/hotthreads";
            if ((options != null))
            {
                NodesHotThreadsParameters parameters = options.Invoke(new NodesHotThreadsParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-hot-threads.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> NodesHotThreadsAsync(Func<NodesHotThreadsParameters, NodesHotThreadsParameters> options = null)
        {
            string uri = "/_cluster/nodes/hotthreads";
            if ((options != null))
            {
                NodesHotThreadsParameters parameters = options.Invoke(new NodesHotThreadsParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-hot-threads.html"/></summary>
        /// <param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage NodesHotThreads(string node_id, Func<NodesHotThreadsParameters, NodesHotThreadsParameters> options = null)
        {
            string uri = string.Format("/_cluster/nodes/{0}/hotthreads", node_id);
            if ((options != null))
            {
                NodesHotThreadsParameters parameters = options.Invoke(new NodesHotThreadsParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-hot-threads.html"/></summary>
        /// <param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> NodesHotThreadsAsync(string node_id, Func<NodesHotThreadsParameters, NodesHotThreadsParameters> options = null)
        {
            string uri = string.Format("/_cluster/nodes/{0}/hotthreads", node_id);
            if ((options != null))
            {
                NodesHotThreadsParameters parameters = options.Invoke(new NodesHotThreadsParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("GET", uri);
        }
    }
}
