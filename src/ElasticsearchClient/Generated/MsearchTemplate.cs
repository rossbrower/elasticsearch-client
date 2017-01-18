using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchTemplateGet(Stream body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = "/_msearch/template";
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchTemplateGetAsync(Stream body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = "/_msearch/template";
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchTemplateGet(byte[] body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = "/_msearch/template";
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchTemplateGetAsync(byte[] body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = "/_msearch/template";
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchTemplateGetString(string body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = "/_msearch/template";
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchTemplateGetStringAsync(string body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = "/_msearch/template";
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchTemplatePost(Stream body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = "/_msearch/template";
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchTemplatePostAsync(Stream body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = "/_msearch/template";
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchTemplatePost(byte[] body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = "/_msearch/template";
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchTemplatePostAsync(byte[] body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = "/_msearch/template";
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchTemplatePostString(string body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = "/_msearch/template";
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchTemplatePostStringAsync(string body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = "/_msearch/template";
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchTemplateGet(string index, Stream body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/_msearch/template", index);
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchTemplateGetAsync(string index, Stream body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/_msearch/template", index);
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchTemplateGet(string index, byte[] body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/_msearch/template", index);
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchTemplateGetAsync(string index, byte[] body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/_msearch/template", index);
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchTemplateGetString(string index, string body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/_msearch/template", index);
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchTemplateGetStringAsync(string index, string body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/_msearch/template", index);
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchTemplatePost(string index, Stream body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/_msearch/template", index);
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchTemplatePostAsync(string index, Stream body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/_msearch/template", index);
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchTemplatePost(string index, byte[] body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/_msearch/template", index);
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchTemplatePostAsync(string index, byte[] body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/_msearch/template", index);
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchTemplatePostString(string index, string body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/_msearch/template", index);
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchTemplatePostStringAsync(string index, string body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/_msearch/template", index);
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="type">A comma-separated list of document types to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchTemplateGet(string index, string type, Stream body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_msearch/template", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="type">A comma-separated list of document types to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchTemplateGetAsync(string index, string type, Stream body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_msearch/template", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="type">A comma-separated list of document types to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchTemplateGet(string index, string type, byte[] body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_msearch/template", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="type">A comma-separated list of document types to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchTemplateGetAsync(string index, string type, byte[] body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_msearch/template", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="type">A comma-separated list of document types to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchTemplateGetString(string index, string type, string body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_msearch/template", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="type">A comma-separated list of document types to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchTemplateGetStringAsync(string index, string type, string body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_msearch/template", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="type">A comma-separated list of document types to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchTemplatePost(string index, string type, Stream body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_msearch/template", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="type">A comma-separated list of document types to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchTemplatePostAsync(string index, string type, Stream body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_msearch/template", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="type">A comma-separated list of document types to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchTemplatePost(string index, string type, byte[] body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_msearch/template", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="type">A comma-separated list of document types to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchTemplatePostAsync(string index, string type, byte[] body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_msearch/template", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="type">A comma-separated list of document types to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MsearchTemplatePostString(string index, string type, string body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_msearch/template", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to use as default</param>
        ///<param name="type">A comma-separated list of document types to use as default</param>
        ///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MsearchTemplatePostStringAsync(string index, string type, string body, Func<MsearchTemplateParameters, MsearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_msearch/template", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MsearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}