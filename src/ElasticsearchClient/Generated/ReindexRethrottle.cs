using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/docs-reindex.html"/></summary>
        ///<param name="task_id">The task id to rethrottle</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ReindexRethrottle(string task_id, Func<ReindexRethrottleParameters, ReindexRethrottleParameters> options = null)
        {
            var uri = string.Format("/_reindex/{0}/_rethrottle", task_id);
            if (options != null)
            {
                uri = options.Invoke(new ReindexRethrottleParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/docs-reindex.html"/></summary>
        ///<param name="task_id">The task id to rethrottle</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ReindexRethrottleAsync(string task_id, Func<ReindexRethrottleParameters, ReindexRethrottleParameters> options = null)
        {
            var uri = string.Format("/_reindex/{0}/_rethrottle", task_id);
            if (options != null)
            {
                uri = options.Invoke(new ReindexRethrottleParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }
    }
}