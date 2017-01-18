namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-aliases.html"/></summary>
    public class IndicesPutAliasParameters : Parameters
    {
        ///<summary>Explicit timestamp for the document</summary>
        ///<param name="value"></param>
        public virtual IndicesPutAliasParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }

        ///<summary>Specify timeout for connection to master</summary>
        ///<param name="value"></param>
        public virtual IndicesPutAliasParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }
    }
}