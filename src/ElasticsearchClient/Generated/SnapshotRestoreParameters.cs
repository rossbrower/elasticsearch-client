namespace Elasticsearch.Client
{
    public class SnapshotRestoreParameters : Parameters
    {
        ///<summary>Explicit operation timeout for connection to master node</summary>
        ///<param name="value"></param>
        public virtual SnapshotRestoreParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }

        ///<summary>Should this request wait until the operation has completed before returning</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual SnapshotRestoreParameters wait_for_completion(bool value)
        {
            SetValue("wait_for_completion", value.ToString().ToLower());
            return this;
        }
    }
}