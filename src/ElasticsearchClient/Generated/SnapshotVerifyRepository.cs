using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="repository">A repository name</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SnapshotVerifyRepository(string repository, Func<SnapshotVerifyRepositoryParameters, SnapshotVerifyRepositoryParameters> options = null)
        {
            var uri = string.Format("/_snapshot/{0}/_verify", repository);
            if (options != null)
            {
                uri = options.Invoke(new SnapshotVerifyRepositoryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="repository">A repository name</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SnapshotVerifyRepositoryAsync(string repository, Func<SnapshotVerifyRepositoryParameters, SnapshotVerifyRepositoryParameters> options = null)
        {
            var uri = string.Format("/_snapshot/{0}/_verify", repository);
            if (options != null)
            {
                uri = options.Invoke(new SnapshotVerifyRepositoryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }
    }
}