using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-recovery.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CatRecovery(Func<CatRecoveryParameters, CatRecoveryParameters> options = null)
        {
            var uri = "/_cat/recovery";
            if (options != null)
            {
                uri = options.Invoke(new CatRecoveryParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-recovery.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatRecoveryAsync(Func<CatRecoveryParameters, CatRecoveryParameters> options = null)
        {
            var uri = "/_cat/recovery";
            if (options != null)
            {
                uri = options.Invoke(new CatRecoveryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-recovery.html"/></summary>
        ///<param name="index">A comma-separated list of index names to limit the returned information</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CatRecovery(string index, Func<CatRecoveryParameters, CatRecoveryParameters> options = null)
        {
            var uri = string.Format("/_cat/recovery/{0}", index);
            if (options != null)
            {
                uri = options.Invoke(new CatRecoveryParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-recovery.html"/></summary>
        ///<param name="index">A comma-separated list of index names to limit the returned information</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatRecoveryAsync(string index, Func<CatRecoveryParameters, CatRecoveryParameters> options = null)
        {
            var uri = string.Format("/_cat/recovery/{0}", index);
            if (options != null)
            {
                uri = options.Invoke(new CatRecoveryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}