//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Elasticsearch.Client.UnitTests
{
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    
    public class ClusterStatsTests
    {
        
        private ElasticsearchClient mClient;
        
        public ClusterStatsTests(ElasticsearchClient client)
        {
            this.mClient = client;
        }
        
        public virtual async Task TestClusterStats(HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.ClusterStats();
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.ClusterStatsAsync();
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestClusterStats(Func<ClusterStatsParameters, ClusterStatsParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.ClusterStats(options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.ClusterStatsAsync(options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestClusterStats(string node_id, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.ClusterStats(node_id);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.ClusterStatsAsync(node_id);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestClusterStats(string node_id, Func<ClusterStatsParameters, ClusterStatsParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.ClusterStats(node_id, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.ClusterStatsAsync(node_id, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
    }
}
