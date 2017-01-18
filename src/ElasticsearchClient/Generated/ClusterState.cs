using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-state.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClusterState(Func<ClusterStateParameters, ClusterStateParameters> options = null)
        {
            var uri = "/_cluster/state";
            if (options != null)
            {
                uri = options.Invoke(new ClusterStateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-state.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClusterStateAsync(Func<ClusterStateParameters, ClusterStateParameters> options = null)
        {
            var uri = "/_cluster/state";
            if (options != null)
            {
                uri = options.Invoke(new ClusterStateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-state.html"/></summary>
        ///<param name="metric">Limit the information returned to the specified metrics</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClusterState(string metric, Func<ClusterStateParameters, ClusterStateParameters> options = null)
        {
            var uri = string.Format("/_cluster/state/{0}", metric);
            if (options != null)
            {
                uri = options.Invoke(new ClusterStateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-state.html"/></summary>
        ///<param name="metric">Limit the information returned to the specified metrics</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClusterStateAsync(string metric, Func<ClusterStateParameters, ClusterStateParameters> options = null)
        {
            var uri = string.Format("/_cluster/state/{0}", metric);
            if (options != null)
            {
                uri = options.Invoke(new ClusterStateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-state.html"/></summary>
        ///<param name="metric">Limit the information returned to the specified metrics</param>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClusterState(string metric, string index, Func<ClusterStateParameters, ClusterStateParameters> options = null)
        {
            var uri = string.Format("/_cluster/state/{0}/{1}", metric, index);
            if (options != null)
            {
                uri = options.Invoke(new ClusterStateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-state.html"/></summary>
        ///<param name="metric">Limit the information returned to the specified metrics</param>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClusterStateAsync(string metric, string index, Func<ClusterStateParameters, ClusterStateParameters> options = null)
        {
            var uri = string.Format("/_cluster/state/{0}/{1}", metric, index);
            if (options != null)
            {
                uri = options.Invoke(new ClusterStateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}