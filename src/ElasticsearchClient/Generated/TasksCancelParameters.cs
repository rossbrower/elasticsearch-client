namespace Elasticsearch.Client
{
    ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html"/></summary>
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

        ///<summary>Pretty format the returned JSON response.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual TasksCancelParameters pretty(bool value)
        {
            SetValue("pretty", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return human readable values for statistics.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual TasksCancelParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Include the stack trace of returned errors.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual TasksCancelParameters error_trace(bool value)
        {
            SetValue("error_trace", value.ToString().ToLower());
            return this;
        }

        ///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
        ///<param name="value"></param>
        public virtual TasksCancelParameters source(string value)
        {
            SetValue("source", value);
            return this;
        }

        ///<summary>A comma-separated list of filters used to reduce the respone.</summary>
        ///<param name="value"></param>
        public virtual TasksCancelParameters filter_path(string value)
        {
            SetValue("filter_path", value);
            return this;
        }
    }
}