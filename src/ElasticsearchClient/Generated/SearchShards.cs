using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-shards.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchShardsGet(Func<SearchShardsParameters, SearchShardsParameters> options = null)
        {
            var uri = "/_search_shards";
            if (options != null)
            {
                uri = options.Invoke(new SearchShardsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-shards.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchShardsGetAsync(Func<SearchShardsParameters, SearchShardsParameters> options = null)
        {
            var uri = "/_search_shards";
            if (options != null)
            {
                uri = options.Invoke(new SearchShardsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-shards.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchShardsPost(Func<SearchShardsParameters, SearchShardsParameters> options = null)
        {
            var uri = "/_search_shards";
            if (options != null)
            {
                uri = options.Invoke(new SearchShardsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-shards.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchShardsPostAsync(Func<SearchShardsParameters, SearchShardsParameters> options = null)
        {
            var uri = "/_search_shards";
            if (options != null)
            {
                uri = options.Invoke(new SearchShardsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-shards.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchShardsGet(string index, Func<SearchShardsParameters, SearchShardsParameters> options = null)
        {
            var uri = string.Format("/{0}/_search_shards", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchShardsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-shards.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchShardsGetAsync(string index, Func<SearchShardsParameters, SearchShardsParameters> options = null)
        {
            var uri = string.Format("/{0}/_search_shards", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchShardsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-shards.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchShardsPost(string index, Func<SearchShardsParameters, SearchShardsParameters> options = null)
        {
            var uri = string.Format("/{0}/_search_shards", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchShardsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-shards.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchShardsPostAsync(string index, Func<SearchShardsParameters, SearchShardsParameters> options = null)
        {
            var uri = string.Format("/{0}/_search_shards", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchShardsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-shards.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchShardsGet(string index, string type, Func<SearchShardsParameters, SearchShardsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search_shards", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchShardsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-shards.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchShardsGetAsync(string index, string type, Func<SearchShardsParameters, SearchShardsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search_shards", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchShardsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-shards.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchShardsPost(string index, string type, Func<SearchShardsParameters, SearchShardsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search_shards", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchShardsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-shards.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchShardsPostAsync(string index, string type, Func<SearchShardsParameters, SearchShardsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search_shards", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchShardsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }
    }
}