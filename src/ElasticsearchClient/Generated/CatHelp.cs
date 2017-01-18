using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cat.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CatHelp(Func<CatHelpParameters, CatHelpParameters> options = null)
        {
            var uri = "/_cat";
            if (options != null)
            {
                uri = options.Invoke(new CatHelpParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cat.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatHelpAsync(Func<CatHelpParameters, CatHelpParameters> options = null)
        {
            var uri = "/_cat";
            if (options != null)
            {
                uri = options.Invoke(new CatHelpParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}