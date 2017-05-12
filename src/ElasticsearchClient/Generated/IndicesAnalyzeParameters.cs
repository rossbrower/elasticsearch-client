namespace Elasticsearch.Client
{
    ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-analyze.html"/></summary>
    public class IndicesAnalyzeParameters : Parameters
    {
        ///<summary>The name of the index to scope the operation</summary>
        ///<param name="value"></param>
        public virtual IndicesAnalyzeParameters index(string value)
        {
            SetValue("index", value);
            return this;
        }

        ///<summary>With `true`, specify that a local shard should be used if available, with `false`, use a random shard (default: true)</summary>
        ///<param name="value"></param>
        public virtual IndicesAnalyzeParameters prefer_local(bool value)
        {
            SetValue("prefer_local", value.ToString().ToLower());
            return this;
        }

        ///<summary>Format of the output</summary>
        ///<param name="value"><para>Options: detailed,text</para><para>Default: detailed</para></param>
        public virtual IndicesAnalyzeParameters format(string value)
        {
            SetValue("format", value);
            return this;
        }

        ///<summary>Pretty format the returned JSON response.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual IndicesAnalyzeParameters pretty(bool value)
        {
            SetValue("pretty", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return human readable values for statistics.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual IndicesAnalyzeParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Include the stack trace of returned errors.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual IndicesAnalyzeParameters error_trace(bool value)
        {
            SetValue("error_trace", value.ToString().ToLower());
            return this;
        }

        ///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
        ///<param name="value"></param>
        public virtual IndicesAnalyzeParameters source(string value)
        {
            SetValue("source", value);
            return this;
        }

        ///<summary>A comma-separated list of filters used to reduce the respone.</summary>
        ///<param name="value"></param>
        public virtual IndicesAnalyzeParameters filter_path(string value)
        {
            SetValue("filter_path", value);
            return this;
        }
    }
}