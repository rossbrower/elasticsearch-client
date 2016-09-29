namespace Elasticsearch.Client
{
    public class IndicesRolloverParameters : Parameters
    {
        ///<summary>Explicit operation timeout</summary>
        ///<param name="value"></param>
        public virtual IndicesRolloverParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }

        ///<summary>Specify timeout for connection to master</summary>
        ///<param name="value"></param>
        public virtual IndicesRolloverParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }

        ///<summary>Set the number of active shards to wait for on the newly created rollover index before the operation returns.</summary>
        ///<param name="value"></param>
        public virtual IndicesRolloverParameters wait_for_active_shards(string value)
        {
            SetValue("wait_for_active_shards", value);
            return this;
        }
    }
}