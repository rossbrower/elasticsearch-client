namespace Elasticsearch.Client
{
    public class SnapshotStatusParameters : Parameters
    {
        ///<summary>Explicit operation timeout for connection to master node</summary>
        ///<param name="value"></param>
        public virtual SnapshotStatusParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }

        ///<summary>Whether to ignore unavailable snapshots, defaults to false which means a SnapshotMissingException is thrown</summary>
        ///<param name="value"></param>
        public virtual SnapshotStatusParameters ignore_unavailable(bool value)
        {
            SetValue("ignore_unavailable", value.ToString().ToLower());
            return this;
        }
    }
}