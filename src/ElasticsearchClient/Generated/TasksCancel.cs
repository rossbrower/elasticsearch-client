using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/tasks.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage TasksCancel(Func<TasksCancelParameters, TasksCancelParameters> options = null)
        {
            var uri = "/_tasks/_cancel";
            if (options != null)
            {
                uri = options.Invoke(new TasksCancelParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/tasks.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> TasksCancelAsync(Func<TasksCancelParameters, TasksCancelParameters> options = null)
        {
            var uri = "/_tasks/_cancel";
            if (options != null)
            {
                uri = options.Invoke(new TasksCancelParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/tasks.html"/></summary>
        ///<param name="task_id">Cancel the task with specified task id (node_id:task_number)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage TasksCancel(string task_id, Func<TasksCancelParameters, TasksCancelParameters> options = null)
        {
            var uri = string.Format("/_tasks/{0}/_cancel", task_id);
            if (options != null)
            {
                uri = options.Invoke(new TasksCancelParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/tasks.html"/></summary>
        ///<param name="task_id">Cancel the task with specified task id (node_id:task_number)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> TasksCancelAsync(string task_id, Func<TasksCancelParameters, TasksCancelParameters> options = null)
        {
            var uri = string.Format("/_tasks/{0}/_cancel", task_id);
            if (options != null)
            {
                uri = options.Invoke(new TasksCancelParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }
    }
}