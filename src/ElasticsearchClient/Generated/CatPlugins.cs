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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-plugins.html"/></summary>
        private HttpResponseMessage CatPlugins()
        {
            string uri = "/_cat/plugins";
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-plugins.html"/></summary>
        private async Task<HttpResponseMessage> CatPluginsAsync()
        {
            string uri = "/_cat/plugins";
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-plugins.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        private HttpResponseMessage CatPlugins(Func<CatPluginsParameters, CatPluginsParameters> options)
        {
            string uri = "/_cat/plugins";
            CatPluginsParameters parameters = options.Invoke(new CatPluginsParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-plugins.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        private async Task<HttpResponseMessage> CatPluginsAsync(Func<CatPluginsParameters, CatPluginsParameters> options)
        {
            string uri = "/_cat/plugins";
            CatPluginsParameters parameters = options.Invoke(new CatPluginsParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("GET", uri);
        }
    }
}
