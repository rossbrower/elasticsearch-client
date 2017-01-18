namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-delete-by-query.html"/></summary>
    public class DeleteByQueryParameters : Parameters
    {
        ///<summary>The analyzer to use for the query string</summary>
        ///<param name="value"></param>
        public virtual DeleteByQueryParameters analyzer(string value)
        {
            SetValue("analyzer", value);
            return this;
        }

        ///<summary>Specify whether wildcard and prefix queries should be analyzed (default: false)</summary>
        ///<param name="value"></param>
        public virtual DeleteByQueryParameters analyze_wildcard(bool value)
        {
            SetValue("analyze_wildcard", value.ToString().ToLower());
            return this;
        }

        ///<summary>The default operator for query string query (AND or OR)</summary>
        ///<param name="value"><para>Options: AND,OR</para><para>Default: OR</para></param>
        public virtual DeleteByQueryParameters default_operator(string value)
        {
            SetValue("default_operator", value);
            return this;
        }

        ///<summary>The field to use as default where no field prefix is given in the query string</summary>
        ///<param name="value"></param>
        public virtual DeleteByQueryParameters df(string value)
        {
            SetValue("df", value);
            return this;
        }

        ///<summary>Starting offset (default: 0)</summary>
        ///<param name="value"></param>
        public virtual DeleteByQueryParameters from(long value)
        {
            SetValue("from", value);
            return this;
        }

        ///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
        ///<param name="value"></param>
        public virtual DeleteByQueryParameters ignore_unavailable(bool value)
        {
            SetValue("ignore_unavailable", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have been specified)</summary>
        ///<param name="value"></param>
        public virtual DeleteByQueryParameters allow_no_indices(bool value)
        {
            SetValue("allow_no_indices", value.ToString().ToLower());
            return this;
        }

        ///<summary>What to do when the delete-by-query hits version conflicts?</summary>
        ///<param name="value"><para>Options: abort,proceed</para><para>Default: abort</para></param>
        public virtual DeleteByQueryParameters conflicts(string value)
        {
            SetValue("conflicts", value);
            return this;
        }

        ///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
        ///<param name="value"><para>Options: open,closed,none,all</para><para>Default: open</para></param>
        public virtual DeleteByQueryParameters expand_wildcards(string value)
        {
            SetValue("expand_wildcards", value);
            return this;
        }

        ///<summary>Specify whether format-based query failures (such as providing text to a numeric field) should be ignored</summary>
        ///<param name="value"></param>
        public virtual DeleteByQueryParameters lenient(bool value)
        {
            SetValue("lenient", value.ToString().ToLower());
            return this;
        }

        ///<summary>Specify the node or shard the operation should be performed on (default: random)</summary>
        ///<param name="value"></param>
        public virtual DeleteByQueryParameters preference(string value)
        {
            SetValue("preference", value);
            return this;
        }

        ///<summary>Query in the Lucene query string syntax</summary>
        ///<param name="value"></param>
        public virtual DeleteByQueryParameters q(string value)
        {
            SetValue("q", value);
            return this;
        }

        ///<summary>A comma-separated list of specific routing values</summary>
        ///<param name="value"></param>
        public virtual DeleteByQueryParameters routing(string value)
        {
            SetValue("routing", value);
            return this;
        }

        ///<summary>Specify how long a consistent view of the index should be maintained for scrolled search</summary>
        ///<param name="value"></param>
        public virtual DeleteByQueryParameters scroll(string value)
        {
            SetValue("scroll", value);
            return this;
        }

        ///<summary>Search operation type</summary>
        ///<param name="value"><para>Options: query_then_fetch,dfs_query_then_fetch</para></param>
        public virtual DeleteByQueryParameters search_type(string value)
        {
            SetValue("search_type", value);
            return this;
        }

        ///<summary>Explicit timeout for each search request. Defaults to no timeout.</summary>
        ///<param name="value"></param>
        public virtual DeleteByQueryParameters search_timeout(string value)
        {
            SetValue("search_timeout", value);
            return this;
        }

        ///<summary>Number of hits to return (default: 10)</summary>
        ///<param name="value"></param>
        public virtual DeleteByQueryParameters size(long value)
        {
            SetValue("size", value);
            return this;
        }

        ///<summary>A comma-separated list of &lt;field&gt;:&lt;direction&gt; pairs</summary>
        ///<param name="value"></param>
        public virtual DeleteByQueryParameters sort(string value)
        {
            SetValue("sort", value);
            return this;
        }

        ///<summary>True or false to return the _source field or not, or a list of fields to return</summary>
        ///<param name="value"></param>
        public virtual DeleteByQueryParameters _source(string value)
        {
            SetValue("_source", value);
            return this;
        }

        ///<summary>A list of fields to exclude from the returned _source field</summary>
        ///<param name="value"></param>
        public virtual DeleteByQueryParameters _source_exclude(string value)
        {
            SetValue("_source_exclude", value);
            return this;
        }

        ///<summary>A list of fields to extract and return from the _source field</summary>
        ///<param name="value"></param>
        public virtual DeleteByQueryParameters _source_include(string value)
        {
            SetValue("_source_include", value);
            return this;
        }

        ///<summary>The maximum number of documents to collect for each shard, upon reaching which the query execution will terminate early.</summary>
        ///<param name="value"></param>
        public virtual DeleteByQueryParameters terminate_after(long value)
        {
            SetValue("terminate_after", value);
            return this;
        }

        ///<summary>Specific 'tag' of the request for logging and statistical purposes</summary>
        ///<param name="value"></param>
        public virtual DeleteByQueryParameters stats(string value)
        {
            SetValue("stats", value);
            return this;
        }

        ///<summary>Specify whether to return document version as part of a hit</summary>
        ///<param name="value"></param>
        public virtual DeleteByQueryParameters version(bool value)
        {
            SetValue("version", value.ToString().ToLower());
            return this;
        }

        ///<summary>Specify if request cache should be used for this request or not, defaults to index level setting</summary>
        ///<param name="value"></param>
        public virtual DeleteByQueryParameters request_cache(bool value)
        {
            SetValue("request_cache", value.ToString().ToLower());
            return this;
        }

        ///<summary>Should the effected indexes be refreshed?</summary>
        ///<param name="value"></param>
        public virtual DeleteByQueryParameters refresh(bool value)
        {
            SetValue("refresh", value.ToString().ToLower());
            return this;
        }

        ///<summary>Time each individual bulk request should wait for shards that are unavailable.</summary>
        ///<param name="value"><para>Default: 1m</para></param>
        public virtual DeleteByQueryParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }

        ///<summary>Sets the number of shard copies that must be active before proceeding with the delete by query operation. Defaults to 1, meaning the primary shard only. Set to `all` for all shard copies, otherwise set to any non-negative value less than or equal to the total number of copies for the shard (number of replicas + 1)</summary>
        ///<param name="value"></param>
        public virtual DeleteByQueryParameters wait_for_active_shards(string value)
        {
            SetValue("wait_for_active_shards", value);
            return this;
        }

        ///<summary>Size on the scroll request powering the update_by_query</summary>
        ///<param name="value"></param>
        public virtual DeleteByQueryParameters scroll_size(long value)
        {
            SetValue("scroll_size", value);
            return this;
        }

        ///<summary>Should the request should block until the delete-by-query is complete.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual DeleteByQueryParameters wait_for_completion(bool value)
        {
            SetValue("wait_for_completion", value.ToString().ToLower());
            return this;
        }

        ///<summary>The throttle for this request in sub-requests per second. -1 means no throttle.</summary>
        ///<param name="value"><para>Default: 0</para></param>
        public virtual DeleteByQueryParameters requests_per_second(long value)
        {
            SetValue("requests_per_second", value);
            return this;
        }

        ///<summary>The number of slices this task should be divided into. Defaults to 1 meaning the task isn't sliced into subtasks.</summary>
        ///<param name="value"><para>Default: 1</para></param>
        public virtual DeleteByQueryParameters slices(int value)
        {
            SetValue("slices", value);
            return this;
        }
    }
}