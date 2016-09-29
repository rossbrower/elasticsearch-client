using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-refresh.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesRefreshPost(Func<IndicesRefreshParameters, IndicesRefreshParameters> options = null)
        {
            var uri = "/_refresh";
            if (options != null)
            {
                uri = options.Invoke(new IndicesRefreshParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-refresh.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesRefreshPostAsync(Func<IndicesRefreshParameters, IndicesRefreshParameters> options = null)
        {
            var uri = "/_refresh";
            if (options != null)
            {
                uri = options.Invoke(new IndicesRefreshParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-refresh.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesRefreshGet(Func<IndicesRefreshParameters, IndicesRefreshParameters> options = null)
        {
            var uri = "/_refresh";
            if (options != null)
            {
                uri = options.Invoke(new IndicesRefreshParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-refresh.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesRefreshGetAsync(Func<IndicesRefreshParameters, IndicesRefreshParameters> options = null)
        {
            var uri = "/_refresh";
            if (options != null)
            {
                uri = options.Invoke(new IndicesRefreshParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-refresh.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesRefreshPost(string index, Func<IndicesRefreshParameters, IndicesRefreshParameters> options = null)
        {
            var uri = $"{"/{0}/_refresh"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesRefreshParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-refresh.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesRefreshPostAsync(string index, Func<IndicesRefreshParameters, IndicesRefreshParameters> options = null)
        {
            var uri = $"{"/{0}/_refresh"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesRefreshParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-refresh.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesRefreshGet(string index, Func<IndicesRefreshParameters, IndicesRefreshParameters> options = null)
        {
            var uri = $"{"/{0}/_refresh"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesRefreshParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-refresh.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesRefreshGetAsync(string index, Func<IndicesRefreshParameters, IndicesRefreshParameters> options = null)
        {
            var uri = $"{"/{0}/_refresh"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesRefreshParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}