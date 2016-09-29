using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchGet(Stream body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = "/_msearch";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchGetAsync(Stream body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = "/_msearch";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchGet(byte[] body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = "/_msearch";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchGetAsync(byte[] body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = "/_msearch";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchGetString(string body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = "/_msearch";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchGetStringAsync(string body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = "/_msearch";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchPost(Stream body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = "/_msearch";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchPostAsync(Stream body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = "/_msearch";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchPost(byte[] body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = "/_msearch";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchPostAsync(byte[] body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = "/_msearch";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchPostString(string body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = "/_msearch";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchPostStringAsync(string body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = "/_msearch";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchGet(string index, Stream body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = $"{"/{0}/_msearch"}";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchGetAsync(string index, Stream body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = $"{"/{0}/_msearch"}";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchGet(string index, byte[] body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = $"{"/{0}/_msearch"}";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchGetAsync(string index, byte[] body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = $"{"/{0}/_msearch"}";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchGetString(string index, string body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = $"{"/{0}/_msearch"}";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchGetStringAsync(string index, string body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = $"{"/{0}/_msearch"}";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchPost(string index, Stream body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = $"{"/{0}/_msearch"}";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchPostAsync(string index, Stream body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = $"{"/{0}/_msearch"}";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchPost(string index, byte[] body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = $"{"/{0}/_msearch"}";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchPostAsync(string index, byte[] body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = $"{"/{0}/_msearch"}";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchPostString(string index, string body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = $"{"/{0}/_msearch"}";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchPostStringAsync(string index, string body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = $"{"/{0}/_msearch"}";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="type">A comma-separated list of document types to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchGet(string index, string type, Stream body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/_msearch"}";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="type">A comma-separated list of document types to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchGetAsync(string index, string type, Stream body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/_msearch"}";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="type">A comma-separated list of document types to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchGet(string index, string type, byte[] body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/_msearch"}";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="type">A comma-separated list of document types to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchGetAsync(string index, string type, byte[] body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/_msearch"}";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="type">A comma-separated list of document types to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchGetString(string index, string type, string body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/_msearch"}";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="type">A comma-separated list of document types to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchGetStringAsync(string index, string type, string body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/_msearch"}";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="type">A comma-separated list of document types to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchPost(string index, string type, Stream body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/_msearch"}";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="type">A comma-separated list of document types to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchPostAsync(string index, string type, Stream body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/_msearch"}";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="type">A comma-separated list of document types to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchPost(string index, string type, byte[] body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/_msearch"}";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="type">A comma-separated list of document types to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchPostAsync(string index, string type, byte[] body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/_msearch"}";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="type">A comma-separated list of document types to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchPostString(string index, string type, string body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/_msearch"}";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="type">A comma-separated list of document types to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchPostStringAsync(string index, string type, string body, Func<MsearchParameters, MsearchParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/_msearch"}";
            if (options != null)
            {
                uri = options.Invoke(new MsearchParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}