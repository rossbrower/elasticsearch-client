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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-recovery.html"/></summary>
        public virtual HttpResponseMessage IndicesRecovery()
        {
            string uri = "/_recovery";
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-recovery.html"/></summary>
        public virtual async Task<HttpResponseMessage> IndicesRecoveryAsync()
        {
            string uri = "/_recovery";
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-recovery.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesRecovery(Func<IndicesRecoveryParameters, IndicesRecoveryParameters> options)
        {
            string uri = "/_recovery";
            IndicesRecoveryParameters parameters = options.Invoke(new IndicesRecoveryParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-recovery.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesRecoveryAsync(Func<IndicesRecoveryParameters, IndicesRecoveryParameters> options)
        {
            string uri = "/_recovery";
            IndicesRecoveryParameters parameters = options.Invoke(new IndicesRecoveryParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-recovery.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        public virtual HttpResponseMessage IndicesRecovery(string index)
        {
            string uri = string.Format("/{0}/_recovery", index);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-recovery.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        public virtual async Task<HttpResponseMessage> IndicesRecoveryAsync(string index)
        {
            string uri = string.Format("/{0}/_recovery", index);
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-recovery.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesRecovery(string index, Func<IndicesRecoveryParameters, IndicesRecoveryParameters> options)
        {
            string uri = string.Format("/{0}/_recovery", index);
            IndicesRecoveryParameters parameters = options.Invoke(new IndicesRecoveryParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-recovery.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesRecoveryAsync(string index, Func<IndicesRecoveryParameters, IndicesRecoveryParameters> options)
        {
            string uri = string.Format("/{0}/_recovery", index);
            IndicesRecoveryParameters parameters = options.Invoke(new IndicesRecoveryParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("GET", uri);
        }
    }
}
