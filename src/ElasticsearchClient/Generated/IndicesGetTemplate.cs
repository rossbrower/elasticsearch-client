using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/indices-templates.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesGetTemplate(Func<IndicesGetTemplateParameters, IndicesGetTemplateParameters> options = null)
        {
            var uri = "/_template";
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/indices-templates.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesGetTemplateAsync(Func<IndicesGetTemplateParameters, IndicesGetTemplateParameters> options = null)
        {
            var uri = "/_template";
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/indices-templates.html"/></summary>
        ///<param name="name">The comma separated names of the index templates</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesGetTemplate(string name, Func<IndicesGetTemplateParameters, IndicesGetTemplateParameters> options = null)
        {
            var uri = string.Format("/_template/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetTemplateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/indices-templates.html"/></summary>
        ///<param name="name">The comma separated names of the index templates</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesGetTemplateAsync(string name, Func<IndicesGetTemplateParameters, IndicesGetTemplateParameters> options = null)
        {
            var uri = string.Format("/_template/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetTemplateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}