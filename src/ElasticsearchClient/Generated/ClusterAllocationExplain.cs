using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-allocation-explain.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClusterAllocationExplainGet(Func<ClusterAllocationExplainParameters, ClusterAllocationExplainParameters> options = null)
        {
            var uri = "/_cluster/allocation/explain";
            if (options != null)
            {
                uri = options.Invoke(new ClusterAllocationExplainParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-allocation-explain.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClusterAllocationExplainGetAsync(Func<ClusterAllocationExplainParameters, ClusterAllocationExplainParameters> options = null)
        {
            var uri = "/_cluster/allocation/explain";
            if (options != null)
            {
                uri = options.Invoke(new ClusterAllocationExplainParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-allocation-explain.html"/></summary>
        ///<param name="body">The index, shard, and primary flag to explain. Empty means 'explain the first unassigned shard'</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClusterAllocationExplainGet(Stream body, Func<ClusterAllocationExplainParameters, ClusterAllocationExplainParameters> options = null)
        {
            var uri = "/_cluster/allocation/explain";
            if (options != null)
            {
                uri = options.Invoke(new ClusterAllocationExplainParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-allocation-explain.html"/></summary>
        ///<param name="body">The index, shard, and primary flag to explain. Empty means 'explain the first unassigned shard'</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClusterAllocationExplainGetAsync(Stream body, Func<ClusterAllocationExplainParameters, ClusterAllocationExplainParameters> options = null)
        {
            var uri = "/_cluster/allocation/explain";
            if (options != null)
            {
                uri = options.Invoke(new ClusterAllocationExplainParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-allocation-explain.html"/></summary>
        ///<param name="body">The index, shard, and primary flag to explain. Empty means 'explain the first unassigned shard'</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClusterAllocationExplainGet(byte[] body, Func<ClusterAllocationExplainParameters, ClusterAllocationExplainParameters> options = null)
        {
            var uri = "/_cluster/allocation/explain";
            if (options != null)
            {
                uri = options.Invoke(new ClusterAllocationExplainParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-allocation-explain.html"/></summary>
        ///<param name="body">The index, shard, and primary flag to explain. Empty means 'explain the first unassigned shard'</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClusterAllocationExplainGetAsync(byte[] body, Func<ClusterAllocationExplainParameters, ClusterAllocationExplainParameters> options = null)
        {
            var uri = "/_cluster/allocation/explain";
            if (options != null)
            {
                uri = options.Invoke(new ClusterAllocationExplainParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-allocation-explain.html"/></summary>
        ///<param name="body">The index, shard, and primary flag to explain. Empty means 'explain the first unassigned shard'</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClusterAllocationExplainGetString(string body, Func<ClusterAllocationExplainParameters, ClusterAllocationExplainParameters> options = null)
        {
            var uri = "/_cluster/allocation/explain";
            if (options != null)
            {
                uri = options.Invoke(new ClusterAllocationExplainParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-allocation-explain.html"/></summary>
        ///<param name="body">The index, shard, and primary flag to explain. Empty means 'explain the first unassigned shard'</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClusterAllocationExplainGetStringAsync(string body, Func<ClusterAllocationExplainParameters, ClusterAllocationExplainParameters> options = null)
        {
            var uri = "/_cluster/allocation/explain";
            if (options != null)
            {
                uri = options.Invoke(new ClusterAllocationExplainParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-allocation-explain.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClusterAllocationExplainPost(Func<ClusterAllocationExplainParameters, ClusterAllocationExplainParameters> options = null)
        {
            var uri = "/_cluster/allocation/explain";
            if (options != null)
            {
                uri = options.Invoke(new ClusterAllocationExplainParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-allocation-explain.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClusterAllocationExplainPostAsync(Func<ClusterAllocationExplainParameters, ClusterAllocationExplainParameters> options = null)
        {
            var uri = "/_cluster/allocation/explain";
            if (options != null)
            {
                uri = options.Invoke(new ClusterAllocationExplainParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-allocation-explain.html"/></summary>
        ///<param name="body">The index, shard, and primary flag to explain. Empty means 'explain the first unassigned shard'</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClusterAllocationExplainPost(Stream body, Func<ClusterAllocationExplainParameters, ClusterAllocationExplainParameters> options = null)
        {
            var uri = "/_cluster/allocation/explain";
            if (options != null)
            {
                uri = options.Invoke(new ClusterAllocationExplainParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-allocation-explain.html"/></summary>
        ///<param name="body">The index, shard, and primary flag to explain. Empty means 'explain the first unassigned shard'</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClusterAllocationExplainPostAsync(Stream body, Func<ClusterAllocationExplainParameters, ClusterAllocationExplainParameters> options = null)
        {
            var uri = "/_cluster/allocation/explain";
            if (options != null)
            {
                uri = options.Invoke(new ClusterAllocationExplainParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-allocation-explain.html"/></summary>
        ///<param name="body">The index, shard, and primary flag to explain. Empty means 'explain the first unassigned shard'</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClusterAllocationExplainPost(byte[] body, Func<ClusterAllocationExplainParameters, ClusterAllocationExplainParameters> options = null)
        {
            var uri = "/_cluster/allocation/explain";
            if (options != null)
            {
                uri = options.Invoke(new ClusterAllocationExplainParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-allocation-explain.html"/></summary>
        ///<param name="body">The index, shard, and primary flag to explain. Empty means 'explain the first unassigned shard'</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClusterAllocationExplainPostAsync(byte[] body, Func<ClusterAllocationExplainParameters, ClusterAllocationExplainParameters> options = null)
        {
            var uri = "/_cluster/allocation/explain";
            if (options != null)
            {
                uri = options.Invoke(new ClusterAllocationExplainParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-allocation-explain.html"/></summary>
        ///<param name="body">The index, shard, and primary flag to explain. Empty means 'explain the first unassigned shard'</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage ClusterAllocationExplainPostString(string body, Func<ClusterAllocationExplainParameters, ClusterAllocationExplainParameters> options = null)
        {
            var uri = "/_cluster/allocation/explain";
            if (options != null)
            {
                uri = options.Invoke(new ClusterAllocationExplainParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-allocation-explain.html"/></summary>
        ///<param name="body">The index, shard, and primary flag to explain. Empty means 'explain the first unassigned shard'</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> ClusterAllocationExplainPostStringAsync(string body, Func<ClusterAllocationExplainParameters, ClusterAllocationExplainParameters> options = null)
        {
            var uri = "/_cluster/allocation/explain";
            if (options != null)
            {
                uri = options.Invoke(new ClusterAllocationExplainParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}