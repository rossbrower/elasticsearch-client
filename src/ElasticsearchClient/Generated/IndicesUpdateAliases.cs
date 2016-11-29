using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/indices-aliases.html"/></summary>
        ///<param name="body">The definition of `actions` to perform</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesUpdateAliases(Stream body, Func<IndicesUpdateAliasesParameters, IndicesUpdateAliasesParameters> options = null)
        {
            var uri = "/_aliases";
            if (options != null)
            {
                uri = options.Invoke(new IndicesUpdateAliasesParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/indices-aliases.html"/></summary>
        ///<param name="body">The definition of `actions` to perform</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesUpdateAliasesAsync(Stream body, Func<IndicesUpdateAliasesParameters, IndicesUpdateAliasesParameters> options = null)
        {
            var uri = "/_aliases";
            if (options != null)
            {
                uri = options.Invoke(new IndicesUpdateAliasesParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/indices-aliases.html"/></summary>
        ///<param name="body">The definition of `actions` to perform</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesUpdateAliases(byte[] body, Func<IndicesUpdateAliasesParameters, IndicesUpdateAliasesParameters> options = null)
        {
            var uri = "/_aliases";
            if (options != null)
            {
                uri = options.Invoke(new IndicesUpdateAliasesParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/indices-aliases.html"/></summary>
        ///<param name="body">The definition of `actions` to perform</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesUpdateAliasesAsync(byte[] body, Func<IndicesUpdateAliasesParameters, IndicesUpdateAliasesParameters> options = null)
        {
            var uri = "/_aliases";
            if (options != null)
            {
                uri = options.Invoke(new IndicesUpdateAliasesParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/indices-aliases.html"/></summary>
        ///<param name="body">The definition of `actions` to perform</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesUpdateAliasesString(string body, Func<IndicesUpdateAliasesParameters, IndicesUpdateAliasesParameters> options = null)
        {
            var uri = "/_aliases";
            if (options != null)
            {
                uri = options.Invoke(new IndicesUpdateAliasesParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/indices-aliases.html"/></summary>
        ///<param name="body">The definition of `actions` to perform</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesUpdateAliasesStringAsync(string body, Func<IndicesUpdateAliasesParameters, IndicesUpdateAliasesParameters> options = null)
        {
            var uri = "/_aliases";
            if (options != null)
            {
                uri = options.Invoke(new IndicesUpdateAliasesParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}