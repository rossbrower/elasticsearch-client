using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-clearcache.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesClearCachePost(Func<IndicesClearCacheParameters, IndicesClearCacheParameters> options = null)
        {
            var uri = "/_cache/clear";
            if (options != null)
            {
                uri = options.Invoke(new IndicesClearCacheParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-clearcache.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesClearCachePostAsync(Func<IndicesClearCacheParameters, IndicesClearCacheParameters> options = null)
        {
            var uri = "/_cache/clear";
            if (options != null)
            {
                uri = options.Invoke(new IndicesClearCacheParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-clearcache.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesClearCacheGet(Func<IndicesClearCacheParameters, IndicesClearCacheParameters> options = null)
        {
            var uri = "/_cache/clear";
            if (options != null)
            {
                uri = options.Invoke(new IndicesClearCacheParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-clearcache.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesClearCacheGetAsync(Func<IndicesClearCacheParameters, IndicesClearCacheParameters> options = null)
        {
            var uri = "/_cache/clear";
            if (options != null)
            {
                uri = options.Invoke(new IndicesClearCacheParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-clearcache.html"/></summary>
        ///<param name="index">A comma-separated list of index name to limit the operation</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesClearCachePost(string index, Func<IndicesClearCacheParameters, IndicesClearCacheParameters> options = null)
        {
            var uri = string.Format("/{0}/_cache/clear", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesClearCacheParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-clearcache.html"/></summary>
        ///<param name="index">A comma-separated list of index name to limit the operation</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesClearCachePostAsync(string index, Func<IndicesClearCacheParameters, IndicesClearCacheParameters> options = null)
        {
            var uri = string.Format("/{0}/_cache/clear", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesClearCacheParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-clearcache.html"/></summary>
        ///<param name="index">A comma-separated list of index name to limit the operation</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesClearCacheGet(string index, Func<IndicesClearCacheParameters, IndicesClearCacheParameters> options = null)
        {
            var uri = string.Format("/{0}/_cache/clear", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesClearCacheParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-clearcache.html"/></summary>
        ///<param name="index">A comma-separated list of index name to limit the operation</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesClearCacheGetAsync(string index, Func<IndicesClearCacheParameters, IndicesClearCacheParameters> options = null)
        {
            var uri = string.Format("/{0}/_cache/clear", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesClearCacheParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}