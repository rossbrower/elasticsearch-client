namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-percolate.html"/></summary>
    public class PercolateParameters : Parameters
    {
        ///<summary>A comma-separated list of specific routing values</summary>
        ///<param name="value"></param>
        public virtual PercolateParameters routing(string value)
        {
            SetValue("routing", value);
            return this;
        }

        ///<summary>Specify the node or shard the operation should be performed on (default: random)</summary>
        ///<param name="value"></param>
        public virtual PercolateParameters preference(string value)
        {
            SetValue("preference", value);
            return this;
        }

        ///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
        ///<param name="value"></param>
        public virtual PercolateParameters ignore_unavailable(bool value)
        {
            SetValue("ignore_unavailable", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have been specified)</summary>
        ///<param name="value"></param>
        public virtual PercolateParameters allow_no_indices(bool value)
        {
            SetValue("allow_no_indices", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
        ///<param name="value"><para>Options: open,closed,none,all</para><para>Default: open</para></param>
        public virtual PercolateParameters expand_wildcards(string value)
        {
            SetValue("expand_wildcards", value);
            return this;
        }

        ///<summary>The index to percolate the document into. Defaults to index.</summary>
        ///<param name="value"></param>
        public virtual PercolateParameters percolate_index(string value)
        {
            SetValue("percolate_index", value);
            return this;
        }

        ///<summary>The type to percolate document into. Defaults to type.</summary>
        ///<param name="value"></param>
        public virtual PercolateParameters percolate_type(string value)
        {
            SetValue("percolate_type", value);
            return this;
        }

        ///<summary>The routing value to use when percolating the existing document.</summary>
        ///<param name="value"></param>
        public virtual PercolateParameters percolate_routing(string value)
        {
            SetValue("percolate_routing", value);
            return this;
        }

        ///<summary>Which shard to prefer when executing the percolate request.</summary>
        ///<param name="value"></param>
        public virtual PercolateParameters percolate_preference(string value)
        {
            SetValue("percolate_preference", value);
            return this;
        }

        ///<summary>Return an array of matching query IDs instead of objects</summary>
        ///<param name="value"><para>Options: ids</para></param>
        public virtual PercolateParameters percolate_format(string value)
        {
            SetValue("percolate_format", value);
            return this;
        }

        ///<summary>Explicit version number for concurrency control</summary>
        ///<param name="value"></param>
        public virtual PercolateParameters version(long value)
        {
            SetValue("version", value);
            return this;
        }

        ///<summary>Specific version type</summary>
        ///<param name="value"><para>Options: internal,external,external_gte,force</para></param>
        public virtual PercolateParameters version_type(string value)
        {
            SetValue("version_type", value);
            return this;
        }

        ///<summary>Pretty format the returned JSON response.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual PercolateParameters pretty(bool value)
        {
            SetValue("pretty", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return human readable values for statistics.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual PercolateParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Include the stack trace of returned errors.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual PercolateParameters error_trace(bool value)
        {
            SetValue("error_trace", value.ToString().ToLower());
            return this;
        }

        ///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
        ///<param name="value"></param>
        public virtual PercolateParameters source(string value)
        {
            SetValue("source", value);
            return this;
        }

        ///<summary>A comma-separated list of filters used to reduce the respone.</summary>
        ///<param name="value"></param>
        public virtual PercolateParameters filter_path(string value)
        {
            SetValue("filter_path", value);
            return this;
        }
    }
}