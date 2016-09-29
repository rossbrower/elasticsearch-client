using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A comma-separated list of snapshot names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SnapshotStatus(string snapshot, Func<SnapshotStatusParameters, SnapshotStatusParameters> options = null)
        {
            var uri = $"{"/_0/_status"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotStatusParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A comma-separated list of snapshot names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SnapshotStatusAsync(string snapshot, Func<SnapshotStatusParameters, SnapshotStatusParameters> options = null)
        {
            var uri = $"{"/_0/_status"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotStatusParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A comma-separated list of snapshot names</param>
        ///<param name="repository">A repository name</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SnapshotStatus(string snapshot, string repository, Func<SnapshotStatusParameters, SnapshotStatusParameters> options = null)
        {
            var uri = $"{"/_0/{1}/_status"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotStatusParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A comma-separated list of snapshot names</param>
        ///<param name="repository">A repository name</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SnapshotStatusAsync(string snapshot, string repository, Func<SnapshotStatusParameters, SnapshotStatusParameters> options = null)
        {
            var uri = $"{"/_0/{1}/_status"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotStatusParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}