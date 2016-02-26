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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-indices.html"/></summary>
        private HttpResponseMessage CatIndices()
        {
            string uri = "/_cat/indices";
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-indices.html"/></summary>
        private async Task<HttpResponseMessage> CatIndicesAsync()
        {
            string uri = "/_cat/indices";
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-indices.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        private HttpResponseMessage CatIndices(Func<CatIndicesParameters, CatIndicesParameters> options)
        {
            string uri = "/_cat/indices";
            CatIndicesParameters parameters = options.Invoke(new CatIndicesParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-indices.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        private async Task<HttpResponseMessage> CatIndicesAsync(Func<CatIndicesParameters, CatIndicesParameters> options)
        {
            string uri = "/_cat/indices";
            CatIndicesParameters parameters = options.Invoke(new CatIndicesParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-indices.html"/></summary>
        /// <param name="index">A comma-separated list of index names to limit the returned information</param>
        private HttpResponseMessage CatIndices(string index)
        {
            string uri = string.Format("/_cat/indices/{0}", index);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-indices.html"/></summary>
        /// <param name="index">A comma-separated list of index names to limit the returned information</param>
        private async Task<HttpResponseMessage> CatIndicesAsync(string index)
        {
            string uri = string.Format("/_cat/indices/{0}", index);
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-indices.html"/></summary>
        /// <param name="index">A comma-separated list of index names to limit the returned information</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private HttpResponseMessage CatIndices(string index, Func<CatIndicesParameters, CatIndicesParameters> options)
        {
            string uri = string.Format("/_cat/indices/{0}", index);
            CatIndicesParameters parameters = options.Invoke(new CatIndicesParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-indices.html"/></summary>
        /// <param name="index">A comma-separated list of index names to limit the returned information</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private async Task<HttpResponseMessage> CatIndicesAsync(string index, Func<CatIndicesParameters, CatIndicesParameters> options)
        {
            string uri = string.Format("/_cat/indices/{0}", index);
            CatIndicesParameters parameters = options.Invoke(new CatIndicesParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("GET", uri);
        }
    }
}
