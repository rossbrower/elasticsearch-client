namespace Elasticsearch.Client
{
    ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-search.html"/></summary>
    public class SearchParameters : Parameters
    {
        ///<summary>The analyzer to use for the query string</summary>
        ///<param name="value"></param>
        public virtual SearchParameters analyzer(string value)
        {
            SetValue("analyzer", value);
            return this;
        }

        ///<summary>Specify whether wildcard and prefix queries should be analyzed (default: false)</summary>
        ///<param name="value"></param>
        public virtual SearchParameters analyze_wildcard(bool value)
        {
            SetValue("analyze_wildcard", value.ToString().ToLower());
            return this;
        }

        ///<summary>The default operator for query string query (AND or OR)</summary>
        ///<param name="value"><para>Options: AND,OR</para><para>Default: OR</para></param>
        public virtual SearchParameters default_operator(string value)
        {
            SetValue("default_operator", value);
            return this;
        }

        ///<summary>The field to use as default where no field prefix is given in the query string</summary>
        ///<param name="value"></param>
        public virtual SearchParameters df(string value)
        {
            SetValue("df", value);
            return this;
        }

        ///<summary>Specify whether to return detailed information about score computation as part of a hit</summary>
        ///<param name="value"></param>
        public virtual SearchParameters explain(bool value)
        {
            SetValue("explain", value.ToString().ToLower());
            return this;
        }

        ///<summary>A comma-separated list of stored fields to return as part of a hit</summary>
        ///<param name="value"></param>
        public virtual SearchParameters stored_fields(string value)
        {
            SetValue("stored_fields", value);
            return this;
        }

        ///<summary>A comma-separated list of fields to return as the docvalue representation of a field for each hit</summary>
        ///<param name="value"></param>
        public virtual SearchParameters docvalue_fields(string value)
        {
            SetValue("docvalue_fields", value);
            return this;
        }

        ///<summary>Starting offset (default: 0)</summary>
        ///<param name="value"></param>
        public virtual SearchParameters from(long value)
        {
            SetValue("from", value);
            return this;
        }

        ///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
        ///<param name="value"></param>
        public virtual SearchParameters ignore_unavailable(bool value)
        {
            SetValue("ignore_unavailable", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have been specified)</summary>
        ///<param name="value"></param>
        public virtual SearchParameters allow_no_indices(bool value)
        {
            SetValue("allow_no_indices", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
        ///<param name="value"><para>Options: open,closed,none,all</para><para>Default: open</para></param>
        public virtual SearchParameters expand_wildcards(string value)
        {
            SetValue("expand_wildcards", value);
            return this;
        }

        ///<summary>Specify whether format-based query failures (such as providing text to a numeric field) should be ignored</summary>
        ///<param name="value"></param>
        public virtual SearchParameters lenient(bool value)
        {
            SetValue("lenient", value.ToString().ToLower());
            return this;
        }

        ///<summary>Specify the node or shard the operation should be performed on (default: random)</summary>
        ///<param name="value"></param>
        public virtual SearchParameters preference(string value)
        {
            SetValue("preference", value);
            return this;
        }

        ///<summary>Query in the Lucene query string syntax</summary>
        ///<param name="value"></param>
        public virtual SearchParameters q(string value)
        {
            SetValue("q", value);
            return this;
        }

        ///<summary>A comma-separated list of specific routing values</summary>
        ///<param name="value"></param>
        public virtual SearchParameters routing(string value)
        {
            SetValue("routing", value);
            return this;
        }

        ///<summary>Specify how long a consistent view of the index should be maintained for scrolled search</summary>
        ///<param name="value"></param>
        public virtual SearchParameters scroll(string value)
        {
            SetValue("scroll", value);
            return this;
        }

        ///<summary>Search operation type</summary>
        ///<param name="value"><para>Options: query_then_fetch,dfs_query_then_fetch</para></param>
        public virtual SearchParameters search_type(string value)
        {
            SetValue("search_type", value);
            return this;
        }

        ///<summary>Number of hits to return (default: 10)</summary>
        ///<param name="value"></param>
        public virtual SearchParameters size(long value)
        {
            SetValue("size", value);
            return this;
        }

        ///<summary>A comma-separated list of &lt;field&gt;:&lt;direction&gt; pairs</summary>
        ///<param name="value"></param>
        public virtual SearchParameters sort(string value)
        {
            SetValue("sort", value);
            return this;
        }

        ///<summary>True or false to return the _source field or not, or a list of fields to return</summary>
        ///<param name="value"></param>
        public virtual SearchParameters _source(string value)
        {
            SetValue("_source", value);
            return this;
        }

        ///<summary>A list of fields to exclude from the returned _source field</summary>
        ///<param name="value"></param>
        public virtual SearchParameters _source_exclude(string value)
        {
            SetValue("_source_exclude", value);
            return this;
        }

        ///<summary>A list of fields to extract and return from the _source field</summary>
        ///<param name="value"></param>
        public virtual SearchParameters _source_include(string value)
        {
            SetValue("_source_include", value);
            return this;
        }

        ///<summary>The maximum number of documents to collect for each shard, upon reaching which the query execution will terminate early.</summary>
        ///<param name="value"></param>
        public virtual SearchParameters terminate_after(long value)
        {
            SetValue("terminate_after", value);
            return this;
        }

        ///<summary>Specific 'tag' of the request for logging and statistical purposes</summary>
        ///<param name="value"></param>
        public virtual SearchParameters stats(string value)
        {
            SetValue("stats", value);
            return this;
        }

        ///<summary>Specify which field to use for suggestions</summary>
        ///<param name="value"></param>
        public virtual SearchParameters suggest_field(string value)
        {
            SetValue("suggest_field", value);
            return this;
        }

        ///<summary>Specify suggest mode</summary>
        ///<param name="value"><para>Options: missing,popular,always</para><para>Default: missing</para></param>
        public virtual SearchParameters suggest_mode(string value)
        {
            SetValue("suggest_mode", value);
            return this;
        }

        ///<summary>How many suggestions to return in response</summary>
        ///<param name="value"></param>
        public virtual SearchParameters suggest_size(long value)
        {
            SetValue("suggest_size", value);
            return this;
        }

        ///<summary>The source text for which the suggestions should be returned</summary>
        ///<param name="value"></param>
        public virtual SearchParameters suggest_text(string value)
        {
            SetValue("suggest_text", value);
            return this;
        }

        ///<summary>Explicit operation timeout</summary>
        ///<param name="value"></param>
        public virtual SearchParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }

        ///<summary>Whether to calculate and return scores even if they are not used for sorting</summary>
        ///<param name="value"></param>
        public virtual SearchParameters track_scores(bool value)
        {
            SetValue("track_scores", value.ToString().ToLower());
            return this;
        }

        ///<summary>Indicate if the number of documents that match the query should be tracked</summary>
        ///<param name="value"></param>
        public virtual SearchParameters track_total_hits(bool value)
        {
            SetValue("track_total_hits", value.ToString().ToLower());
            return this;
        }

        ///<summary>Specify whether aggregation and suggester names should be prefixed by their respective types in the response</summary>
        ///<param name="value"></param>
        public virtual SearchParameters typed_keys(bool value)
        {
            SetValue("typed_keys", value.ToString().ToLower());
            return this;
        }

        ///<summary>Specify whether to return document version as part of a hit</summary>
        ///<param name="value"></param>
        public virtual SearchParameters version(bool value)
        {
            SetValue("version", value.ToString().ToLower());
            return this;
        }

        ///<summary>Specify if request cache should be used for this request or not, defaults to index level setting</summary>
        ///<param name="value"></param>
        public virtual SearchParameters request_cache(bool value)
        {
            SetValue("request_cache", value.ToString().ToLower());
            return this;
        }

        ///<summary>The number of shard results that should be reduced at once on the coordinating node. This value should be used as a protection mechanism to reduce the memory overhead per search request if the potential number of shards in the request can be large.</summary>
        ///<param name="value"><para>Default: 512</para></param>
        public virtual SearchParameters batched_reduce_size(long value)
        {
            SetValue("batched_reduce_size", value);
            return this;
        }

        ///<summary>The number of concurrent shard requests this search executes concurrently. This value should be used to limit the impact of the search on the cluster in order to limit the number of concurrent shard requests</summary>
        ///<param name="value"><para>Default: The default grows with the number of nodes in the cluster but is at most 256.</para></param>
        public virtual SearchParameters max_concurrent_shard_requests(long value)
        {
            SetValue("max_concurrent_shard_requests", value);
            return this;
        }

        ///<summary>A threshold that enforces a pre-filter roundtrip to prefilter search shards based on query rewriting if the number of shards the search request expands to exceeds the threshold. This filter roundtrip can limit the number of shards significantly if for instance a shard can not match any documents based on it's rewrite method ie. if date filters are mandatory to match but the shard bounds and the query are disjoint.</summary>
        ///<param name="value"><para>Default: 128</para></param>
        public virtual SearchParameters pre_filter_shard_size(long value)
        {
            SetValue("pre_filter_shard_size", value);
            return this;
        }

        ///<summary>Pretty format the returned JSON response.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual SearchParameters pretty(bool value)
        {
            SetValue("pretty", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return human readable values for statistics.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual SearchParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Include the stack trace of returned errors.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual SearchParameters error_trace(bool value)
        {
            SetValue("error_trace", value.ToString().ToLower());
            return this;
        }

        ///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
        ///<param name="value"></param>
        public virtual SearchParameters source(string value)
        {
            SetValue("source", value);
            return this;
        }

        ///<summary>A comma-separated list of filters used to reduce the respone.</summary>
        ///<param name="value"></param>
        public virtual SearchParameters filter_path(string value)
        {
            SetValue("filter_path", value);
            return this;
        }
    }
}