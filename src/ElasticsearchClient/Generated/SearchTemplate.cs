using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchTemplateGet(Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = "/_search/template";
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchTemplateGetAsync(Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = "/_search/template";
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchTemplateGet(Stream body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = "/_search/template";
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchTemplateGetAsync(Stream body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = "/_search/template";
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchTemplateGet(byte[] body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = "/_search/template";
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchTemplateGetAsync(byte[] body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = "/_search/template";
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchTemplateGetString(string body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = "/_search/template";
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchTemplateGetStringAsync(string body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = "/_search/template";
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchTemplatePost(Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = "/_search/template";
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchTemplatePostAsync(Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = "/_search/template";
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchTemplatePost(Stream body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = "/_search/template";
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchTemplatePostAsync(Stream body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = "/_search/template";
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchTemplatePost(byte[] body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = "/_search/template";
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchTemplatePostAsync(byte[] body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = "/_search/template";
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchTemplatePostString(string body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = "/_search/template";
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchTemplatePostStringAsync(string body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = "/_search/template";
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchTemplateGet(string index, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/template", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchTemplateGetAsync(string index, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/template", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchTemplateGet(string index, Stream body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/template", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchTemplateGetAsync(string index, Stream body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/template", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchTemplateGet(string index, byte[] body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/template", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchTemplateGetAsync(string index, byte[] body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/template", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchTemplateGetString(string index, string body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/template", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchTemplateGetStringAsync(string index, string body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/template", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchTemplatePost(string index, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/template", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchTemplatePostAsync(string index, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/template", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchTemplatePost(string index, Stream body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/template", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchTemplatePostAsync(string index, Stream body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/template", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchTemplatePost(string index, byte[] body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/template", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchTemplatePostAsync(string index, byte[] body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/template", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchTemplatePostString(string index, string body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/template", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchTemplatePostStringAsync(string index, string body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/_search/template", index);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchTemplateGet(string index, string type, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/template", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchTemplateGetAsync(string index, string type, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/template", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchTemplateGet(string index, string type, Stream body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/template", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchTemplateGetAsync(string index, string type, Stream body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/template", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchTemplateGet(string index, string type, byte[] body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/template", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchTemplateGetAsync(string index, string type, byte[] body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/template", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchTemplateGetString(string index, string type, string body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/template", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchTemplateGetStringAsync(string index, string type, string body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/template", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchTemplatePost(string index, string type, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/template", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchTemplatePostAsync(string index, string type, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/template", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchTemplatePost(string index, string type, Stream body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/template", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchTemplatePostAsync(string index, string type, Stream body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/template", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchTemplatePost(string index, string type, byte[] body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/template", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchTemplatePostAsync(string index, string type, byte[] body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/template", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SearchTemplatePostString(string index, string type, string body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/template", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SearchTemplatePostStringAsync(string index, string type, string body, Func<SearchTemplateParameters, SearchTemplateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_search/template", index, type);
            if (options != null)
            {
                uri = options.Invoke(new SearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}