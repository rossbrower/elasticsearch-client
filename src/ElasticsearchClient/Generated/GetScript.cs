using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="lang">Script language</param>
        ///<param name="id">Script ID</param>
        public HttpResponseMessage GetScript(string lang, string id)
        {
            var uri = string.Format("/_scripts/{0}/{1}", lang, id);
            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
        ///<param name="lang">Script language</param>
        ///<param name="id">Script ID</param>
        public async Task<HttpResponseMessage> GetScriptAsync(string lang, string id)
        {
            var uri = string.Format("/_scripts/{0}/{1}", lang, id);
            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}