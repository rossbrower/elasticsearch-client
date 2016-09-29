using System.Collections.Generic;

namespace Elasticsearch.Client.Generator
{
    public class RestMethod
    {
    public RestMethod()
    {
        UrlParts = new List<RestParameter>();
        UrlParams = new List<RestParameter>();
    }

    public string Name { get; set; }
    public string DocumentationLink { get; set; }
    public List<string> Methods { get; set; }
    public List<string> UrlPaths { get; set; }
    public List<RestParameter> UrlParts { get; set; }
    public List<RestParameter> UrlParams { get; set; }
    public RestParameter Body { get; set; }
}
}
