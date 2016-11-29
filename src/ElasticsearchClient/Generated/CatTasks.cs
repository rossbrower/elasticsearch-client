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
        public HttpResponseMessage CatTasks(Func<CatTasksParameters, CatTasksParameters> options = null)
        {
            var uri = "/_cat/tasks";
            if (options != null)
            {
                uri = options.Invoke(new CatTasksParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/tasks.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatTasksAsync(Func<CatTasksParameters, CatTasksParameters> options = null)
        {
            var uri = "/_cat/tasks";
            if (options != null)
            {
                uri = options.Invoke(new CatTasksParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}