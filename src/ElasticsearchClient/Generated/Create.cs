using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CreatePut(string index, string type, string id, Stream body, Func<CreateParameters, CreateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_create", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new CreateParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CreatePutAsync(string index, string type, string id, Stream body, Func<CreateParameters, CreateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_create", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new CreateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CreatePut(string index, string type, string id, byte[] body, Func<CreateParameters, CreateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_create", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new CreateParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CreatePutAsync(string index, string type, string id, byte[] body, Func<CreateParameters, CreateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_create", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new CreateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CreatePutString(string index, string type, string id, string body, Func<CreateParameters, CreateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_create", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new CreateParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CreatePutStringAsync(string index, string type, string id, string body, Func<CreateParameters, CreateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_create", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new CreateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CreatePost(string index, string type, string id, Stream body, Func<CreateParameters, CreateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_create", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new CreateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CreatePostAsync(string index, string type, string id, Stream body, Func<CreateParameters, CreateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_create", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new CreateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CreatePost(string index, string type, string id, byte[] body, Func<CreateParameters, CreateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_create", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new CreateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CreatePostAsync(string index, string type, string id, byte[] body, Func<CreateParameters, CreateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_create", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new CreateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CreatePostString(string index, string type, string id, string body, Func<CreateParameters, CreateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_create", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new CreateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CreatePostStringAsync(string index, string type, string id, string body, Func<CreateParameters, CreateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_create", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new CreateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}