//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Elasticsearch.Client
{
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    
    
    public class TasksListParameters : Parameters
    {
        
        /// <summary>A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</summary>
        /// <param name="value"></param>
        public virtual TasksListParameters node_id(string value)
        {
            this.SetValue("node_id", value);
            return this;
        }
        
        /// <summary>A comma-separated list of actions that should be returned. Leave empty to return all.</summary>
        /// <param name="value"></param>
        public virtual TasksListParameters actions(string value)
        {
            this.SetValue("actions", value);
            return this;
        }
        
        /// <summary>Return detailed task information (default: false)</summary>
        /// <param name="value"></param>
        public virtual TasksListParameters detailed(bool value)
        {
            this.SetValue("detailed", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>Return tasks with specified parent node.</summary>
        /// <param name="value"></param>
        public virtual TasksListParameters parent_node(string value)
        {
            this.SetValue("parent_node", value);
            return this;
        }
        
        /// <summary>Return tasks with specified parent task id. Set to -1 to return all.</summary>
        /// <param name="value"></param>
        public virtual TasksListParameters parent_task(long value)
        {
            this.SetValue("parent_task", value);
            return this;
        }
        
        /// <summary>Wait for the matching tasks to complete (default: false)</summary>
        /// <param name="value"></param>
        public virtual TasksListParameters wait_for_completion(bool value)
        {
            this.SetValue("wait_for_completion", value.ToString().ToLower());
            return this;
        }
    }
}
