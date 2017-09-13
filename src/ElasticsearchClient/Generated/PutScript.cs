using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PutScriptPut(string id, Stream body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            var uri = string.Format("/_scripts/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new PutScriptParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PutScriptPutAsync(string id, Stream body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            var uri = string.Format("/_scripts/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new PutScriptParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PutScriptPut(string id, byte[] body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            var uri = string.Format("/_scripts/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new PutScriptParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PutScriptPutAsync(string id, byte[] body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            var uri = string.Format("/_scripts/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new PutScriptParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PutScriptPutString(string id, string body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            var uri = string.Format("/_scripts/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new PutScriptParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PutScriptPutStringAsync(string id, string body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            var uri = string.Format("/_scripts/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new PutScriptParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PutScriptPost(string id, Stream body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            var uri = string.Format("/_scripts/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new PutScriptParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PutScriptPostAsync(string id, Stream body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            var uri = string.Format("/_scripts/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new PutScriptParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PutScriptPost(string id, byte[] body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            var uri = string.Format("/_scripts/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new PutScriptParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PutScriptPostAsync(string id, byte[] body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            var uri = string.Format("/_scripts/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new PutScriptParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PutScriptPostString(string id, string body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            var uri = string.Format("/_scripts/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new PutScriptParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PutScriptPostStringAsync(string id, string body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            var uri = string.Format("/_scripts/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new PutScriptParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}