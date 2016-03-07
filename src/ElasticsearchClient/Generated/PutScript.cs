//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Elasticsearch.Client
{
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    
    
    public partial class ElasticsearchClient
    {
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        /// <param name="lang">Script language</param>
        /// <param name="id">Script ID</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage PutScriptPut(string lang, string id, Stream body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            string uri = string.Format("/_scripts/{0}/{1}", lang, id);
            if ((options != null))
            {
                PutScriptParameters parameters = options.Invoke(new PutScriptParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        /// <param name="lang">Script language</param>
        /// <param name="id">Script ID</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> PutScriptPutAsync(string lang, string id, Stream body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            string uri = string.Format("/_scripts/{0}/{1}", lang, id);
            if ((options != null))
            {
                PutScriptParameters parameters = options.Invoke(new PutScriptParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        /// <param name="lang">Script language</param>
        /// <param name="id">Script ID</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage PutScriptPut(string lang, string id, Byte[] body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            string uri = string.Format("/_scripts/{0}/{1}", lang, id);
            if ((options != null))
            {
                PutScriptParameters parameters = options.Invoke(new PutScriptParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        /// <param name="lang">Script language</param>
        /// <param name="id">Script ID</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> PutScriptPutAsync(string lang, string id, Byte[] body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            string uri = string.Format("/_scripts/{0}/{1}", lang, id);
            if ((options != null))
            {
                PutScriptParameters parameters = options.Invoke(new PutScriptParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        /// <param name="lang">Script language</param>
        /// <param name="id">Script ID</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage PutScriptPutString(string lang, string id, string body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            string uri = string.Format("/_scripts/{0}/{1}", lang, id);
            if ((options != null))
            {
                PutScriptParameters parameters = options.Invoke(new PutScriptParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        /// <param name="lang">Script language</param>
        /// <param name="id">Script ID</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> PutScriptPutStringAsync(string lang, string id, string body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            string uri = string.Format("/_scripts/{0}/{1}", lang, id);
            if ((options != null))
            {
                PutScriptParameters parameters = options.Invoke(new PutScriptParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        /// <param name="lang">Script language</param>
        /// <param name="id">Script ID</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage PutScriptPost(string lang, string id, Stream body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            string uri = string.Format("/_scripts/{0}/{1}", lang, id);
            if ((options != null))
            {
                PutScriptParameters parameters = options.Invoke(new PutScriptParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        /// <param name="lang">Script language</param>
        /// <param name="id">Script ID</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> PutScriptPostAsync(string lang, string id, Stream body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            string uri = string.Format("/_scripts/{0}/{1}", lang, id);
            if ((options != null))
            {
                PutScriptParameters parameters = options.Invoke(new PutScriptParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        /// <param name="lang">Script language</param>
        /// <param name="id">Script ID</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage PutScriptPost(string lang, string id, Byte[] body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            string uri = string.Format("/_scripts/{0}/{1}", lang, id);
            if ((options != null))
            {
                PutScriptParameters parameters = options.Invoke(new PutScriptParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        /// <param name="lang">Script language</param>
        /// <param name="id">Script ID</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> PutScriptPostAsync(string lang, string id, Byte[] body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            string uri = string.Format("/_scripts/{0}/{1}", lang, id);
            if ((options != null))
            {
                PutScriptParameters parameters = options.Invoke(new PutScriptParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        /// <param name="lang">Script language</param>
        /// <param name="id">Script ID</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage PutScriptPostString(string lang, string id, string body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            string uri = string.Format("/_scripts/{0}/{1}", lang, id);
            if ((options != null))
            {
                PutScriptParameters parameters = options.Invoke(new PutScriptParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        /// <param name="lang">Script language</param>
        /// <param name="id">Script ID</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> PutScriptPostStringAsync(string lang, string id, string body, Func<PutScriptParameters, PutScriptParameters> options = null)
        {
            string uri = string.Format("/_scripts/{0}/{1}", lang, id);
            if ((options != null))
            {
                PutScriptParameters parameters = options.Invoke(new PutScriptParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("POST", uri, body);
        }
    }
}
