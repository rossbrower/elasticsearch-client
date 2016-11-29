using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountPost(Func<CountParameters, CountParameters> options = null)
        {
            var uri = "/_count";
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountPostAsync(Func<CountParameters, CountParameters> options = null)
        {
            var uri = "/_count";
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountPost(Stream body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = "/_count";
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountPostAsync(Stream body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = "/_count";
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountPost(byte[] body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = "/_count";
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountPostAsync(byte[] body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = "/_count";
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountPostString(string body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = "/_count";
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountPostStringAsync(string body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = "/_count";
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountGet(Func<CountParameters, CountParameters> options = null)
        {
            var uri = "/_count";
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountGetAsync(Func<CountParameters, CountParameters> options = null)
        {
            var uri = "/_count";
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountGet(Stream body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = "/_count";
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountGetAsync(Stream body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = "/_count";
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountGet(byte[] body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = "/_count";
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountGetAsync(byte[] body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = "/_count";
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountGetString(string body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = "/_count";
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountGetStringAsync(string body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = "/_count";
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountPost(string index, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/_count", index);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountPostAsync(string index, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/_count", index);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountPost(string index, Stream body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/_count", index);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountPostAsync(string index, Stream body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/_count", index);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountPost(string index, byte[] body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/_count", index);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountPostAsync(string index, byte[] body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/_count", index);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountPostString(string index, string body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/_count", index);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountPostStringAsync(string index, string body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/_count", index);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountGet(string index, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/_count", index);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountGetAsync(string index, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/_count", index);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountGet(string index, Stream body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/_count", index);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountGetAsync(string index, Stream body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/_count", index);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountGet(string index, byte[] body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/_count", index);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountGetAsync(string index, byte[] body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/_count", index);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountGetString(string index, string body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/_count", index);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountGetStringAsync(string index, string body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/_count", index);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountPost(string index, string type, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountPostAsync(string index, string type, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountPost(string index, string type, Stream body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountPostAsync(string index, string type, Stream body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountPost(string index, string type, byte[] body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountPostAsync(string index, string type, byte[] body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountPostString(string index, string type, string body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountPostStringAsync(string index, string type, string body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountGet(string index, string type, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountGetAsync(string index, string type, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountGet(string index, string type, Stream body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountGetAsync(string index, string type, Stream body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountGet(string index, string type, byte[] body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountGetAsync(string index, string type, byte[] body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountGetString(string index, string type, string body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-count.html"/></summary>
        ///<param name="index">A comma-separated list of indices to restrict the results</param>
        ///<param name="type">A comma-separated list of types to restrict the results</param>
        ///<param name="body">A query to restrict the results specified with the Query DSL (optional)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountGetStringAsync(string index, string type, string body, Func<CountParameters, CountParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }
    }
}