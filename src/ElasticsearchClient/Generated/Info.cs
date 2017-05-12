using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage Info(Func<InfoParameters, InfoParameters> options = null)
        {
            var uri = "/";
            if (options != null)
            {
                uri = options.Invoke(new InfoParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> InfoAsync(Func<InfoParameters, InfoParameters> options = null)
        {
            var uri = "/";
            if (options != null)
            {
                uri = options.Invoke(new InfoParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}