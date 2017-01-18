namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-exists.html"/></summary>
    public class SearchExistsParameters : Parameters
    {
        ///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
        ///<param name="value"></param>
        public virtual SearchExistsParameters ignore_unavailable(bool value)
        {
            SetValue("ignore_unavailable", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have been specified)</summary>
        ///<param name="value"></param>
        public virtual SearchExistsParameters allow_no_indices(bool value)
        {
            SetValue("allow_no_indices", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
        ///<param name="value"><para>Options: open,closed,none,all</para><para>Default: open</para></param>
        public virtual SearchExistsParameters expand_wildcards(string value)
        {
            SetValue("expand_wildcards", value);
            return this;
        }

        ///<summary>Include only documents with a specific `_score` value in the result</summary>
        ///<param name="value"></param>
        public virtual SearchExistsParameters min_score(long value)
        {
            SetValue("min_score", value);
            return this;
        }

        ///<summary>Specify the node or shard the operation should be performed on (default: random)</summary>
        ///<param name="value"></param>
        public virtual SearchExistsParameters preference(string value)
        {
            SetValue("preference", value);
            return this;
        }

        ///<summary>Specific routing value</summary>
        ///<param name="value"></param>
        public virtual SearchExistsParameters routing(string value)
        {
            SetValue("routing", value);
            return this;
        }

        ///<summary>Query in the Lucene query string syntax</summary>
        ///<param name="value"></param>
        public virtual SearchExistsParameters q(string value)
        {
            SetValue("q", value);
            return this;
        }

        ///<summary>The analyzer to use for the query string</summary>
        ///<param name="value"></param>
        public virtual SearchExistsParameters analyzer(string value)
        {
            SetValue("analyzer", value);
            return this;
        }

        ///<summary>Specify whether wildcard and prefix queries should be analyzed (default: false)</summary>
        ///<param name="value"></param>
        public virtual SearchExistsParameters analyze_wildcard(bool value)
        {
            SetValue("analyze_wildcard", value.ToString().ToLower());
            return this;
        }

        ///<summary>The default operator for query string query (AND or OR)</summary>
        ///<param name="value"><para>Options: AND,OR</para><para>Default: OR</para></param>
        public virtual SearchExistsParameters default_operator(string value)
        {
            SetValue("default_operator", value);
            return this;
        }

        ///<summary>The field to use as default where no field prefix is given in the query string</summary>
        ///<param name="value"></param>
        public virtual SearchExistsParameters df(string value)
        {
            SetValue("df", value);
            return this;
        }

        ///<summary>Specify whether format-based query failures (such as providing text to a numeric field) should be ignored</summary>
        ///<param name="value"></param>
        public virtual SearchExistsParameters lenient(bool value)
        {
            SetValue("lenient", value.ToString().ToLower());
            return this;
        }

        ///<summary>Specify whether query terms should be lowercased</summary>
        ///<param name="value"></param>
        public virtual SearchExistsParameters lowercase_expanded_terms(bool value)
        {
            SetValue("lowercase_expanded_terms", value.ToString().ToLower());
            return this;
        }
    }
}