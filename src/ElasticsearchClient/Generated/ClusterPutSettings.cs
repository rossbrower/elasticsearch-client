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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/cluster-update-settings.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage ClusterPutSettings(Func<ClusterPutSettingsParameters, ClusterPutSettingsParameters> options = null)
        {
            string uri = "/_cluster/settings";
            if ((options != null))
            {
                ClusterPutSettingsParameters parameters = options.Invoke(new ClusterPutSettingsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("PUT", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/cluster-update-settings.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> ClusterPutSettingsAsync(Func<ClusterPutSettingsParameters, ClusterPutSettingsParameters> options = null)
        {
            string uri = "/_cluster/settings";
            if ((options != null))
            {
                ClusterPutSettingsParameters parameters = options.Invoke(new ClusterPutSettingsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("PUT", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/cluster-update-settings.html"/></summary>
        /// <param name="body">The settings to be updated. Can be either `transient` or `persistent` (survives cluster restart).</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage ClusterPutSettings(Stream body, Func<ClusterPutSettingsParameters, ClusterPutSettingsParameters> options = null)
        {
            string uri = "/_cluster/settings";
            if ((options != null))
            {
                ClusterPutSettingsParameters parameters = options.Invoke(new ClusterPutSettingsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/cluster-update-settings.html"/></summary>
        /// <param name="body">The settings to be updated. Can be either `transient` or `persistent` (survives cluster restart).</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> ClusterPutSettingsAsync(Stream body, Func<ClusterPutSettingsParameters, ClusterPutSettingsParameters> options = null)
        {
            string uri = "/_cluster/settings";
            if ((options != null))
            {
                ClusterPutSettingsParameters parameters = options.Invoke(new ClusterPutSettingsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/cluster-update-settings.html"/></summary>
        /// <param name="body">The settings to be updated. Can be either `transient` or `persistent` (survives cluster restart).</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage ClusterPutSettings(Byte[] body, Func<ClusterPutSettingsParameters, ClusterPutSettingsParameters> options = null)
        {
            string uri = "/_cluster/settings";
            if ((options != null))
            {
                ClusterPutSettingsParameters parameters = options.Invoke(new ClusterPutSettingsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/cluster-update-settings.html"/></summary>
        /// <param name="body">The settings to be updated. Can be either `transient` or `persistent` (survives cluster restart).</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> ClusterPutSettingsAsync(Byte[] body, Func<ClusterPutSettingsParameters, ClusterPutSettingsParameters> options = null)
        {
            string uri = "/_cluster/settings";
            if ((options != null))
            {
                ClusterPutSettingsParameters parameters = options.Invoke(new ClusterPutSettingsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/cluster-update-settings.html"/></summary>
        /// <param name="body">The settings to be updated. Can be either `transient` or `persistent` (survives cluster restart).</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage ClusterPutSettingsString(string body, Func<ClusterPutSettingsParameters, ClusterPutSettingsParameters> options = null)
        {
            string uri = "/_cluster/settings";
            if ((options != null))
            {
                ClusterPutSettingsParameters parameters = options.Invoke(new ClusterPutSettingsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/cluster-update-settings.html"/></summary>
        /// <param name="body">The settings to be updated. Can be either `transient` or `persistent` (survives cluster restart).</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> ClusterPutSettingsStringAsync(string body, Func<ClusterPutSettingsParameters, ClusterPutSettingsParameters> options = null)
        {
            string uri = "/_cluster/settings";
            if ((options != null))
            {
                ClusterPutSettingsParameters parameters = options.Invoke(new ClusterPutSettingsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("PUT", uri, body);
        }
    }
}
