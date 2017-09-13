namespace Elasticsearch.Client
{
    ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-usage.html"/></summary>
    public class NodesUsageParameters : Parameters
    {
        ///<summary>Whether to return time and byte values in human-readable format.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual NodesUsageParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Explicit operation timeout</summary>
        ///<param name="value"></param>
        public virtual NodesUsageParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }

        ///<summary>Pretty format the returned JSON response.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual NodesUsageParameters pretty(bool value)
        {
            SetValue("pretty", value.ToString().ToLower());
            return this;
        }

        ///<summary>Include the stack trace of returned errors.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual NodesUsageParameters error_trace(bool value)
        {
            SetValue("error_trace", value.ToString().ToLower());
            return this;
        }

        ///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
        ///<param name="value"></param>
        public virtual NodesUsageParameters source(string value)
        {
            SetValue("source", value);
            return this;
        }

        ///<summary>A comma-separated list of filters used to reduce the respone.</summary>
        ///<param name="value"></param>
        public virtual NodesUsageParameters filter_path(string value)
        {
            SetValue("filter_path", value);
            return this;
        }
    }
}