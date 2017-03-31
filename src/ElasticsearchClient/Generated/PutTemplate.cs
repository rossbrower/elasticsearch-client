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
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PutTemplatePut(string id, Stream body, Func<PutTemplateParameters, PutTemplateParameters> options = null)
        {
            var uri = string.Format("/_search/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new PutTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">Template ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PutTemplatePutAsync(string id, Stream body, Func<PutTemplateParameters, PutTemplateParameters> options = null)
        {
            var uri = string.Format("/_search/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new PutTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">Template ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PutTemplatePut(string id, byte[] body, Func<PutTemplateParameters, PutTemplateParameters> options = null)
        {
            var uri = string.Format("/_search/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new PutTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">Template ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PutTemplatePutAsync(string id, byte[] body, Func<PutTemplateParameters, PutTemplateParameters> options = null)
        {
            var uri = string.Format("/_search/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new PutTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">Template ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PutTemplatePutString(string id, string body, Func<PutTemplateParameters, PutTemplateParameters> options = null)
        {
            var uri = string.Format("/_search/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new PutTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">Template ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PutTemplatePutStringAsync(string id, string body, Func<PutTemplateParameters, PutTemplateParameters> options = null)
        {
            var uri = string.Format("/_search/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new PutTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">Template ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PutTemplatePost(string id, Stream body, Func<PutTemplateParameters, PutTemplateParameters> options = null)
        {
            var uri = string.Format("/_search/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new PutTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">Template ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PutTemplatePostAsync(string id, Stream body, Func<PutTemplateParameters, PutTemplateParameters> options = null)
        {
            var uri = string.Format("/_search/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new PutTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">Template ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PutTemplatePost(string id, byte[] body, Func<PutTemplateParameters, PutTemplateParameters> options = null)
        {
            var uri = string.Format("/_search/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new PutTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">Template ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PutTemplatePostAsync(string id, byte[] body, Func<PutTemplateParameters, PutTemplateParameters> options = null)
        {
            var uri = string.Format("/_search/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new PutTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">Template ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PutTemplatePostString(string id, string body, Func<PutTemplateParameters, PutTemplateParameters> options = null)
        {
            var uri = string.Format("/_search/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new PutTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-template.html"/></summary>
        ///<param name="id">Template ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PutTemplatePostStringAsync(string id, string body, Func<PutTemplateParameters, PutTemplateParameters> options = null)
        {
            var uri = string.Format("/_search/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new PutTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}