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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/search-shards.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage SearchShardsGet(Func<SearchShardsParameters, SearchShardsParameters> options = null)
        {
            string uri = "/_search_shards";
            if ((options != null))
            {
                SearchShardsParameters parameters = options.Invoke(new SearchShardsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/search-shards.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> SearchShardsGetAsync(Func<SearchShardsParameters, SearchShardsParameters> options = null)
        {
            string uri = "/_search_shards";
            if ((options != null))
            {
                SearchShardsParameters parameters = options.Invoke(new SearchShardsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/search-shards.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage SearchShardsPost(Func<SearchShardsParameters, SearchShardsParameters> options = null)
        {
            string uri = "/_search_shards";
            if ((options != null))
            {
                SearchShardsParameters parameters = options.Invoke(new SearchShardsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/search-shards.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> SearchShardsPostAsync(Func<SearchShardsParameters, SearchShardsParameters> options = null)
        {
            string uri = "/_search_shards";
            if ((options != null))
            {
                SearchShardsParameters parameters = options.Invoke(new SearchShardsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/search-shards.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage SearchShardsGet(string index, Func<SearchShardsParameters, SearchShardsParameters> options = null)
        {
            string uri = string.Format("/{0}/_search_shards", index);
            if ((options != null))
            {
                SearchShardsParameters parameters = options.Invoke(new SearchShardsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/search-shards.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> SearchShardsGetAsync(string index, Func<SearchShardsParameters, SearchShardsParameters> options = null)
        {
            string uri = string.Format("/{0}/_search_shards", index);
            if ((options != null))
            {
                SearchShardsParameters parameters = options.Invoke(new SearchShardsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/search-shards.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage SearchShardsPost(string index, Func<SearchShardsParameters, SearchShardsParameters> options = null)
        {
            string uri = string.Format("/{0}/_search_shards", index);
            if ((options != null))
            {
                SearchShardsParameters parameters = options.Invoke(new SearchShardsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/search-shards.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> SearchShardsPostAsync(string index, Func<SearchShardsParameters, SearchShardsParameters> options = null)
        {
            string uri = string.Format("/{0}/_search_shards", index);
            if ((options != null))
            {
                SearchShardsParameters parameters = options.Invoke(new SearchShardsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/search-shards.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage SearchShardsGet(string index, string type, Func<SearchShardsParameters, SearchShardsParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_search_shards", index, type);
            if ((options != null))
            {
                SearchShardsParameters parameters = options.Invoke(new SearchShardsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/search-shards.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> SearchShardsGetAsync(string index, string type, Func<SearchShardsParameters, SearchShardsParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_search_shards", index, type);
            if ((options != null))
            {
                SearchShardsParameters parameters = options.Invoke(new SearchShardsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/search-shards.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage SearchShardsPost(string index, string type, Func<SearchShardsParameters, SearchShardsParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_search_shards", index, type);
            if ((options != null))
            {
                SearchShardsParameters parameters = options.Invoke(new SearchShardsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/search-shards.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> SearchShardsPostAsync(string index, string type, Func<SearchShardsParameters, SearchShardsParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_search_shards", index, type);
            if ((options != null))
            {
                SearchShardsParameters parameters = options.Invoke(new SearchShardsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri);
        }
    }
}
