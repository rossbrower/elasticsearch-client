namespace Elasticsearch.Client
{
    public class IndicesDeleteTemplateParameters : Parameters
    {
        ///<summary>Explicit operation timeout</summary>
        ///<param name="value"></param>
        public virtual IndicesDeleteTemplateParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }

        ///<summary>Specify timeout for connection to master</summary>
        ///<param name="value"></param>
        public virtual IndicesDeleteTemplateParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }
    }
}