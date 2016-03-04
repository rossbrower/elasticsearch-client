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
    
    
    public class IndicesExistsTemplateTests
    {
        
        private ElasticsearchClient mClient;
        
        public IndicesExistsTemplateTests(ElasticsearchClient client)
        {
            this.mClient = client;
        }
        
        public virtual async Task TestIndicesExistsTemplate(string name, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesExistsTemplate(name);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesExistsTemplateAsync(name);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesExistsTemplate(string name, Func<IndicesExistsTemplateParameters, IndicesExistsTemplateParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesExistsTemplate(name, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesExistsTemplateAsync(name, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
    }
}
