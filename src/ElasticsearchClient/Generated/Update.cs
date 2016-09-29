using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-update.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage Update(string index, string type, string id, Func<UpdateParameters, UpdateParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/{2}/_update"}";
            if (options != null)
            {
                uri = options.Invoke(new UpdateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-update.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> UpdateAsync(string index, string type, string id, Func<UpdateParameters, UpdateParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/{2}/_update"}";
            if (options != null)
            {
                uri = options.Invoke(new UpdateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-update.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The request definition using either `script` or partial `doc`</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage Update(string index, string type, string id, Stream body, Func<UpdateParameters, UpdateParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/{2}/_update"}";
            if (options != null)
            {
                uri = options.Invoke(new UpdateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-update.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The request definition using either `script` or partial `doc`</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> UpdateAsync(string index, string type, string id, Stream body, Func<UpdateParameters, UpdateParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/{2}/_update"}";
            if (options != null)
            {
                uri = options.Invoke(new UpdateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-update.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The request definition using either `script` or partial `doc`</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage Update(string index, string type, string id, byte[] body, Func<UpdateParameters, UpdateParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/{2}/_update"}";
            if (options != null)
            {
                uri = options.Invoke(new UpdateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-update.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The request definition using either `script` or partial `doc`</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> UpdateAsync(string index, string type, string id, byte[] body, Func<UpdateParameters, UpdateParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/{2}/_update"}";
            if (options != null)
            {
                uri = options.Invoke(new UpdateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-update.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The request definition using either `script` or partial `doc`</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage UpdateString(string index, string type, string id, string body, Func<UpdateParameters, UpdateParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/{2}/_update"}";
            if (options != null)
            {
                uri = options.Invoke(new UpdateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-update.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">Document ID</param>
        ///<param name="body">The request definition using either `script` or partial `doc`</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> UpdateStringAsync(string index, string type, string id, string body, Func<UpdateParameters, UpdateParameters> options = null)
        {
            var uri = $"{"/{0}/{1}/{2}/_update"}";
            if (options != null)
            {
                uri = options.Invoke(new UpdateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}