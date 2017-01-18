using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A comma-separated list of snapshot names</param>
        ///<param name="repository">A repository name</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SnapshotGet(string snapshot, string repository, Func<SnapshotGetParameters, SnapshotGetParameters> options = null)
        {
            var uri = string.Format("/_0/{1}/{0}", snapshot, repository);
            if (options != null)
            {
                uri = options.Invoke(new SnapshotGetParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A comma-separated list of snapshot names</param>
        ///<param name="repository">A repository name</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SnapshotGetAsync(string snapshot, string repository, Func<SnapshotGetParameters, SnapshotGetParameters> options = null)
        {
            var uri = string.Format("/_0/{1}/{0}", snapshot, repository);
            if (options != null)
            {
                uri = options.Invoke(new SnapshotGetParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}