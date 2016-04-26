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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-index.html"/></summary>
        /// <param name="index">A comma-separated list of index names</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesGet(string index, Func<IndicesGetParameters, IndicesGetParameters> options = null)
        {
            string uri = string.Format("/{0}", index);
            if ((options != null))
            {
                IndicesGetParameters parameters = options.Invoke(new IndicesGetParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-index.html"/></summary>
        /// <param name="index">A comma-separated list of index names</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesGetAsync(string index, Func<IndicesGetParameters, IndicesGetParameters> options = null)
        {
            string uri = string.Format("/{0}", index);
            if ((options != null))
            {
                IndicesGetParameters parameters = options.Invoke(new IndicesGetParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-index.html"/></summary>
        /// <param name="index">A comma-separated list of index names</param>
        /// <param name="feature">A comma-separated list of features</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesGet(string index, string feature, Func<IndicesGetParameters, IndicesGetParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}", index, feature);
            if ((options != null))
            {
                IndicesGetParameters parameters = options.Invoke(new IndicesGetParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-index.html"/></summary>
        /// <param name="index">A comma-separated list of index names</param>
        /// <param name="feature">A comma-separated list of features</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesGetAsync(string index, string feature, Func<IndicesGetParameters, IndicesGetParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}", index, feature);
            if ((options != null))
            {
                IndicesGetParameters parameters = options.Invoke(new IndicesGetParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}
