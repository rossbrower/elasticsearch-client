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
        public HttpResponseMessage GetTemplate(string id, Func<GetTemplateParameters, GetTemplateParameters> options = null)
        {
            var uri = $"{"/_search/template/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new GetTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-template.html"/></summary>
        ///<param name="id">Template ID</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> GetTemplateAsync(string id, Func<GetTemplateParameters, GetTemplateParameters> options = null)
        {
            var uri = $"{"/_search/template/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new GetTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}