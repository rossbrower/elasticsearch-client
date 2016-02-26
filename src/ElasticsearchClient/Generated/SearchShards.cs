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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html"/></summary>
        private HttpResponseMessage SearchShardsGet()
        {
            string uri = "/_search_shards";
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html"/></summary>
        private async Task<HttpResponseMessage> SearchShardsGetAsync()
        {
            string uri = "/_search_shards";
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        private HttpResponseMessage SearchShardsGet(Func<SearchShardsParameters, SearchShardsParameters> options)
        {
            string uri = "/_search_shards";
            SearchShardsParameters parameters = options.Invoke(new SearchShardsParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        private async Task<HttpResponseMessage> SearchShardsGetAsync(Func<SearchShardsParameters, SearchShardsParameters> options)
        {
            string uri = "/_search_shards";
            SearchShardsParameters parameters = options.Invoke(new SearchShardsParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html"/></summary>
        private HttpResponseMessage SearchShardsPost()
        {
            string uri = "/_search_shards";
            return this.Execute("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html"/></summary>
        private async Task<HttpResponseMessage> SearchShardsPostAsync()
        {
            string uri = "/_search_shards";
            return await this.ExecuteAsync("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        private HttpResponseMessage SearchShardsPost(Func<SearchShardsParameters, SearchShardsParameters> options)
        {
            string uri = "/_search_shards";
            SearchShardsParameters parameters = options.Invoke(new SearchShardsParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        private async Task<HttpResponseMessage> SearchShardsPostAsync(Func<SearchShardsParameters, SearchShardsParameters> options)
        {
            string uri = "/_search_shards";
            SearchShardsParameters parameters = options.Invoke(new SearchShardsParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        private HttpResponseMessage SearchShardsGet(string index)
        {
            string uri = string.Format("/{0}/_search_shards", index);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        private async Task<HttpResponseMessage> SearchShardsGetAsync(string index)
        {
            string uri = string.Format("/{0}/_search_shards", index);
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private HttpResponseMessage SearchShardsGet(string index, Func<SearchShardsParameters, SearchShardsParameters> options)
        {
            string uri = string.Format("/{0}/_search_shards", index);
            SearchShardsParameters parameters = options.Invoke(new SearchShardsParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private async Task<HttpResponseMessage> SearchShardsGetAsync(string index, Func<SearchShardsParameters, SearchShardsParameters> options)
        {
            string uri = string.Format("/{0}/_search_shards", index);
            SearchShardsParameters parameters = options.Invoke(new SearchShardsParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        private HttpResponseMessage SearchShardsPost(string index)
        {
            string uri = string.Format("/{0}/_search_shards", index);
            return this.Execute("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        private async Task<HttpResponseMessage> SearchShardsPostAsync(string index)
        {
            string uri = string.Format("/{0}/_search_shards", index);
            return await this.ExecuteAsync("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private HttpResponseMessage SearchShardsPost(string index, Func<SearchShardsParameters, SearchShardsParameters> options)
        {
            string uri = string.Format("/{0}/_search_shards", index);
            SearchShardsParameters parameters = options.Invoke(new SearchShardsParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private async Task<HttpResponseMessage> SearchShardsPostAsync(string index, Func<SearchShardsParameters, SearchShardsParameters> options)
        {
            string uri = string.Format("/{0}/_search_shards", index);
            SearchShardsParameters parameters = options.Invoke(new SearchShardsParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        private HttpResponseMessage SearchShardsGet(string index, string type)
        {
            string uri = string.Format("/{0}/{1}/_search_shards", index, type);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        private async Task<HttpResponseMessage> SearchShardsGetAsync(string index, string type)
        {
            string uri = string.Format("/{0}/{1}/_search_shards", index, type);
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private HttpResponseMessage SearchShardsGet(string index, string type, Func<SearchShardsParameters, SearchShardsParameters> options)
        {
            string uri = string.Format("/{0}/{1}/_search_shards", index, type);
            SearchShardsParameters parameters = options.Invoke(new SearchShardsParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private async Task<HttpResponseMessage> SearchShardsGetAsync(string index, string type, Func<SearchShardsParameters, SearchShardsParameters> options)
        {
            string uri = string.Format("/{0}/{1}/_search_shards", index, type);
            SearchShardsParameters parameters = options.Invoke(new SearchShardsParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        private HttpResponseMessage SearchShardsPost(string index, string type)
        {
            string uri = string.Format("/{0}/{1}/_search_shards", index, type);
            return this.Execute("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        private async Task<HttpResponseMessage> SearchShardsPostAsync(string index, string type)
        {
            string uri = string.Format("/{0}/{1}/_search_shards", index, type);
            return await this.ExecuteAsync("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private HttpResponseMessage SearchShardsPost(string index, string type, Func<SearchShardsParameters, SearchShardsParameters> options)
        {
            string uri = string.Format("/{0}/{1}/_search_shards", index, type);
            SearchShardsParameters parameters = options.Invoke(new SearchShardsParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-shards.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private async Task<HttpResponseMessage> SearchShardsPostAsync(string index, string type, Func<SearchShardsParameters, SearchShardsParameters> options)
        {
            string uri = string.Format("/{0}/{1}/_search_shards", index, type);
            SearchShardsParameters parameters = options.Invoke(new SearchShardsParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("POST", uri);
        }
    }
}
