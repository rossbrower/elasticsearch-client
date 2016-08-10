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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/cat-pending-tasks.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage CatPendingTasks(Func<CatPendingTasksParameters, CatPendingTasksParameters> options = null)
        {
            string uri = "/_cat/pending_tasks";
            if ((options != null))
            {
                CatPendingTasksParameters parameters = options.Invoke(new CatPendingTasksParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/cat-pending-tasks.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> CatPendingTasksAsync(Func<CatPendingTasksParameters, CatPendingTasksParameters> options = null)
        {
            string uri = "/_cat/pending_tasks";
            if ((options != null))
            {
                CatPendingTasksParameters parameters = options.Invoke(new CatPendingTasksParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}
