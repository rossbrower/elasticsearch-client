using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-pending.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClusterPendingTasks(Func<ClusterPendingTasksParameters, ClusterPendingTasksParameters> options = null)
        {
            var uri = "/_cluster/pending_tasks";
            if (options != null)
            {
                uri = options.Invoke(new ClusterPendingTasksParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-pending.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClusterPendingTasksAsync(Func<ClusterPendingTasksParameters, ClusterPendingTasksParameters> options = null)
        {
            var uri = "/_cluster/pending_tasks";
            if (options != null)
            {
                uri = options.Invoke(new ClusterPendingTasksParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}