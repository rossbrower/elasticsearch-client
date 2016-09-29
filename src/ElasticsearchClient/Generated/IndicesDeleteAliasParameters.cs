namespace Elasticsearch.Client
{
    public class IndicesDeleteAliasParameters : Parameters
    {
        ///<summary>Explicit timestamp for the document</summary>
        ///<param name="value"></param>
        public virtual IndicesDeleteAliasParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }

        ///<summary>Specify timeout for connection to master</summary>
        ///<param name="value"></param>
        public virtual IndicesDeleteAliasParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }
    }
}