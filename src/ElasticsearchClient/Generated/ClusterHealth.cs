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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-health.html"/></summary>
        private HttpResponseMessage ClusterHealth()
        {
            string uri = "/_cluster/health";
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-health.html"/></summary>
        private async Task<HttpResponseMessage> ClusterHealthAsync()
        {
            string uri = "/_cluster/health";
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-health.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        private HttpResponseMessage ClusterHealth(Func<ClusterHealthParameters, ClusterHealthParameters> options)
        {
            string uri = "/_cluster/health";
            ClusterHealthParameters parameters = options.Invoke(new ClusterHealthParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-health.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        private async Task<HttpResponseMessage> ClusterHealthAsync(Func<ClusterHealthParameters, ClusterHealthParameters> options)
        {
            string uri = "/_cluster/health";
            ClusterHealthParameters parameters = options.Invoke(new ClusterHealthParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-health.html"/></summary>
        /// <param name="index">Limit the information returned to a specific index</param>
        private HttpResponseMessage ClusterHealth(string index)
        {
            string uri = string.Format("/_cluster/health/{0}", index);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-health.html"/></summary>
        /// <param name="index">Limit the information returned to a specific index</param>
        private async Task<HttpResponseMessage> ClusterHealthAsync(string index)
        {
            string uri = string.Format("/_cluster/health/{0}", index);
            return await this.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-health.html"/></summary>
        /// <param name="index">Limit the information returned to a specific index</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private HttpResponseMessage ClusterHealth(string index, Func<ClusterHealthParameters, ClusterHealthParameters> options)
        {
            string uri = string.Format("/_cluster/health/{0}", index);
            ClusterHealthParameters parameters = options.Invoke(new ClusterHealthParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-health.html"/></summary>
        /// <param name="index">Limit the information returned to a specific index</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private async Task<HttpResponseMessage> ClusterHealthAsync(string index, Func<ClusterHealthParameters, ClusterHealthParameters> options)
        {
            string uri = string.Format("/_cluster/health/{0}", index);
            ClusterHealthParameters parameters = options.Invoke(new ClusterHealthParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("GET", uri);
        }
    }
}
