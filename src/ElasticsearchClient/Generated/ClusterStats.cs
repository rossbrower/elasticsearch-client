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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-stats.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage ClusterStats(Func<ClusterStatsParameters, ClusterStatsParameters> options = null)
        {
            string uri = "/_cluster/stats";
            if ((options != null))
            {
                ClusterStatsParameters parameters = options.Invoke(new ClusterStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-stats.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> ClusterStatsAsync(Func<ClusterStatsParameters, ClusterStatsParameters> options = null)
        {
            string uri = "/_cluster/stats";
            if ((options != null))
            {
                ClusterStatsParameters parameters = options.Invoke(new ClusterStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-stats.html"/></summary>
        /// <param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage ClusterStats(string node_id, Func<ClusterStatsParameters, ClusterStatsParameters> options = null)
        {
            string uri = string.Format("/_cluster/stats/nodes/{0}", node_id);
            if ((options != null))
            {
                ClusterStatsParameters parameters = options.Invoke(new ClusterStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-stats.html"/></summary>
        /// <param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> ClusterStatsAsync(string node_id, Func<ClusterStatsParameters, ClusterStatsParameters> options = null)
        {
            string uri = string.Format("/_cluster/stats/nodes/{0}", node_id);
            if ((options != null))
            {
                ClusterStatsParameters parameters = options.Invoke(new ClusterStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}
