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
        public HttpResponseMessage SnapshotDelete(string snapshot, string repository, Func<SnapshotDeleteParameters, SnapshotDeleteParameters> options = null)
        {
            var uri = $"{"/_0/{1}/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotDeleteParameters()).GetUri(uri);
            }

            return mConnection.Execute("DELETE", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A snapshot name</param>
        ///<param name="repository">A repository name</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SnapshotDeleteAsync(string snapshot, string repository, Func<SnapshotDeleteParameters, SnapshotDeleteParameters> options = null)
        {
            var uri = $"{"/_0/{1}/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotDeleteParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("DELETE", uri);
        }
    }
}