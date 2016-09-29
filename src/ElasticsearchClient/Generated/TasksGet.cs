using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html"/></summary>
        ///<param name="task_id">Return the task with specified id (node_id:task_number)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage TasksGet(string task_id, Func<TasksGetParameters, TasksGetParameters> options = null)
        {
            var uri = string.Format("/_tasks/{0}", task_id);
            if (options != null)
            {
                uri = options.Invoke(new TasksGetParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html"/></summary>
        ///<param name="task_id">Return the task with specified id (node_id:task_number)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> TasksGetAsync(string task_id, Func<TasksGetParameters, TasksGetParameters> options = null)
        {
            var uri = string.Format("/_tasks/{0}", task_id);
            if (options != null)
            {
                uri = options.Invoke(new TasksGetParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}