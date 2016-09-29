using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-forcemerge.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesForcemergePost(Func<IndicesForcemergeParameters, IndicesForcemergeParameters> options = null)
        {
            var uri = "/_forcemerge";
            if (options != null)
            {
                uri = options.Invoke(new IndicesForcemergeParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-forcemerge.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesForcemergePostAsync(Func<IndicesForcemergeParameters, IndicesForcemergeParameters> options = null)
        {
            var uri = "/_forcemerge";
            if (options != null)
            {
                uri = options.Invoke(new IndicesForcemergeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-forcemerge.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesForcemergeGet(Func<IndicesForcemergeParameters, IndicesForcemergeParameters> options = null)
        {
            var uri = "/_forcemerge";
            if (options != null)
            {
                uri = options.Invoke(new IndicesForcemergeParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-forcemerge.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesForcemergeGetAsync(Func<IndicesForcemergeParameters, IndicesForcemergeParameters> options = null)
        {
            var uri = "/_forcemerge";
            if (options != null)
            {
                uri = options.Invoke(new IndicesForcemergeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-forcemerge.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesForcemergePost(string index, Func<IndicesForcemergeParameters, IndicesForcemergeParameters> options = null)
        {
            var uri = string.Format("/{0}/_forcemerge", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesForcemergeParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-forcemerge.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesForcemergePostAsync(string index, Func<IndicesForcemergeParameters, IndicesForcemergeParameters> options = null)
        {
            var uri = string.Format("/{0}/_forcemerge", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesForcemergeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-forcemerge.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesForcemergeGet(string index, Func<IndicesForcemergeParameters, IndicesForcemergeParameters> options = null)
        {
            var uri = string.Format("/{0}/_forcemerge", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesForcemergeParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-forcemerge.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesForcemergeGetAsync(string index, Func<IndicesForcemergeParameters, IndicesForcemergeParameters> options = null)
        {
            var uri = string.Format("/{0}/_forcemerge", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesForcemergeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}