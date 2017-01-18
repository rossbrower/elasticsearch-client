using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-synced-flush.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesFlushSyncedPost(Func<IndicesFlushSyncedParameters, IndicesFlushSyncedParameters> options = null)
        {
            var uri = "/_flush/synced";
            if (options != null)
            {
                uri = options.Invoke(new IndicesFlushSyncedParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-synced-flush.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesFlushSyncedPostAsync(Func<IndicesFlushSyncedParameters, IndicesFlushSyncedParameters> options = null)
        {
            var uri = "/_flush/synced";
            if (options != null)
            {
                uri = options.Invoke(new IndicesFlushSyncedParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-synced-flush.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesFlushSyncedGet(Func<IndicesFlushSyncedParameters, IndicesFlushSyncedParameters> options = null)
        {
            var uri = "/_flush/synced";
            if (options != null)
            {
                uri = options.Invoke(new IndicesFlushSyncedParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-synced-flush.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesFlushSyncedGetAsync(Func<IndicesFlushSyncedParameters, IndicesFlushSyncedParameters> options = null)
        {
            var uri = "/_flush/synced";
            if (options != null)
            {
                uri = options.Invoke(new IndicesFlushSyncedParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-synced-flush.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string for all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesFlushSyncedPost(string index, Func<IndicesFlushSyncedParameters, IndicesFlushSyncedParameters> options = null)
        {
            var uri = string.Format("/{0}/_flush/synced", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesFlushSyncedParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-synced-flush.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string for all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesFlushSyncedPostAsync(string index, Func<IndicesFlushSyncedParameters, IndicesFlushSyncedParameters> options = null)
        {
            var uri = string.Format("/{0}/_flush/synced", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesFlushSyncedParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-synced-flush.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string for all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesFlushSyncedGet(string index, Func<IndicesFlushSyncedParameters, IndicesFlushSyncedParameters> options = null)
        {
            var uri = string.Format("/{0}/_flush/synced", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesFlushSyncedParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-synced-flush.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string for all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesFlushSyncedGetAsync(string index, Func<IndicesFlushSyncedParameters, IndicesFlushSyncedParameters> options = null)
        {
            var uri = string.Format("/{0}/_flush/synced", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesFlushSyncedParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}