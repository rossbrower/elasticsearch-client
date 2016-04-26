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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        /// <param name="repository">A repository name</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage SnapshotVerifyRepository(string repository, Func<SnapshotVerifyRepositoryParameters, SnapshotVerifyRepositoryParameters> options = null)
        {
            string uri = string.Format("/_snapshot/{0}/_verify", repository);
            if ((options != null))
            {
                SnapshotVerifyRepositoryParameters parameters = options.Invoke(new SnapshotVerifyRepositoryParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        /// <param name="repository">A repository name</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> SnapshotVerifyRepositoryAsync(string repository, Func<SnapshotVerifyRepositoryParameters, SnapshotVerifyRepositoryParameters> options = null)
        {
            string uri = string.Format("/_snapshot/{0}/_verify", repository);
            if ((options != null))
            {
                SnapshotVerifyRepositoryParameters parameters = options.Invoke(new SnapshotVerifyRepositoryParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri);
        }
    }
}
