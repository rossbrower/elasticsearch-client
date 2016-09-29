using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-open-close.html"/></summary>
        ///<param name="index">A comma separated list of indices to close</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesClose(string index, Func<IndicesCloseParameters, IndicesCloseParameters> options = null)
        {
            var uri = $"{"/{0}/_close"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesCloseParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-open-close.html"/></summary>
        ///<param name="index">A comma separated list of indices to close</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesCloseAsync(string index, Func<IndicesCloseParameters, IndicesCloseParameters> options = null)
        {
            var uri = $"{"/{0}/_close"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesCloseParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }
    }
}