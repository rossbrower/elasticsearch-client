namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/modules-snapshots.html"/></summary>
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