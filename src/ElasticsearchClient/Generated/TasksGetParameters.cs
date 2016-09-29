namespace Elasticsearch.Client
{
    public class TasksGetParameters : Parameters
    {
        ///<summary>Wait for the matching tasks to complete (default: false)</summary>
        ///<param name="value"></param>
        public virtual TasksGetParameters wait_for_completion(bool value)
        {
            SetValue("wait_for_completion", value.ToString().ToLower());
            return this;
        }
    }
}