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
        public HttpResponseMessage IndicesGetAliases(Func<IndicesGetAliasesParameters, IndicesGetAliasesParameters> options = null)
        {
            var uri = "/_aliases";
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetAliasesParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesGetAliasesAsync(Func<IndicesGetAliasesParameters, IndicesGetAliasesParameters> options = null)
        {
            var uri = "/_aliases";
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetAliasesParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        ///<param name="index">A comma-separated list of index names to filter aliases</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesGetAliases(string index, Func<IndicesGetAliasesParameters, IndicesGetAliasesParameters> options = null)
        {
            var uri = $"{"/{0}/_aliases"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetAliasesParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        ///<param name="index">A comma-separated list of index names to filter aliases</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesGetAliasesAsync(string index, Func<IndicesGetAliasesParameters, IndicesGetAliasesParameters> options = null)
        {
            var uri = $"{"/{0}/_aliases"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetAliasesParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        ///<param name="index">A comma-separated list of index names to filter aliases</param>
        ///<param name="name">A comma-separated list of alias names to filter</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesGetAliases(string index, string name, Func<IndicesGetAliasesParameters, IndicesGetAliasesParameters> options = null)
        {
            var uri = $"{"/{0}/_aliases/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetAliasesParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        ///<param name="index">A comma-separated list of index names to filter aliases</param>
        ///<param name="name">A comma-separated list of alias names to filter</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesGetAliasesAsync(string index, string name, Func<IndicesGetAliasesParameters, IndicesGetAliasesParameters> options = null)
        {
            var uri = $"{"/{0}/_aliases/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetAliasesParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}