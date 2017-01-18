namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-percolate.html"/></summary>
    public class CountPercolateParameters : Parameters
    {
        ///<summary>A comma-separated list of specific routing values</summary>
        ///<param name="value"></param>
        public virtual CountPercolateParameters routing(string value)
        {
            SetValue("routing", value);
            return this;
        }

        ///<summary>Specify the node or shard the operation should be performed on (default: random)</summary>
        ///<param name="value"></param>
        public virtual CountPercolateParameters preference(string value)
        {
            SetValue("preference", value);
            return this;
        }

        ///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
        ///<param name="value"></param>
        public virtual CountPercolateParameters ignore_unavailable(bool value)
        {
            SetValue("ignore_unavailable", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have been specified)</summary>
        ///<param name="value"></param>
        public virtual CountPercolateParameters allow_no_indices(bool value)
        {
            SetValue("allow_no_indices", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
        ///<param name="value"><para>Options: open,closed,none,all</para><para>Default: open</para></param>
        public virtual CountPercolateParameters expand_wildcards(string value)
        {
            SetValue("expand_wildcards", value);
            return this;
        }

        ///<summary>The index to count percolate the document into. Defaults to index.</summary>
        ///<param name="value"></param>
        public virtual CountPercolateParameters percolate_index(string value)
        {
            SetValue("percolate_index", value);
            return this;
        }

        ///<summary>The type to count percolate document into. Defaults to type.</summary>
        ///<param name="value"></param>
        public virtual CountPercolateParameters percolate_type(string value)
        {
            SetValue("percolate_type", value);
            return this;
        }

        ///<summary>Explicit version number for concurrency control</summary>
        ///<param name="value"></param>
        public virtual CountPercolateParameters version(long value)
        {
            SetValue("version", value);
            return this;
        }

        ///<summary>Specific version type</summary>
        ///<param name="value"><para>Options: internal,external,external_gte,force</para></param>
        public virtual CountPercolateParameters version_type(string value)
        {
            SetValue("version_type", value);
            return this;
        }
    }
}