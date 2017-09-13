namespace Elasticsearch.Client
{
    ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-remote-info.html"/></summary>
    public class RemoteInfoParameters : Parameters
    {
        ///<summary>Pretty format the returned JSON response.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual RemoteInfoParameters pretty(bool value)
        {
            SetValue("pretty", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return human readable values for statistics.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual RemoteInfoParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Include the stack trace of returned errors.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual RemoteInfoParameters error_trace(bool value)
        {
            SetValue("error_trace", value.ToString().ToLower());
            return this;
        }

        ///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
        ///<param name="value"></param>
        public virtual RemoteInfoParameters source(string value)
        {
            SetValue("source", value);
            return this;
        }

        ///<summary>A comma-separated list of filters used to reduce the respone.</summary>
        ///<param name="value"></param>
        public virtual RemoteInfoParameters filter_path(string value)
        {
            SetValue("filter_path", value);
            return this;
        }
    }
}