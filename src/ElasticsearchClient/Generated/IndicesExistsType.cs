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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-types-exists.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` to check the types across all indices</param>
        /// <param name="type">A comma-separated list of document types to check</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesExistsType(string index, string type, Func<IndicesExistsTypeParameters, IndicesExistsTypeParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}", index, type);
            if ((options != null))
            {
                IndicesExistsTypeParameters parameters = options.Invoke(new IndicesExistsTypeParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("HEAD", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-types-exists.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` to check the types across all indices</param>
        /// <param name="type">A comma-separated list of document types to check</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesExistsTypeAsync(string index, string type, Func<IndicesExistsTypeParameters, IndicesExistsTypeParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}", index, type);
            if ((options != null))
            {
                IndicesExistsTypeParameters parameters = options.Invoke(new IndicesExistsTypeParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("HEAD", uri);
        }
    }
}
