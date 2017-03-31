namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-allocation-explain.html"/></summary>
    public class ClusterAllocationExplainParameters : Parameters
    {
        ///<summary>Return 'YES' decisions in explanation (default: false)</summary>
        ///<param name="value"></param>
        public virtual ClusterAllocationExplainParameters include_yes_decisions(bool value)
        {
            SetValue("include_yes_decisions", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return information about disk usage and shard sizes (default: false)</summary>
        ///<param name="value"></param>
        public virtual ClusterAllocationExplainParameters include_disk_info(bool value)
        {
            SetValue("include_disk_info", value.ToString().ToLower());
            return this;
        }

        ///<summary>Pretty format the returned JSON response.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual ClusterAllocationExplainParameters pretty(bool value)
        {
            SetValue("pretty", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return human readable values for statistics.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual ClusterAllocationExplainParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Include the stack trace of returned errors.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual ClusterAllocationExplainParameters error_trace(bool value)
        {
            SetValue("error_trace", value.ToString().ToLower());
            return this;
        }

        ///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
        ///<param name="value"></param>
        public virtual ClusterAllocationExplainParameters source(string value)
        {
            SetValue("source", value);
            return this;
        }

        ///<summary>A comma-separated list of filters used to reduce the respone.</summary>
        ///<param name="value"></param>
        public virtual ClusterAllocationExplainParameters filter_path(string value)
        {
            SetValue("filter_path", value);
            return this;
        }
    }
}