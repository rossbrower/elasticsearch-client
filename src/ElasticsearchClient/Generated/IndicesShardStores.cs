using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-shards-stores.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesShardStores(Func<IndicesShardStoresParameters, IndicesShardStoresParameters> options = null)
        {
            var uri = "/_shard_stores";
            if (options != null)
            {
                uri = options.Invoke(new IndicesShardStoresParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-shards-stores.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesShardStoresAsync(Func<IndicesShardStoresParameters, IndicesShardStoresParameters> options = null)
        {
            var uri = "/_shard_stores";
            if (options != null)
            {
                uri = options.Invoke(new IndicesShardStoresParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-shards-stores.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesShardStores(string index, Func<IndicesShardStoresParameters, IndicesShardStoresParameters> options = null)
        {
            var uri = string.Format("/{0}/_shard_stores", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesShardStoresParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-shards-stores.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesShardStoresAsync(string index, Func<IndicesShardStoresParameters, IndicesShardStoresParameters> options = null)
        {
            var uri = string.Format("/{0}/_shard_stores", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesShardStoresParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}