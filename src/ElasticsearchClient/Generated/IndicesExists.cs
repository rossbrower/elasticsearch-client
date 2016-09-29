using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to check</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesExists(string index, Func<IndicesExistsParameters, IndicesExistsParameters> options = null)
        {
            var uri = string.Format("/{0}", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesExistsParameters()).GetUri(uri);
            }

            return mConnection.Execute("HEAD", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-exists.html"/></summary>
        ///<param name="index">A comma-separated list of indices to check</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesExistsAsync(string index, Func<IndicesExistsParameters, IndicesExistsParameters> options = null)
        {
            var uri = string.Format("/{0}", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesExistsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("HEAD", uri);
        }
    }
}