using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-flush.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesFlushPost(Func<IndicesFlushParameters, IndicesFlushParameters> options = null)
        {
            var uri = "/_flush";
            if (options != null)
            {
                uri = options.Invoke(new IndicesFlushParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-flush.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesFlushPostAsync(Func<IndicesFlushParameters, IndicesFlushParameters> options = null)
        {
            var uri = "/_flush";
            if (options != null)
            {
                uri = options.Invoke(new IndicesFlushParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-flush.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesFlushGet(Func<IndicesFlushParameters, IndicesFlushParameters> options = null)
        {
            var uri = "/_flush";
            if (options != null)
            {
                uri = options.Invoke(new IndicesFlushParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-flush.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesFlushGetAsync(Func<IndicesFlushParameters, IndicesFlushParameters> options = null)
        {
            var uri = "/_flush";
            if (options != null)
            {
                uri = options.Invoke(new IndicesFlushParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-flush.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string for all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesFlushPost(string index, Func<IndicesFlushParameters, IndicesFlushParameters> options = null)
        {
            var uri = string.Format("/{0}/_flush", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesFlushParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-flush.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string for all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesFlushPostAsync(string index, Func<IndicesFlushParameters, IndicesFlushParameters> options = null)
        {
            var uri = string.Format("/{0}/_flush", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesFlushParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-flush.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string for all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesFlushGet(string index, Func<IndicesFlushParameters, IndicesFlushParameters> options = null)
        {
            var uri = string.Format("/{0}/_flush", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesFlushParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-flush.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string for all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesFlushGetAsync(string index, Func<IndicesFlushParameters, IndicesFlushParameters> options = null)
        {
            var uri = string.Format("/{0}/_flush", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesFlushParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}