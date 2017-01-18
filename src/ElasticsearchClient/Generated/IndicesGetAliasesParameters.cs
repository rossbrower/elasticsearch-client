namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-aliases.html"/></summary>
    public class IndicesGetAliasesParameters : Parameters
    {
        ///<summary>Explicit operation timeout</summary>
        ///<param name="value"></param>
        public virtual IndicesGetAliasesParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }

        ///<summary>Return local information, do not retrieve the state from master node (default: false)</summary>
        ///<param name="value"></param>
        public virtual IndicesGetAliasesParameters local(bool value)
        {
            SetValue("local", value.ToString().ToLower());
            return this;
        }
    }
}