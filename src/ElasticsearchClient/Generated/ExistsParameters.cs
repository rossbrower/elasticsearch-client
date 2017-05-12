namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-get.html"/></summary>
    public class ExistsParameters : Parameters
    {
        ///<summary>A comma-separated list of stored fields to return in the response</summary>
        ///<param name="value"></param>
        public virtual ExistsParameters stored_fields(string value)
        {
            SetValue("stored_fields", value);
            return this;
        }

        ///<summary>The ID of the parent document</summary>
        ///<param name="value"></param>
        public virtual ExistsParameters parent(string value)
        {
            SetValue("parent", value);
            return this;
        }

        ///<summary>Specify the node or shard the operation should be performed on (default: random)</summary>
        ///<param name="value"></param>
        public virtual ExistsParameters preference(string value)
        {
            SetValue("preference", value);
            return this;
        }

        ///<summary>Specify whether to perform the operation in realtime or search mode</summary>
        ///<param name="value"></param>
        public virtual ExistsParameters realtime(bool value)
        {
            SetValue("realtime", value.ToString().ToLower());
            return this;
        }

        ///<summary>Refresh the shard containing the document before performing the operation</summary>
        ///<param name="value"></param>
        public virtual ExistsParameters refresh(bool value)
        {
            SetValue("refresh", value.ToString().ToLower());
            return this;
        }

        ///<summary>Specific routing value</summary>
        ///<param name="value"></param>
        public virtual ExistsParameters routing(string value)
        {
            SetValue("routing", value);
            return this;
        }

        ///<summary>True or false to return the _source field or not, or a list of fields to return</summary>
        ///<param name="value"></param>
        public virtual ExistsParameters _source(string value)
        {
            SetValue("_source", value);
            return this;
        }

        ///<summary>A list of fields to exclude from the returned _source field</summary>
        ///<param name="value"></param>
        public virtual ExistsParameters _source_exclude(string value)
        {
            SetValue("_source_exclude", value);
            return this;
        }

        ///<summary>A list of fields to extract and return from the _source field</summary>
        ///<param name="value"></param>
        public virtual ExistsParameters _source_include(string value)
        {
            SetValue("_source_include", value);
            return this;
        }

        ///<summary>Explicit version number for concurrency control</summary>
        ///<param name="value"></param>
        public virtual ExistsParameters version(long value)
        {
            SetValue("version", value);
            return this;
        }

        ///<summary>Specific version type</summary>
        ///<param name="value"><para>Options: internal,external,external_gte,force</para></param>
        public virtual ExistsParameters version_type(string value)
        {
            SetValue("version_type", value);
            return this;
        }

        ///<summary>Pretty format the returned JSON response.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual ExistsParameters pretty(bool value)
        {
            SetValue("pretty", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return human readable values for statistics.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual ExistsParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Include the stack trace of returned errors.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual ExistsParameters error_trace(bool value)
        {
            SetValue("error_trace", value.ToString().ToLower());
            return this;
        }

        ///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
        ///<param name="value"></param>
        public virtual ExistsParameters source(string value)
        {
            SetValue("source", value);
            return this;
        }

        ///<summary>A comma-separated list of filters used to reduce the respone.</summary>
        ///<param name="value"></param>
        public virtual ExistsParameters filter_path(string value)
        {
            SetValue("filter_path", value);
            return this;
        }
    }
}