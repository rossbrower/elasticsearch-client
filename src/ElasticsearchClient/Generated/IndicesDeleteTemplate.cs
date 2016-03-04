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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-templates.html"/></summary>
        /// <param name="name">The name of the template</param>
        public virtual HttpResponseMessage IndicesDeleteTemplate(string name)
        {
            string uri = string.Format("/_template/{0}", name);
            return this.Execute("DELETE", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-templates.html"/></summary>
        /// <param name="name">The name of the template</param>
        public virtual async Task<HttpResponseMessage> IndicesDeleteTemplateAsync(string name)
        {
            string uri = string.Format("/_template/{0}", name);
            return await this.ExecuteAsync("DELETE", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-templates.html"/></summary>
        /// <param name="name">The name of the template</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesDeleteTemplate(string name, Func<IndicesDeleteTemplateParameters, IndicesDeleteTemplateParameters> options)
        {
            string uri = string.Format("/_template/{0}", name);
            IndicesDeleteTemplateParameters parameters = options.Invoke(new IndicesDeleteTemplateParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("DELETE", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-templates.html"/></summary>
        /// <param name="name">The name of the template</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesDeleteTemplateAsync(string name, Func<IndicesDeleteTemplateParameters, IndicesDeleteTemplateParameters> options)
        {
            string uri = string.Format("/_template/{0}", name);
            IndicesDeleteTemplateParameters parameters = options.Invoke(new IndicesDeleteTemplateParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("DELETE", uri);
        }
    }
}
