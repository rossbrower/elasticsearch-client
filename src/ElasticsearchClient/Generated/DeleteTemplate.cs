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
        public HttpResponseMessage DeleteTemplate(string id)
        {
            var uri = string.Format("/_search/template/{0}", id);
            return mConnection.Execute("DELETE", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-template.html"/></summary>
        ///<param name="id">Template ID</param>
        public async Task<HttpResponseMessage> DeleteTemplateAsync(string id)
        {
            var uri = string.Format("/_search/template/{0}", id);
            return await mConnection.ExecuteAsync("DELETE", uri);
        }
    }
}