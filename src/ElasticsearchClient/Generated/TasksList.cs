using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage TasksList(Func<TasksListParameters, TasksListParameters> options = null)
        {
            var uri = "/_tasks";
            if (options != null)
            {
                uri = options.Invoke(new TasksListParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> TasksListAsync(Func<TasksListParameters, TasksListParameters> options = null)
        {
            var uri = "/_tasks";
            if (options != null)
            {
                uri = options.Invoke(new TasksListParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}