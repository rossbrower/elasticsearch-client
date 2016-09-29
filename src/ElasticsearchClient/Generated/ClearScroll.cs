using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">A comma-separated list of scroll IDs to clear</param>
        public HttpResponseMessage ClearScroll(string scroll_id)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            return mConnection.Execute("DELETE", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">A comma-separated list of scroll IDs to clear</param>
        public async Task<HttpResponseMessage> ClearScrollAsync(string scroll_id)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            return await mConnection.ExecuteAsync("DELETE", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">A comma-separated list of scroll IDs to clear</param>
        ///<param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        public HttpResponseMessage ClearScroll(string scroll_id, Stream body)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            return mConnection.Execute("DELETE", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">A comma-separated list of scroll IDs to clear</param>
        ///<param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        public async Task<HttpResponseMessage> ClearScrollAsync(string scroll_id, Stream body)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            return await mConnection.ExecuteAsync("DELETE", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">A comma-separated list of scroll IDs to clear</param>
        ///<param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        public HttpResponseMessage ClearScroll(string scroll_id, byte[] body)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            return mConnection.Execute("DELETE", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">A comma-separated list of scroll IDs to clear</param>
        ///<param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        public async Task<HttpResponseMessage> ClearScrollAsync(string scroll_id, byte[] body)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            return await mConnection.ExecuteAsync("DELETE", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">A comma-separated list of scroll IDs to clear</param>
        ///<param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        public HttpResponseMessage ClearScrollString(string scroll_id, string body)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            return mConnection.Execute("DELETE", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">A comma-separated list of scroll IDs to clear</param>
        ///<param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        public async Task<HttpResponseMessage> ClearScrollStringAsync(string scroll_id, string body)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            return await mConnection.ExecuteAsync("DELETE", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        public HttpResponseMessage ClearScroll()
        {
            var uri = "/_search/scroll";
            return mConnection.Execute("DELETE", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        public async Task<HttpResponseMessage> ClearScrollAsync()
        {
            var uri = "/_search/scroll";
            return await mConnection.ExecuteAsync("DELETE", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        public HttpResponseMessage ClearScroll(Stream body)
        {
            var uri = "/_search/scroll";
            return mConnection.Execute("DELETE", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        public async Task<HttpResponseMessage> ClearScrollAsync(Stream body)
        {
            var uri = "/_search/scroll";
            return await mConnection.ExecuteAsync("DELETE", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        public HttpResponseMessage ClearScroll(byte[] body)
        {
            var uri = "/_search/scroll";
            return mConnection.Execute("DELETE", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        public async Task<HttpResponseMessage> ClearScrollAsync(byte[] body)
        {
            var uri = "/_search/scroll";
            return await mConnection.ExecuteAsync("DELETE", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        public HttpResponseMessage ClearScrollString(string body)
        {
            var uri = "/_search/scroll";
            return mConnection.Execute("DELETE", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        public async Task<HttpResponseMessage> ClearScrollStringAsync(string body)
        {
            var uri = "/_search/scroll";
            return await mConnection.ExecuteAsync("DELETE", uri, body);
        }
    }
}