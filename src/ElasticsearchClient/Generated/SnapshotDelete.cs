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
        /// <param name="snapshot">A snapshot name</param>
        /// <param name="repository">A repository name</param>
        private HttpResponseMessage SnapshotDelete(string snapshot, string repository)
        {
            string uri = string.Format("/_0/{1}/{0}", snapshot, repository);
            return this.Execute("DELETE", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        /// <param name="snapshot">A snapshot name</param>
        /// <param name="repository">A repository name</param>
        private async Task<HttpResponseMessage> SnapshotDeleteAsync(string snapshot, string repository)
        {
            string uri = string.Format("/_0/{1}/{0}", snapshot, repository);
            return await this.ExecuteAsync("DELETE", uri);
        }
    }
}
