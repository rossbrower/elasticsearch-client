namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/modules-snapshots.html"/></summary>
    public class SnapshotDeleteRepositoryParameters : Parameters
    {
        ///<summary>Explicit operation timeout for connection to master node</summary>
        ///<param name="value"></param>
        public virtual SnapshotDeleteRepositoryParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }

        ///<summary>Explicit operation timeout</summary>
        ///<param name="value"></param>
        public virtual SnapshotDeleteRepositoryParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }
    }
}