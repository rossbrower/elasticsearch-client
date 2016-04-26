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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-alias.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage CatAliases(Func<CatAliasesParameters, CatAliasesParameters> options = null)
        {
            string uri = "/_cat/aliases";
            if ((options != null))
            {
                CatAliasesParameters parameters = options.Invoke(new CatAliasesParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-alias.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> CatAliasesAsync(Func<CatAliasesParameters, CatAliasesParameters> options = null)
        {
            string uri = "/_cat/aliases";
            if ((options != null))
            {
                CatAliasesParameters parameters = options.Invoke(new CatAliasesParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-alias.html"/></summary>
        /// <param name="name">A comma-separated list of alias names to return</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage CatAliases(string name, Func<CatAliasesParameters, CatAliasesParameters> options = null)
        {
            string uri = string.Format("/_cat/aliases/{0}", name);
            if ((options != null))
            {
                CatAliasesParameters parameters = options.Invoke(new CatAliasesParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-alias.html"/></summary>
        /// <param name="name">A comma-separated list of alias names to return</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> CatAliasesAsync(string name, Func<CatAliasesParameters, CatAliasesParameters> options = null)
        {
            string uri = string.Format("/_cat/aliases/{0}", name);
            if ((options != null))
            {
                CatAliasesParameters parameters = options.Invoke(new CatAliasesParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}
