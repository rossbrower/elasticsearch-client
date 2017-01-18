using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/modules-scripting.html"/></summary>
        ///<param name="lang">Script language</param>
        ///<param name="id">Script ID</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage GetScript(string lang, string id, Func<GetScriptParameters, GetScriptParameters> options = null)
        {
            var uri = string.Format("/_scripts/{0}/{1}", lang, id);
            if (options != null)
            {
                uri = options.Invoke(new GetScriptParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/modules-scripting.html"/></summary>
        ///<param name="lang">Script language</param>
        ///<param name="id">Script ID</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> GetScriptAsync(string lang, string id, Func<GetScriptParameters, GetScriptParameters> options = null)
        {
            var uri = string.Format("/_scripts/{0}/{1}", lang, id);
            if (options != null)
            {
                uri = options.Invoke(new GetScriptParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}