using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-snapshots.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CatSnapshots(Func<CatSnapshotsParameters, CatSnapshotsParameters> options = null)
        {
            var uri = "/_cat/snapshots";
            if (options != null)
            {
                uri = options.Invoke(new CatSnapshotsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-snapshots.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatSnapshotsAsync(Func<CatSnapshotsParameters, CatSnapshotsParameters> options = null)
        {
            var uri = "/_cat/snapshots";
            if (options != null)
            {
                uri = options.Invoke(new CatSnapshotsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-snapshots.html"/></summary>
        ///<param name="repository">Name of repository from which to fetch the snapshot information</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CatSnapshots(string repository, Func<CatSnapshotsParameters, CatSnapshotsParameters> options = null)
        {
            var uri = string.Format("/_cat/snapshots/{0}", repository);
            if (options != null)
            {
                uri = options.Invoke(new CatSnapshotsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-snapshots.html"/></summary>
        ///<param name="repository">Name of repository from which to fetch the snapshot information</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatSnapshotsAsync(string repository, Func<CatSnapshotsParameters, CatSnapshotsParameters> options = null)
        {
            var uri = string.Format("/_cat/snapshots/{0}", repository);
            if (options != null)
            {
                uri = options.Invoke(new CatSnapshotsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}