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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/indices-open-close.html"/></summary>
        /// <param name="index">A comma separated list of indices to open</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesOpen(string index, Func<IndicesOpenParameters, IndicesOpenParameters> options = null)
        {
            string uri = string.Format("/{0}/_open", index);
            if ((options != null))
            {
                IndicesOpenParameters parameters = options.Invoke(new IndicesOpenParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/indices-open-close.html"/></summary>
        /// <param name="index">A comma separated list of indices to open</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesOpenAsync(string index, Func<IndicesOpenParameters, IndicesOpenParameters> options = null)
        {
            string uri = string.Format("/{0}/_open", index);
            if ((options != null))
            {
                IndicesOpenParameters parameters = options.Invoke(new IndicesOpenParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri);
        }
    }
}
