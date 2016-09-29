using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ScrollGet(Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = "/_search/scroll";
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ScrollGetAsync(Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = "/_search/scroll";
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ScrollGet(Stream body, Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = "/_search/scroll";
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ScrollGetAsync(Stream body, Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = "/_search/scroll";
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ScrollGet(byte[] body, Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = "/_search/scroll";
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ScrollGetAsync(byte[] body, Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = "/_search/scroll";
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ScrollGetString(string body, Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = "/_search/scroll";
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ScrollGetStringAsync(string body, Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = "/_search/scroll";
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ScrollPost(Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = "/_search/scroll";
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ScrollPostAsync(Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = "/_search/scroll";
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ScrollPost(Stream body, Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = "/_search/scroll";
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ScrollPostAsync(Stream body, Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = "/_search/scroll";
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ScrollPost(byte[] body, Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = "/_search/scroll";
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ScrollPostAsync(byte[] body, Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = "/_search/scroll";
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ScrollPostString(string body, Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = "/_search/scroll";
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ScrollPostStringAsync(string body, Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = "/_search/scroll";
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">The scroll ID</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ScrollGet(string scroll_id, Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">The scroll ID</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ScrollGetAsync(string scroll_id, Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">The scroll ID</param>
        ///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ScrollGet(string scroll_id, Stream body, Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">The scroll ID</param>
        ///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ScrollGetAsync(string scroll_id, Stream body, Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">The scroll ID</param>
        ///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ScrollGet(string scroll_id, byte[] body, Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">The scroll ID</param>
        ///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ScrollGetAsync(string scroll_id, byte[] body, Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">The scroll ID</param>
        ///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ScrollGetString(string scroll_id, string body, Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">The scroll ID</param>
        ///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ScrollGetStringAsync(string scroll_id, string body, Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">The scroll ID</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ScrollPost(string scroll_id, Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">The scroll ID</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ScrollPostAsync(string scroll_id, Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">The scroll ID</param>
        ///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ScrollPost(string scroll_id, Stream body, Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">The scroll ID</param>
        ///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ScrollPostAsync(string scroll_id, Stream body, Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">The scroll ID</param>
        ///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ScrollPost(string scroll_id, byte[] body, Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">The scroll ID</param>
        ///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ScrollPostAsync(string scroll_id, byte[] body, Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">The scroll ID</param>
        ///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ScrollPostString(string scroll_id, string body, Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-request-scroll.html"/></summary>
        ///<param name="scroll_id">The scroll ID</param>
        ///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ScrollPostStringAsync(string scroll_id, string body, Func<ScrollParameters, ScrollParameters> options = null)
        {
            var uri = string.Format("/_search/scroll/{0}", scroll_id);
            if (options != null)
            {
                uri = options.Invoke(new ScrollParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}