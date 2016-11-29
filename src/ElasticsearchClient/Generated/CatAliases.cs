using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cat-alias.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CatAliases(Func<CatAliasesParameters, CatAliasesParameters> options = null)
        {
            var uri = "/_cat/aliases";
            if (options != null)
            {
                uri = options.Invoke(new CatAliasesParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cat-alias.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatAliasesAsync(Func<CatAliasesParameters, CatAliasesParameters> options = null)
        {
            var uri = "/_cat/aliases";
            if (options != null)
            {
                uri = options.Invoke(new CatAliasesParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cat-alias.html"/></summary>
        ///<param name="name">A comma-separated list of alias names to return</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CatAliases(string name, Func<CatAliasesParameters, CatAliasesParameters> options = null)
        {
            var uri = string.Format("/_cat/aliases/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new CatAliasesParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cat-alias.html"/></summary>
        ///<param name="name">A comma-separated list of alias names to return</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatAliasesAsync(string name, Func<CatAliasesParameters, CatAliasesParameters> options = null)
        {
            var uri = string.Format("/_cat/aliases/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new CatAliasesParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}