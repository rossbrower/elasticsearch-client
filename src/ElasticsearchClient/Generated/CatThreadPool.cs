using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cat-thread-pool.html"/></summary>
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

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cat-thread-pool.html"/></summary>
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

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cat-thread-pool.html"/></summary>
        ///<param name="thread_pool_patterns">A comma-separated list of regular-expressions to filter the thread pools in the output</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CatThreadPool(string thread_pool_patterns, Func<CatThreadPoolParameters, CatThreadPoolParameters> options = null)
        {
            var uri = string.Format("/_cat/thread_pool/{0}", thread_pool_patterns);
            if (options != null)
            {
                uri = options.Invoke(new CatThreadPoolParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cat-thread-pool.html"/></summary>
        ///<param name="thread_pool_patterns">A comma-separated list of regular-expressions to filter the thread pools in the output</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatThreadPoolAsync(string thread_pool_patterns, Func<CatThreadPoolParameters, CatThreadPoolParameters> options = null)
        {
            var uri = string.Format("/_cat/thread_pool/{0}", thread_pool_patterns);
            if (options != null)
            {
                uri = options.Invoke(new CatThreadPoolParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}