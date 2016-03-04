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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-master.html"/></summary>
        public virtual HttpResponseMessage CatMaster()
        {
            string uri = "/_cat/master";
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-master.html"/></summary>
        public virtual async Task<HttpResponseMessage> CatMasterAsync()
        {
            string uri = "/_cat/master";
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-master.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage CatMaster(Func<CatMasterParameters, CatMasterParameters> options)
        {
            string uri = "/_cat/master";
            CatMasterParameters parameters = options.Invoke(new CatMasterParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-master.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> CatMasterAsync(Func<CatMasterParameters, CatMasterParameters> options)
        {
            string uri = "/_cat/master";
            CatMasterParameters parameters = options.Invoke(new CatMasterParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("GET", uri);
        }
    }
}
