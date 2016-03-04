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
    
    
    public class IndicesValidateQueryTests
    {
        
        private ElasticsearchClient mClient;
        
        public IndicesValidateQueryTests(ElasticsearchClient client)
        {
            this.mClient = client;
        }
        
        public virtual async Task TestIndicesValidateQueryGet(Stream body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryGet(body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryGetAsync(body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryGet(Stream body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryGet(body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryGetAsync(body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryGet(Byte[] body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryGet(body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryGetAsync(body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryGet(Byte[] body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryGet(body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryGetAsync(body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryGet(string body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryGet(body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryGetAsync(body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryGet(string body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryGet(body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryGetAsync(body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryPost(Stream body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryPost(body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryPostAsync(body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryPost(Stream body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryPost(body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryPostAsync(body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryPost(Byte[] body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryPost(body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryPostAsync(body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryPost(Byte[] body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryPost(body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryPostAsync(body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryPost(string body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryPost(body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryPostAsync(body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryPost(string body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryPost(body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryPostAsync(body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryGet(string index, Stream body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryGet(index, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryGetAsync(index, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryGet(string index, Stream body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryGet(index, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryGetAsync(index, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryGet(string index, Byte[] body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryGet(index, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryGetAsync(index, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryGet(string index, Byte[] body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryGet(index, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryGetAsync(index, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryGet(string index, string body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryGet(index, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryGetAsync(index, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryGet(string index, string body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryGet(index, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryGetAsync(index, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryPost(string index, Stream body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryPost(index, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryPostAsync(index, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryPost(string index, Stream body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryPost(index, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryPostAsync(index, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryPost(string index, Byte[] body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryPost(index, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryPostAsync(index, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryPost(string index, Byte[] body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryPost(index, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryPostAsync(index, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryPost(string index, string body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryPost(index, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryPostAsync(index, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryPost(string index, string body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryPost(index, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryPostAsync(index, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryGet(string index, string type, Stream body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryGet(index, type, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryGetAsync(index, type, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryGet(string index, string type, Stream body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryGet(index, type, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryGetAsync(index, type, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryGet(string index, string type, Byte[] body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryGet(index, type, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryGetAsync(index, type, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryGet(string index, string type, Byte[] body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryGet(index, type, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryGetAsync(index, type, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryGet(string index, string type, string body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryGet(index, type, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryGetAsync(index, type, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryGet(string index, string type, string body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryGet(index, type, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryGetAsync(index, type, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryPost(string index, string type, Stream body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryPost(index, type, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryPostAsync(index, type, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryPost(string index, string type, Stream body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryPost(index, type, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryPostAsync(index, type, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryPost(string index, string type, Byte[] body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryPost(index, type, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryPostAsync(index, type, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryPost(string index, string type, Byte[] body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryPost(index, type, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryPostAsync(index, type, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryPost(string index, string type, string body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryPost(index, type, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryPostAsync(index, type, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesValidateQueryPost(string index, string type, string body, Func<IndicesValidateQueryParameters, IndicesValidateQueryParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesValidateQueryPost(index, type, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesValidateQueryPostAsync(index, type, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
    }
}
