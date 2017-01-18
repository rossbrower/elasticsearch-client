namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/tasks.html"/></summary>
    public class TasksListParameters : Parameters
    {
        ///<summary>A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</summary>
        ///<param name="value"></param>
        public virtual TasksListParameters node_id(string value)
        {
            SetValue("node_id", value);
            return this;
        }

        ///<summary>A comma-separated list of actions that should be returned. Leave empty to return all.</summary>
        ///<param name="value"></param>
        public virtual TasksListParameters actions(string value)
        {
            SetValue("actions", value);
            return this;
        }

        ///<summary>Return detailed task information (default: false)</summary>
        ///<param name="value"></param>
        public virtual TasksListParameters detailed(bool value)
        {
            SetValue("detailed", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return tasks with specified parent node.</summary>
        ///<param name="value"></param>
        public virtual TasksListParameters parent_node(string value)
        {
            SetValue("parent_node", value);
            return this;
        }

        ///<summary>Return tasks with specified parent task id (node_id:task_number). Set to -1 to return all.</summary>
        ///<param name="value"></param>
        public virtual TasksListParameters parent_task(string value)
        {
            SetValue("parent_task", value);
            return this;
        }

        ///<summary>Wait for the matching tasks to complete (default: false)</summary>
        ///<param name="value"></param>
        public virtual TasksListParameters wait_for_completion(bool value)
        {
            SetValue("wait_for_completion", value.ToString().ToLower());
            return this;
        }
    }
}