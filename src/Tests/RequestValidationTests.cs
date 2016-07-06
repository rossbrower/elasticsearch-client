using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Elasticsearch.Client.Tests
{
    public class RequestValidationTests
    {
        [Fact]
        public static void TestIndex()
        {
            RequestValidator.Validate(c => c
                .IndexPostString("a", "b", "c", "{}", o => o.refresh("true").op_type("create")),
                "POST", "/a/b/c?refresh=true&op_type=create");
        }
    }
}
