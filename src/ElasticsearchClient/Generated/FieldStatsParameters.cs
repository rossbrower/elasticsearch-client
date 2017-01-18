namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-field-stats.html"/></summary>
    public class FieldStatsParameters : Parameters
    {
        ///<summary>A comma-separated list of fields for to get field statistics for (min value, max value, and more)</summary>
        ///<param name="value"></param>
        public virtual FieldStatsParameters fields(string value)
        {
            SetValue("fields", value);
            return this;
        }

        ///<summary>Defines if field stats should be returned on a per index level or on a cluster wide level</summary>
        ///<param name="value"><para>Options: indices,cluster</para><para>Default: cluster</para></param>
        public virtual FieldStatsParameters level(string value)
        {
            SetValue("level", value);
            return this;
        }

        ///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
        ///<param name="value"></param>
        public virtual FieldStatsParameters ignore_unavailable(bool value)
        {
            SetValue("ignore_unavailable", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have been specified)</summary>
        ///<param name="value"></param>
        public virtual FieldStatsParameters allow_no_indices(bool value)
        {
            SetValue("allow_no_indices", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
        ///<param name="value"><para>Options: open,closed,none,all</para><para>Default: open</para></param>
        public virtual FieldStatsParameters expand_wildcards(string value)
        {
            SetValue("expand_wildcards", value);
            return this;
        }
    }
}