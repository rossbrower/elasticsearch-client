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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/cluster-state.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage ClusterState(Func<ClusterStateParameters, ClusterStateParameters> options = null)
        {
            string uri = "/_cluster/state";
            if ((options != null))
            {
                ClusterStateParameters parameters = options.Invoke(new ClusterStateParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/cluster-state.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> ClusterStateAsync(Func<ClusterStateParameters, ClusterStateParameters> options = null)
        {
            string uri = "/_cluster/state";
            if ((options != null))
            {
                ClusterStateParameters parameters = options.Invoke(new ClusterStateParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/cluster-state.html"/></summary>
        /// <param name="metric">Limit the information returned to the specified metrics</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage ClusterState(string metric, Func<ClusterStateParameters, ClusterStateParameters> options = null)
        {
            string uri = string.Format("/_cluster/state/{0}", metric);
            if ((options != null))
            {
                ClusterStateParameters parameters = options.Invoke(new ClusterStateParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/cluster-state.html"/></summary>
        /// <param name="metric">Limit the information returned to the specified metrics</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> ClusterStateAsync(string metric, Func<ClusterStateParameters, ClusterStateParameters> options = null)
        {
            string uri = string.Format("/_cluster/state/{0}", metric);
            if ((options != null))
            {
                ClusterStateParameters parameters = options.Invoke(new ClusterStateParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/cluster-state.html"/></summary>
        /// <param name="metric">Limit the information returned to the specified metrics</param>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage ClusterState(string metric, string index, Func<ClusterStateParameters, ClusterStateParameters> options = null)
        {
            string uri = string.Format("/_cluster/state/{0}/{1}", metric, index);
            if ((options != null))
            {
                ClusterStateParameters parameters = options.Invoke(new ClusterStateParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/cluster-state.html"/></summary>
        /// <param name="metric">Limit the information returned to the specified metrics</param>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> ClusterStateAsync(string metric, string index, Func<ClusterStateParameters, ClusterStateParameters> options = null)
        {
            string uri = string.Format("/_cluster/state/{0}/{1}", metric, index);
            if ((options != null))
            {
                ClusterStateParameters parameters = options.Invoke(new ClusterStateParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}
