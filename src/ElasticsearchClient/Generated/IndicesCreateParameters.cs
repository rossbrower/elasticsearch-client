namespace Elasticsearch.Client
{
    public class IndicesCreateParameters : Parameters
    {
        ///<summary>Set the number of active shards to wait for before the operation returns.</summary>
        ///<param name="value"></param>
        public virtual IndicesCreateParameters wait_for_active_shards(string value)
        {
            SetValue("wait_for_active_shards", value);
            return this;
        }

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