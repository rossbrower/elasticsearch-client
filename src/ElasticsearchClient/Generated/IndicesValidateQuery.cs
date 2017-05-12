using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesValidateQueryGet(Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = "/_validate/query";
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesValidateQueryGetAsync(Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = "/_validate/query";
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesValidateQueryGet(Stream body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = "/_validate/query";
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesValidateQueryGetAsync(Stream body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = "/_validate/query";
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesValidateQueryGet(byte[] body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = "/_validate/query";
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesValidateQueryGetAsync(byte[] body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = "/_validate/query";
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesValidateQueryGetString(string body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = "/_validate/query";
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesValidateQueryGetStringAsync(string body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = "/_validate/query";
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesValidateQueryPost(Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = "/_validate/query";
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesValidateQueryPostAsync(Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = "/_validate/query";
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesValidateQueryPost(Stream body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = "/_validate/query";
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesValidateQueryPostAsync(Stream body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = "/_validate/query";
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesValidateQueryPost(byte[] body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = "/_validate/query";
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesValidateQueryPostAsync(byte[] body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = "/_validate/query";
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesValidateQueryPostString(string body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = "/_validate/query";
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesValidateQueryPostStringAsync(string body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = "/_validate/query";
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesValidateQueryGet(string index, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_validate/query", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesValidateQueryGetAsync(string index, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_validate/query", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesValidateQueryGet(string index, Stream body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_validate/query", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesValidateQueryGetAsync(string index, Stream body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_validate/query", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesValidateQueryGet(string index, byte[] body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_validate/query", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesValidateQueryGetAsync(string index, byte[] body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_validate/query", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesValidateQueryGetString(string index, string body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_validate/query", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesValidateQueryGetStringAsync(string index, string body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_validate/query", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesValidateQueryPost(string index, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_validate/query", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesValidateQueryPostAsync(string index, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_validate/query", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesValidateQueryPost(string index, Stream body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_validate/query", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesValidateQueryPostAsync(string index, Stream body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_validate/query", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesValidateQueryPost(string index, byte[] body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_validate/query", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesValidateQueryPostAsync(string index, byte[] body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_validate/query", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesValidateQueryPostString(string index, string body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_validate/query", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesValidateQueryPostStringAsync(string index, string body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_validate/query", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesValidateQueryGet(string index, string type, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_validate/query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesValidateQueryGetAsync(string index, string type, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_validate/query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesValidateQueryGet(string index, string type, Stream body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_validate/query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesValidateQueryGetAsync(string index, string type, Stream body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_validate/query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesValidateQueryGet(string index, string type, byte[] body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_validate/query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesValidateQueryGetAsync(string index, string type, byte[] body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_validate/query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesValidateQueryGetString(string index, string type, string body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_validate/query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesValidateQueryGetStringAsync(string index, string type, string body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_validate/query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesValidateQueryPost(string index, string type, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_validate/query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesValidateQueryPostAsync(string index, string type, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_validate/query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesValidateQueryPost(string index, string type, Stream body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_validate/query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesValidateQueryPostAsync(string index, string type, Stream body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_validate/query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesValidateQueryPost(string index, string type, byte[] body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_validate/query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesValidateQueryPostAsync(string index, string type, byte[] body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_validate/query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesValidateQueryPostString(string index, string type, string body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_validate/query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-validate.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
        ///<param name="body">The query definition specified with the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesValidateQueryPostStringAsync(string index, string type, string body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_validate/query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesValidateQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}