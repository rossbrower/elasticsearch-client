namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/modules-snapshots.html"/></summary>
    public class SnapshotDeleteParameters : Parameters
    {
        ///<summary>Explicit operation timeout for connection to master node</summary>
        ///<param name="value"></param>
        public virtual SnapshotDeleteParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }
    }
}