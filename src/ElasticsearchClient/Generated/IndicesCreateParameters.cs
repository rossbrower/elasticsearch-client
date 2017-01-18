namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-create-index.html"/></summary>
    public class IndicesCreateParameters : Parameters
    {
        ///<summary>Explicit operation timeout</summary>
        ///<param name="value"></param>
        public virtual IndicesCreateParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }

        ///<summary>Specify timeout for connection to master</summary>
        ///<param name="value"></param>
        public virtual IndicesCreateParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }

        ///<summary>Whether to update the mapping for all fields with the same name across all types or not</summary>
        ///<param name="value"></param>
        public virtual IndicesCreateParameters update_all_types(bool value)
        {
            SetValue("update_all_types", value.ToString().ToLower());
            return this;
        }
    }
}