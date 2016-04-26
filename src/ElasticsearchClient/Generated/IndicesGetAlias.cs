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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesGetAlias(Func<IndicesGetAliasParameters, IndicesGetAliasParameters> options = null)
        {
            string uri = "/_alias";
            if ((options != null))
            {
                IndicesGetAliasParameters parameters = options.Invoke(new IndicesGetAliasParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesGetAliasAsync(Func<IndicesGetAliasParameters, IndicesGetAliasParameters> options = null)
        {
            string uri = "/_alias";
            if ((options != null))
            {
                IndicesGetAliasParameters parameters = options.Invoke(new IndicesGetAliasParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        /// <param name="name">A comma-separated list of alias names to return</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesGetAlias(string name, Func<IndicesGetAliasParameters, IndicesGetAliasParameters> options = null)
        {
            string uri = string.Format("/_alias/{0}", name);
            if ((options != null))
            {
                IndicesGetAliasParameters parameters = options.Invoke(new IndicesGetAliasParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        /// <param name="name">A comma-separated list of alias names to return</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesGetAliasAsync(string name, Func<IndicesGetAliasParameters, IndicesGetAliasParameters> options = null)
        {
            string uri = string.Format("/_alias/{0}", name);
            if ((options != null))
            {
                IndicesGetAliasParameters parameters = options.Invoke(new IndicesGetAliasParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        /// <param name="index">A comma-separated list of index names to filter aliases</param>
        /// <param name="name">A comma-separated list of alias names to return</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesGetAlias(string index, string name, Func<IndicesGetAliasParameters, IndicesGetAliasParameters> options = null)
        {
            string uri = string.Format("/{0}/_alias/{1}", index, name);
            if ((options != null))
            {
                IndicesGetAliasParameters parameters = options.Invoke(new IndicesGetAliasParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        /// <param name="index">A comma-separated list of index names to filter aliases</param>
        /// <param name="name">A comma-separated list of alias names to return</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesGetAliasAsync(string index, string name, Func<IndicesGetAliasParameters, IndicesGetAliasParameters> options = null)
        {
            string uri = string.Format("/{0}/_alias/{1}", index, name);
            if ((options != null))
            {
                IndicesGetAliasParameters parameters = options.Invoke(new IndicesGetAliasParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}
