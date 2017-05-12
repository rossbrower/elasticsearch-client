namespace Elasticsearch.Client
{
    ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-stats.html"/></summary>
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

        ///<summary>Whether to report the aggregated disk usage of each one of the Lucene index files (only applies if segment stats are requested)</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual IndicesStatsParameters include_segment_file_sizes(bool value)
        {
            SetValue("include_segment_file_sizes", value.ToString().ToLower());
            return this;
        }

        ///<summary>Pretty format the returned JSON response.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual IndicesStatsParameters pretty(bool value)
        {
            SetValue("pretty", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return human readable values for statistics.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual IndicesStatsParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Include the stack trace of returned errors.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual IndicesStatsParameters error_trace(bool value)
        {
            SetValue("error_trace", value.ToString().ToLower());
            return this;
        }

        ///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
        ///<param name="value"></param>
        public virtual IndicesStatsParameters source(string value)
        {
            SetValue("source", value);
            return this;
        }

        ///<summary>A comma-separated list of filters used to reduce the respone.</summary>
        ///<param name="value"></param>
        public virtual IndicesStatsParameters filter_path(string value)
        {
            SetValue("filter_path", value);
            return this;
        }
    }
}