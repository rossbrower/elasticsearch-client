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
        public HttpResponseMessage PutScriptPut(string lang, string id, Stream body)
        {
            var uri = string.Format("/_scripts/{0}/{1}", lang, id);
            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="lang">Script language</param>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        public async Task<HttpResponseMessage> PutScriptPutAsync(string lang, string id, Stream body)
        {
            var uri = string.Format("/_scripts/{0}/{1}", lang, id);
            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="lang">Script language</param>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        public HttpResponseMessage PutScriptPut(string lang, string id, byte[] body)
        {
            var uri = string.Format("/_scripts/{0}/{1}", lang, id);
            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="lang">Script language</param>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        public async Task<HttpResponseMessage> PutScriptPutAsync(string lang, string id, byte[] body)
        {
            var uri = string.Format("/_scripts/{0}/{1}", lang, id);
            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="lang">Script language</param>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        public HttpResponseMessage PutScriptPutString(string lang, string id, string body)
        {
            var uri = string.Format("/_scripts/{0}/{1}", lang, id);
            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="lang">Script language</param>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        public async Task<HttpResponseMessage> PutScriptPutStringAsync(string lang, string id, string body)
        {
            var uri = string.Format("/_scripts/{0}/{1}", lang, id);
            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="lang">Script language</param>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        public HttpResponseMessage PutScriptPost(string lang, string id, Stream body)
        {
            var uri = string.Format("/_scripts/{0}/{1}", lang, id);
            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="lang">Script language</param>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        public async Task<HttpResponseMessage> PutScriptPostAsync(string lang, string id, Stream body)
        {
            var uri = string.Format("/_scripts/{0}/{1}", lang, id);
            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="lang">Script language</param>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        public HttpResponseMessage PutScriptPost(string lang, string id, byte[] body)
        {
            var uri = string.Format("/_scripts/{0}/{1}", lang, id);
            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="lang">Script language</param>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        public async Task<HttpResponseMessage> PutScriptPostAsync(string lang, string id, byte[] body)
        {
            var uri = string.Format("/_scripts/{0}/{1}", lang, id);
            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="lang">Script language</param>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        public HttpResponseMessage PutScriptPostString(string lang, string id, string body)
        {
            var uri = string.Format("/_scripts/{0}/{1}", lang, id);
            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="lang">Script language</param>
        ///<param name="id">Script ID</param>
        ///<param name="body">The document</param>
        public async Task<HttpResponseMessage> PutScriptPostStringAsync(string lang, string id, string body)
        {
            var uri = string.Format("/_scripts/{0}/{1}", lang, id);
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}