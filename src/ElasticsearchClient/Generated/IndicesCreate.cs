using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-create-index.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesCreatePut(string index, Func<IndicesCreateParameters, IndicesCreateParameters> options = null)
        {
            var uri = $"{"/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesCreateParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-create-index.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesCreatePutAsync(string index, Func<IndicesCreateParameters, IndicesCreateParameters> options = null)
        {
            var uri = $"{"/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesCreateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-create-index.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="body">The configuration for the index (`settings` and `mappings`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesCreatePut(string index, Stream body, Func<IndicesCreateParameters, IndicesCreateParameters> options = null)
        {
            var uri = $"{"/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesCreateParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-create-index.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="body">The configuration for the index (`settings` and `mappings`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesCreatePutAsync(string index, Stream body, Func<IndicesCreateParameters, IndicesCreateParameters> options = null)
        {
            var uri = $"{"/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesCreateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-create-index.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="body">The configuration for the index (`settings` and `mappings`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesCreatePut(string index, byte[] body, Func<IndicesCreateParameters, IndicesCreateParameters> options = null)
        {
            var uri = $"{"/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesCreateParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-create-index.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="body">The configuration for the index (`settings` and `mappings`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesCreatePutAsync(string index, byte[] body, Func<IndicesCreateParameters, IndicesCreateParameters> options = null)
        {
            var uri = $"{"/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesCreateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-create-index.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="body">The configuration for the index (`settings` and `mappings`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesCreatePutString(string index, string body, Func<IndicesCreateParameters, IndicesCreateParameters> options = null)
        {
            var uri = $"{"/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesCreateParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-create-index.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="body">The configuration for the index (`settings` and `mappings`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesCreatePutStringAsync(string index, string body, Func<IndicesCreateParameters, IndicesCreateParameters> options = null)
        {
            var uri = $"{"/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesCreateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-create-index.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesCreatePost(string index, Func<IndicesCreateParameters, IndicesCreateParameters> options = null)
        {
            var uri = $"{"/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesCreateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-create-index.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesCreatePostAsync(string index, Func<IndicesCreateParameters, IndicesCreateParameters> options = null)
        {
            var uri = $"{"/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesCreateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-create-index.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="body">The configuration for the index (`settings` and `mappings`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesCreatePost(string index, Stream body, Func<IndicesCreateParameters, IndicesCreateParameters> options = null)
        {
            var uri = $"{"/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesCreateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-create-index.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="body">The configuration for the index (`settings` and `mappings`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesCreatePostAsync(string index, Stream body, Func<IndicesCreateParameters, IndicesCreateParameters> options = null)
        {
            var uri = $"{"/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesCreateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-create-index.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="body">The configuration for the index (`settings` and `mappings`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesCreatePost(string index, byte[] body, Func<IndicesCreateParameters, IndicesCreateParameters> options = null)
        {
            var uri = $"{"/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesCreateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-create-index.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="body">The configuration for the index (`settings` and `mappings`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesCreatePostAsync(string index, byte[] body, Func<IndicesCreateParameters, IndicesCreateParameters> options = null)
        {
            var uri = $"{"/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesCreateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-create-index.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="body">The configuration for the index (`settings` and `mappings`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesCreatePostString(string index, string body, Func<IndicesCreateParameters, IndicesCreateParameters> options = null)
        {
            var uri = $"{"/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesCreateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-create-index.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="body">The configuration for the index (`settings` and `mappings`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesCreatePostStringAsync(string index, string body, Func<IndicesCreateParameters, IndicesCreateParameters> options = null)
        {
            var uri = $"{"/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesCreateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}