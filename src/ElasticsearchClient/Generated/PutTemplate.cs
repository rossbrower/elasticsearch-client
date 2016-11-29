using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">Template ID</param>
        ///<param name="body">The document</param>
        public HttpResponseMessage PutTemplatePut(string id, Stream body)
        {
            var uri = string.Format("/_search/template/{0}", id);
            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">Template ID</param>
        ///<param name="body">The document</param>
        public async Task<HttpResponseMessage> PutTemplatePutAsync(string id, Stream body)
        {
            var uri = string.Format("/_search/template/{0}", id);
            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">Template ID</param>
        ///<param name="body">The document</param>
        public HttpResponseMessage PutTemplatePut(string id, byte[] body)
        {
            var uri = string.Format("/_search/template/{0}", id);
            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">Template ID</param>
        ///<param name="body">The document</param>
        public async Task<HttpResponseMessage> PutTemplatePutAsync(string id, byte[] body)
        {
            var uri = string.Format("/_search/template/{0}", id);
            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">Template ID</param>
        ///<param name="body">The document</param>
        public HttpResponseMessage PutTemplatePutString(string id, string body)
        {
            var uri = string.Format("/_search/template/{0}", id);
            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">Template ID</param>
        ///<param name="body">The document</param>
        public async Task<HttpResponseMessage> PutTemplatePutStringAsync(string id, string body)
        {
            var uri = string.Format("/_search/template/{0}", id);
            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">Template ID</param>
        ///<param name="body">The document</param>
        public HttpResponseMessage PutTemplatePost(string id, Stream body)
        {
            var uri = string.Format("/_search/template/{0}", id);
            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">Template ID</param>
        ///<param name="body">The document</param>
        public async Task<HttpResponseMessage> PutTemplatePostAsync(string id, Stream body)
        {
            var uri = string.Format("/_search/template/{0}", id);
            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">Template ID</param>
        ///<param name="body">The document</param>
        public HttpResponseMessage PutTemplatePost(string id, byte[] body)
        {
            var uri = string.Format("/_search/template/{0}", id);
            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">Template ID</param>
        ///<param name="body">The document</param>
        public async Task<HttpResponseMessage> PutTemplatePostAsync(string id, byte[] body)
        {
            var uri = string.Format("/_search/template/{0}", id);
            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">Template ID</param>
        ///<param name="body">The document</param>
        public HttpResponseMessage PutTemplatePostString(string id, string body)
        {
            var uri = string.Format("/_search/template/{0}", id);
            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">Template ID</param>
        ///<param name="body">The document</param>
        public async Task<HttpResponseMessage> PutTemplatePostStringAsync(string id, string body)
        {
            var uri = string.Format("/_search/template/{0}", id);
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}