namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-delete-index.html"/></summary>
    public class IndicesDeleteParameters : Parameters
    {
        ///<summary>Explicit operation timeout</summary>
        ///<param name="value"></param>
        public virtual IndicesDeleteParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }

        ///<summary>Specify timeout for connection to master</summary>
        ///<param name="value"></param>
        public virtual IndicesDeleteParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }
    }
}