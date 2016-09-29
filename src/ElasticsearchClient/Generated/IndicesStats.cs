using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-stats.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesStats(Func<IndicesStatsParameters, IndicesStatsParameters> options = null)
        {
            var uri = "/_stats";
            if (options != null)
            {
                uri = options.Invoke(new IndicesStatsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-stats.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesStatsAsync(Func<IndicesStatsParameters, IndicesStatsParameters> options = null)
        {
            var uri = "/_stats";
            if (options != null)
            {
                uri = options.Invoke(new IndicesStatsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-stats.html"/></summary>
        ///<param name="metric">Limit the information returned the specific metrics.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesStats(string metric, Func<IndicesStatsParameters, IndicesStatsParameters> options = null)
        {
            var uri = $"{"/_stats/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesStatsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-stats.html"/></summary>
        ///<param name="metric">Limit the information returned the specific metrics.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesStatsAsync(string metric, Func<IndicesStatsParameters, IndicesStatsParameters> options = null)
        {
            var uri = $"{"/_stats/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesStatsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-stats.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="metric">Limit the information returned the specific metrics.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesStats(string index, string metric, Func<IndicesStatsParameters, IndicesStatsParameters> options = null)
        {
            var uri = $"{"/{0}/_stats/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesStatsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-stats.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="metric">Limit the information returned the specific metrics.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesStatsAsync(string index, string metric, Func<IndicesStatsParameters, IndicesStatsParameters> options = null)
        {
            var uri = $"{"/{0}/_stats/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesStatsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}