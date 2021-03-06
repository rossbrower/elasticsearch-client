﻿using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Elasticsearch.Client.Tests
{
    [TestClass]
    public class PerfTest
    {
        [TestMethod]
        public async Task TestBasicOperations()
        {
            using (var pool = new ConnectionPool(new [] {"http://localhost:9200"}))
            {
                var client = new ElasticsearchClient(pool);
                using (var resp = client.IndicesExists("foo"))
                {
                    if (resp.IsSuccessStatusCode)
                    {
                        using (var resp2 = client.IndicesDelete("foo"))
                        {
                            Assert.IsTrue(resp2.IsSuccessStatusCode);
                        }
                    }
                }
                using (var resp = await client.IndicesCreateAsync("foo"))
                {
                    Debug.WriteLine(await resp.Content.ReadAsStringAsync());
                    Assert.IsTrue(resp.IsSuccessStatusCode);
                }
                using (var resp = await client.IndexPostStringAsync("foo", "bar", "1", "{\"Foo\": 42}"))
                {
                    Debug.WriteLine(await resp.Content.ReadAsStringAsync());
                    Assert.IsTrue(resp.IsSuccessStatusCode);
                }
                using (var resp = client.IndexPostString("foo", "bar", "2", "{\"Foo\": 42}"))
                {
                    Debug.WriteLine(await resp.Content.ReadAsStringAsync());
                    Assert.IsTrue(resp.IsSuccessStatusCode);
                }
                var docBytes = Encoding.UTF8.GetBytes("{\"Foo\": 42}");
                using (var resp = await client.IndexPostAsync("foo", "bar", "3", docBytes))
                {
                    Debug.WriteLine(await resp.Content.ReadAsStringAsync());
                    Assert.IsTrue(resp.IsSuccessStatusCode);
                }
                using (var resp = client.IndexPost("foo", "bar", "4", docBytes))
                {
                    Debug.WriteLine(await resp.Content.ReadAsStringAsync());
                    Assert.IsTrue(resp.IsSuccessStatusCode);
                }
                var docStream1 = new MemoryStream(docBytes);
                using (var resp = await client.IndexPostAsync("foo", "bar", "5", docStream1))
                {
                    Debug.WriteLine(await resp.Content.ReadAsStringAsync());
                    Assert.IsTrue(resp.IsSuccessStatusCode);
                }
                var docStream2 = new MemoryStream(docBytes);
                using (var resp = client.IndexPost("foo", "bar", "6", docStream2))
                {
                    Debug.WriteLine(await resp.Content.ReadAsStringAsync());
                    Assert.IsTrue(resp.IsSuccessStatusCode);
                }
                using (var resp = await client.DeleteAsync("foo", "bar", "1"))
                {
                    Debug.WriteLine(await resp.Content.ReadAsStringAsync());
                    Assert.IsTrue(resp.IsSuccessStatusCode);
                }
                using (var resp = await client.IndicesDeleteAsync("foo"))
                {
                    Debug.WriteLine(await resp.Content.ReadAsStringAsync());
                    Assert.IsTrue(resp.IsSuccessStatusCode);
                }
            }
        }
    }
}
