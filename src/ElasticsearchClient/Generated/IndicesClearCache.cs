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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-clearcache.html"/></summary>
        private HttpResponseMessage IndicesClearCachePost()
        {
            string uri = "/_cache/clear";
            return this.Execute("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-clearcache.html"/></summary>
        private async Task<HttpResponseMessage> IndicesClearCachePostAsync()
        {
            string uri = "/_cache/clear";
            return await this.ExecuteAsync("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-clearcache.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        private HttpResponseMessage IndicesClearCachePost(Func<IndicesClearCacheParameters, IndicesClearCacheParameters> options)
        {
            string uri = "/_cache/clear";
            IndicesClearCacheParameters parameters = options.Invoke(new IndicesClearCacheParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-clearcache.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        private async Task<HttpResponseMessage> IndicesClearCachePostAsync(Func<IndicesClearCacheParameters, IndicesClearCacheParameters> options)
        {
            string uri = "/_cache/clear";
            IndicesClearCacheParameters parameters = options.Invoke(new IndicesClearCacheParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-clearcache.html"/></summary>
        private HttpResponseMessage IndicesClearCacheGet()
        {
            string uri = "/_cache/clear";
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-clearcache.html"/></summary>
        private async Task<HttpResponseMessage> IndicesClearCacheGetAsync()
        {
            string uri = "/_cache/clear";
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-clearcache.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        private HttpResponseMessage IndicesClearCacheGet(Func<IndicesClearCacheParameters, IndicesClearCacheParameters> options)
        {
            string uri = "/_cache/clear";
            IndicesClearCacheParameters parameters = options.Invoke(new IndicesClearCacheParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-clearcache.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        private async Task<HttpResponseMessage> IndicesClearCacheGetAsync(Func<IndicesClearCacheParameters, IndicesClearCacheParameters> options)
        {
            string uri = "/_cache/clear";
            IndicesClearCacheParameters parameters = options.Invoke(new IndicesClearCacheParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-clearcache.html"/></summary>
        /// <param name="index">A comma-separated list of index name to limit the operation</param>
        private HttpResponseMessage IndicesClearCachePost(string index)
        {
            string uri = string.Format("/{0}/_cache/clear", index);
            return this.Execute("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-clearcache.html"/></summary>
        /// <param name="index">A comma-separated list of index name to limit the operation</param>
        private async Task<HttpResponseMessage> IndicesClearCachePostAsync(string index)
        {
            string uri = string.Format("/{0}/_cache/clear", index);
            return await this.ExecuteAsync("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-clearcache.html"/></summary>
        /// <param name="index">A comma-separated list of index name to limit the operation</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private HttpResponseMessage IndicesClearCachePost(string index, Func<IndicesClearCacheParameters, IndicesClearCacheParameters> options)
        {
            string uri = string.Format("/{0}/_cache/clear", index);
            IndicesClearCacheParameters parameters = options.Invoke(new IndicesClearCacheParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-clearcache.html"/></summary>
        /// <param name="index">A comma-separated list of index name to limit the operation</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private async Task<HttpResponseMessage> IndicesClearCachePostAsync(string index, Func<IndicesClearCacheParameters, IndicesClearCacheParameters> options)
        {
            string uri = string.Format("/{0}/_cache/clear", index);
            IndicesClearCacheParameters parameters = options.Invoke(new IndicesClearCacheParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-clearcache.html"/></summary>
        /// <param name="index">A comma-separated list of index name to limit the operation</param>
        private HttpResponseMessage IndicesClearCacheGet(string index)
        {
            string uri = string.Format("/{0}/_cache/clear", index);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-clearcache.html"/></summary>
        /// <param name="index">A comma-separated list of index name to limit the operation</param>
        private async Task<HttpResponseMessage> IndicesClearCacheGetAsync(string index)
        {
            string uri = string.Format("/{0}/_cache/clear", index);
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-clearcache.html"/></summary>
        /// <param name="index">A comma-separated list of index name to limit the operation</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private HttpResponseMessage IndicesClearCacheGet(string index, Func<IndicesClearCacheParameters, IndicesClearCacheParameters> options)
        {
            string uri = string.Format("/{0}/_cache/clear", index);
            IndicesClearCacheParameters parameters = options.Invoke(new IndicesClearCacheParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-clearcache.html"/></summary>
        /// <param name="index">A comma-separated list of index name to limit the operation</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private async Task<HttpResponseMessage> IndicesClearCacheGetAsync(string index, Func<IndicesClearCacheParameters, IndicesClearCacheParameters> options)
        {
            string uri = string.Format("/{0}/_cache/clear", index);
            IndicesClearCacheParameters parameters = options.Invoke(new IndicesClearCacheParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("GET", uri);
        }
    }
}
