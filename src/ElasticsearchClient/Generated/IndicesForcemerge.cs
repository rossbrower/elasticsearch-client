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
        public HttpResponseMessage IndicesForcemerge(Func<IndicesForcemergeParameters, IndicesForcemergeParameters> options = null)
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
        public async Task<HttpResponseMessage> IndicesForcemergeAsync(Func<IndicesForcemergeParameters, IndicesForcemergeParameters> options = null)
        {
            var uri = "/_forcemerge";
            if (options != null)
            {
                uri = options.Invoke(new IndicesForcemergeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-forcemerge.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesForcemerge(string index, Func<IndicesForcemergeParameters, IndicesForcemergeParameters> options = null)
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
        public async Task<HttpResponseMessage> IndicesForcemergeAsync(string index, Func<IndicesForcemergeParameters, IndicesForcemergeParameters> options = null)
        {
            var uri = string.Format("/{0}/_forcemerge", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesForcemergeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }
    }
}