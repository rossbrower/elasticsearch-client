using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-health.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClusterHealth(Func<ClusterHealthParameters, ClusterHealthParameters> options = null)
        {
            var uri = "/_cluster/health";
            if (options != null)
            {
                uri = options.Invoke(new ClusterHealthParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-health.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClusterHealthAsync(Func<ClusterHealthParameters, ClusterHealthParameters> options = null)
        {
            var uri = "/_cluster/health";
            if (options != null)
            {
                uri = options.Invoke(new ClusterHealthParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-health.html"/></summary>
        ///<param name="index">Limit the information returned to a specific index</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClusterHealth(string index, Func<ClusterHealthParameters, ClusterHealthParameters> options = null)
        {
            var uri = string.Format("/_cluster/health/{0}", index);
            if (options != null)
            {
                uri = options.Invoke(new ClusterHealthParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-health.html"/></summary>
        ///<param name="index">Limit the information returned to a specific index</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClusterHealthAsync(string index, Func<ClusterHealthParameters, ClusterHealthParameters> options = null)
        {
            var uri = string.Format("/_cluster/health/{0}", index);
            if (options != null)
            {
                uri = options.Invoke(new ClusterHealthParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}