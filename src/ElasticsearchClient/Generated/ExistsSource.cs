using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-get.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document; use `_all` to fetch the first document matching the ID across all types</param>
        ///<param name="id">The document ID</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ExistsSource(string index, string type, string id, Func<ExistsSourceParameters, ExistsSourceParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_source", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new ExistsSourceParameters()).GetUri(uri);
            }

            return mConnection.Execute("HEAD", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-get.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document; use `_all` to fetch the first document matching the ID across all types</param>
        ///<param name="id">The document ID</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ExistsSourceAsync(string index, string type, string id, Func<ExistsSourceParameters, ExistsSourceParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_source", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new ExistsSourceParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("HEAD", uri);
        }
    }
}