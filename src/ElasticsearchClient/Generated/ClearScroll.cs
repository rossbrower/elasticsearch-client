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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        /// <param name="scroll_id">A comma-separated list of scroll IDs to clear</param>
        /// <param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        public virtual HttpResponseMessage ClearScroll(string scroll_id, Stream body)
        {
            string uri = string.Format("/_search/scroll/{0}", scroll_id);
            return this.Execute("DELETE", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        /// <param name="scroll_id">A comma-separated list of scroll IDs to clear</param>
        /// <param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        public virtual async Task<HttpResponseMessage> ClearScrollAsync(string scroll_id, Stream body)
        {
            string uri = string.Format("/_search/scroll/{0}", scroll_id);
            return await this.ExecuteAsync("DELETE", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        /// <param name="scroll_id">A comma-separated list of scroll IDs to clear</param>
        /// <param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        public virtual HttpResponseMessage ClearScroll(string scroll_id, Byte[] body)
        {
            string uri = string.Format("/_search/scroll/{0}", scroll_id);
            return this.Execute("DELETE", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        /// <param name="scroll_id">A comma-separated list of scroll IDs to clear</param>
        /// <param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        public virtual async Task<HttpResponseMessage> ClearScrollAsync(string scroll_id, Byte[] body)
        {
            string uri = string.Format("/_search/scroll/{0}", scroll_id);
            return await this.ExecuteAsync("DELETE", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        /// <param name="scroll_id">A comma-separated list of scroll IDs to clear</param>
        /// <param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        public virtual HttpResponseMessage ClearScroll(string scroll_id, string body)
        {
            string uri = string.Format("/_search/scroll/{0}", scroll_id);
            return this.Execute("DELETE", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        /// <param name="scroll_id">A comma-separated list of scroll IDs to clear</param>
        /// <param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        public virtual async Task<HttpResponseMessage> ClearScrollAsync(string scroll_id, string body)
        {
            string uri = string.Format("/_search/scroll/{0}", scroll_id);
            return await this.ExecuteAsync("DELETE", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        /// <param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        public virtual HttpResponseMessage ClearScroll(Stream body)
        {
            string uri = "/_search/scroll";
            return this.Execute("DELETE", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        /// <param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        public virtual async Task<HttpResponseMessage> ClearScrollAsync(Stream body)
        {
            string uri = "/_search/scroll";
            return await this.ExecuteAsync("DELETE", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        /// <param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        public virtual HttpResponseMessage ClearScroll(Byte[] body)
        {
            string uri = "/_search/scroll";
            return this.Execute("DELETE", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        /// <param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        public virtual async Task<HttpResponseMessage> ClearScrollAsync(Byte[] body)
        {
            string uri = "/_search/scroll";
            return await this.ExecuteAsync("DELETE", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        /// <param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        public virtual HttpResponseMessage ClearScroll(string body)
        {
            string uri = "/_search/scroll";
            return this.Execute("DELETE", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        /// <param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        public virtual async Task<HttpResponseMessage> ClearScrollAsync(string body)
        {
            string uri = "/_search/scroll";
            return await this.ExecuteAsync("DELETE", uri, body);
        }
    }
}
