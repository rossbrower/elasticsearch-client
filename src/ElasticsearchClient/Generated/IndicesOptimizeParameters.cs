namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-optimize.html"/></summary>
    public class IndicesOptimizeParameters : Parameters
    {
        ///<summary>Specify whether the index should be flushed after performing the operation (default: true)</summary>
        ///<param name="value"></param>
        public virtual IndicesOptimizeParameters flush(bool value)
        {
            SetValue("flush", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
        ///<param name="value"></param>
        public virtual IndicesOptimizeParameters ignore_unavailable(bool value)
        {
            SetValue("ignore_unavailable", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have been specified)</summary>
        ///<param name="value"></param>
        public virtual IndicesOptimizeParameters allow_no_indices(bool value)
        {
            SetValue("allow_no_indices", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
        ///<param name="value"><para>Options: open,closed,none,all</para><para>Default: open</para></param>
        public virtual IndicesOptimizeParameters expand_wildcards(string value)
        {
            SetValue("expand_wildcards", value);
            return this;
        }

        ///<summary>The number of segments the index should be merged into (default: dynamic)</summary>
        ///<param name="value"></param>
        public virtual IndicesOptimizeParameters max_num_segments(long value)
        {
            SetValue("max_num_segments", value);
            return this;
        }

        ///<summary>Specify whether the operation should only expunge deleted documents</summary>
        ///<param name="value"></param>
        public virtual IndicesOptimizeParameters only_expunge_deletes(bool value)
        {
            SetValue("only_expunge_deletes", value.ToString().ToLower());
            return this;
        }

        ///<summary>Specify whether the request should block until the merge process is finished (default: true)</summary>
        ///<param name="value"></param>
        public virtual IndicesOptimizeParameters wait_for_merge(bool value)
        {
            SetValue("wait_for_merge", value.ToString().ToLower());
            return this;
        }
    }
}