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
    
    
    public class IndicesPutWarmerTests
    {
        
        private ElasticsearchClient mClient;
        
        public IndicesPutWarmerTests(ElasticsearchClient client)
        {
            this.mClient = client;
        }
        
        public virtual async Task TestIndicesPutWarmerPut(string name, Stream body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPut(name, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPutAsync(name, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPut(string name, Stream body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPut(name, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPutAsync(name, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPut(string name, Byte[] body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPut(name, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPutAsync(name, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPut(string name, Byte[] body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPut(name, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPutAsync(name, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPut(string name, string body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPut(name, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPutAsync(name, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPut(string name, string body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPut(name, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPutAsync(name, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPost(string name, Stream body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPost(name, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPostAsync(name, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPost(string name, Stream body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPost(name, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPostAsync(name, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPost(string name, Byte[] body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPost(name, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPostAsync(name, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPost(string name, Byte[] body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPost(name, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPostAsync(name, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPost(string name, string body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPost(name, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPostAsync(name, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPost(string name, string body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPost(name, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPostAsync(name, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPut(string index, string name, Stream body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPut(index, name, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPutAsync(index, name, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPut(string index, string name, Stream body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPut(index, name, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPutAsync(index, name, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPut(string index, string name, Byte[] body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPut(index, name, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPutAsync(index, name, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPut(string index, string name, Byte[] body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPut(index, name, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPutAsync(index, name, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPut(string index, string name, string body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPut(index, name, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPutAsync(index, name, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPut(string index, string name, string body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPut(index, name, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPutAsync(index, name, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPost(string index, string name, Stream body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPost(index, name, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPostAsync(index, name, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPost(string index, string name, Stream body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPost(index, name, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPostAsync(index, name, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPost(string index, string name, Byte[] body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPost(index, name, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPostAsync(index, name, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPost(string index, string name, Byte[] body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPost(index, name, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPostAsync(index, name, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPost(string index, string name, string body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPost(index, name, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPostAsync(index, name, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPost(string index, string name, string body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPost(index, name, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPostAsync(index, name, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPut(string index, string type, string name, Stream body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPut(index, type, name, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPutAsync(index, type, name, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPut(string index, string type, string name, Stream body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPut(index, type, name, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPutAsync(index, type, name, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPut(string index, string type, string name, Byte[] body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPut(index, type, name, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPutAsync(index, type, name, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPut(string index, string type, string name, Byte[] body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPut(index, type, name, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPutAsync(index, type, name, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPut(string index, string type, string name, string body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPut(index, type, name, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPutAsync(index, type, name, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPut(string index, string type, string name, string body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPut(index, type, name, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPutAsync(index, type, name, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPost(string index, string type, string name, Stream body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPost(index, type, name, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPostAsync(index, type, name, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPost(string index, string type, string name, Stream body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPost(index, type, name, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPostAsync(index, type, name, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPost(string index, string type, string name, Byte[] body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPost(index, type, name, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPostAsync(index, type, name, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPost(string index, string type, string name, Byte[] body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPost(index, type, name, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPostAsync(index, type, name, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPost(string index, string type, string name, string body, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPost(index, type, name, body);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPostAsync(index, type, name, body);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
        
        public virtual async Task TestIndicesPutWarmerPost(string index, string type, string name, string body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options, HttpStatusCode expectedStatusCode, string expectedContent)
        {
            HttpResponseMessage syncResponse = mClient.IndicesPutWarmerPost(index, type, name, body, options);
            Assert.AreEqual(expectedStatusCode, syncResponse.StatusCode);
            string syncContent = await syncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, syncContent);
            HttpResponseMessage asyncResponse = await mClient.IndicesPutWarmerPostAsync(index, type, name, body, options);
            Assert.AreEqual(expectedStatusCode, asyncResponse.StatusCode);
            string asyncContent = await asyncResponse.Content.ReadAsStringAsync();
            Assert.AreEqual(expectedContent, asyncContent);
            Assert.AreEqual(syncContent, asyncContent);
        }
    }
}
