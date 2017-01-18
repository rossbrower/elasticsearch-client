using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/cat-thread-pool.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CatThreadPool(Func<CatThreadPoolParameters, CatThreadPoolParameters> options = null)
        {
            var uri = "/_cat/thread_pool";
            if (options != null)
            {
                uri = options.Invoke(new CatThreadPoolParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/cat-thread-pool.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatThreadPoolAsync(Func<CatThreadPoolParameters, CatThreadPoolParameters> options = null)
        {
            var uri = "/_cat/thread_pool";
            if (options != null)
            {
                uri = options.Invoke(new CatThreadPoolParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}