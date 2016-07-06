//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Elasticsearch.Client
{
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    
    
    public class DeleteByQueryParameters : Parameters
    {
        
        /// <summary>The analyzer to use for the query string</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters analyzer(string value)
        {
            this.SetValue("analyzer", value);
            return this;
        }
        
        /// <summary>Specify whether wildcard and prefix queries should be analyzed (default: false)</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters analyze_wildcard(bool value)
        {
            this.SetValue("analyze_wildcard", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>The default operator for query string query (AND or OR)</summary>
        /// <param name="value"><para>Options: AND,OR</para><para>Default: OR</para></param>
        public virtual DeleteByQueryParameters default_operator(string value)
        {
            this.SetValue("default_operator", value);
            return this;
        }
        
        /// <summary>The field to use as default where no field prefix is given in the query string</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters df(string value)
        {
            this.SetValue("df", value);
            return this;
        }
        
        /// <summary>Specify whether to return detailed information about score computation as part of a hit</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters explain(bool value)
        {
            this.SetValue("explain", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>A comma-separated list of fields to return as part of a hit</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters fields(string value)
        {
            this.SetValue("fields", value);
            return this;
        }
        
        /// <summary>A comma-separated list of fields to return as the field data representation of a field for each hit</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters fielddata_fields(string value)
        {
            this.SetValue("fielddata_fields", value);
            return this;
        }
        
        /// <summary>Starting offset (default: 0)</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters from(long value)
        {
            this.SetValue("from", value);
            return this;
        }
        
        /// <summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters ignore_unavailable(bool value)
        {
            this.SetValue("ignore_unavailable", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have been specified)</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters allow_no_indices(bool value)
        {
            this.SetValue("allow_no_indices", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>What to do when the delete-by-query hits version conflicts?</summary>
        /// <param name="value"><para>Options: abort,proceed</para><para>Default: abort</para></param>
        public virtual DeleteByQueryParameters conflicts(string value)
        {
            this.SetValue("conflicts", value);
            return this;
        }
        
        /// <summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
        /// <param name="value"><para>Options: open,closed,none,all</para><para>Default: open</para></param>
        public virtual DeleteByQueryParameters expand_wildcards(string value)
        {
            this.SetValue("expand_wildcards", value);
            return this;
        }
        
        /// <summary>Specify whether format-based query failures (such as providing text to a numeric field) should be ignored</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters lenient(bool value)
        {
            this.SetValue("lenient", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>Specify whether query terms should be lowercased</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters lowercase_expanded_terms(bool value)
        {
            this.SetValue("lowercase_expanded_terms", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>Specify the node or shard the operation should be performed on (default: random)</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters preference(string value)
        {
            this.SetValue("preference", value);
            return this;
        }
        
        /// <summary>Query in the Lucene query string syntax</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters q(string value)
        {
            this.SetValue("q", value);
            return this;
        }
        
        /// <summary>A comma-separated list of specific routing values</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters routing(string value)
        {
            this.SetValue("routing", value);
            return this;
        }
        
        /// <summary>Specify how long a consistent view of the index should be maintained for scrolled search</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters scroll(string value)
        {
            this.SetValue("scroll", value);
            return this;
        }
        
        /// <summary>Search operation type</summary>
        /// <param name="value"><para>Options: query_then_fetch,dfs_query_then_fetch</para></param>
        public virtual DeleteByQueryParameters search_type(string value)
        {
            this.SetValue("search_type", value);
            return this;
        }
        
        /// <summary>Explicit timeout for each search request. Defaults to no timeout.</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters search_timeout(string value)
        {
            this.SetValue("search_timeout", value);
            return this;
        }
        
        /// <summary>Number of hits to return (default: 10)</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters size(long value)
        {
            this.SetValue("size", value);
            return this;
        }
        
        /// <summary>A comma-separated list of <field>:<direction> pairs</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters sort(string value)
        {
            this.SetValue("sort", value);
            return this;
        }
        
        /// <summary>True or false to return the _source field or not, or a list of fields to return</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters _source(string value)
        {
            this.SetValue("_source", value);
            return this;
        }
        
        /// <summary>A list of fields to exclude from the returned _source field</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters _source_exclude(string value)
        {
            this.SetValue("_source_exclude", value);
            return this;
        }
        
        /// <summary>A list of fields to extract and return from the _source field</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters _source_include(string value)
        {
            this.SetValue("_source_include", value);
            return this;
        }
        
        /// <summary>The maximum number of documents to collect for each shard, upon reaching which the query execution will terminate early.</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters terminate_after(long value)
        {
            this.SetValue("terminate_after", value);
            return this;
        }
        
        /// <summary>Specific 'tag' of the request for logging and statistical purposes</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters stats(string value)
        {
            this.SetValue("stats", value);
            return this;
        }
        
        /// <summary>Specify which field to use for suggestions</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters suggest_field(string value)
        {
            this.SetValue("suggest_field", value);
            return this;
        }
        
        /// <summary>Specify suggest mode</summary>
        /// <param name="value"><para>Options: missing,popular,always</para><para>Default: missing</para></param>
        public virtual DeleteByQueryParameters suggest_mode(string value)
        {
            this.SetValue("suggest_mode", value);
            return this;
        }
        
        /// <summary>How many suggestions to return in response</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters suggest_size(long value)
        {
            this.SetValue("suggest_size", value);
            return this;
        }
        
        /// <summary>The source text for which the suggestions should be returned</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters suggest_text(string value)
        {
            this.SetValue("suggest_text", value);
            return this;
        }
        
        /// <summary>Time each individual bulk request should wait for shards that are unavailable.</summary>
        /// <param name="value"><para>Default: 1m</para></param>
        public virtual DeleteByQueryParameters timeout(string value)
        {
            this.SetValue("timeout", value);
            return this;
        }
        
        /// <summary>Whether to calculate and return scores even if they are not used for sorting</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters track_scores(bool value)
        {
            this.SetValue("track_scores", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>Specify whether to return document version as part of a hit</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters version(bool value)
        {
            this.SetValue("version", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>Specify if request cache should be used for this request or not, defaults to index level setting</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters request_cache(bool value)
        {
            this.SetValue("request_cache", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>Should the effected indexes be refreshed?</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters refresh(bool value)
        {
            this.SetValue("refresh", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>Explicit write consistency setting for the operation</summary>
        /// <param name="value"><para>Options: one,quorum,all</para></param>
        public virtual DeleteByQueryParameters consistency(string value)
        {
            this.SetValue("consistency", value);
            return this;
        }
        
        /// <summary>Size on the scroll request powering the update_by_query</summary>
        /// <param name="value"></param>
        public virtual DeleteByQueryParameters scroll_size(int value)
        {
            this.SetValue("scroll_size", value);
            return this;
        }
        
        /// <summary>Should the request should block until the delete-by-query is complete.</summary>
        /// <param name="value"><para>Default: False</para></param>
        public virtual DeleteByQueryParameters wait_for_completion(bool value)
        {
            this.SetValue("wait_for_completion", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>The throttle for this request in sub-requests per second. 0 means set no throttle.</summary>
        /// <param name="value"><para>Default: 0</para></param>
        public virtual DeleteByQueryParameters requests_per_second(double value)
        {
            this.SetValue("requests_per_second", value);
            return this;
        }
    }
}