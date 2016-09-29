namespace Elasticsearch.Client
{
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