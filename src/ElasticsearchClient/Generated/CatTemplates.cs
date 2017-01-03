using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cat-templates.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CatTemplates(Func<CatTemplatesParameters, CatTemplatesParameters> options = null)
        {
            var uri = "/_cat/templates";
            if (options != null)
            {
                uri = options.Invoke(new CatTemplatesParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cat-templates.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatTemplatesAsync(Func<CatTemplatesParameters, CatTemplatesParameters> options = null)
        {
            var uri = "/_cat/templates";
            if (options != null)
            {
                uri = options.Invoke(new CatTemplatesParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cat-templates.html"/></summary>
        ///<param name="name">A pattern that returned template names must match</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CatTemplates(string name, Func<CatTemplatesParameters, CatTemplatesParameters> options = null)
        {
            var uri = string.Format("/_cat/templates/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new CatTemplatesParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cat-templates.html"/></summary>
        ///<param name="name">A pattern that returned template names must match</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatTemplatesAsync(string name, Func<CatTemplatesParameters, CatTemplatesParameters> options = null)
        {
            var uri = string.Format("/_cat/templates/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new CatTemplatesParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}