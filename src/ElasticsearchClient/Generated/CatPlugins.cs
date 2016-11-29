using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cat-plugins.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CatPlugins(Func<CatPluginsParameters, CatPluginsParameters> options = null)
        {
            var uri = "/_cat/plugins";
            if (options != null)
            {
                uri = options.Invoke(new CatPluginsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cat-plugins.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatPluginsAsync(Func<CatPluginsParameters, CatPluginsParameters> options = null)
        {
            var uri = "/_cat/plugins";
            if (options != null)
            {
                uri = options.Invoke(new CatPluginsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}