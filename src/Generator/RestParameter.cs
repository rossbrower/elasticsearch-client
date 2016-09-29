using System.Collections.Generic;

namespace Elasticsearch.Client.Generator
{
    public class RestParameter
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public List<string> Options { get; set; }
        public object Default { get; set; }
        public bool Required { get; set; }
        public string Serialize { get; set; }
    }
}
