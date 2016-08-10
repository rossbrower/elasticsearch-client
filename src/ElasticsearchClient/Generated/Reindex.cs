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
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-reindex.html"/></summary>
        /// <param name="body">The search definition using the Query DSL and the prototype for the index request.</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage Reindex(Stream body, Func<ReindexParameters, ReindexParameters> options = null)
        {
            string uri = "/_reindex";
            if ((options != null))
            {
                ReindexParameters parameters = options.Invoke(new ReindexParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-reindex.html"/></summary>
        /// <param name="body">The search definition using the Query DSL and the prototype for the index request.</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> ReindexAsync(Stream body, Func<ReindexParameters, ReindexParameters> options = null)
        {
            string uri = "/_reindex";
            if ((options != null))
            {
                ReindexParameters parameters = options.Invoke(new ReindexParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-reindex.html"/></summary>
        /// <param name="body">The search definition using the Query DSL and the prototype for the index request.</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage Reindex(Byte[] body, Func<ReindexParameters, ReindexParameters> options = null)
        {
            string uri = "/_reindex";
            if ((options != null))
            {
                ReindexParameters parameters = options.Invoke(new ReindexParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-reindex.html"/></summary>
        /// <param name="body">The search definition using the Query DSL and the prototype for the index request.</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> ReindexAsync(Byte[] body, Func<ReindexParameters, ReindexParameters> options = null)
        {
            string uri = "/_reindex";
            if ((options != null))
            {
                ReindexParameters parameters = options.Invoke(new ReindexParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-reindex.html"/></summary>
        /// <param name="body">The search definition using the Query DSL and the prototype for the index request.</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage ReindexString(string body, Func<ReindexParameters, ReindexParameters> options = null)
        {
            string uri = "/_reindex";
            if ((options != null))
            {
                ReindexParameters parameters = options.Invoke(new ReindexParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-reindex.html"/></summary>
        /// <param name="body">The search definition using the Query DSL and the prototype for the index request.</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> ReindexStringAsync(string body, Func<ReindexParameters, ReindexParameters> options = null)
        {
            string uri = "/_reindex";
            if ((options != null))
            {
                ReindexParameters parameters = options.Invoke(new ReindexParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}
