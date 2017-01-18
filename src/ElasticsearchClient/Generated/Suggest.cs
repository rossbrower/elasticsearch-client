using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-suggesters.html"/></summary>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SuggestPost(Stream body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = "/_suggest";
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-suggesters.html"/></summary>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SuggestPostAsync(Stream body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = "/_suggest";
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-suggesters.html"/></summary>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SuggestPost(byte[] body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = "/_suggest";
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-suggesters.html"/></summary>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SuggestPostAsync(byte[] body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = "/_suggest";
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-suggesters.html"/></summary>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SuggestPostString(string body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = "/_suggest";
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-suggesters.html"/></summary>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SuggestPostStringAsync(string body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = "/_suggest";
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-suggesters.html"/></summary>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SuggestGet(Stream body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = "/_suggest";
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-suggesters.html"/></summary>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SuggestGetAsync(Stream body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = "/_suggest";
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-suggesters.html"/></summary>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SuggestGet(byte[] body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = "/_suggest";
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-suggesters.html"/></summary>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SuggestGetAsync(byte[] body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = "/_suggest";
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-suggesters.html"/></summary>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SuggestGetString(string body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = "/_suggest";
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-suggesters.html"/></summary>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SuggestGetStringAsync(string body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = "/_suggest";
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-suggesters.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SuggestPost(string index, Stream body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = string.Format("/{0}/_suggest", index);
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-suggesters.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SuggestPostAsync(string index, Stream body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = string.Format("/{0}/_suggest", index);
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-suggesters.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SuggestPost(string index, byte[] body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = string.Format("/{0}/_suggest", index);
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-suggesters.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SuggestPostAsync(string index, byte[] body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = string.Format("/{0}/_suggest", index);
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-suggesters.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SuggestPostString(string index, string body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = string.Format("/{0}/_suggest", index);
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-suggesters.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SuggestPostStringAsync(string index, string body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = string.Format("/{0}/_suggest", index);
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-suggesters.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SuggestGet(string index, Stream body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = string.Format("/{0}/_suggest", index);
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-suggesters.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SuggestGetAsync(string index, Stream body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = string.Format("/{0}/_suggest", index);
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-suggesters.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SuggestGet(string index, byte[] body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = string.Format("/{0}/_suggest", index);
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-suggesters.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SuggestGetAsync(string index, byte[] body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = string.Format("/{0}/_suggest", index);
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-suggesters.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SuggestGetString(string index, string body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = string.Format("/{0}/_suggest", index);
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-suggesters.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SuggestGetStringAsync(string index, string body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = string.Format("/{0}/_suggest", index);
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }
    }
}