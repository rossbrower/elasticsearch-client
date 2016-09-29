using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-template.html"/></summary>
        ///<param name="id">Template ID</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage DeleteTemplate(string id, Func<DeleteTemplateParameters, DeleteTemplateParameters> options = null)
        {
            var uri = string.Format("/_search/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new DeleteTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("DELETE", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-template.html"/></summary>
        ///<param name="id">Template ID</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> DeleteTemplateAsync(string id, Func<DeleteTemplateParameters, DeleteTemplateParameters> options = null)
        {
            var uri = string.Format("/_search/template/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new DeleteTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("DELETE", uri);
        }
    }
}