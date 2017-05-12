using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesGetAlias(Func<IndicesGetAliasParameters, IndicesGetAliasParameters> options = null)
        {
            var uri = "/_alias";
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetAliasParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesGetAliasAsync(Func<IndicesGetAliasParameters, IndicesGetAliasParameters> options = null)
        {
            var uri = "/_alias";
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetAliasParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        ///<param name="name">A comma-separated list of alias names to return</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesGetAlias(string name, Func<IndicesGetAliasParameters, IndicesGetAliasParameters> options = null)
        {
            var uri = string.Format("/_alias/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetAliasParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        ///<param name="name">A comma-separated list of alias names to return</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesGetAliasAsync(string name, Func<IndicesGetAliasParameters, IndicesGetAliasParameters> options = null)
        {
            var uri = string.Format("/_alias/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetAliasParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        ///<param name="index">A comma-separated list of index names to filter aliases</param>
        ///<param name="name">A comma-separated list of alias names to return</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesGetAlias(string index, string name, Func<IndicesGetAliasParameters, IndicesGetAliasParameters> options = null)
        {
            var uri = string.Format("/{0}/_alias/{1}", index, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetAliasParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        ///<param name="index">A comma-separated list of index names to filter aliases</param>
        ///<param name="name">A comma-separated list of alias names to return</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesGetAliasAsync(string index, string name, Func<IndicesGetAliasParameters, IndicesGetAliasParameters> options = null)
        {
            var uri = string.Format("/{0}/_alias/{1}", index, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetAliasParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}