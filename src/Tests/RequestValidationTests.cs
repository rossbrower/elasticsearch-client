using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Elasticsearch.Client.Tests
{
    [TestClass]
    public class RequestValidationTests
    {
        [TestMethod]
        public void TestIndex()
        {
            RequestValidator.Validate(c => c
                .IndexPostString("a", "b", "c", "{}", o => o.refresh("true").op_type("create")),
                "POST", "/a/b/c?refresh=true&op_type=create");
        }
    }
}
