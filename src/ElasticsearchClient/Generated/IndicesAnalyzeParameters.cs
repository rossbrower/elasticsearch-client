namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/indices-analyze.html"/></summary>
    public class IndicesAnalyzeParameters : Parameters
    {
        ///<summary>The name of the analyzer to use</summary>
        ///<param name="value"></param>
        public virtual IndicesAnalyzeParameters analyzer(string value)
        {
            SetValue("analyzer", value);
            return this;
        }

        ///<summary>A comma-separated list of character filters to use for the analysis</summary>
        ///<param name="value"></param>
        public virtual IndicesAnalyzeParameters char_filter(string value)
        {
            SetValue("char_filter", value);
            return this;
        }

        ///<summary>Use the analyzer configured for this field (instead of passing the analyzer name)</summary>
        ///<param name="value"></param>
        public virtual IndicesAnalyzeParameters field(string value)
        {
            SetValue("field", value);
            return this;
        }

        ///<summary>A comma-separated list of filters to use for the analysis</summary>
        ///<param name="value"></param>
        public virtual IndicesAnalyzeParameters filter(string value)
        {
            SetValue("filter", value);
            return this;
        }

        ///<summary>The name of the index to scope the operation</summary>
        ///<param name="value"></param>
        public virtual IndicesAnalyzeParameters index(string value)
        {
            SetValue("index", value);
            return this;
        }

        ///<summary>With `true`, specify that a local shard should be used if available, with `false`, use a random shard (default: true)</summary>
        ///<param name="value"></param>
        public virtual IndicesAnalyzeParameters prefer_local(bool value)
        {
            SetValue("prefer_local", value.ToString().ToLower());
            return this;
        }

        ///<summary>The text on which the analysis should be performed (when request body is not used)</summary>
        ///<param name="value"></param>
        public virtual IndicesAnalyzeParameters text(string value)
        {
            SetValue("text", value);
            return this;
        }

        ///<summary>The name of the tokenizer to use for the analysis</summary>
        ///<param name="value"></param>
        public virtual IndicesAnalyzeParameters tokenizer(string value)
        {
            SetValue("tokenizer", value);
            return this;
        }

        ///<summary>With `true`, outputs more advanced details. (default: false)</summary>
        ///<param name="value"></param>
        public virtual IndicesAnalyzeParameters explain(bool value)
        {
            SetValue("explain", value.ToString().ToLower());
            return this;
        }

        ///<summary>A comma-separated list of token attributes to output, this parameter works only with `explain=true`</summary>
        ///<param name="value"></param>
        public virtual IndicesAnalyzeParameters attributes(string value)
        {
            SetValue("attributes", value);
            return this;
        }

        ///<summary>Format of the output</summary>
        ///<param name="value"><para>Options: detailed,text</para><para>Default: detailed</para></param>
        public virtual IndicesAnalyzeParameters format(string value)
        {
            SetValue("format", value);
            return this;
        }

        ///<summary>Pretty format the returned JSON response.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual IndicesAnalyzeParameters pretty(bool value)
        {
            SetValue("pretty", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return human readable values for statistics.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual IndicesAnalyzeParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Include the stack trace of returned errors.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual IndicesAnalyzeParameters error_trace(bool value)
        {
            SetValue("error_trace", value.ToString().ToLower());
            return this;
        }

        ///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
        ///<param name="value"></param>
        public virtual IndicesAnalyzeParameters source(string value)
        {
            SetValue("source", value);
            return this;
        }

        ///<summary>A comma-separated list of filters used to reduce the respone.</summary>
        ///<param name="value"></param>
        public virtual IndicesAnalyzeParameters filter_path(string value)
        {
            SetValue("filter_path", value);
            return this;
        }
    }
}