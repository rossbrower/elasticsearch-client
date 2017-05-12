namespace Elasticsearch.Client
{
    ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-bulk.html"/></summary>
    public class BulkParameters : Parameters
    {
        ///<summary>Sets the number of shard copies that must be active before proceeding with the bulk operation. Defaults to 1, meaning the primary shard only. Set to `all` for all shard copies, otherwise set to any non-negative value less than or equal to the total number of copies for the shard (number of replicas + 1)</summary>
        ///<param name="value"></param>
        public virtual BulkParameters wait_for_active_shards(string value)
        {
            SetValue("wait_for_active_shards", value);
            return this;
        }

        ///<summary>If `true` then refresh the effected shards to make this operation visible to search, if `wait_for` then wait for a refresh to make this operation visible to search, if `false` (the default) then do nothing with refreshes.</summary>
        ///<param name="value"><para>Options: true,false,wait_for</para></param>
        public virtual BulkParameters refresh(string value)
        {
            SetValue("refresh", value);
            return this;
        }

        ///<summary>Specific routing value</summary>
        ///<param name="value"></param>
        public virtual BulkParameters routing(string value)
        {
            SetValue("routing", value);
            return this;
        }

        ///<summary>Explicit operation timeout</summary>
        ///<param name="value"></param>
        public virtual BulkParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }

        ///<summary>Default document type for items which don't provide one</summary>
        ///<param name="value"></param>
        public virtual BulkParameters type(string value)
        {
            SetValue("type", value);
            return this;
        }

        ///<summary>Default comma-separated list of fields to return in the response for updates, can be overridden on each sub-request</summary>
        ///<param name="value"></param>
        public virtual BulkParameters fields(string value)
        {
            SetValue("fields", value);
            return this;
        }

        ///<summary>True or false to return the _source field or not, or default list of fields to return, can be overridden on each sub-request</summary>
        ///<param name="value"></param>
        public virtual BulkParameters _source(string value)
        {
            SetValue("_source", value);
            return this;
        }

        ///<summary>Default list of fields to exclude from the returned _source field, can be overridden on each sub-request</summary>
        ///<param name="value"></param>
        public virtual BulkParameters _source_exclude(string value)
        {
            SetValue("_source_exclude", value);
            return this;
        }

        ///<summary>Default list of fields to extract and return from the _source field, can be overridden on each sub-request</summary>
        ///<param name="value"></param>
        public virtual BulkParameters _source_include(string value)
        {
            SetValue("_source_include", value);
            return this;
        }

        ///<summary>The pipeline id to preprocess incoming documents with</summary>
        ///<param name="value"></param>
        public virtual BulkParameters pipeline(string value)
        {
            SetValue("pipeline", value);
            return this;
        }

        ///<summary>Pretty format the returned JSON response.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual BulkParameters pretty(bool value)
        {
            SetValue("pretty", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return human readable values for statistics.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual BulkParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Include the stack trace of returned errors.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual BulkParameters error_trace(bool value)
        {
            SetValue("error_trace", value.ToString().ToLower());
            return this;
        }

        ///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
        ///<param name="value"></param>
        public virtual BulkParameters source(string value)
        {
            SetValue("source", value);
            return this;
        }

        ///<summary>A comma-separated list of filters used to reduce the respone.</summary>
        ///<param name="value"></param>
        public virtual BulkParameters filter_path(string value)
        {
            SetValue("filter_path", value);
            return this;
        }
    }
}