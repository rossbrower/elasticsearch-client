using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesAnalyzeGet(Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = "/_analyze";
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesAnalyzeGetAsync(Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = "/_analyze";
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="body">The text on which the analysis should be performed</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesAnalyzeGet(Stream body, Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = "/_analyze";
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="body">The text on which the analysis should be performed</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesAnalyzeGetAsync(Stream body, Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = "/_analyze";
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="body">The text on which the analysis should be performed</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesAnalyzeGet(byte[] body, Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = "/_analyze";
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="body">The text on which the analysis should be performed</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesAnalyzeGetAsync(byte[] body, Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = "/_analyze";
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="body">The text on which the analysis should be performed</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesAnalyzeGetString(string body, Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = "/_analyze";
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="body">The text on which the analysis should be performed</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesAnalyzeGetStringAsync(string body, Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = "/_analyze";
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesAnalyzePost(Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = "/_analyze";
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesAnalyzePostAsync(Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = "/_analyze";
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="body">The text on which the analysis should be performed</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesAnalyzePost(Stream body, Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = "/_analyze";
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="body">The text on which the analysis should be performed</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesAnalyzePostAsync(Stream body, Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = "/_analyze";
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="body">The text on which the analysis should be performed</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesAnalyzePost(byte[] body, Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = "/_analyze";
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="body">The text on which the analysis should be performed</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesAnalyzePostAsync(byte[] body, Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = "/_analyze";
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="body">The text on which the analysis should be performed</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesAnalyzePostString(string body, Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = "/_analyze";
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="body">The text on which the analysis should be performed</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesAnalyzePostStringAsync(string body, Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = "/_analyze";
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="index">The name of the index to scope the operation</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesAnalyzeGet(string index, Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = string.Format("/{0}/_analyze", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="index">The name of the index to scope the operation</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesAnalyzeGetAsync(string index, Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = string.Format("/{0}/_analyze", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="index">The name of the index to scope the operation</param>
        ///<param name="body">The text on which the analysis should be performed</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesAnalyzeGet(string index, Stream body, Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = string.Format("/{0}/_analyze", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="index">The name of the index to scope the operation</param>
        ///<param name="body">The text on which the analysis should be performed</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesAnalyzeGetAsync(string index, Stream body, Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = string.Format("/{0}/_analyze", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="index">The name of the index to scope the operation</param>
        ///<param name="body">The text on which the analysis should be performed</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesAnalyzeGet(string index, byte[] body, Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = string.Format("/{0}/_analyze", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="index">The name of the index to scope the operation</param>
        ///<param name="body">The text on which the analysis should be performed</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesAnalyzeGetAsync(string index, byte[] body, Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = string.Format("/{0}/_analyze", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="index">The name of the index to scope the operation</param>
        ///<param name="body">The text on which the analysis should be performed</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesAnalyzeGetString(string index, string body, Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = string.Format("/{0}/_analyze", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="index">The name of the index to scope the operation</param>
        ///<param name="body">The text on which the analysis should be performed</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesAnalyzeGetStringAsync(string index, string body, Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = string.Format("/{0}/_analyze", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="index">The name of the index to scope the operation</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesAnalyzePost(string index, Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = string.Format("/{0}/_analyze", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="index">The name of the index to scope the operation</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesAnalyzePostAsync(string index, Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = string.Format("/{0}/_analyze", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="index">The name of the index to scope the operation</param>
        ///<param name="body">The text on which the analysis should be performed</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesAnalyzePost(string index, Stream body, Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = string.Format("/{0}/_analyze", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="index">The name of the index to scope the operation</param>
        ///<param name="body">The text on which the analysis should be performed</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesAnalyzePostAsync(string index, Stream body, Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = string.Format("/{0}/_analyze", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="index">The name of the index to scope the operation</param>
        ///<param name="body">The text on which the analysis should be performed</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesAnalyzePost(string index, byte[] body, Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = string.Format("/{0}/_analyze", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="index">The name of the index to scope the operation</param>
        ///<param name="body">The text on which the analysis should be performed</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesAnalyzePostAsync(string index, byte[] body, Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = string.Format("/{0}/_analyze", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="index">The name of the index to scope the operation</param>
        ///<param name="body">The text on which the analysis should be performed</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesAnalyzePostString(string index, string body, Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = string.Format("/{0}/_analyze", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-analyze.html"/></summary>
        ///<param name="index">The name of the index to scope the operation</param>
        ///<param name="body">The text on which the analysis should be performed</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesAnalyzePostStringAsync(string index, string body, Func<IndicesAnalyzeParameters, IndicesAnalyzeParameters> options = null)
        {
            var uri = string.Format("/{0}/_analyze", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesAnalyzeParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}