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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-delete-index.html"/></summary>
        /// <param name="index">A comma-separated list of indices to delete; use `_all` or `*` string to delete all indices</param>
        public virtual HttpResponseMessage IndicesDelete(string index)
        {
            string uri = string.Format("/{0}", index);
            return this.Execute("DELETE", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-delete-index.html"/></summary>
        /// <param name="index">A comma-separated list of indices to delete; use `_all` or `*` string to delete all indices</param>
        public virtual async Task<HttpResponseMessage> IndicesDeleteAsync(string index)
        {
            string uri = string.Format("/{0}", index);
            return await this.ExecuteAsync("DELETE", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-delete-index.html"/></summary>
        /// <param name="index">A comma-separated list of indices to delete; use `_all` or `*` string to delete all indices</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesDelete(string index, Func<IndicesDeleteParameters, IndicesDeleteParameters> options)
        {
            string uri = string.Format("/{0}", index);
            IndicesDeleteParameters parameters = options.Invoke(new IndicesDeleteParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("DELETE", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-delete-index.html"/></summary>
        /// <param name="index">A comma-separated list of indices to delete; use `_all` or `*` string to delete all indices</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesDeleteAsync(string index, Func<IndicesDeleteParameters, IndicesDeleteParameters> options)
        {
            string uri = string.Format("/{0}", index);
            IndicesDeleteParameters parameters = options.Invoke(new IndicesDeleteParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("DELETE", uri);
        }
    }
}
