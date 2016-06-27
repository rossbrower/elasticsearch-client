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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-template.html"/></summary>
        /// <param name="id">Template ID</param>
        public virtual HttpResponseMessage DeleteTemplate(string id)
        {
            string uri = string.Format("/_search/template/{0}", id);
            return mConnection.Execute("DELETE", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-template.html"/></summary>
        /// <param name="id">Template ID</param>
        public virtual async Task<HttpResponseMessage> DeleteTemplateAsync(string id)
        {
            string uri = string.Format("/_search/template/{0}", id);
            return await mConnection.ExecuteAsync("DELETE", uri);
        }
    }
}
