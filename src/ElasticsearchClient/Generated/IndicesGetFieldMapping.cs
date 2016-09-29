using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-field-mapping.html"/></summary>
        ///<param name="fields">A comma-separated list of fields</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesGetFieldMapping(string fields, Func<IndicesGetFieldMappingParameters, IndicesGetFieldMappingParameters> options = null)
        {
            var uri = $"{"/_mapping/field/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetFieldMappingParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-field-mapping.html"/></summary>
        ///<param name="fields">A comma-separated list of fields</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesGetFieldMappingAsync(string fields, Func<IndicesGetFieldMappingParameters, IndicesGetFieldMappingParameters> options = null)
        {
            var uri = $"{"/_mapping/field/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetFieldMappingParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-field-mapping.html"/></summary>
        ///<param name="index">A comma-separated list of index names</param>
        ///<param name="fields">A comma-separated list of fields</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesGetFieldMapping(string index, string fields, Func<IndicesGetFieldMappingParameters, IndicesGetFieldMappingParameters> options = null)
        {
            var uri = $"{"/{0}/_mapping/field/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetFieldMappingParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-field-mapping.html"/></summary>
        ///<param name="index">A comma-separated list of index names</param>
        ///<param name="fields">A comma-separated list of fields</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesGetFieldMappingAsync(string index, string fields, Func<IndicesGetFieldMappingParameters, IndicesGetFieldMappingParameters> options = null)
        {
            var uri = $"{"/{0}/_mapping/field/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetFieldMappingParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-field-mapping.html"/></summary>
        ///<param name="index">A comma-separated list of index names</param>
        ///<param name="type">A comma-separated list of document types</param>
        ///<param name="fields">A comma-separated list of fields</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesGetFieldMapping(string index, string type, string fields, Func<IndicesGetFieldMappingParameters, IndicesGetFieldMappingParameters> options = null)
        {
            var uri = $"{"/{0}/_mapping/{1}/field/{2}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetFieldMappingParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-field-mapping.html"/></summary>
        ///<param name="index">A comma-separated list of index names</param>
        ///<param name="type">A comma-separated list of document types</param>
        ///<param name="fields">A comma-separated list of fields</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesGetFieldMappingAsync(string index, string type, string fields, Func<IndicesGetFieldMappingParameters, IndicesGetFieldMappingParameters> options = null)
        {
            var uri = $"{"/{0}/_mapping/{1}/field/{2}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetFieldMappingParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}