using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MpercolateGet(Stream body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = "/_mpercolate";
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MpercolateGetAsync(Stream body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = "/_mpercolate";
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MpercolateGet(byte[] body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = "/_mpercolate";
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MpercolateGetAsync(byte[] body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = "/_mpercolate";
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MpercolateGetString(string body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = "/_mpercolate";
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MpercolateGetStringAsync(string body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = "/_mpercolate";
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MpercolatePost(Stream body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = "/_mpercolate";
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MpercolatePostAsync(Stream body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = "/_mpercolate";
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MpercolatePost(byte[] body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = "/_mpercolate";
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MpercolatePostAsync(byte[] body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = "/_mpercolate";
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MpercolatePostString(string body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = "/_mpercolate";
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MpercolatePostStringAsync(string body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = "/_mpercolate";
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated to use as default</param>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MpercolateGet(string index, Stream body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/_mpercolate", index);
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated to use as default</param>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MpercolateGetAsync(string index, Stream body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/_mpercolate", index);
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated to use as default</param>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MpercolateGet(string index, byte[] body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/_mpercolate", index);
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated to use as default</param>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MpercolateGetAsync(string index, byte[] body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/_mpercolate", index);
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated to use as default</param>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MpercolateGetString(string index, string body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/_mpercolate", index);
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated to use as default</param>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MpercolateGetStringAsync(string index, string body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/_mpercolate", index);
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated to use as default</param>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MpercolatePost(string index, Stream body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/_mpercolate", index);
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated to use as default</param>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MpercolatePostAsync(string index, Stream body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/_mpercolate", index);
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated to use as default</param>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MpercolatePost(string index, byte[] body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/_mpercolate", index);
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated to use as default</param>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MpercolatePostAsync(string index, byte[] body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/_mpercolate", index);
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated to use as default</param>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MpercolatePostString(string index, string body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/_mpercolate", index);
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated to use as default</param>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MpercolatePostStringAsync(string index, string body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/_mpercolate", index);
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated to use as default</param>
        ///<param name="type">The type of the document being percolated to use as default.</param>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MpercolateGet(string index, string type, Stream body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mpercolate", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated to use as default</param>
        ///<param name="type">The type of the document being percolated to use as default.</param>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MpercolateGetAsync(string index, string type, Stream body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mpercolate", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated to use as default</param>
        ///<param name="type">The type of the document being percolated to use as default.</param>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MpercolateGet(string index, string type, byte[] body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mpercolate", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated to use as default</param>
        ///<param name="type">The type of the document being percolated to use as default.</param>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MpercolateGetAsync(string index, string type, byte[] body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mpercolate", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated to use as default</param>
        ///<param name="type">The type of the document being percolated to use as default.</param>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MpercolateGetString(string index, string type, string body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mpercolate", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated to use as default</param>
        ///<param name="type">The type of the document being percolated to use as default.</param>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MpercolateGetStringAsync(string index, string type, string body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mpercolate", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated to use as default</param>
        ///<param name="type">The type of the document being percolated to use as default.</param>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MpercolatePost(string index, string type, Stream body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mpercolate", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated to use as default</param>
        ///<param name="type">The type of the document being percolated to use as default.</param>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MpercolatePostAsync(string index, string type, Stream body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mpercolate", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated to use as default</param>
        ///<param name="type">The type of the document being percolated to use as default.</param>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MpercolatePost(string index, string type, byte[] body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mpercolate", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated to use as default</param>
        ///<param name="type">The type of the document being percolated to use as default.</param>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MpercolatePostAsync(string index, string type, byte[] body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mpercolate", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated to use as default</param>
        ///<param name="type">The type of the document being percolated to use as default.</param>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MpercolatePostString(string index, string type, string body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mpercolate", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated to use as default</param>
        ///<param name="type">The type of the document being percolated to use as default.</param>
        ///<param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MpercolatePostStringAsync(string index, string type, string body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mpercolate", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MpercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}