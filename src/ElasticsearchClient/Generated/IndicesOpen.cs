using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-open-close.html"/></summary>
        ///<param name="index">A comma separated list of indices to open</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesOpen(string index, Func<IndicesOpenParameters, IndicesOpenParameters> options = null)
        {
            var uri = string.Format("/{0}/_open", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesOpenParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-open-close.html"/></summary>
        ///<param name="index">A comma separated list of indices to open</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesOpenAsync(string index, Func<IndicesOpenParameters, IndicesOpenParameters> options = null)
        {
            var uri = string.Format("/{0}/_open", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesOpenParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }
    }
}