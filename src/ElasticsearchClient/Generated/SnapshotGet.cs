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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/modules-snapshots.html"/></summary>
        /// <param name="snapshot">A comma-separated list of snapshot names</param>
        /// <param name="repository">A repository name</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage SnapshotGet(string snapshot, string repository, Func<SnapshotGetParameters, SnapshotGetParameters> options = null)
        {
            string uri = string.Format("/_0/{1}/{0}", snapshot, repository);
            if ((options != null))
            {
                SnapshotGetParameters parameters = options.Invoke(new SnapshotGetParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/modules-snapshots.html"/></summary>
        /// <param name="snapshot">A comma-separated list of snapshot names</param>
        /// <param name="repository">A repository name</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> SnapshotGetAsync(string snapshot, string repository, Func<SnapshotGetParameters, SnapshotGetParameters> options = null)
        {
            string uri = string.Format("/_0/{1}/{0}", snapshot, repository);
            if ((options != null))
            {
                SnapshotGetParameters parameters = options.Invoke(new SnapshotGetParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}
