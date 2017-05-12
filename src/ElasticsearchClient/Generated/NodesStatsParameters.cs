namespace Elasticsearch.Client
{
    ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-stats.html"/></summary>
    public class NodesStatsParameters : Parameters
    {
        ///<summary>A comma-separated list of fields for `fielddata` and `suggest` index metric (supports wildcards)</summary>
        ///<param name="value"></param>
        public virtual NodesStatsParameters completion_fields(string value)
        {
            SetValue("completion_fields", value);
            return this;
        }

        ///<summary>A comma-separated list of fields for `fielddata` index metric (supports wildcards)</summary>
        ///<param name="value"></param>
        public virtual NodesStatsParameters fielddata_fields(string value)
        {
            SetValue("fielddata_fields", value);
            return this;
        }

        ///<summary>A comma-separated list of fields for `fielddata` and `completion` index metric (supports wildcards)</summary>
        ///<param name="value"></param>
        public virtual NodesStatsParameters fields(string value)
        {
            SetValue("fields", value);
            return this;
        }

        ///<summary>A comma-separated list of search groups for `search` index metric</summary>
        ///<param name="value"></param>
        public virtual NodesStatsParameters groups(bool value)
        {
            SetValue("groups", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return indices stats aggregated at index, node or shard level</summary>
        ///<param name="value"><para>Options: indices,node,shards</para><para>Default: node</para></param>
        public virtual NodesStatsParameters level(string value)
        {
            SetValue("level", value);
            return this;
        }

        ///<summary>A comma-separated list of document types for the `indexing` index metric</summary>
        ///<param name="value"></param>
        public virtual NodesStatsParameters types(string value)
        {
            SetValue("types", value);
            return this;
        }

        ///<summary>Explicit operation timeout</summary>
        ///<param name="value"></param>
        public virtual NodesStatsParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }

        ///<summary>Whether to report the aggregated disk usage of each one of the Lucene index files (only applies if segment stats are requested)</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual NodesStatsParameters include_segment_file_sizes(bool value)
        {
            SetValue("include_segment_file_sizes", value.ToString().ToLower());
            return this;
        }

        ///<summary>Pretty format the returned JSON response.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual NodesStatsParameters pretty(bool value)
        {
            SetValue("pretty", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return human readable values for statistics.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual NodesStatsParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Include the stack trace of returned errors.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual NodesStatsParameters error_trace(bool value)
        {
            SetValue("error_trace", value.ToString().ToLower());
            return this;
        }

        ///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
        ///<param name="value"></param>
        public virtual NodesStatsParameters source(string value)
        {
            SetValue("source", value);
            return this;
        }

        ///<summary>A comma-separated list of filters used to reduce the respone.</summary>
        ///<param name="value"></param>
        public virtual NodesStatsParameters filter_path(string value)
        {
            SetValue("filter_path", value);
            return this;
        }
    }
}