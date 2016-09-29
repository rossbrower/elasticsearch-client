using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-index.html"/></summary>
        ///<param name="index">A comma-separated list of index names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesGet(string index, Func<IndicesGetParameters, IndicesGetParameters> options = null)
        {
            var uri = $"{"/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-index.html"/></summary>
        ///<param name="index">A comma-separated list of index names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesGetAsync(string index, Func<IndicesGetParameters, IndicesGetParameters> options = null)
        {
            var uri = $"{"/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-index.html"/></summary>
        ///<param name="index">A comma-separated list of index names</param>
        ///<param name="feature">A comma-separated list of features</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesGet(string index, string feature, Func<IndicesGetParameters, IndicesGetParameters> options = null)
        {
            var uri = $"{"/{0}/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-index.html"/></summary>
        ///<param name="index">A comma-separated list of index names</param>
        ///<param name="feature">A comma-separated list of features</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesGetAsync(string index, string feature, Func<IndicesGetParameters, IndicesGetParameters> options = null)
        {
            var uri = $"{"/{0}/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}