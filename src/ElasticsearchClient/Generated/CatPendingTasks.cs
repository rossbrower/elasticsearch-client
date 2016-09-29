using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-pending-tasks.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CatPendingTasks(Func<CatPendingTasksParameters, CatPendingTasksParameters> options = null)
        {
            var uri = "/_cat/pending_tasks";
            if (options != null)
            {
                uri = options.Invoke(new CatPendingTasksParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-pending-tasks.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatPendingTasksAsync(Func<CatPendingTasksParameters, CatPendingTasksParameters> options = null)
        {
            var uri = "/_cat/pending_tasks";
            if (options != null)
            {
                uri = options.Invoke(new CatPendingTasksParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}