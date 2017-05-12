namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/docs-reindex.html"/></summary>
    public class ReindexRethrottleParameters : Parameters
    {
        ///<summary>The throttle to set on this request in floating sub-requests per second. -1 means set no throttle.</summary>
        ///<param name="value"></param>
        public virtual ReindexRethrottleParameters requests_per_second(long value)
        {
            SetValue("requests_per_second", value);
            return this;
        }

        ///<summary>Pretty format the returned JSON response.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual ReindexRethrottleParameters pretty(bool value)
        {
            SetValue("pretty", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return human readable values for statistics.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual ReindexRethrottleParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Include the stack trace of returned errors.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual ReindexRethrottleParameters error_trace(bool value)
        {
            SetValue("error_trace", value.ToString().ToLower());
            return this;
        }

        ///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
        ///<param name="value"></param>
        public virtual ReindexRethrottleParameters source(string value)
        {
            SetValue("source", value);
            return this;
        }

        ///<summary>A comma-separated list of filters used to reduce the respone.</summary>
        ///<param name="value"></param>
        public virtual ReindexRethrottleParameters filter_path(string value)
        {
            SetValue("filter_path", value);
            return this;
        }
    }
}