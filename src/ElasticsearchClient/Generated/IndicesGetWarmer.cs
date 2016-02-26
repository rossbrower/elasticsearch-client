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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html"/></summary>
        private HttpResponseMessage IndicesGetWarmer()
        {
            string uri = "/_warmer";
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html"/></summary>
        private async Task<HttpResponseMessage> IndicesGetWarmerAsync()
        {
            string uri = "/_warmer";
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        private HttpResponseMessage IndicesGetWarmer(Func<IndicesGetWarmerParameters, IndicesGetWarmerParameters> options)
        {
            string uri = "/_warmer";
            IndicesGetWarmerParameters parameters = options.Invoke(new IndicesGetWarmerParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        private async Task<HttpResponseMessage> IndicesGetWarmerAsync(Func<IndicesGetWarmerParameters, IndicesGetWarmerParameters> options)
        {
            string uri = "/_warmer";
            IndicesGetWarmerParameters parameters = options.Invoke(new IndicesGetWarmerParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html"/></summary>
        /// <param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
        private HttpResponseMessage IndicesGetWarmer(string index)
        {
            string uri = string.Format("/{0}/_warmer", index);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html"/></summary>
        /// <param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
        private async Task<HttpResponseMessage> IndicesGetWarmerAsync(string index)
        {
            string uri = string.Format("/{0}/_warmer", index);
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html"/></summary>
        /// <param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private HttpResponseMessage IndicesGetWarmer(string index, Func<IndicesGetWarmerParameters, IndicesGetWarmerParameters> options)
        {
            string uri = string.Format("/{0}/_warmer", index);
            IndicesGetWarmerParameters parameters = options.Invoke(new IndicesGetWarmerParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html"/></summary>
        /// <param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private async Task<HttpResponseMessage> IndicesGetWarmerAsync(string index, Func<IndicesGetWarmerParameters, IndicesGetWarmerParameters> options)
        {
            string uri = string.Format("/{0}/_warmer", index);
            IndicesGetWarmerParameters parameters = options.Invoke(new IndicesGetWarmerParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html"/></summary>
        /// <param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
        /// <param name="name">The name of the warmer (supports wildcards); leave empty to get all warmers</param>
        private HttpResponseMessage IndicesGetWarmer(string index, string name)
        {
            string uri = string.Format("/{0}/_warmer/{1}", index, name);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html"/></summary>
        /// <param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
        /// <param name="name">The name of the warmer (supports wildcards); leave empty to get all warmers</param>
        private async Task<HttpResponseMessage> IndicesGetWarmerAsync(string index, string name)
        {
            string uri = string.Format("/{0}/_warmer/{1}", index, name);
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html"/></summary>
        /// <param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
        /// <param name="name">The name of the warmer (supports wildcards); leave empty to get all warmers</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private HttpResponseMessage IndicesGetWarmer(string index, string name, Func<IndicesGetWarmerParameters, IndicesGetWarmerParameters> options)
        {
            string uri = string.Format("/{0}/_warmer/{1}", index, name);
            IndicesGetWarmerParameters parameters = options.Invoke(new IndicesGetWarmerParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html"/></summary>
        /// <param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
        /// <param name="name">The name of the warmer (supports wildcards); leave empty to get all warmers</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private async Task<HttpResponseMessage> IndicesGetWarmerAsync(string index, string name, Func<IndicesGetWarmerParameters, IndicesGetWarmerParameters> options)
        {
            string uri = string.Format("/{0}/_warmer/{1}", index, name);
            IndicesGetWarmerParameters parameters = options.Invoke(new IndicesGetWarmerParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html"/></summary>
        /// <param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
        /// <param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
        /// <param name="name">The name of the warmer (supports wildcards); leave empty to get all warmers</param>
        private HttpResponseMessage IndicesGetWarmer(string index, string type, string name)
        {
            string uri = string.Format("/{0}/{1}/_warmer/{2}", index, type, name);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html"/></summary>
        /// <param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
        /// <param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
        /// <param name="name">The name of the warmer (supports wildcards); leave empty to get all warmers</param>
        private async Task<HttpResponseMessage> IndicesGetWarmerAsync(string index, string type, string name)
        {
            string uri = string.Format("/{0}/{1}/_warmer/{2}", index, type, name);
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html"/></summary>
        /// <param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
        /// <param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
        /// <param name="name">The name of the warmer (supports wildcards); leave empty to get all warmers</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private HttpResponseMessage IndicesGetWarmer(string index, string type, string name, Func<IndicesGetWarmerParameters, IndicesGetWarmerParameters> options)
        {
            string uri = string.Format("/{0}/{1}/_warmer/{2}", index, type, name);
            IndicesGetWarmerParameters parameters = options.Invoke(new IndicesGetWarmerParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html"/></summary>
        /// <param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
        /// <param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
        /// <param name="name">The name of the warmer (supports wildcards); leave empty to get all warmers</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private async Task<HttpResponseMessage> IndicesGetWarmerAsync(string index, string type, string name, Func<IndicesGetWarmerParameters, IndicesGetWarmerParameters> options)
        {
            string uri = string.Format("/{0}/{1}/_warmer/{2}", index, type, name);
            IndicesGetWarmerParameters parameters = options.Invoke(new IndicesGetWarmerParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("GET", uri);
        }
    }
}
