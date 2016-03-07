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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-settings.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesGetSettings(Func<IndicesGetSettingsParameters, IndicesGetSettingsParameters> options = null)
        {
            string uri = "/_settings";
            if ((options != null))
            {
                IndicesGetSettingsParameters parameters = options.Invoke(new IndicesGetSettingsParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-settings.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesGetSettingsAsync(Func<IndicesGetSettingsParameters, IndicesGetSettingsParameters> options = null)
        {
            string uri = "/_settings";
            if ((options != null))
            {
                IndicesGetSettingsParameters parameters = options.Invoke(new IndicesGetSettingsParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-settings.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesGetSettings(string index, Func<IndicesGetSettingsParameters, IndicesGetSettingsParameters> options = null)
        {
            string uri = string.Format("/{0}/_settings", index);
            if ((options != null))
            {
                IndicesGetSettingsParameters parameters = options.Invoke(new IndicesGetSettingsParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-settings.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesGetSettingsAsync(string index, Func<IndicesGetSettingsParameters, IndicesGetSettingsParameters> options = null)
        {
            string uri = string.Format("/{0}/_settings", index);
            if ((options != null))
            {
                IndicesGetSettingsParameters parameters = options.Invoke(new IndicesGetSettingsParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-settings.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="name">The name of the settings that should be included</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesGetSettings(string index, string name, Func<IndicesGetSettingsParameters, IndicesGetSettingsParameters> options = null)
        {
            string uri = string.Format("/{0}/_settings/{1}", index, name);
            if ((options != null))
            {
                IndicesGetSettingsParameters parameters = options.Invoke(new IndicesGetSettingsParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-settings.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="name">The name of the settings that should be included</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesGetSettingsAsync(string index, string name, Func<IndicesGetSettingsParameters, IndicesGetSettingsParameters> options = null)
        {
            string uri = string.Format("/{0}/_settings/{1}", index, name);
            if ((options != null))
            {
                IndicesGetSettingsParameters parameters = options.Invoke(new IndicesGetSettingsParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("GET", uri);
        }
    }
}
