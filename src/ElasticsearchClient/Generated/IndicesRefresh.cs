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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/indices-refresh.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesRefreshPost(Func<IndicesRefreshParameters, IndicesRefreshParameters> options = null)
        {
            string uri = "/_refresh";
            if ((options != null))
            {
                IndicesRefreshParameters parameters = options.Invoke(new IndicesRefreshParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/indices-refresh.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesRefreshPostAsync(Func<IndicesRefreshParameters, IndicesRefreshParameters> options = null)
        {
            string uri = "/_refresh";
            if ((options != null))
            {
                IndicesRefreshParameters parameters = options.Invoke(new IndicesRefreshParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/indices-refresh.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesRefreshGet(Func<IndicesRefreshParameters, IndicesRefreshParameters> options = null)
        {
            string uri = "/_refresh";
            if ((options != null))
            {
                IndicesRefreshParameters parameters = options.Invoke(new IndicesRefreshParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/indices-refresh.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesRefreshGetAsync(Func<IndicesRefreshParameters, IndicesRefreshParameters> options = null)
        {
            string uri = "/_refresh";
            if ((options != null))
            {
                IndicesRefreshParameters parameters = options.Invoke(new IndicesRefreshParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/indices-refresh.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesRefreshPost(string index, Func<IndicesRefreshParameters, IndicesRefreshParameters> options = null)
        {
            string uri = string.Format("/{0}/_refresh", index);
            if ((options != null))
            {
                IndicesRefreshParameters parameters = options.Invoke(new IndicesRefreshParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/indices-refresh.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesRefreshPostAsync(string index, Func<IndicesRefreshParameters, IndicesRefreshParameters> options = null)
        {
            string uri = string.Format("/{0}/_refresh", index);
            if ((options != null))
            {
                IndicesRefreshParameters parameters = options.Invoke(new IndicesRefreshParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/indices-refresh.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesRefreshGet(string index, Func<IndicesRefreshParameters, IndicesRefreshParameters> options = null)
        {
            string uri = string.Format("/{0}/_refresh", index);
            if ((options != null))
            {
                IndicesRefreshParameters parameters = options.Invoke(new IndicesRefreshParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/indices-refresh.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesRefreshGetAsync(string index, Func<IndicesRefreshParameters, IndicesRefreshParameters> options = null)
        {
            string uri = string.Format("/{0}/_refresh", index);
            if ((options != null))
            {
                IndicesRefreshParameters parameters = options.Invoke(new IndicesRefreshParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}
