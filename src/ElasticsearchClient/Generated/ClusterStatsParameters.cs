namespace Elasticsearch.Client
{
    ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-stats.html"/></summary>
    public class ClusterStatsParameters : Parameters
    {
        ///<summary>Return settings in flat format (default: false)</summary>
        ///<param name="value"></param>
        public virtual ClusterStatsParameters flat_settings(bool value)
        {
            SetValue("flat_settings", value.ToString().ToLower());
            return this;
        }

        ///<summary>Explicit operation timeout</summary>
        ///<param name="value"></param>
        public virtual ClusterStatsParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }

        ///<summary>Pretty format the returned JSON response.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual ClusterStatsParameters pretty(bool value)
        {
            SetValue("pretty", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return human readable values for statistics.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual ClusterStatsParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Include the stack trace of returned errors.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual ClusterStatsParameters error_trace(bool value)
        {
            SetValue("error_trace", value.ToString().ToLower());
            return this;
        }

        ///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
        ///<param name="value"></param>
        public virtual ClusterStatsParameters source(string value)
        {
            SetValue("source", value);
            return this;
        }

        ///<summary>A comma-separated list of filters used to reduce the respone.</summary>
        ///<param name="value"></param>
        public virtual ClusterStatsParameters filter_path(string value)
        {
            SetValue("filter_path", value);
            return this;
        }
    }
}