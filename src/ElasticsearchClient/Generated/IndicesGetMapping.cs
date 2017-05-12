using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-mapping.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesGetMapping(Func<IndicesGetMappingParameters, IndicesGetMappingParameters> options = null)
        {
            var uri = "/_mapping";
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetMappingParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-mapping.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesGetMappingAsync(Func<IndicesGetMappingParameters, IndicesGetMappingParameters> options = null)
        {
            var uri = "/_mapping";
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetMappingParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-mapping.html"/></summary>
        ///<param name="index">A comma-separated list of index names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesGetMapping(string index, Func<IndicesGetMappingParameters, IndicesGetMappingParameters> options = null)
        {
            var uri = string.Format("/{0}/_mapping", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetMappingParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-mapping.html"/></summary>
        ///<param name="index">A comma-separated list of index names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesGetMappingAsync(string index, Func<IndicesGetMappingParameters, IndicesGetMappingParameters> options = null)
        {
            var uri = string.Format("/{0}/_mapping", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetMappingParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-mapping.html"/></summary>
        ///<param name="index">A comma-separated list of index names</param>
        ///<param name="type">A comma-separated list of document types</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesGetMapping(string index, string type, Func<IndicesGetMappingParameters, IndicesGetMappingParameters> options = null)
        {
            var uri = string.Format("/{0}/_mapping/{1}", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetMappingParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-mapping.html"/></summary>
        ///<param name="index">A comma-separated list of index names</param>
        ///<param name="type">A comma-separated list of document types</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesGetMappingAsync(string index, string type, Func<IndicesGetMappingParameters, IndicesGetMappingParameters> options = null)
        {
            var uri = string.Format("/{0}/_mapping/{1}", index, type);
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetMappingParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}