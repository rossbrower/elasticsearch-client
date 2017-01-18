using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/modules-snapshots.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SnapshotGetRepository(Func<SnapshotGetRepositoryParameters, SnapshotGetRepositoryParameters> options = null)
        {
            var uri = "/_snapshot";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotGetRepositoryParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/modules-snapshots.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SnapshotGetRepositoryAsync(Func<SnapshotGetRepositoryParameters, SnapshotGetRepositoryParameters> options = null)
        {
            var uri = "/_snapshot";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotGetRepositoryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/modules-snapshots.html"/></summary>
        ///<param name="repository">A comma-separated list of repository names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SnapshotGetRepository(string repository, Func<SnapshotGetRepositoryParameters, SnapshotGetRepositoryParameters> options = null)
        {
            var uri = string.Format("/_snapshot/{0}", repository);
            if (options != null)
            {
                uri = options.Invoke(new SnapshotGetRepositoryParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/modules-snapshots.html"/></summary>
        ///<param name="repository">A comma-separated list of repository names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SnapshotGetRepositoryAsync(string repository, Func<SnapshotGetRepositoryParameters, SnapshotGetRepositoryParameters> options = null)
        {
            var uri = string.Format("/_snapshot/{0}", repository);
            if (options != null)
            {
                uri = options.Invoke(new SnapshotGetRepositoryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}