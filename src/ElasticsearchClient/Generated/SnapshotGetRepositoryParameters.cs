namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/modules-snapshots.html"/></summary>
    public class SnapshotGetRepositoryParameters : Parameters
    {
        ///<summary>Explicit operation timeout for connection to master node</summary>
        ///<param name="value"></param>
        public virtual SnapshotGetRepositoryParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }

        ///<summary>Return local information, do not retrieve the state from master node (default: false)</summary>
        ///<param name="value"></param>
        public virtual SnapshotGetRepositoryParameters local(bool value)
        {
            SetValue("local", value.ToString().ToLower());
            return this;
        }
    }
}