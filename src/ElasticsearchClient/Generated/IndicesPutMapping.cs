using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html"/></summary>
        ///<param name="index">A comma-separated list of index names the mapping should be added to (supports wildcards); use `_all` or omit to add the mapping on all indices.</param>
        ///<param name="type">The name of the document type</param>
        ///<param name="body">The mapping definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutMappingPut(string index, string type, Stream body, Func<IndicesPutMappingParameters, IndicesPutMappingParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mapping", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutMappingParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html"/></summary>
        ///<param name="index">A comma-separated list of index names the mapping should be added to (supports wildcards); use `_all` or omit to add the mapping on all indices.</param>
        ///<param name="type">The name of the document type</param>
        ///<param name="body">The mapping definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutMappingPutAsync(string index, string type, Stream body, Func<IndicesPutMappingParameters, IndicesPutMappingParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mapping", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutMappingParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html"/></summary>
        ///<param name="index">A comma-separated list of index names the mapping should be added to (supports wildcards); use `_all` or omit to add the mapping on all indices.</param>
        ///<param name="type">The name of the document type</param>
        ///<param name="body">The mapping definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutMappingPut(string index, string type, byte[] body, Func<IndicesPutMappingParameters, IndicesPutMappingParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mapping", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutMappingParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html"/></summary>
        ///<param name="index">A comma-separated list of index names the mapping should be added to (supports wildcards); use `_all` or omit to add the mapping on all indices.</param>
        ///<param name="type">The name of the document type</param>
        ///<param name="body">The mapping definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutMappingPutAsync(string index, string type, byte[] body, Func<IndicesPutMappingParameters, IndicesPutMappingParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mapping", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutMappingParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html"/></summary>
        ///<param name="index">A comma-separated list of index names the mapping should be added to (supports wildcards); use `_all` or omit to add the mapping on all indices.</param>
        ///<param name="type">The name of the document type</param>
        ///<param name="body">The mapping definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutMappingPutString(string index, string type, string body, Func<IndicesPutMappingParameters, IndicesPutMappingParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mapping", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutMappingParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html"/></summary>
        ///<param name="index">A comma-separated list of index names the mapping should be added to (supports wildcards); use `_all` or omit to add the mapping on all indices.</param>
        ///<param name="type">The name of the document type</param>
        ///<param name="body">The mapping definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutMappingPutStringAsync(string index, string type, string body, Func<IndicesPutMappingParameters, IndicesPutMappingParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mapping", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutMappingParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html"/></summary>
        ///<param name="index">A comma-separated list of index names the mapping should be added to (supports wildcards); use `_all` or omit to add the mapping on all indices.</param>
        ///<param name="type">The name of the document type</param>
        ///<param name="body">The mapping definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutMappingPost(string index, string type, Stream body, Func<IndicesPutMappingParameters, IndicesPutMappingParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mapping", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutMappingParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html"/></summary>
        ///<param name="index">A comma-separated list of index names the mapping should be added to (supports wildcards); use `_all` or omit to add the mapping on all indices.</param>
        ///<param name="type">The name of the document type</param>
        ///<param name="body">The mapping definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutMappingPostAsync(string index, string type, Stream body, Func<IndicesPutMappingParameters, IndicesPutMappingParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mapping", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutMappingParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html"/></summary>
        ///<param name="index">A comma-separated list of index names the mapping should be added to (supports wildcards); use `_all` or omit to add the mapping on all indices.</param>
        ///<param name="type">The name of the document type</param>
        ///<param name="body">The mapping definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutMappingPost(string index, string type, byte[] body, Func<IndicesPutMappingParameters, IndicesPutMappingParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mapping", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutMappingParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html"/></summary>
        ///<param name="index">A comma-separated list of index names the mapping should be added to (supports wildcards); use `_all` or omit to add the mapping on all indices.</param>
        ///<param name="type">The name of the document type</param>
        ///<param name="body">The mapping definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutMappingPostAsync(string index, string type, byte[] body, Func<IndicesPutMappingParameters, IndicesPutMappingParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mapping", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutMappingParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html"/></summary>
        ///<param name="index">A comma-separated list of index names the mapping should be added to (supports wildcards); use `_all` or omit to add the mapping on all indices.</param>
        ///<param name="type">The name of the document type</param>
        ///<param name="body">The mapping definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutMappingPostString(string index, string type, string body, Func<IndicesPutMappingParameters, IndicesPutMappingParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mapping", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutMappingParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html"/></summary>
        ///<param name="index">A comma-separated list of index names the mapping should be added to (supports wildcards); use `_all` or omit to add the mapping on all indices.</param>
        ///<param name="type">The name of the document type</param>
        ///<param name="body">The mapping definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutMappingPostStringAsync(string index, string type, string body, Func<IndicesPutMappingParameters, IndicesPutMappingParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mapping", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutMappingParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html"/></summary>
        ///<param name="type">The name of the document type</param>
        ///<param name="body">The mapping definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutMappingPut(string type, Stream body, Func<IndicesPutMappingParameters, IndicesPutMappingParameters> options = null)
        {
            var uri = string.Format("/_mapping/{0}", type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutMappingParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html"/></summary>
        ///<param name="type">The name of the document type</param>
        ///<param name="body">The mapping definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutMappingPutAsync(string type, Stream body, Func<IndicesPutMappingParameters, IndicesPutMappingParameters> options = null)
        {
            var uri = string.Format("/_mapping/{0}", type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutMappingParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html"/></summary>
        ///<param name="type">The name of the document type</param>
        ///<param name="body">The mapping definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutMappingPut(string type, byte[] body, Func<IndicesPutMappingParameters, IndicesPutMappingParameters> options = null)
        {
            var uri = string.Format("/_mapping/{0}", type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutMappingParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html"/></summary>
        ///<param name="type">The name of the document type</param>
        ///<param name="body">The mapping definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutMappingPutAsync(string type, byte[] body, Func<IndicesPutMappingParameters, IndicesPutMappingParameters> options = null)
        {
            var uri = string.Format("/_mapping/{0}", type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutMappingParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html"/></summary>
        ///<param name="type">The name of the document type</param>
        ///<param name="body">The mapping definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutMappingPutString(string type, string body, Func<IndicesPutMappingParameters, IndicesPutMappingParameters> options = null)
        {
            var uri = string.Format("/_mapping/{0}", type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutMappingParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html"/></summary>
        ///<param name="type">The name of the document type</param>
        ///<param name="body">The mapping definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutMappingPutStringAsync(string type, string body, Func<IndicesPutMappingParameters, IndicesPutMappingParameters> options = null)
        {
            var uri = string.Format("/_mapping/{0}", type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutMappingParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html"/></summary>
        ///<param name="type">The name of the document type</param>
        ///<param name="body">The mapping definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutMappingPost(string type, Stream body, Func<IndicesPutMappingParameters, IndicesPutMappingParameters> options = null)
        {
            var uri = string.Format("/_mapping/{0}", type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutMappingParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html"/></summary>
        ///<param name="type">The name of the document type</param>
        ///<param name="body">The mapping definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutMappingPostAsync(string type, Stream body, Func<IndicesPutMappingParameters, IndicesPutMappingParameters> options = null)
        {
            var uri = string.Format("/_mapping/{0}", type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutMappingParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html"/></summary>
        ///<param name="type">The name of the document type</param>
        ///<param name="body">The mapping definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutMappingPost(string type, byte[] body, Func<IndicesPutMappingParameters, IndicesPutMappingParameters> options = null)
        {
            var uri = string.Format("/_mapping/{0}", type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutMappingParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html"/></summary>
        ///<param name="type">The name of the document type</param>
        ///<param name="body">The mapping definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutMappingPostAsync(string type, byte[] body, Func<IndicesPutMappingParameters, IndicesPutMappingParameters> options = null)
        {
            var uri = string.Format("/_mapping/{0}", type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutMappingParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html"/></summary>
        ///<param name="type">The name of the document type</param>
        ///<param name="body">The mapping definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutMappingPostString(string type, string body, Func<IndicesPutMappingParameters, IndicesPutMappingParameters> options = null)
        {
            var uri = string.Format("/_mapping/{0}", type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutMappingParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-put-mapping.html"/></summary>
        ///<param name="type">The name of the document type</param>
        ///<param name="body">The mapping definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutMappingPostStringAsync(string type, string body, Func<IndicesPutMappingParameters, IndicesPutMappingParameters> options = null)
        {
            var uri = string.Format("/_mapping/{0}", type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutMappingParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}