using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/indices-recovery.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesRecovery(Func<IndicesRecoveryParameters, IndicesRecoveryParameters> options = null)
        {
            var uri = "/_recovery";
            if (options != null)
            {
                uri = options.Invoke(new IndicesRecoveryParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/indices-recovery.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesRecoveryAsync(Func<IndicesRecoveryParameters, IndicesRecoveryParameters> options = null)
        {
            var uri = "/_recovery";
            if (options != null)
            {
                uri = options.Invoke(new IndicesRecoveryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/indices-recovery.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesRecovery(string index, Func<IndicesRecoveryParameters, IndicesRecoveryParameters> options = null)
        {
            var uri = string.Format("/{0}/_recovery", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesRecoveryParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/indices-recovery.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesRecoveryAsync(string index, Func<IndicesRecoveryParameters, IndicesRecoveryParameters> options = null)
        {
            var uri = string.Format("/{0}/_recovery", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesRecoveryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}