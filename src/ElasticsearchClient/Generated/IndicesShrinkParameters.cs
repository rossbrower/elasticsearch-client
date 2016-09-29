namespace Elasticsearch.Client
{
    public class IndicesShrinkParameters : Parameters
    {
        ///<summary>Explicit operation timeout</summary>
        ///<param name="value"></param>
        public virtual IndicesShrinkParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }

        ///<summary>Specify timeout for connection to master</summary>
        ///<param name="value"></param>
        public virtual IndicesShrinkParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }

        ///<summary>Set the number of active shards to wait for on the shrunken index before the operation returns.</summary>
        ///<param name="value"></param>
        public virtual IndicesShrinkParameters wait_for_active_shards(string value)
        {
            SetValue("wait_for_active_shards", value);
            return this;
        }
    }
}