namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/indices-upgrade.html"/></summary>
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
    }
}