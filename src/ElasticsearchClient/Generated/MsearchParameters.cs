namespace Elasticsearch.Client
{
    ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-multi-search.html"/></summary>
    public class MsearchParameters : Parameters
    {
        ///<summary>Search operation type</summary>
        ///<param name="value"><para>Options: query_then_fetch,query_and_fetch,dfs_query_then_fetch,dfs_query_and_fetch</para></param>
        public virtual MsearchParameters search_type(string value)
        {
            SetValue("search_type", value);
            return this;
        }

        ///<summary>Controls the maximum number of concurrent searches the multi search api will execute</summary>
        ///<param name="value"></param>
        public virtual MsearchParameters max_concurrent_searches(long value)
        {
            SetValue("max_concurrent_searches", value);
            return this;
        }

        ///<summary>Specify whether aggregation and suggester names should be prefixed by their respective types in the response</summary>
        ///<param name="value"></param>
        public virtual MsearchParameters typed_keys(bool value)
        {
            SetValue("typed_keys", value.ToString().ToLower());
            return this;
        }

        ///<summary>Pretty format the returned JSON response.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual MsearchParameters pretty(bool value)
        {
            SetValue("pretty", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return human readable values for statistics.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual MsearchParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Include the stack trace of returned errors.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual MsearchParameters error_trace(bool value)
        {
            SetValue("error_trace", value.ToString().ToLower());
            return this;
        }

        ///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
        ///<param name="value"></param>
        public virtual MsearchParameters source(string value)
        {
            SetValue("source", value);
            return this;
        }

        ///<summary>A comma-separated list of filters used to reduce the respone.</summary>
        ///<param name="value"></param>
        public virtual MsearchParameters filter_path(string value)
        {
            SetValue("filter_path", value);
            return this;
        }
    }
}