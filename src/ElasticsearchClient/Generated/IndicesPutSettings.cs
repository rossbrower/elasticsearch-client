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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-update-settings.html"/></summary>
        /// <param name="body">The index settings to be updated</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesPutSettings(Stream body, Func<IndicesPutSettingsParameters, IndicesPutSettingsParameters> options = null)
        {
            string uri = "/_settings";
            if ((options != null))
            {
                IndicesPutSettingsParameters parameters = options.Invoke(new IndicesPutSettingsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-update-settings.html"/></summary>
        /// <param name="body">The index settings to be updated</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesPutSettingsAsync(Stream body, Func<IndicesPutSettingsParameters, IndicesPutSettingsParameters> options = null)
        {
            string uri = "/_settings";
            if ((options != null))
            {
                IndicesPutSettingsParameters parameters = options.Invoke(new IndicesPutSettingsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-update-settings.html"/></summary>
        /// <param name="body">The index settings to be updated</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesPutSettings(Byte[] body, Func<IndicesPutSettingsParameters, IndicesPutSettingsParameters> options = null)
        {
            string uri = "/_settings";
            if ((options != null))
            {
                IndicesPutSettingsParameters parameters = options.Invoke(new IndicesPutSettingsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-update-settings.html"/></summary>
        /// <param name="body">The index settings to be updated</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesPutSettingsAsync(Byte[] body, Func<IndicesPutSettingsParameters, IndicesPutSettingsParameters> options = null)
        {
            string uri = "/_settings";
            if ((options != null))
            {
                IndicesPutSettingsParameters parameters = options.Invoke(new IndicesPutSettingsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-update-settings.html"/></summary>
        /// <param name="body">The index settings to be updated</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesPutSettingsString(string body, Func<IndicesPutSettingsParameters, IndicesPutSettingsParameters> options = null)
        {
            string uri = "/_settings";
            if ((options != null))
            {
                IndicesPutSettingsParameters parameters = options.Invoke(new IndicesPutSettingsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-update-settings.html"/></summary>
        /// <param name="body">The index settings to be updated</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesPutSettingsStringAsync(string body, Func<IndicesPutSettingsParameters, IndicesPutSettingsParameters> options = null)
        {
            string uri = "/_settings";
            if ((options != null))
            {
                IndicesPutSettingsParameters parameters = options.Invoke(new IndicesPutSettingsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-update-settings.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="body">The index settings to be updated</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesPutSettings(string index, Stream body, Func<IndicesPutSettingsParameters, IndicesPutSettingsParameters> options = null)
        {
            string uri = string.Format("/{0}/_settings", index);
            if ((options != null))
            {
                IndicesPutSettingsParameters parameters = options.Invoke(new IndicesPutSettingsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-update-settings.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="body">The index settings to be updated</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesPutSettingsAsync(string index, Stream body, Func<IndicesPutSettingsParameters, IndicesPutSettingsParameters> options = null)
        {
            string uri = string.Format("/{0}/_settings", index);
            if ((options != null))
            {
                IndicesPutSettingsParameters parameters = options.Invoke(new IndicesPutSettingsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-update-settings.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="body">The index settings to be updated</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesPutSettings(string index, Byte[] body, Func<IndicesPutSettingsParameters, IndicesPutSettingsParameters> options = null)
        {
            string uri = string.Format("/{0}/_settings", index);
            if ((options != null))
            {
                IndicesPutSettingsParameters parameters = options.Invoke(new IndicesPutSettingsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-update-settings.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="body">The index settings to be updated</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesPutSettingsAsync(string index, Byte[] body, Func<IndicesPutSettingsParameters, IndicesPutSettingsParameters> options = null)
        {
            string uri = string.Format("/{0}/_settings", index);
            if ((options != null))
            {
                IndicesPutSettingsParameters parameters = options.Invoke(new IndicesPutSettingsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-update-settings.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="body">The index settings to be updated</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndicesPutSettingsString(string index, string body, Func<IndicesPutSettingsParameters, IndicesPutSettingsParameters> options = null)
        {
            string uri = string.Format("/{0}/_settings", index);
            if ((options != null))
            {
                IndicesPutSettingsParameters parameters = options.Invoke(new IndicesPutSettingsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-update-settings.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="body">The index settings to be updated</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndicesPutSettingsStringAsync(string index, string body, Func<IndicesPutSettingsParameters, IndicesPutSettingsParameters> options = null)
        {
            string uri = string.Format("/{0}/_settings", index);
            if ((options != null))
            {
                IndicesPutSettingsParameters parameters = options.Invoke(new IndicesPutSettingsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("PUT", uri, body);
        }
    }
}
