using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cat-master.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CatMaster(Func<CatMasterParameters, CatMasterParameters> options = null)
        {
            var uri = "/_cat/master";
            if (options != null)
            {
                uri = options.Invoke(new CatMasterParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cat-master.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatMasterAsync(Func<CatMasterParameters, CatMasterParameters> options = null)
        {
            var uri = "/_cat/master";
            if (options != null)
            {
                uri = options.Invoke(new CatMasterParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}