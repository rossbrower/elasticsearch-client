using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A snapshot name</param>
        ///<param name="repository">A repository name</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SnapshotRestore(string snapshot, string repository, Func<SnapshotRestoreParameters, SnapshotRestoreParameters> options = null)
        {
            var uri = $"{"/_0/{1}/{0}/_restore"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotRestoreParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A snapshot name</param>
        ///<param name="repository">A repository name</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SnapshotRestoreAsync(string snapshot, string repository, Func<SnapshotRestoreParameters, SnapshotRestoreParameters> options = null)
        {
            var uri = $"{"/_0/{1}/{0}/_restore"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotRestoreParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A snapshot name</param>
        ///<param name="repository">A repository name</param>
        ///<param name="body">Details of what to restore</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SnapshotRestore(string snapshot, string repository, Stream body, Func<SnapshotRestoreParameters, SnapshotRestoreParameters> options = null)
        {
            var uri = $"{"/_0/{1}/{0}/_restore"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotRestoreParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A snapshot name</param>
        ///<param name="repository">A repository name</param>
        ///<param name="body">Details of what to restore</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SnapshotRestoreAsync(string snapshot, string repository, Stream body, Func<SnapshotRestoreParameters, SnapshotRestoreParameters> options = null)
        {
            var uri = $"{"/_0/{1}/{0}/_restore"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotRestoreParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A snapshot name</param>
        ///<param name="repository">A repository name</param>
        ///<param name="body">Details of what to restore</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SnapshotRestore(string snapshot, string repository, byte[] body, Func<SnapshotRestoreParameters, SnapshotRestoreParameters> options = null)
        {
            var uri = $"{"/_0/{1}/{0}/_restore"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotRestoreParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A snapshot name</param>
        ///<param name="repository">A repository name</param>
        ///<param name="body">Details of what to restore</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SnapshotRestoreAsync(string snapshot, string repository, byte[] body, Func<SnapshotRestoreParameters, SnapshotRestoreParameters> options = null)
        {
            var uri = $"{"/_0/{1}/{0}/_restore"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotRestoreParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A snapshot name</param>
        ///<param name="repository">A repository name</param>
        ///<param name="body">Details of what to restore</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SnapshotRestoreString(string snapshot, string repository, string body, Func<SnapshotRestoreParameters, SnapshotRestoreParameters> options = null)
        {
            var uri = $"{"/_0/{1}/{0}/_restore"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotRestoreParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A snapshot name</param>
        ///<param name="repository">A repository name</param>
        ///<param name="body">Details of what to restore</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SnapshotRestoreStringAsync(string snapshot, string repository, string body, Func<SnapshotRestoreParameters, SnapshotRestoreParameters> options = null)
        {
            var uri = $"{"/_0/{1}/{0}/_restore"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotRestoreParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}