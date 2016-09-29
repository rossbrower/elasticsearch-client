namespace Elasticsearch.Client
{
    public class ClusterPendingTasksParameters : Parameters
    {
        ///<summary>Return local information, do not retrieve the state from master node (default: false)</summary>
        ///<param name="value"></param>
        public virtual ClusterPendingTasksParameters local(bool value)
        {
            SetValue("local", value.ToString().ToLower());
            return this;
        }

        ///<summary>Specify timeout for connection to master</summary>
        ///<param name="value"></param>
        public virtual ClusterPendingTasksParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }
    }
}