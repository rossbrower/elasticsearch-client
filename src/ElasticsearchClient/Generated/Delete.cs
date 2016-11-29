using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-delete.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">The document ID</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage Delete(string index, string type, string id, Func<DeleteParameters, DeleteParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new DeleteParameters()).GetUri(uri);
            }

            return mConnection.Execute("DELETE", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-delete.html"/></summary>
        ///<param name="index">The name of the index</param>
        ///<param name="type">The type of the document</param>
        ///<param name="id">The document ID</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> DeleteAsync(string index, string type, string id, Func<DeleteParameters, DeleteParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new DeleteParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("DELETE", uri);
        }
    }
}