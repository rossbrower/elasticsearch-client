using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-optimize.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesOptimizePost(Func<IndicesOptimizeParameters, IndicesOptimizeParameters> options = null)
        {
            var uri = "/_optimize";
            if (options != null)
            {
                uri = options.Invoke(new IndicesOptimizeParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-optimize.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesOptimizePostAsync(Func<IndicesOptimizeParameters, IndicesOptimizeParameters> options = null)
        {
            var uri = "/_optimize";
            if (options != null)
            {
                uri = options.Invoke(new IndicesOptimizeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-optimize.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesOptimizeGet(Func<IndicesOptimizeParameters, IndicesOptimizeParameters> options = null)
        {
            var uri = "/_optimize";
            if (options != null)
            {
                uri = options.Invoke(new IndicesOptimizeParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-optimize.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesOptimizeGetAsync(Func<IndicesOptimizeParameters, IndicesOptimizeParameters> options = null)
        {
            var uri = "/_optimize";
            if (options != null)
            {
                uri = options.Invoke(new IndicesOptimizeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-optimize.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesOptimizePost(string index, Func<IndicesOptimizeParameters, IndicesOptimizeParameters> options = null)
        {
            var uri = string.Format("/{0}/_optimize", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesOptimizeParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-optimize.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesOptimizePostAsync(string index, Func<IndicesOptimizeParameters, IndicesOptimizeParameters> options = null)
        {
            var uri = string.Format("/{0}/_optimize", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesOptimizeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-optimize.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesOptimizeGet(string index, Func<IndicesOptimizeParameters, IndicesOptimizeParameters> options = null)
        {
            var uri = string.Format("/{0}/_optimize", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesOptimizeParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-optimize.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesOptimizeGetAsync(string index, Func<IndicesOptimizeParameters, IndicesOptimizeParameters> options = null)
        {
            var uri = string.Format("/{0}/_optimize", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesOptimizeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}