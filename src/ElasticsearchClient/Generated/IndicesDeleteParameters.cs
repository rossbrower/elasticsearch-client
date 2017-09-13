namespace Elasticsearch.Client
{
    ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-delete-index.html"/></summary>
    public class IndicesDeleteParameters : Parameters
    {
        ///<summary>Explicit operation timeout</summary>
        ///<param name="value"></param>
        public virtual IndicesDeleteParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }

        ///<summary>Specify timeout for connection to master</summary>
        ///<param name="value"></param>
        public virtual IndicesDeleteParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }

        ///<summary>Ignore unavailable indexes (default: false)</summary>
        ///<param name="value"></param>
        public virtual IndicesDeleteParameters ignore_unavailable(bool value)
        {
            SetValue("ignore_unavailable", value.ToString().ToLower());
            return this;
        }

        ///<summary>Ignore if a wildcard expression resolves to no concrete indices (default: false)</summary>
        ///<param name="value"></param>
        public virtual IndicesDeleteParameters allow_no_indices(bool value)
        {
            SetValue("allow_no_indices", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether wildcard expressions should get expanded to open or closed indices (default: open)</summary>
        ///<param name="value"><para>Options: open,closed,none,all</para><para>Default: open</para></param>
        public virtual IndicesDeleteParameters expand_wildcards(string value)
        {
            SetValue("expand_wildcards", value);
            return this;
        }

        ///<summary>Pretty format the returned JSON response.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual IndicesDeleteParameters pretty(bool value)
        {
            SetValue("pretty", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return human readable values for statistics.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual IndicesDeleteParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Include the stack trace of returned errors.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual IndicesDeleteParameters error_trace(bool value)
        {
            SetValue("error_trace", value.ToString().ToLower());
            return this;
        }

        ///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
        ///<param name="value"></param>
        public virtual IndicesDeleteParameters source(string value)
        {
            SetValue("source", value);
            return this;
        }

        ///<summary>A comma-separated list of filters used to reduce the respone.</summary>
        ///<param name="value"></param>
        public virtual IndicesDeleteParameters filter_path(string value)
        {
            SetValue("filter_path", value);
            return this;
        }
    }
}