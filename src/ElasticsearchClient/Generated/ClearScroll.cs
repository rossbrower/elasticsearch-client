using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">A comma-separated list of scroll IDs to clear</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClearScroll(string scroll_id, Func<ClearScrollParameters, ClearScrollParameters> options = null)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            if (options != null)
            {
                uri = options.Invoke(new ClearScrollParameters()).GetUri(uri);
            }

            return mConnection.Execute("DELETE", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">A comma-separated list of scroll IDs to clear</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClearScrollAsync(string scroll_id, Func<ClearScrollParameters, ClearScrollParameters> options = null)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            if (options != null)
            {
                uri = options.Invoke(new ClearScrollParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("DELETE", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">A comma-separated list of scroll IDs to clear</param>
        ///<param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClearScroll(string scroll_id, Stream body, Func<ClearScrollParameters, ClearScrollParameters> options = null)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            if (options != null)
            {
                uri = options.Invoke(new ClearScrollParameters()).GetUri(uri);
            }

            return mConnection.Execute("DELETE", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">A comma-separated list of scroll IDs to clear</param>
        ///<param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClearScrollAsync(string scroll_id, Stream body, Func<ClearScrollParameters, ClearScrollParameters> options = null)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            if (options != null)
            {
                uri = options.Invoke(new ClearScrollParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("DELETE", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">A comma-separated list of scroll IDs to clear</param>
        ///<param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClearScroll(string scroll_id, byte[] body, Func<ClearScrollParameters, ClearScrollParameters> options = null)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            if (options != null)
            {
                uri = options.Invoke(new ClearScrollParameters()).GetUri(uri);
            }

            return mConnection.Execute("DELETE", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">A comma-separated list of scroll IDs to clear</param>
        ///<param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClearScrollAsync(string scroll_id, byte[] body, Func<ClearScrollParameters, ClearScrollParameters> options = null)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            if (options != null)
            {
                uri = options.Invoke(new ClearScrollParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("DELETE", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">A comma-separated list of scroll IDs to clear</param>
        ///<param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClearScrollString(string scroll_id, string body, Func<ClearScrollParameters, ClearScrollParameters> options = null)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            if (options != null)
            {
                uri = options.Invoke(new ClearScrollParameters()).GetUri(uri);
            }

            return mConnection.Execute("DELETE", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">A comma-separated list of scroll IDs to clear</param>
        ///<param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClearScrollStringAsync(string scroll_id, string body, Func<ClearScrollParameters, ClearScrollParameters> options = null)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            if (options != null)
            {
                uri = options.Invoke(new ClearScrollParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("DELETE", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-request-scroll.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClearScroll(Func<ClearScrollParameters, ClearScrollParameters> options = null)
        {
            var uri = "/_search/scroll";
            if (options != null)
            {
                uri = options.Invoke(new ClearScrollParameters()).GetUri(uri);
            }

            return mConnection.Execute("DELETE", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-request-scroll.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClearScrollAsync(Func<ClearScrollParameters, ClearScrollParameters> options = null)
        {
            var uri = "/_search/scroll";
            if (options != null)
            {
                uri = options.Invoke(new ClearScrollParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("DELETE", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-request-scroll.html"/></summary>
        ///<param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClearScroll(Stream body, Func<ClearScrollParameters, ClearScrollParameters> options = null)
        {
            var uri = "/_search/scroll";
            if (options != null)
            {
                uri = options.Invoke(new ClearScrollParameters()).GetUri(uri);
            }

            return mConnection.Execute("DELETE", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-request-scroll.html"/></summary>
        ///<param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClearScrollAsync(Stream body, Func<ClearScrollParameters, ClearScrollParameters> options = null)
        {
            var uri = "/_search/scroll";
            if (options != null)
            {
                uri = options.Invoke(new ClearScrollParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("DELETE", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-request-scroll.html"/></summary>
        ///<param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClearScroll(byte[] body, Func<ClearScrollParameters, ClearScrollParameters> options = null)
        {
            var uri = "/_search/scroll";
            if (options != null)
            {
                uri = options.Invoke(new ClearScrollParameters()).GetUri(uri);
            }

            return mConnection.Execute("DELETE", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-request-scroll.html"/></summary>
        ///<param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClearScrollAsync(byte[] body, Func<ClearScrollParameters, ClearScrollParameters> options = null)
        {
            var uri = "/_search/scroll";
            if (options != null)
            {
                uri = options.Invoke(new ClearScrollParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("DELETE", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-request-scroll.html"/></summary>
        ///<param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClearScrollString(string body, Func<ClearScrollParameters, ClearScrollParameters> options = null)
        {
            var uri = "/_search/scroll";
            if (options != null)
            {
                uri = options.Invoke(new ClearScrollParameters()).GetUri(uri);
            }

            return mConnection.Execute("DELETE", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-request-scroll.html"/></summary>
        ///<param name="body">A comma-separated list of scroll IDs to clear if none was specified via the scroll_id parameter</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClearScrollStringAsync(string body, Func<ClearScrollParameters, ClearScrollParameters> options = null)
        {
            var uri = "/_search/scroll";
            if (options != null)
            {
                uri = options.Invoke(new ClearScrollParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("DELETE", uri, body);
        }
    }
}