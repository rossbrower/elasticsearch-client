namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
    public class IndicesPutWarmerParameters : Parameters
    {
        ///<summary>Specify timeout for connection to master</summary>
        ///<param name="value"></param>
        public virtual IndicesPutWarmerParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }

        ///<summary>Whether specified concrete indices should be ignored when unavailable (missing or closed) in the search request to warm</summary>
        ///<param name="value"></param>
        public virtual IndicesPutWarmerParameters ignore_unavailable(bool value)
        {
            SetValue("ignore_unavailable", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to ignore if a wildcard indices expression resolves into no concrete indices in the search request to warm. (This includes `_all` string or when no indices have been specified)</summary>
        ///<param name="value"></param>
        public virtual IndicesPutWarmerParameters allow_no_indices(bool value)
        {
            SetValue("allow_no_indices", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to expand wildcard expression to concrete indices that are open, closed or both, in the search request to warm.</summary>
        ///<param name="value"><para>Options: open,closed,none,all</para><para>Default: open</para></param>
        public virtual IndicesPutWarmerParameters expand_wildcards(string value)
        {
            SetValue("expand_wildcards", value);
            return this;
        }

        ///<summary>Specify whether the request to be warmed should use the request cache, defaults to index level setting</summary>
        ///<param name="value"></param>
        public virtual IndicesPutWarmerParameters request_cache(bool value)
        {
            SetValue("request_cache", value.ToString().ToLower());
            return this;
        }
    }
}