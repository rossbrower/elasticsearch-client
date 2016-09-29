namespace Elasticsearch.Client
{
    public class SnapshotGetParameters : Parameters
    {
        ///<summary>Explicit operation timeout for connection to master node</summary>
        ///<param name="value"></param>
        public virtual SnapshotGetParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }
    }
}