namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-validate.html"/></summary>
    public class IndicesValidateQueryParameters : Parameters
    {
        ///<summary>Return detailed information about the error</summary>
        ///<param name="value"></param>
        public virtual IndicesValidateQueryParameters explain(bool value)
        {
            SetValue("explain", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
        ///<param name="value"></param>
        public virtual IndicesValidateQueryParameters ignore_unavailable(bool value)
        {
            SetValue("ignore_unavailable", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have been specified)</summary>
        ///<param name="value"></param>
        public virtual IndicesValidateQueryParameters allow_no_indices(bool value)
        {
            SetValue("allow_no_indices", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
        ///<param name="value"><para>Options: open,closed,none,all</para><para>Default: open</para></param>
        public virtual IndicesValidateQueryParameters expand_wildcards(string value)
        {
            SetValue("expand_wildcards", value);
            return this;
        }

        ///<summary>Query in the Lucene query string syntax</summary>
        ///<param name="value"></param>
        public virtual IndicesValidateQueryParameters q(string value)
        {
            SetValue("q", value);
            return this;
        }

        ///<summary>The analyzer to use for the query string</summary>
        ///<param name="value"></param>
        public virtual IndicesValidateQueryParameters analyzer(string value)
        {
            SetValue("analyzer", value);
            return this;
        }

        ///<summary>Specify whether wildcard and prefix queries should be analyzed (default: false)</summary>
        ///<param name="value"></param>
        public virtual IndicesValidateQueryParameters analyze_wildcard(bool value)
        {
            SetValue("analyze_wildcard", value.ToString().ToLower());
            return this;
        }

        ///<summary>The default operator for query string query (AND or OR)</summary>
        ///<param name="value"><para>Options: AND,OR</para><para>Default: OR</para></param>
        public virtual IndicesValidateQueryParameters default_operator(string value)
        {
            SetValue("default_operator", value);
            return this;
        }

        ///<summary>The field to use as default where no field prefix is given in the query string</summary>
        ///<param name="value"></param>
        public virtual IndicesValidateQueryParameters df(string value)
        {
            SetValue("df", value);
            return this;
        }

        ///<summary>Specify whether format-based query failures (such as providing text to a numeric field) should be ignored</summary>
        ///<param name="value"></param>
        public virtual IndicesValidateQueryParameters lenient(bool value)
        {
            SetValue("lenient", value.ToString().ToLower());
            return this;
        }

        ///<summary>Provide a more detailed explanation showing the actual Lucene query that will be executed.</summary>
        ///<param name="value"></param>
        public virtual IndicesValidateQueryParameters rewrite(bool value)
        {
            SetValue("rewrite", value.ToString().ToLower());
            return this;
        }
    }
}