using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/modules-scripting.html"/></summary>
        ///<param name="lang">Script language</param>
        ///<param name="id">Script ID</param>
        public HttpResponseMessage DeleteScript(string lang, string id)
        {
            var uri = string.Format("/_scripts/{0}/{1}", lang, id);
            return mConnection.Execute("DELETE", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/modules-scripting.html"/></summary>
        ///<param name="lang">Script language</param>
        ///<param name="id">Script ID</param>
        public async Task<HttpResponseMessage> DeleteScriptAsync(string lang, string id)
        {
            var uri = string.Format("/_scripts/{0}/{1}", lang, id);
            return await mConnection.ExecuteAsync("DELETE", uri);
        }
    }
}