using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-templates.html"/></summary>
        ///<param name="name">The name of the template</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesDeleteTemplate(string name, Func<IndicesDeleteTemplateParameters, IndicesDeleteTemplateParameters> options = null)
        {
            var uri = string.Format("/_template/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesDeleteTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("DELETE", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-templates.html"/></summary>
        ///<param name="name">The name of the template</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesDeleteTemplateAsync(string name, Func<IndicesDeleteTemplateParameters, IndicesDeleteTemplateParameters> options = null)
        {
            var uri = string.Format("/_template/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesDeleteTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("DELETE", uri);
        }
    }
}