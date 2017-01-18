using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/cat-segments.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CatSegments(Func<CatSegmentsParameters, CatSegmentsParameters> options = null)
        {
            var uri = "/_cat/segments";
            if (options != null)
            {
                uri = options.Invoke(new CatSegmentsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/cat-segments.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatSegmentsAsync(Func<CatSegmentsParameters, CatSegmentsParameters> options = null)
        {
            var uri = "/_cat/segments";
            if (options != null)
            {
                uri = options.Invoke(new CatSegmentsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/cat-segments.html"/></summary>
        ///<param name="index">A comma-separated list of index names to limit the returned information</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CatSegments(string index, Func<CatSegmentsParameters, CatSegmentsParameters> options = null)
        {
            var uri = string.Format("/_cat/segments/{0}", index);
            if (options != null)
            {
                uri = options.Invoke(new CatSegmentsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/cat-segments.html"/></summary>
        ///<param name="index">A comma-separated list of index names to limit the returned information</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatSegmentsAsync(string index, Func<CatSegmentsParameters, CatSegmentsParameters> options = null)
        {
            var uri = string.Format("/_cat/segments/{0}", index);
            if (options != null)
            {
                uri = options.Invoke(new CatSegmentsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}