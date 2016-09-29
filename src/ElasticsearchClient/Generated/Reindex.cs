using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/plugins-reindex.html"/></summary>
        ///<param name="body">The search definition using the Query DSL and the prototype for the index request.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage Reindex(Stream body, Func<ReindexParameters, ReindexParameters> options = null)
        {
            var uri = "/_reindex";
            if (options != null)
            {
                uri = options.Invoke(new ReindexParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/plugins-reindex.html"/></summary>
        ///<param name="body">The search definition using the Query DSL and the prototype for the index request.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ReindexAsync(Stream body, Func<ReindexParameters, ReindexParameters> options = null)
        {
            var uri = "/_reindex";
            if (options != null)
            {
                uri = options.Invoke(new ReindexParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/plugins-reindex.html"/></summary>
        ///<param name="body">The search definition using the Query DSL and the prototype for the index request.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage Reindex(byte[] body, Func<ReindexParameters, ReindexParameters> options = null)
        {
            var uri = "/_reindex";
            if (options != null)
            {
                uri = options.Invoke(new ReindexParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/plugins-reindex.html"/></summary>
        ///<param name="body">The search definition using the Query DSL and the prototype for the index request.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ReindexAsync(byte[] body, Func<ReindexParameters, ReindexParameters> options = null)
        {
            var uri = "/_reindex";
            if (options != null)
            {
                uri = options.Invoke(new ReindexParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/plugins-reindex.html"/></summary>
        ///<param name="body">The search definition using the Query DSL and the prototype for the index request.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ReindexString(string body, Func<ReindexParameters, ReindexParameters> options = null)
        {
            var uri = "/_reindex";
            if (options != null)
            {
                uri = options.Invoke(new ReindexParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/plugins-reindex.html"/></summary>
        ///<param name="body">The search definition using the Query DSL and the prototype for the index request.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ReindexStringAsync(string body, Func<ReindexParameters, ReindexParameters> options = null)
        {
            var uri = "/_reindex";
            if (options != null)
            {
                uri = options.Invoke(new ReindexParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}