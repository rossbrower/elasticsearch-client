using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">The document ID</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ExplainGet(string index, string type, string id, Func<ExplainParameters, ExplainParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/{2}/_explain"}";
            if (options != null)
            {
                uri = options.Invoke(new ExplainParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">The document ID</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ExplainGetAsync(string index, string type, string id, Func<ExplainParameters, ExplainParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/{2}/_explain"}";
            if (options != null)
            {
                uri = options.Invoke(new ExplainParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">The document ID</param>
        ///<param name="body">The query definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ExplainGet(string index, string type, string id, Stream body, Func<ExplainParameters, ExplainParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/{2}/_explain"}";
            if (options != null)
            {
                uri = options.Invoke(new ExplainParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">The document ID</param>
        ///<param name="body">The query definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ExplainGetAsync(string index, string type, string id, Stream body, Func<ExplainParameters, ExplainParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/{2}/_explain"}";
            if (options != null)
            {
                uri = options.Invoke(new ExplainParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">The document ID</param>
        ///<param name="body">The query definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ExplainGet(string index, string type, string id, byte[] body, Func<ExplainParameters, ExplainParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/{2}/_explain"}";
            if (options != null)
            {
                uri = options.Invoke(new ExplainParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">The document ID</param>
        ///<param name="body">The query definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ExplainGetAsync(string index, string type, string id, byte[] body, Func<ExplainParameters, ExplainParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/{2}/_explain"}";
            if (options != null)
            {
                uri = options.Invoke(new ExplainParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">The document ID</param>
        ///<param name="body">The query definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ExplainGetString(string index, string type, string id, string body, Func<ExplainParameters, ExplainParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/{2}/_explain"}";
            if (options != null)
            {
                uri = options.Invoke(new ExplainParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">The document ID</param>
        ///<param name="body">The query definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ExplainGetStringAsync(string index, string type, string id, string body, Func<ExplainParameters, ExplainParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/{2}/_explain"}";
            if (options != null)
            {
                uri = options.Invoke(new ExplainParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">The document ID</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ExplainPost(string index, string type, string id, Func<ExplainParameters, ExplainParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/{2}/_explain"}";
            if (options != null)
            {
                uri = options.Invoke(new ExplainParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">The document ID</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ExplainPostAsync(string index, string type, string id, Func<ExplainParameters, ExplainParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/{2}/_explain"}";
            if (options != null)
            {
                uri = options.Invoke(new ExplainParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">The document ID</param>
        ///<param name="body">The query definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ExplainPost(string index, string type, string id, Stream body, Func<ExplainParameters, ExplainParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/{2}/_explain"}";
            if (options != null)
            {
                uri = options.Invoke(new ExplainParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">The document ID</param>
        ///<param name="body">The query definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ExplainPostAsync(string index, string type, string id, Stream body, Func<ExplainParameters, ExplainParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/{2}/_explain"}";
            if (options != null)
            {
                uri = options.Invoke(new ExplainParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">The document ID</param>
        ///<param name="body">The query definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ExplainPost(string index, string type, string id, byte[] body, Func<ExplainParameters, ExplainParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/{2}/_explain"}";
            if (options != null)
            {
                uri = options.Invoke(new ExplainParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">The document ID</param>
        ///<param name="body">The query definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ExplainPostAsync(string index, string type, string id, byte[] body, Func<ExplainParameters, ExplainParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/{2}/_explain"}";
            if (options != null)
            {
                uri = options.Invoke(new ExplainParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">The document ID</param>
        ///<param name="body">The query definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ExplainPostString(string index, string type, string id, string body, Func<ExplainParameters, ExplainParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/{2}/_explain"}";
            if (options != null)
            {
                uri = options.Invoke(new ExplainParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">The document ID</param>
        ///<param name="body">The query definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ExplainPostStringAsync(string index, string type, string id, string body, Func<ExplainParameters, ExplainParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/{2}/_explain"}";
            if (options != null)
            {
                uri = options.Invoke(new ExplainParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}