namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/search-template.html"/></summary>
    public class SearchTemplateParameters : Parameters
    {
        ///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
        ///<param name="value"></param>
        public virtual SearchTemplateParameters ignore_unavailable(bool value)
        {
            SetValue("ignore_unavailable", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have been specified)</summary>
        ///<param name="value"></param>
        public virtual SearchTemplateParameters allow_no_indices(bool value)
        {
            SetValue("allow_no_indices", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
        ///<param name="value"><para>Options: open,closed,none,all</para><para>Default: open</para></param>
        public virtual SearchTemplateParameters expand_wildcards(string value)
        {
            SetValue("expand_wildcards", value);
            return this;
        }

        ///<summary>Specify the node or shard the operation should be performed on (default: random)</summary>
        ///<param name="value"></param>
        public virtual SearchTemplateParameters preference(string value)
        {
            SetValue("preference", value);
            return this;
        }

        ///<summary>A comma-separated list of specific routing values</summary>
        ///<param name="value"></param>
        public virtual SearchTemplateParameters routing(string value)
        {
            SetValue("routing", value);
            return this;
        }

        ///<summary>Specify how long a consistent view of the index should be maintained for scrolled search</summary>
        ///<param name="value"></param>
        public virtual SearchTemplateParameters scroll(string value)
        {
            SetValue("scroll", value);
            return this;
        }

        ///<summary>Search operation type</summary>
        ///<param name="value"><para>Options: query_then_fetch,query_and_fetch,dfs_query_then_fetch,dfs_query_and_fetch</para></param>
        public virtual SearchTemplateParameters search_type(string value)
        {
            SetValue("search_type", value);
            return this;
        }

        ///<summary>Specify whether to return detailed information about score computation as part of a hit</summary>
        ///<param name="value"></param>
        public virtual SearchTemplateParameters explain(bool value)
        {
            SetValue("explain", value.ToString().ToLower());
            return this;
        }

        ///<summary>Specify whether to profile the query execution</summary>
        ///<param name="value"></param>
        public virtual SearchTemplateParameters profile(bool value)
        {
            SetValue("profile", value.ToString().ToLower());
            return this;
        }

        ///<summary>Specify whether aggregation and suggester names should be prefixed by their respective types in the response</summary>
        ///<param name="value"></param>
        public virtual SearchTemplateParameters typed_keys(bool value)
        {
            SetValue("typed_keys", value.ToString().ToLower());
            return this;
        }

        ///<summary>Pretty format the returned JSON response.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual SearchTemplateParameters pretty(bool value)
        {
            SetValue("pretty", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return human readable values for statistics.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual SearchTemplateParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Include the stack trace of returned errors.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual SearchTemplateParameters error_trace(bool value)
        {
            SetValue("error_trace", value.ToString().ToLower());
            return this;
        }

        ///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
        ///<param name="value"></param>
        public virtual SearchTemplateParameters source(string value)
        {
            SetValue("source", value);
            return this;
        }

        ///<summary>A comma-separated list of filters used to reduce the respone.</summary>
        ///<param name="value"></param>
        public virtual SearchTemplateParameters filter_path(string value)
        {
            SetValue("filter_path", value);
            return this;
        }
    }
}