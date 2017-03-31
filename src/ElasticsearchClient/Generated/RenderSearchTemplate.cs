using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage RenderSearchTemplateGet(Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = "/_render/template";
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> RenderSearchTemplateGetAsync(Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = "/_render/template";
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage RenderSearchTemplateGet(Stream body, Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = "/_render/template";
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> RenderSearchTemplateGetAsync(Stream body, Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = "/_render/template";
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage RenderSearchTemplateGet(byte[] body, Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = "/_render/template";
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> RenderSearchTemplateGetAsync(byte[] body, Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = "/_render/template";
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage RenderSearchTemplateGetString(string body, Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = "/_render/template";
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> RenderSearchTemplateGetStringAsync(string body, Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = "/_render/template";
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage RenderSearchTemplatePost(Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = "/_render/template";
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> RenderSearchTemplatePostAsync(Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = "/_render/template";
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage RenderSearchTemplatePost(Stream body, Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = "/_render/template";
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> RenderSearchTemplatePostAsync(Stream body, Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = "/_render/template";
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage RenderSearchTemplatePost(byte[] body, Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = "/_render/template";
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> RenderSearchTemplatePostAsync(byte[] body, Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = "/_render/template";
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage RenderSearchTemplatePostString(string body, Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = "/_render/template";
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> RenderSearchTemplatePostStringAsync(string body, Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = "/_render/template";
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage RenderSearchTemplateGet(string id, Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = string.Format("/_render/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> RenderSearchTemplateGetAsync(string id, Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = string.Format("/_render/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage RenderSearchTemplateGet(string id, Stream body, Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = string.Format("/_render/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> RenderSearchTemplateGetAsync(string id, Stream body, Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = string.Format("/_render/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage RenderSearchTemplateGet(string id, byte[] body, Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = string.Format("/_render/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> RenderSearchTemplateGetAsync(string id, byte[] body, Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = string.Format("/_render/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage RenderSearchTemplateGetString(string id, string body, Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = string.Format("/_render/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> RenderSearchTemplateGetStringAsync(string id, string body, Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = string.Format("/_render/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage RenderSearchTemplatePost(string id, Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = string.Format("/_render/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> RenderSearchTemplatePostAsync(string id, Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = string.Format("/_render/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage RenderSearchTemplatePost(string id, Stream body, Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = string.Format("/_render/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> RenderSearchTemplatePostAsync(string id, Stream body, Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = string.Format("/_render/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage RenderSearchTemplatePost(string id, byte[] body, Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = string.Format("/_render/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> RenderSearchTemplatePostAsync(string id, byte[] body, Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = string.Format("/_render/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage RenderSearchTemplatePostString(string id, string body, Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = string.Format("/_render/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        ///<param name="body">The search definition template and its params</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> RenderSearchTemplatePostStringAsync(string id, string body, Func<RenderSearchTemplateParameters, RenderSearchTemplateParameters> options = null)
        {
            var uri = string.Format("/_render/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new RenderSearchTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}