namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/indices-clearcache.html"/></summary>
    public class IndicesClearCacheParameters : Parameters
    {
        ///<summary>Clear field data</summary>
        ///<param name="value"></param>
        public virtual IndicesClearCacheParameters field_data(bool value)
        {
            SetValue("field_data", value.ToString().ToLower());
            return this;
        }

        ///<summary>Clear field data</summary>
        ///<param name="value"></param>
        public virtual IndicesClearCacheParameters fielddata(bool value)
        {
            SetValue("fielddata", value.ToString().ToLower());
            return this;
        }

        ///<summary>A comma-separated list of fields to clear when using the `field_data` parameter (default: all)</summary>
        ///<param name="value"></param>
        public virtual IndicesClearCacheParameters fields(string value)
        {
            SetValue("fields", value);
            return this;
        }

        ///<summary>Clear query caches</summary>
        ///<param name="value"></param>
        public virtual IndicesClearCacheParameters query(bool value)
        {
            SetValue("query", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
        ///<param name="value"></param>
        public virtual IndicesClearCacheParameters ignore_unavailable(bool value)
        {
            SetValue("ignore_unavailable", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have been specified)</summary>
        ///<param name="value"></param>
        public virtual IndicesClearCacheParameters allow_no_indices(bool value)
        {
            SetValue("allow_no_indices", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
        ///<param name="value"><para>Options: open,closed,none,all</para><para>Default: open</para></param>
        public virtual IndicesClearCacheParameters expand_wildcards(string value)
        {
            SetValue("expand_wildcards", value);
            return this;
        }

        ///<summary>A comma-separated list of index name to limit the operation</summary>
        ///<param name="value"></param>
        public virtual IndicesClearCacheParameters index(string value)
        {
            SetValue("index", value);
            return this;
        }

        ///<summary>Clear the recycler cache</summary>
        ///<param name="value"></param>
        public virtual IndicesClearCacheParameters recycler(bool value)
        {
            SetValue("recycler", value.ToString().ToLower());
            return this;
        }

        ///<summary>Clear request cache</summary>
        ///<param name="value"></param>
        public virtual IndicesClearCacheParameters request(bool value)
        {
            SetValue("request", value.ToString().ToLower());
            return this;
        }

        ///<summary>Pretty format the returned JSON response.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual IndicesClearCacheParameters pretty(bool value)
        {
            SetValue("pretty", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return human readable values for statistics.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual IndicesClearCacheParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Include the stack trace of returned errors.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual IndicesClearCacheParameters error_trace(bool value)
        {
            SetValue("error_trace", value.ToString().ToLower());
            return this;
        }

        ///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
        ///<param name="value"></param>
        public virtual IndicesClearCacheParameters source(string value)
        {
            SetValue("source", value);
            return this;
        }

        ///<summary>A comma-separated list of filters used to reduce the respone.</summary>
        ///<param name="value"></param>
        public virtual IndicesClearCacheParameters filter_path(string value)
        {
            SetValue("filter_path", value);
            return this;
        }
    }
}