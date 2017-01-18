using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/indices-aliases.html"/></summary>
        ///<param name="name">A comma-separated list of alias names to return</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesExistsAlias(string name, Func<IndicesExistsAliasParameters, IndicesExistsAliasParameters> options = null)
        {
            var uri = string.Format("/_alias/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesExistsAliasParameters()).GetUri(uri);
            }

            return mConnection.Execute("HEAD", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/indices-aliases.html"/></summary>
        ///<param name="name">A comma-separated list of alias names to return</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesExistsAliasAsync(string name, Func<IndicesExistsAliasParameters, IndicesExistsAliasParameters> options = null)
        {
            var uri = string.Format("/_alias/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesExistsAliasParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("HEAD", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/indices-aliases.html"/></summary>
        ///<param name="index">A comma-separated list of index names to filter aliases</param>
        ///<param name="name">A comma-separated list of alias names to return</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesExistsAlias(string index, string name, Func<IndicesExistsAliasParameters, IndicesExistsAliasParameters> options = null)
        {
            var uri = string.Format("/{0}/_alias/{1}", index, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesExistsAliasParameters()).GetUri(uri);
            }

            return mConnection.Execute("HEAD", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/indices-aliases.html"/></summary>
        ///<param name="index">A comma-separated list of index names to filter aliases</param>
        ///<param name="name">A comma-separated list of alias names to return</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesExistsAliasAsync(string index, string name, Func<IndicesExistsAliasParameters, IndicesExistsAliasParameters> options = null)
        {
            var uri = string.Format("/{0}/_alias/{1}", index, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesExistsAliasParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("HEAD", uri);
        }
    }
}