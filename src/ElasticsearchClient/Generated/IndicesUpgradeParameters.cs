namespace Elasticsearch.Client
{
    ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-upgrade.html"/></summary>
    public class IndicesUpgradeParameters : Parameters
    {
        ///<summary>Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have been specified)</summary>
        ///<param name="value"></param>
        public virtual IndicesUpgradeParameters allow_no_indices(bool value)
        {
            SetValue("allow_no_indices", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
        ///<param name="value"><para>Options: open,closed,none,all</para><para>Default: open</para></param>
        public virtual IndicesUpgradeParameters expand_wildcards(string value)
        {
            SetValue("expand_wildcards", value);
            return this;
        }

        ///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
        ///<param name="value"></param>
        public virtual IndicesUpgradeParameters ignore_unavailable(bool value)
        {
            SetValue("ignore_unavailable", value.ToString().ToLower());
            return this;
        }

        ///<summary>Specify whether the request should block until the all segments are upgraded (default: false)</summary>
        ///<param name="value"></param>
        public virtual IndicesUpgradeParameters wait_for_completion(bool value)
        {
            SetValue("wait_for_completion", value.ToString().ToLower());
            return this;
        }

        ///<summary>If true, only ancient (an older Lucene major release) segments will be upgraded</summary>
        ///<param name="value"></param>
        public virtual IndicesUpgradeParameters only_ancient_segments(bool value)
        {
            SetValue("only_ancient_segments", value.ToString().ToLower());
            return this;
        }

        ///<summary>Pretty format the returned JSON response.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual IndicesUpgradeParameters pretty(bool value)
        {
            SetValue("pretty", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return human readable values for statistics.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual IndicesUpgradeParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Include the stack trace of returned errors.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual IndicesUpgradeParameters error_trace(bool value)
        {
            SetValue("error_trace", value.ToString().ToLower());
            return this;
        }

        ///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
        ///<param name="value"></param>
        public virtual IndicesUpgradeParameters source(string value)
        {
            SetValue("source", value);
            return this;
        }

        ///<summary>A comma-separated list of filters used to reduce the respone.</summary>
        ///<param name="value"></param>
        public virtual IndicesUpgradeParameters filter_path(string value)
        {
            SetValue("filter_path", value);
            return this;
        }
    }
}