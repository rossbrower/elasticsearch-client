//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Elasticsearch.Client
{
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    
    
    public partial class ElasticsearchClient
    {
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-snapshots.html"/></summary>
        /// <param name="repository">Name of repository from which to fetch the snapshot information</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage CatSnapshots(string repository, Func<CatSnapshotsParameters, CatSnapshotsParameters> options = null)
        {
            string uri = string.Format("/_cat/snapshots/{0}", repository);
            if ((options != null))
            {
                CatSnapshotsParameters parameters = options.Invoke(new CatSnapshotsParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cat-snapshots.html"/></summary>
        /// <param name="repository">Name of repository from which to fetch the snapshot information</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> CatSnapshotsAsync(string repository, Func<CatSnapshotsParameters, CatSnapshotsParameters> options = null)
        {
            string uri = string.Format("/_cat/snapshots/{0}", repository);
            if ((options != null))
            {
                CatSnapshotsParameters parameters = options.Invoke(new CatSnapshotsParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("GET", uri);
        }
    }
}
