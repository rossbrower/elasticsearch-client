//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Elasticsearch.Client
{
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    
    
    public partial class ElasticsearchClient
    {
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-field-mapping.html"/></summary>
        /// <param name="fields">A comma-separated list of fields</param>
        public virtual HttpResponseMessage IndicesGetFieldMapping(string fields)
        {
            string uri = string.Format("/_mapping/field/{0}", fields);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-field-mapping.html"/></summary>
        /// <param name="fields">A comma-separated list of fields</param>
        public virtual async Task<HttpResponseMessage> IndicesGetFieldMappingAsync(string fields)
        {
            string uri = string.Format("/_mapping/field/{0}", fields);
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-field-mapping.html"/></summary>
        /// <param name="fields">A comma-separated list of fields</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesGetFieldMapping(string fields, Func<IndicesGetFieldMappingParameters, IndicesGetFieldMappingParameters> options)
        {
            string uri = string.Format("/_mapping/field/{0}", fields);
            IndicesGetFieldMappingParameters parameters = options.Invoke(new IndicesGetFieldMappingParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-field-mapping.html"/></summary>
        /// <param name="fields">A comma-separated list of fields</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesGetFieldMappingAsync(string fields, Func<IndicesGetFieldMappingParameters, IndicesGetFieldMappingParameters> options)
        {
            string uri = string.Format("/_mapping/field/{0}", fields);
            IndicesGetFieldMappingParameters parameters = options.Invoke(new IndicesGetFieldMappingParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-field-mapping.html"/></summary>
        /// <param name="index">A comma-separated list of index names</param>
        /// <param name="fields">A comma-separated list of fields</param>
        public virtual HttpResponseMessage IndicesGetFieldMapping(string index, string fields)
        {
            string uri = string.Format("/{0}/_mapping/field/{1}", index, fields);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-field-mapping.html"/></summary>
        /// <param name="index">A comma-separated list of index names</param>
        /// <param name="fields">A comma-separated list of fields</param>
        public virtual async Task<HttpResponseMessage> IndicesGetFieldMappingAsync(string index, string fields)
        {
            string uri = string.Format("/{0}/_mapping/field/{1}", index, fields);
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-field-mapping.html"/></summary>
        /// <param name="index">A comma-separated list of index names</param>
        /// <param name="fields">A comma-separated list of fields</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesGetFieldMapping(string index, string fields, Func<IndicesGetFieldMappingParameters, IndicesGetFieldMappingParameters> options)
        {
            string uri = string.Format("/{0}/_mapping/field/{1}", index, fields);
            IndicesGetFieldMappingParameters parameters = options.Invoke(new IndicesGetFieldMappingParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-field-mapping.html"/></summary>
        /// <param name="index">A comma-separated list of index names</param>
        /// <param name="fields">A comma-separated list of fields</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesGetFieldMappingAsync(string index, string fields, Func<IndicesGetFieldMappingParameters, IndicesGetFieldMappingParameters> options)
        {
            string uri = string.Format("/{0}/_mapping/field/{1}", index, fields);
            IndicesGetFieldMappingParameters parameters = options.Invoke(new IndicesGetFieldMappingParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-field-mapping.html"/></summary>
        /// <param name="index">A comma-separated list of index names</param>
        /// <param name="type">A comma-separated list of document types</param>
        /// <param name="fields">A comma-separated list of fields</param>
        public virtual HttpResponseMessage IndicesGetFieldMapping(string index, string type, string fields)
        {
            string uri = string.Format("/{0}/_mapping/{1}/field/{2}", index, type, fields);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-field-mapping.html"/></summary>
        /// <param name="index">A comma-separated list of index names</param>
        /// <param name="type">A comma-separated list of document types</param>
        /// <param name="fields">A comma-separated list of fields</param>
        public virtual async Task<HttpResponseMessage> IndicesGetFieldMappingAsync(string index, string type, string fields)
        {
            string uri = string.Format("/{0}/_mapping/{1}/field/{2}", index, type, fields);
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-field-mapping.html"/></summary>
        /// <param name="index">A comma-separated list of index names</param>
        /// <param name="type">A comma-separated list of document types</param>
        /// <param name="fields">A comma-separated list of fields</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesGetFieldMapping(string index, string type, string fields, Func<IndicesGetFieldMappingParameters, IndicesGetFieldMappingParameters> options)
        {
            string uri = string.Format("/{0}/_mapping/{1}/field/{2}", index, type, fields);
            IndicesGetFieldMappingParameters parameters = options.Invoke(new IndicesGetFieldMappingParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-field-mapping.html"/></summary>
        /// <param name="index">A comma-separated list of index names</param>
        /// <param name="type">A comma-separated list of document types</param>
        /// <param name="fields">A comma-separated list of fields</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesGetFieldMappingAsync(string index, string type, string fields, Func<IndicesGetFieldMappingParameters, IndicesGetFieldMappingParameters> options)
        {
            string uri = string.Format("/{0}/_mapping/{1}/field/{2}", index, type, fields);
            IndicesGetFieldMappingParameters parameters = options.Invoke(new IndicesGetFieldMappingParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("GET", uri);
        }
    }
}
