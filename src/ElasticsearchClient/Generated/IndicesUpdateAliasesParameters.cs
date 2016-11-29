namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/indices-aliases.html"/></summary>
    public class IndicesUpdateAliasesParameters : Parameters
    {
        ///<summary>Request timeout</summary>
        ///<param name="value"></param>
        public virtual IndicesUpdateAliasesParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }

        ///<summary>Specify timeout for connection to master</summary>
        ///<param name="value"></param>
        public virtual IndicesUpdateAliasesParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }
    }
}