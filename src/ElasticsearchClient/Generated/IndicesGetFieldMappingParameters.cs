namespace Elasticsearch.Client
{
    ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-field-mapping.html"/></summary>
    public class IndicesGetFieldMappingParameters : Parameters
    {
        ///<summary>Whether the default mapping values should be returned as well</summary>
        ///<param name="value"></param>
        public virtual IndicesGetFieldMappingParameters include_defaults(bool value)
        {
            SetValue("include_defaults", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
        ///<param name="value"></param>
        public virtual IndicesGetFieldMappingParameters ignore_unavailable(bool value)
        {
            SetValue("ignore_unavailable", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have been specified)</summary>
        ///<param name="value"></param>
        public virtual IndicesGetFieldMappingParameters allow_no_indices(bool value)
        {
            SetValue("allow_no_indices", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
        ///<param name="value"><para>Options: open,closed,none,all</para><para>Default: open</para></param>
        public virtual IndicesGetFieldMappingParameters expand_wildcards(string value)
        {
            SetValue("expand_wildcards", value);
            return this;
        }

        ///<summary>Return local information, do not retrieve the state from master node (default: false)</summary>
        ///<param name="value"></param>
        public virtual IndicesGetFieldMappingParameters local(bool value)
        {
            SetValue("local", value.ToString().ToLower());
            return this;
        }

        ///<summary>Pretty format the returned JSON response.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual IndicesGetFieldMappingParameters pretty(bool value)
        {
            SetValue("pretty", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return human readable values for statistics.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual IndicesGetFieldMappingParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Include the stack trace of returned errors.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual IndicesGetFieldMappingParameters error_trace(bool value)
        {
            SetValue("error_trace", value.ToString().ToLower());
            return this;
        }

        ///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
        ///<param name="value"></param>
        public virtual IndicesGetFieldMappingParameters source(string value)
        {
            SetValue("source", value);
            return this;
        }

        ///<summary>A comma-separated list of filters used to reduce the respone.</summary>
        ///<param name="value"></param>
        public virtual IndicesGetFieldMappingParameters filter_path(string value)
        {
            SetValue("filter_path", value);
            return this;
        }
    }
}