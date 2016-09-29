using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-segments.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesSegments(Func<IndicesSegmentsParameters, IndicesSegmentsParameters> options = null)
        {
            var uri = "/_segments";
            if (options != null)
            {
                uri = options.Invoke(new IndicesSegmentsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-segments.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesSegmentsAsync(Func<IndicesSegmentsParameters, IndicesSegmentsParameters> options = null)
        {
            var uri = "/_segments";
            if (options != null)
            {
                uri = options.Invoke(new IndicesSegmentsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-segments.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesSegments(string index, Func<IndicesSegmentsParameters, IndicesSegmentsParameters> options = null)
        {
            var uri = $"{"/{0}/_segments"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesSegmentsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-segments.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesSegmentsAsync(string index, Func<IndicesSegmentsParameters, IndicesSegmentsParameters> options = null)
        {
            var uri = $"{"/{0}/_segments"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesSegmentsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}