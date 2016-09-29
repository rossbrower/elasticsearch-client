using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="repository">A comma-separated list of repository names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SnapshotDeleteRepository(string repository, Func<SnapshotDeleteRepositoryParameters, SnapshotDeleteRepositoryParameters> options = null)
        {
            var uri = $"{"/_snapshot/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotDeleteRepositoryParameters()).GetUri(uri);
            }

            return mConnection.Execute("DELETE", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="repository">A comma-separated list of repository names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SnapshotDeleteRepositoryAsync(string repository, Func<SnapshotDeleteRepositoryParameters, SnapshotDeleteRepositoryParameters> options = null)
        {
            var uri = $"{"/_snapshot/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotDeleteRepositoryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("DELETE", uri);
        }
    }
}