using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-repositories.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CatRepositories(Func<CatRepositoriesParameters, CatRepositoriesParameters> options = null)
        {
            var uri = "/_cat/repositories";
            if (options != null)
            {
                uri = options.Invoke(new CatRepositoriesParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-repositories.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatRepositoriesAsync(Func<CatRepositoriesParameters, CatRepositoriesParameters> options = null)
        {
            var uri = "/_cat/repositories";
            if (options != null)
            {
                uri = options.Invoke(new CatRepositoriesParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}