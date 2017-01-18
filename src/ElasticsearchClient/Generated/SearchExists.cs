using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchExistsPost(Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = "/_search/exists";
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchExistsPostAsync(Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = "/_search/exists";
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchExistsPost(Stream body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = "/_search/exists";
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchExistsPostAsync(Stream body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = "/_search/exists";
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchExistsPost(byte[] body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = "/_search/exists";
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchExistsPostAsync(byte[] body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = "/_search/exists";
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchExistsPostString(string body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = "/_search/exists";
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchExistsPostStringAsync(string body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = "/_search/exists";
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchExistsGet(Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = "/_search/exists";
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchExistsGetAsync(Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = "/_search/exists";
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchExistsGet(Stream body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = "/_search/exists";
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchExistsGetAsync(Stream body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = "/_search/exists";
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchExistsGet(byte[] body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = "/_search/exists";
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchExistsGetAsync(byte[] body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = "/_search/exists";
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchExistsGetString(string body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = "/_search/exists";
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchExistsGetStringAsync(string body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = "/_search/exists";
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchExistsPost(string index, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/exists", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchExistsPostAsync(string index, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/exists", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchExistsPost(string index, Stream body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/exists", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchExistsPostAsync(string index, Stream body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/exists", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchExistsPost(string index, byte[] body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/exists", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchExistsPostAsync(string index, byte[] body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/exists", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchExistsPostString(string index, string body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/exists", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchExistsPostStringAsync(string index, string body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/exists", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchExistsGet(string index, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/exists", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchExistsGetAsync(string index, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/exists", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchExistsGet(string index, Stream body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/exists", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchExistsGetAsync(string index, Stream body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/exists", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchExistsGet(string index, byte[] body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/exists", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchExistsGetAsync(string index, byte[] body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/exists", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchExistsGetString(string index, string body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/exists", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchExistsGetStringAsync(string index, string body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/exists", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchExistsPost(string index, string type, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/exists", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchExistsPostAsync(string index, string type, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/exists", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchExistsPost(string index, string type, Stream body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/exists", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchExistsPostAsync(string index, string type, Stream body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/exists", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchExistsPost(string index, string type, byte[] body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/exists", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchExistsPostAsync(string index, string type, byte[] body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/exists", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchExistsPostString(string index, string type, string body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/exists", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchExistsPostStringAsync(string index, string type, string body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/exists", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchExistsGet(string index, string type, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/exists", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchExistsGetAsync(string index, string type, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/exists", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchExistsGet(string index, string type, Stream body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/exists", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchExistsGetAsync(string index, string type, Stream body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/exists", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchExistsGet(string index, string type, byte[] body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/exists", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchExistsGetAsync(string index, string type, byte[] body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/exists", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchExistsGetString(string index, string type, string body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/exists", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchExistsGetStringAsync(string index, string type, string body, Func<SearchExistsParameters, SearchExistsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/exists", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchExistsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }
    }
}