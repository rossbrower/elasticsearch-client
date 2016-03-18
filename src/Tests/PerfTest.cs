using System.Threading.Tasks;
using Xunit;

namespace Elasticsearch.Client.Tests
{
    public class PerfTest
    {
        [Fact]
        public async Task TestBasicOperations()
        {
            using (var pool = new SingleConnection())
            {
                var client = new ElasticsearchClient(pool);
                using (var resp = await client.IndicesCreatePostAsync("foo"))
                {
                    Assert.True(resp.IsSuccessStatusCode);
                }
                using (var resp = await client.IndexPostStringAsync("foo", "bar", "1", "{\"Foo\": 42}"))
                {
                    Assert.True(resp.IsSuccessStatusCode);
                }
                using (var resp = await client.DeleteAsync("foo", "bar", "1"))
                {
                    Assert.True(resp.IsSuccessStatusCode);
                }
                using (var resp = await client.IndicesDeleteAsync("foo"))
                {
                    Assert.True(resp.IsSuccessStatusCode);
                }
            }
        }
    }
}
