using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MgetGet(Stream body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = "/_mget";
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MgetGetAsync(Stream body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = "/_mget";
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MgetGet(byte[] body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = "/_mget";
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MgetGetAsync(byte[] body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = "/_mget";
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MgetGetString(string body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = "/_mget";
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MgetGetStringAsync(string body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = "/_mget";
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MgetPost(Stream body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = "/_mget";
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MgetPostAsync(Stream body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = "/_mget";
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MgetPost(byte[] body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = "/_mget";
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MgetPostAsync(byte[] body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = "/_mget";
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MgetPostString(string body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = "/_mget";
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MgetPostStringAsync(string body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = "/_mget";
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MgetGet(string index, Stream body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = string.Format("/{0}/_mget", index);
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MgetGetAsync(string index, Stream body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = string.Format("/{0}/_mget", index);
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MgetGet(string index, byte[] body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = string.Format("/{0}/_mget", index);
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MgetGetAsync(string index, byte[] body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = string.Format("/{0}/_mget", index);
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MgetGetString(string index, string body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = string.Format("/{0}/_mget", index);
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MgetGetStringAsync(string index, string body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = string.Format("/{0}/_mget", index);
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MgetPost(string index, Stream body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = string.Format("/{0}/_mget", index);
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MgetPostAsync(string index, Stream body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = string.Format("/{0}/_mget", index);
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MgetPost(string index, byte[] body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = string.Format("/{0}/_mget", index);
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MgetPostAsync(string index, byte[] body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = string.Format("/{0}/_mget", index);
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MgetPostString(string index, string body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = string.Format("/{0}/_mget", index);
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MgetPostStringAsync(string index, string body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = string.Format("/{0}/_mget", index);
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MgetGet(string index, string type, Stream body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mget", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MgetGetAsync(string index, string type, Stream body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mget", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MgetGet(string index, string type, byte[] body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mget", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MgetGetAsync(string index, string type, byte[] body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mget", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MgetGetString(string index, string type, string body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mget", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MgetGetStringAsync(string index, string type, string body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mget", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MgetPost(string index, string type, Stream body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mget", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MgetPostAsync(string index, string type, Stream body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mget", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MgetPost(string index, string type, byte[] body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mget", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MgetPostAsync(string index, string type, byte[] body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mget", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MgetPostString(string index, string type, string body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mget", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-multi-get.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MgetPostStringAsync(string index, string type, string body, Func<MgetParameters, MgetParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mget", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MgetParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}