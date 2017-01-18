using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/cat-nodeattrs.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CatNodeattrs(Func<CatNodeattrsParameters, CatNodeattrsParameters> options = null)
        {
            var uri = "/_cat/nodeattrs";
            if (options != null)
            {
                uri = options.Invoke(new CatNodeattrsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/cat-nodeattrs.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatNodeattrsAsync(Func<CatNodeattrsParameters, CatNodeattrsParameters> options = null)
        {
            var uri = "/_cat/nodeattrs";
            if (options != null)
            {
                uri = options.Invoke(new CatNodeattrsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}