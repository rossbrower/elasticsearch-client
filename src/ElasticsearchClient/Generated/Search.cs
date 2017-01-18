using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchGet(Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = "/_search";
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchGetAsync(Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = "/_search";
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchGet(Stream body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = "/_search";
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchGetAsync(Stream body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = "/_search";
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchGet(byte[] body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = "/_search";
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchGetAsync(byte[] body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = "/_search";
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchGetString(string body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = "/_search";
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchGetStringAsync(string body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = "/_search";
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchPost(Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = "/_search";
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchPostAsync(Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = "/_search";
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchPost(Stream body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = "/_search";
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchPostAsync(Stream body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = "/_search";
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchPost(byte[] body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = "/_search";
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchPostAsync(byte[] body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = "/_search";
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchPostString(string body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = "/_search";
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchPostStringAsync(string body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = "/_search";
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchGet(string index, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/_search", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchGetAsync(string index, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/_search", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchGet(string index, Stream body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/_search", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchGetAsync(string index, Stream body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/_search", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchGet(string index, byte[] body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/_search", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchGetAsync(string index, byte[] body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/_search", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchGetString(string index, string body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/_search", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchGetStringAsync(string index, string body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/_search", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchPost(string index, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/_search", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchPostAsync(string index, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/_search", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchPost(string index, Stream body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/_search", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchPostAsync(string index, Stream body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/_search", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchPost(string index, byte[] body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/_search", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchPostAsync(string index, byte[] body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/_search", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchPostString(string index, string body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/_search", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchPostStringAsync(string index, string body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/_search", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchGet(string index, string type, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchGetAsync(string index, string type, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchGet(string index, string type, Stream body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchGetAsync(string index, string type, Stream body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchGet(string index, string type, byte[] body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchGetAsync(string index, string type, byte[] body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchGetString(string index, string type, string body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchGetStringAsync(string index, string type, string body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchPost(string index, string type, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchPostAsync(string index, string type, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchPost(string index, string type, Stream body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchPostAsync(string index, string type, Stream body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchPost(string index, string type, byte[] body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchPostAsync(string index, string type, byte[] body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchPostString(string index, string type, string body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchPostStringAsync(string index, string type, string body, Func<SearchParameters, SearchParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}