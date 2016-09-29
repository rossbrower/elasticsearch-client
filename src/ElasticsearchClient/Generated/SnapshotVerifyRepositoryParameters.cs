namespace Elasticsearch.Client
{
    public class SnapshotVerifyRepositoryParameters : Parameters
    {
        ///<summary>Explicit operation timeout for connection to master node</summary>
        ///<param name="value"></param>
        public virtual SnapshotVerifyRepositoryParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }

        ///<summary>Explicit operation timeout</summary>
        ///<param name="value"></param>
        public virtual SnapshotVerifyRepositoryParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }
    }
}