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
    
    
    public class IndicesShardStoresTests
    {
        
        private ElasticsearchClient mClient;
        
        public IndicesShardStoresTests(ElasticsearchClient client)
        {
            this.mClient = client;
        }
        
        public virtual async Task TestIndicesShardStores(HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesShardStores();
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesShardStoresAsync();
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesShardStores(Func<IndicesShardStoresParameters, IndicesShardStoresParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesShardStores(options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesShardStoresAsync(options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesShardStores(string index, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesShardStores(index);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesShardStoresAsync(index);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesShardStores(string index, Func<IndicesShardStoresParameters, IndicesShardStoresParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesShardStores(index, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesShardStoresAsync(index, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
    }
}
