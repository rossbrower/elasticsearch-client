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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-nodes.html"/></summary>
        private HttpResponseMessage CatNodes()
        {
            string uri = "/_cat/nodes";
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-nodes.html"/></summary>
        private async Task<HttpResponseMessage> CatNodesAsync()
        {
            string uri = "/_cat/nodes";
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-nodes.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        private HttpResponseMessage CatNodes(Func<CatNodesParameters, CatNodesParameters> options)
        {
            string uri = "/_cat/nodes";
            CatNodesParameters parameters = options.Invoke(new CatNodesParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-nodes.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        private async Task<HttpResponseMessage> CatNodesAsync(Func<CatNodesParameters, CatNodesParameters> options)
        {
            string uri = "/_cat/nodes";
            CatNodesParameters parameters = options.Invoke(new CatNodesParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("GET", uri);
        }
    }
}
