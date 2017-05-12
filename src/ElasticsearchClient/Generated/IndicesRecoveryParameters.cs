namespace Elasticsearch.Client
{
    ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-recovery.html"/></summary>
    public class IndicesRecoveryParameters : Parameters
    {
        ///<summary>Whether to display detailed information about shard recovery</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual IndicesRecoveryParameters detailed(bool value)
        {
            SetValue("detailed", value.ToString().ToLower());
            return this;
        }

        ///<summary>Display only those recoveries that are currently on-going</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual IndicesRecoveryParameters active_only(bool value)
        {
            SetValue("active_only", value.ToString().ToLower());
            return this;
        }

        ///<summary>Pretty format the returned JSON response.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual IndicesRecoveryParameters pretty(bool value)
        {
            SetValue("pretty", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return human readable values for statistics.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual IndicesRecoveryParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Include the stack trace of returned errors.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual IndicesRecoveryParameters error_trace(bool value)
        {
            SetValue("error_trace", value.ToString().ToLower());
            return this;
        }

        ///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
        ///<param name="value"></param>
        public virtual IndicesRecoveryParameters source(string value)
        {
            SetValue("source", value);
            return this;
        }

        ///<summary>A comma-separated list of filters used to reduce the respone.</summary>
        ///<param name="value"></param>
        public virtual IndicesRecoveryParameters filter_path(string value)
        {
            SetValue("filter_path", value);
            return this;
        }
    }
}