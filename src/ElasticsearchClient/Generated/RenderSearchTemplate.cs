using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        public HttpResponseMessage RenderSearchTemplateGet()
        {
            var uri = "/_render/template";
            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        public async Task<HttpResponseMessage> RenderSearchTemplateGetAsync()
        {
            var uri = "/_render/template";
            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        public HttpResponseMessage RenderSearchTemplateGet(Stream body)
        {
            var uri = "/_render/template";
            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        public async Task<HttpResponseMessage> RenderSearchTemplateGetAsync(Stream body)
        {
            var uri = "/_render/template";
            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        public HttpResponseMessage RenderSearchTemplateGet(byte[] body)
        {
            var uri = "/_render/template";
            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        public async Task<HttpResponseMessage> RenderSearchTemplateGetAsync(byte[] body)
        {
            var uri = "/_render/template";
            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        public HttpResponseMessage RenderSearchTemplateGetString(string body)
        {
            var uri = "/_render/template";
            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        public async Task<HttpResponseMessage> RenderSearchTemplateGetStringAsync(string body)
        {
            var uri = "/_render/template";
            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        public HttpResponseMessage RenderSearchTemplatePost()
        {
            var uri = "/_render/template";
            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        public async Task<HttpResponseMessage> RenderSearchTemplatePostAsync()
        {
            var uri = "/_render/template";
            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        public HttpResponseMessage RenderSearchTemplatePost(Stream body)
        {
            var uri = "/_render/template";
            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        public async Task<HttpResponseMessage> RenderSearchTemplatePostAsync(Stream body)
        {
            var uri = "/_render/template";
            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        public HttpResponseMessage RenderSearchTemplatePost(byte[] body)
        {
            var uri = "/_render/template";
            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        public async Task<HttpResponseMessage> RenderSearchTemplatePostAsync(byte[] body)
        {
            var uri = "/_render/template";
            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        public HttpResponseMessage RenderSearchTemplatePostString(string body)
        {
            var uri = "/_render/template";
            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="body">The search definition template and its params</param>
        public async Task<HttpResponseMessage> RenderSearchTemplatePostStringAsync(string body)
        {
            var uri = "/_render/template";
            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        public HttpResponseMessage RenderSearchTemplateGet(string id)
        {
            var uri = string.Format("/_render/template/{0}", id);
            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        public async Task<HttpResponseMessage> RenderSearchTemplateGetAsync(string id)
        {
            var uri = string.Format("/_render/template/{0}", id);
            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        ///<param name="body">The search definition template and its params</param>
        public HttpResponseMessage RenderSearchTemplateGet(string id, Stream body)
        {
            var uri = string.Format("/_render/template/{0}", id);
            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        ///<param name="body">The search definition template and its params</param>
        public async Task<HttpResponseMessage> RenderSearchTemplateGetAsync(string id, Stream body)
        {
            var uri = string.Format("/_render/template/{0}", id);
            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        ///<param name="body">The search definition template and its params</param>
        public HttpResponseMessage RenderSearchTemplateGet(string id, byte[] body)
        {
            var uri = string.Format("/_render/template/{0}", id);
            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        ///<param name="body">The search definition template and its params</param>
        public async Task<HttpResponseMessage> RenderSearchTemplateGetAsync(string id, byte[] body)
        {
            var uri = string.Format("/_render/template/{0}", id);
            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        ///<param name="body">The search definition template and its params</param>
        public HttpResponseMessage RenderSearchTemplateGetString(string id, string body)
        {
            var uri = string.Format("/_render/template/{0}", id);
            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        ///<param name="body">The search definition template and its params</param>
        public async Task<HttpResponseMessage> RenderSearchTemplateGetStringAsync(string id, string body)
        {
            var uri = string.Format("/_render/template/{0}", id);
            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        public HttpResponseMessage RenderSearchTemplatePost(string id)
        {
            var uri = string.Format("/_render/template/{0}", id);
            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        public async Task<HttpResponseMessage> RenderSearchTemplatePostAsync(string id)
        {
            var uri = string.Format("/_render/template/{0}", id);
            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        ///<param name="body">The search definition template and its params</param>
        public HttpResponseMessage RenderSearchTemplatePost(string id, Stream body)
        {
            var uri = string.Format("/_render/template/{0}", id);
            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        ///<param name="body">The search definition template and its params</param>
        public async Task<HttpResponseMessage> RenderSearchTemplatePostAsync(string id, Stream body)
        {
            var uri = string.Format("/_render/template/{0}", id);
            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        ///<param name="body">The search definition template and its params</param>
        public HttpResponseMessage RenderSearchTemplatePost(string id, byte[] body)
        {
            var uri = string.Format("/_render/template/{0}", id);
            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        ///<param name="body">The search definition template and its params</param>
        public async Task<HttpResponseMessage> RenderSearchTemplatePostAsync(string id, byte[] body)
        {
            var uri = string.Format("/_render/template/{0}", id);
            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        ///<param name="body">The search definition template and its params</param>
        public HttpResponseMessage RenderSearchTemplatePostString(string id, string body)
        {
            var uri = string.Format("/_render/template/{0}", id);
            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">The id of the stored search template</param>
        ///<param name="body">The search definition template and its params</param>
        public async Task<HttpResponseMessage> RenderSearchTemplatePostStringAsync(string id, string body)
        {
            var uri = string.Format("/_render/template/{0}", id);
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}