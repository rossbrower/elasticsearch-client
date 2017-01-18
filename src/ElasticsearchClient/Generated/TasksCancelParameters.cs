namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/tasks.html#_task_cancellation"/></summary>
    public class TasksCancelParameters : Parameters
    {
        ///<summary>A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</summary>
        ///<param name="value"></param>
        public virtual TasksCancelParameters node_id(string value)
        {
            SetValue("node_id", value);
            return this;
        }

        ///<summary>A comma-separated list of actions that should be cancelled. Leave empty to cancel all.</summary>
        ///<param name="value"></param>
        public virtual TasksCancelParameters actions(string value)
        {
            SetValue("actions", value);
            return this;
        }

        ///<summary>Cancel tasks with specified parent node.</summary>
        ///<param name="value"></param>
        public virtual TasksCancelParameters parent_node(string value)
        {
            SetValue("parent_node", value);
            return this;
        }

        ///<summary>Cancel tasks with specified parent task id (node_id:task_number). Set to -1 to cancel all.</summary>
        ///<param name="value"></param>
        public virtual TasksCancelParameters parent_task(string value)
        {
            SetValue("parent_task", value);
            return this;
        }
    }
}