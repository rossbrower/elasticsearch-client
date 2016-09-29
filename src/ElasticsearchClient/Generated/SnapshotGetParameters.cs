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

        ///<summary>Whether to ignore unavailable snapshots, defaults to false which means a SnapshotMissingException is thrown</summary>
        ///<param name="value"></param>
        public virtual SnapshotGetParameters ignore_unavailable(bool value)
        {
            SetValue("ignore_unavailable", value.ToString().ToLower());
            return this;
        }
    }
}