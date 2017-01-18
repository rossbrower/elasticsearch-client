using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-aliases.html"/></summary>
        ///<param name="index">A comma-separated list of index names (supports wildcards); use `_all` for all indices</param>
        ///<param name="name">A comma-separated list of aliases to delete (supports wildcards); use `_all` to delete all aliases for the specified indices.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesDeleteAlias(string index, string name, Func<IndicesDeleteAliasParameters, IndicesDeleteAliasParameters> options = null)
        {
            var uri = string.Format("/{0}/_alias/{1}", index, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesDeleteAliasParameters()).GetUri(uri);
            }

            return mConnection.Execute("DELETE", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-aliases.html"/></summary>
        ///<param name="index">A comma-separated list of index names (supports wildcards); use `_all` for all indices</param>
        ///<param name="name">A comma-separated list of aliases to delete (supports wildcards); use `_all` to delete all aliases for the specified indices.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesDeleteAliasAsync(string index, string name, Func<IndicesDeleteAliasParameters, IndicesDeleteAliasParameters> options = null)
        {
            var uri = string.Format("/{0}/_alias/{1}", index, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesDeleteAliasParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("DELETE", uri);
        }
    }
}