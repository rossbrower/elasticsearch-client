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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-pending.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage ClusterPendingTasks(Func<ClusterPendingTasksParameters, ClusterPendingTasksParameters> options = null)
        {
            string uri = "/_cluster/pending_tasks";
            if ((options != null))
            {
                ClusterPendingTasksParameters parameters = options.Invoke(new ClusterPendingTasksParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-pending.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> ClusterPendingTasksAsync(Func<ClusterPendingTasksParameters, ClusterPendingTasksParameters> options = null)
        {
            string uri = "/_cluster/pending_tasks";
            if ((options != null))
            {
                ClusterPendingTasksParameters parameters = options.Invoke(new ClusterPendingTasksParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("GET", uri);
        }
    }
}
