using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/cat-indices.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CatIndices(Func<CatIndicesParameters, CatIndicesParameters> options = null)
        {
            var uri = "/_cat/indices";
            if (options != null)
            {
                uri = options.Invoke(new CatIndicesParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/cat-indices.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatIndicesAsync(Func<CatIndicesParameters, CatIndicesParameters> options = null)
        {
            var uri = "/_cat/indices";
            if (options != null)
            {
                uri = options.Invoke(new CatIndicesParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/cat-indices.html"/></summary>
        ///<param name="index">A comma-separated list of index names to limit the returned information</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CatIndices(string index, Func<CatIndicesParameters, CatIndicesParameters> options = null)
        {
            var uri = string.Format("/_cat/indices/{0}", index);
            if (options != null)
            {
                uri = options.Invoke(new CatIndicesParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/cat-indices.html"/></summary>
        ///<param name="index">A comma-separated list of index names to limit the returned information</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatIndicesAsync(string index, Func<CatIndicesParameters, CatIndicesParameters> options = null)
        {
            var uri = string.Format("/_cat/indices/{0}", index);
            if (options != null)
            {
                uri = options.Invoke(new CatIndicesParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}