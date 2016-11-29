using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/indices-delete-index.html"/></summary>
        ///<param name="index">A comma-separated list of indices to delete; use `_all` or `*` string to delete all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesDelete(string index, Func<IndicesDeleteParameters, IndicesDeleteParameters> options = null)
        {
            var uri = string.Format("/{0}", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesDeleteParameters()).GetUri(uri);
            }

            return mConnection.Execute("DELETE", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/indices-delete-index.html"/></summary>
        ///<param name="index">A comma-separated list of indices to delete; use `_all` or `*` string to delete all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesDeleteAsync(string index, Func<IndicesDeleteParameters, IndicesDeleteParameters> options = null)
        {
            var uri = string.Format("/{0}", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesDeleteParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("DELETE", uri);
        }
    }
}