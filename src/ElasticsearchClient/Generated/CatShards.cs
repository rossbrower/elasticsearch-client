using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-shards.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CatShards(Func<CatShardsParameters, CatShardsParameters> options = null)
        {
            var uri = "/_cat/shards";
            if (options != null)
            {
                uri = options.Invoke(new CatShardsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-shards.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatShardsAsync(Func<CatShardsParameters, CatShardsParameters> options = null)
        {
            var uri = "/_cat/shards";
            if (options != null)
            {
                uri = options.Invoke(new CatShardsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-shards.html"/></summary>
        ///<param name="index">A comma-separated list of index names to limit the returned information</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CatShards(string index, Func<CatShardsParameters, CatShardsParameters> options = null)
        {
            var uri = $"{"/_cat/shards/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new CatShardsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-shards.html"/></summary>
        ///<param name="index">A comma-separated list of index names to limit the returned information</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatShardsAsync(string index, Func<CatShardsParameters, CatShardsParameters> options = null)
        {
            var uri = $"{"/_cat/shards/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new CatShardsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}