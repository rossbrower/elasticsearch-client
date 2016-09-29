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
        public HttpResponseMessage IndicesCreate(string index, Func<IndicesCreateParameters, IndicesCreateParameters> options = null)
        {
            var uri = string.Format("/{0}", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesCreateParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-create-index.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesCreateAsync(string index, Func<IndicesCreateParameters, IndicesCreateParameters> options = null)
        {
            var uri = string.Format("/{0}", index);
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
        public HttpResponseMessage IndicesCreate(string index, Stream body, Func<IndicesCreateParameters, IndicesCreateParameters> options = null)
        {
            var uri = string.Format("/{0}", index);
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
        public async Task<HttpResponseMessage> IndicesCreateAsync(string index, Stream body, Func<IndicesCreateParameters, IndicesCreateParameters> options = null)
        {
            var uri = string.Format("/{0}", index);
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
        public HttpResponseMessage IndicesCreate(string index, byte[] body, Func<IndicesCreateParameters, IndicesCreateParameters> options = null)
        {
            var uri = string.Format("/{0}", index);
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
        public async Task<HttpResponseMessage> IndicesCreateAsync(string index, byte[] body, Func<IndicesCreateParameters, IndicesCreateParameters> options = null)
        {
            var uri = string.Format("/{0}", index);
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
        public HttpResponseMessage IndicesCreateString(string index, string body, Func<IndicesCreateParameters, IndicesCreateParameters> options = null)
        {
            var uri = string.Format("/{0}", index);
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
        public async Task<HttpResponseMessage> IndicesCreateStringAsync(string index, string body, Func<IndicesCreateParameters, IndicesCreateParameters> options = null)
        {
            var uri = string.Format("/{0}", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesCreateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }
    }
}