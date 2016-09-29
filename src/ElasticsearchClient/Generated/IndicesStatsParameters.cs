namespace Elasticsearch.Client
{
    public class IndicesStatsParameters : Parameters
    {
        ///<summary>A comma-separated list of fields for `fielddata` and `suggest` index metric (supports wildcards)</summary>
        ///<param name="value"></param>
        public virtual IndicesStatsParameters completion_fields(string value)
        {
            SetValue("completion_fields", value);
            return this;
        }

        ///<summary>A comma-separated list of fields for `fielddata` index metric (supports wildcards)</summary>
        ///<param name="value"></param>
        public virtual IndicesStatsParameters fielddata_fields(string value)
        {
            SetValue("fielddata_fields", value);
            return this;
        }

        ///<summary>A comma-separated list of fields for `fielddata` and `completion` index metric (supports wildcards)</summary>
        ///<param name="value"></param>
        public virtual IndicesStatsParameters fields(string value)
        {
            SetValue("fields", value);
            return this;
        }

        ///<summary>A comma-separated list of search groups for `search` index metric</summary>
        ///<param name="value"></param>
        public virtual IndicesStatsParameters groups(string value)
        {
            SetValue("groups", value);
            return this;
        }

        ///<summary>Whether to return time and byte values in human-readable format.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual IndicesStatsParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return stats aggregated at cluster, index or shard level</summary>
        ///<param name="value"><para>Options: cluster,indices,shards</para><para>Default: indices</para></param>
        public virtual IndicesStatsParameters level(string value)
        {
            SetValue("level", value);
            return this;
        }

        ///<summary>A comma-separated list of document types for the `indexing` index metric</summary>
        ///<param name="value"></param>
        public virtual IndicesStatsParameters types(string value)
        {
            SetValue("types", value);
            return this;
        }
    }
}