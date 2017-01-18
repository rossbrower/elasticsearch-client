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
        public HttpResponseMessage ClusterGetSettings(Func<ClusterGetSettingsParameters, ClusterGetSettingsParameters> options = null)
        {
            var uri = "/_cluster/settings";
            if (options != null)
            {
                uri = options.Invoke(new ClusterGetSettingsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/cluster-update-settings.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClusterGetSettingsAsync(Func<ClusterGetSettingsParameters, ClusterGetSettingsParameters> options = null)
        {
            var uri = "/_cluster/settings";
            if (options != null)
            {
                uri = options.Invoke(new ClusterGetSettingsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}