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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-upgrade.html"/></summary>
        private HttpResponseMessage IndicesGetUpgrade()
        {
            string uri = "/_upgrade";
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-upgrade.html"/></summary>
        private async Task<HttpResponseMessage> IndicesGetUpgradeAsync()
        {
            string uri = "/_upgrade";
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-upgrade.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        private HttpResponseMessage IndicesGetUpgrade(string index)
        {
            string uri = string.Format("/{0}/_upgrade", index);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-upgrade.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        private async Task<HttpResponseMessage> IndicesGetUpgradeAsync(string index)
        {
            string uri = string.Format("/{0}/_upgrade", index);
            return await this.ExecuteAsync("GET", uri);
        }
    }
}
