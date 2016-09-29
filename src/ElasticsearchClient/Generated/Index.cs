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
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndexPost(string index, string type, Stream body, Func<IndexParameters, IndexParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndexParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndexPostAsync(string index, string type, Stream body, Func<IndexParameters, IndexParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndexParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndexPost(string index, string type, byte[] body, Func<IndexParameters, IndexParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndexParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndexPostAsync(string index, string type, byte[] body, Func<IndexParameters, IndexParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndexParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndexPostString(string index, string type, string body, Func<IndexParameters, IndexParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndexParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndexPostStringAsync(string index, string type, string body, Func<IndexParameters, IndexParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndexParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndexPut(string index, string type, Stream body, Func<IndexParameters, IndexParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndexParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndexPutAsync(string index, string type, Stream body, Func<IndexParameters, IndexParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndexParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndexPut(string index, string type, byte[] body, Func<IndexParameters, IndexParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndexParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndexPutAsync(string index, string type, byte[] body, Func<IndexParameters, IndexParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndexParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndexPutString(string index, string type, string body, Func<IndexParameters, IndexParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndexParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndexPutStringAsync(string index, string type, string body, Func<IndexParameters, IndexParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndexParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndexPost(string index, string type, string id, Stream body, Func<IndexParameters, IndexParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new IndexParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndexPostAsync(string index, string type, string id, Stream body, Func<IndexParameters, IndexParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new IndexParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndexPost(string index, string type, string id, byte[] body, Func<IndexParameters, IndexParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new IndexParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndexPostAsync(string index, string type, string id, byte[] body, Func<IndexParameters, IndexParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new IndexParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndexPostString(string index, string type, string id, string body, Func<IndexParameters, IndexParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new IndexParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndexPostStringAsync(string index, string type, string id, string body, Func<IndexParameters, IndexParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new IndexParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndexPut(string index, string type, string id, Stream body, Func<IndexParameters, IndexParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new IndexParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndexPutAsync(string index, string type, string id, Stream body, Func<IndexParameters, IndexParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new IndexParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndexPut(string index, string type, string id, byte[] body, Func<IndexParameters, IndexParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new IndexParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndexPutAsync(string index, string type, string id, byte[] body, Func<IndexParameters, IndexParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new IndexParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndexPutString(string index, string type, string id, string body, Func<IndexParameters, IndexParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new IndexParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The document</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndexPutStringAsync(string index, string type, string id, string body, Func<IndexParameters, IndexParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new IndexParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }
    }
}