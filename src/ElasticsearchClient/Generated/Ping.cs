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
        public HttpResponseMessage Ping(Func<PingParameters, PingParameters> options = null)
        {
            var uri = "/";
            if (options != null)
            {
                uri = options.Invoke(new PingParameters()).GetUri(uri);
            }

            return mConnection.Execute("HEAD", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PingAsync(Func<PingParameters, PingParameters> options = null)
        {
            var uri = "/";
            if (options != null)
            {
                uri = options.Invoke(new PingParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("HEAD", uri);
        }
    }
}