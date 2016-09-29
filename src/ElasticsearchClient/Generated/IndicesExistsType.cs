using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-types-exists.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` to check the types across all indices</param>
        ///<param name="type">A comma-separated list of document types to check</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesExistsType(string index, string type, Func<IndicesExistsTypeParameters, IndicesExistsTypeParameters> options = null)
        {
            var uri = string.Format("/{0}/_mapping/{1}", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesExistsTypeParameters()).GetUri(uri);
            }

            return mConnection.Execute("HEAD", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-types-exists.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` to check the types across all indices</param>
        ///<param name="type">A comma-separated list of document types to check</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesExistsTypeAsync(string index, string type, Func<IndicesExistsTypeParameters, IndicesExistsTypeParameters> options = null)
        {
            var uri = string.Format("/{0}/_mapping/{1}", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesExistsTypeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("HEAD", uri);
        }
    }
}