using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="lang">Script language</param>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PutScriptPut(string lang, string id, Stream body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            var uri = $"{"/_scripts/{0}/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new PutScriptParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="lang">Script language</param>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PutScriptPutAsync(string lang, string id, Stream body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            var uri = $"{"/_scripts/{0}/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new PutScriptParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="lang">Script language</param>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PutScriptPut(string lang, string id, byte[] body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            var uri = $"{"/_scripts/{0}/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new PutScriptParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="lang">Script language</param>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PutScriptPutAsync(string lang, string id, byte[] body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            var uri = $"{"/_scripts/{0}/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new PutScriptParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="lang">Script language</param>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PutScriptPutString(string lang, string id, string body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            var uri = $"{"/_scripts/{0}/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new PutScriptParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="lang">Script language</param>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PutScriptPutStringAsync(string lang, string id, string body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            var uri = $"{"/_scripts/{0}/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new PutScriptParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="lang">Script language</param>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PutScriptPost(string lang, string id, Stream body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            var uri = $"{"/_scripts/{0}/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new PutScriptParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="lang">Script language</param>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PutScriptPostAsync(string lang, string id, Stream body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            var uri = $"{"/_scripts/{0}/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new PutScriptParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="lang">Script language</param>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PutScriptPost(string lang, string id, byte[] body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            var uri = $"{"/_scripts/{0}/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new PutScriptParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="lang">Script language</param>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PutScriptPostAsync(string lang, string id, byte[] body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            var uri = $"{"/_scripts/{0}/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new PutScriptParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="lang">Script language</param>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PutScriptPostString(string lang, string id, string body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            var uri = $"{"/_scripts/{0}/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new PutScriptParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="lang">Script language</param>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PutScriptPostStringAsync(string lang, string id, string body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            var uri = $"{"/_scripts/{0}/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new PutScriptParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}