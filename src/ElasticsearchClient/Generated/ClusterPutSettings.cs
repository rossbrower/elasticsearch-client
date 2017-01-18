using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/cluster-update-settings.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClusterPutSettings(Func<ClusterPutSettingsParameters, ClusterPutSettingsParameters> options = null)
        {
            var uri = "/_cluster/settings";
            if (options != null)
            {
                uri = options.Invoke(new ClusterPutSettingsParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/cluster-update-settings.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClusterPutSettingsAsync(Func<ClusterPutSettingsParameters, ClusterPutSettingsParameters> options = null)
        {
            var uri = "/_cluster/settings";
            if (options != null)
            {
                uri = options.Invoke(new ClusterPutSettingsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/cluster-update-settings.html"/></summary>
        ///<param name="body">The settings to be updated. Can be either `transient` or `persistent` (survives cluster restart).</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClusterPutSettings(Stream body, Func<ClusterPutSettingsParameters, ClusterPutSettingsParameters> options = null)
        {
            var uri = "/_cluster/settings";
            if (options != null)
            {
                uri = options.Invoke(new ClusterPutSettingsParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/cluster-update-settings.html"/></summary>
        ///<param name="body">The settings to be updated. Can be either `transient` or `persistent` (survives cluster restart).</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClusterPutSettingsAsync(Stream body, Func<ClusterPutSettingsParameters, ClusterPutSettingsParameters> options = null)
        {
            var uri = "/_cluster/settings";
            if (options != null)
            {
                uri = options.Invoke(new ClusterPutSettingsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/cluster-update-settings.html"/></summary>
        ///<param name="body">The settings to be updated. Can be either `transient` or `persistent` (survives cluster restart).</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClusterPutSettings(byte[] body, Func<ClusterPutSettingsParameters, ClusterPutSettingsParameters> options = null)
        {
            var uri = "/_cluster/settings";
            if (options != null)
            {
                uri = options.Invoke(new ClusterPutSettingsParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/cluster-update-settings.html"/></summary>
        ///<param name="body">The settings to be updated. Can be either `transient` or `persistent` (survives cluster restart).</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClusterPutSettingsAsync(byte[] body, Func<ClusterPutSettingsParameters, ClusterPutSettingsParameters> options = null)
        {
            var uri = "/_cluster/settings";
            if (options != null)
            {
                uri = options.Invoke(new ClusterPutSettingsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/cluster-update-settings.html"/></summary>
        ///<param name="body">The settings to be updated. Can be either `transient` or `persistent` (survives cluster restart).</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClusterPutSettingsString(string body, Func<ClusterPutSettingsParameters, ClusterPutSettingsParameters> options = null)
        {
            var uri = "/_cluster/settings";
            if (options != null)
            {
                uri = options.Invoke(new ClusterPutSettingsParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/cluster-update-settings.html"/></summary>
        ///<param name="body">The settings to be updated. Can be either `transient` or `persistent` (survives cluster restart).</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClusterPutSettingsStringAsync(string body, Func<ClusterPutSettingsParameters, ClusterPutSettingsParameters> options = null)
        {
            var uri = "/_cluster/settings";
            if (options != null)
            {
                uri = options.Invoke(new ClusterPutSettingsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }
    }
}