namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-flush.html"/></summary>
    public class IndicesFlushParameters : Parameters
    {
        ///<summary>Whether a flush should be forced even if it is not necessarily needed ie. if no changes will be committed to the index. This is useful if transaction log IDs should be incremented even if no uncommitted changes are present. (This setting can be considered as internal)</summary>
        ///<param name="value"></param>
        public virtual IndicesFlushParameters force(bool value)
        {
            SetValue("force", value.ToString().ToLower());
            return this;
        }

        ///<summary>If set to true the flush operation will block until the flush can be executed if another flush operation is already executing. The default is false and will cause an exception to be thrown on the shard level if another flush operation is already running.</summary>
        ///<param name="value"></param>
        public virtual IndicesFlushParameters wait_if_ongoing(bool value)
        {
            SetValue("wait_if_ongoing", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
        ///<param name="value"></param>
        public virtual IndicesFlushParameters ignore_unavailable(bool value)
        {
            SetValue("ignore_unavailable", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have been specified)</summary>
        ///<param name="value"></param>
        public virtual IndicesFlushParameters allow_no_indices(bool value)
        {
            SetValue("allow_no_indices", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
        ///<param name="value"><para>Options: open,closed,none,all</para><para>Default: open</para></param>
        public virtual IndicesFlushParameters expand_wildcards(string value)
        {
            SetValue("expand_wildcards", value);
            return this;
        }
    }
}