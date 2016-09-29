using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-count.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CatCount(Func<CatCountParameters, CatCountParameters> options = null)
        {
            var uri = "/_cat/count";
            if (options != null)
            {
                uri = options.Invoke(new CatCountParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-count.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatCountAsync(Func<CatCountParameters, CatCountParameters> options = null)
        {
            var uri = "/_cat/count";
            if (options != null)
            {
                uri = options.Invoke(new CatCountParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-count.html"/></summary>
        ///<param name="index">A comma-separated list of index names to limit the returned information</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CatCount(string index, Func<CatCountParameters, CatCountParameters> options = null)
        {
            var uri = $"{"/_cat/count/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new CatCountParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-count.html"/></summary>
        ///<param name="index">A comma-separated list of index names to limit the returned information</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatCountAsync(string index, Func<CatCountParameters, CatCountParameters> options = null)
        {
            var uri = $"{"/_cat/count/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new CatCountParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}