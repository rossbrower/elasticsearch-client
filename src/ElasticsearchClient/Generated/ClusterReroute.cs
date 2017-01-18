using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-reroute.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClusterReroute(Func<ClusterRerouteParameters, ClusterRerouteParameters> options = null)
        {
            var uri = "/_cluster/reroute";
            if (options != null)
            {
                uri = options.Invoke(new ClusterRerouteParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-reroute.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClusterRerouteAsync(Func<ClusterRerouteParameters, ClusterRerouteParameters> options = null)
        {
            var uri = "/_cluster/reroute";
            if (options != null)
            {
                uri = options.Invoke(new ClusterRerouteParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-reroute.html"/></summary>
        ///<param name="body">The definition of `commands` to perform (`move`, `cancel`, `allocate`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClusterReroute(Stream body, Func<ClusterRerouteParameters, ClusterRerouteParameters> options = null)
        {
            var uri = "/_cluster/reroute";
            if (options != null)
            {
                uri = options.Invoke(new ClusterRerouteParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-reroute.html"/></summary>
        ///<param name="body">The definition of `commands` to perform (`move`, `cancel`, `allocate`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClusterRerouteAsync(Stream body, Func<ClusterRerouteParameters, ClusterRerouteParameters> options = null)
        {
            var uri = "/_cluster/reroute";
            if (options != null)
            {
                uri = options.Invoke(new ClusterRerouteParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-reroute.html"/></summary>
        ///<param name="body">The definition of `commands` to perform (`move`, `cancel`, `allocate`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClusterReroute(byte[] body, Func<ClusterRerouteParameters, ClusterRerouteParameters> options = null)
        {
            var uri = "/_cluster/reroute";
            if (options != null)
            {
                uri = options.Invoke(new ClusterRerouteParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-reroute.html"/></summary>
        ///<param name="body">The definition of `commands` to perform (`move`, `cancel`, `allocate`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClusterRerouteAsync(byte[] body, Func<ClusterRerouteParameters, ClusterRerouteParameters> options = null)
        {
            var uri = "/_cluster/reroute";
            if (options != null)
            {
                uri = options.Invoke(new ClusterRerouteParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-reroute.html"/></summary>
        ///<param name="body">The definition of `commands` to perform (`move`, `cancel`, `allocate`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClusterRerouteString(string body, Func<ClusterRerouteParameters, ClusterRerouteParameters> options = null)
        {
            var uri = "/_cluster/reroute";
            if (options != null)
            {
                uri = options.Invoke(new ClusterRerouteParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-reroute.html"/></summary>
        ///<param name="body">The definition of `commands` to perform (`move`, `cancel`, `allocate`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClusterRerouteStringAsync(string body, Func<ClusterRerouteParameters, ClusterRerouteParameters> options = null)
        {
            var uri = "/_cluster/reroute";
            if (options != null)
            {
                uri = options.Invoke(new ClusterRerouteParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}