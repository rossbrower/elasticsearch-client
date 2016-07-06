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
    
    
    public class CatTasksParameters : Parameters
    {
        
        /// <summary>a short version of the Accept header, e.g. json, yaml</summary>
        /// <param name="value"></param>
        public virtual CatTasksParameters format(string value)
        {
            this.SetValue("format", value);
            return this;
        }
        
        /// <summary>A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're connecting to, leave empty to get information from all nodes</summary>
        /// <param name="value"></param>
        public virtual CatTasksParameters node_id(string value)
        {
            this.SetValue("node_id", value);
            return this;
        }
        
        /// <summary>A comma-separated list of actions that should be returned. Leave empty to return all.</summary>
        /// <param name="value"></param>
        public virtual CatTasksParameters actions(string value)
        {
            this.SetValue("actions", value);
            return this;
        }
        
        /// <summary>Return detailed task information (default: false)</summary>
        /// <param name="value"></param>
        public virtual CatTasksParameters detailed(bool value)
        {
            this.SetValue("detailed", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>Return tasks with specified parent node.</summary>
        /// <param name="value"></param>
        public virtual CatTasksParameters parent_node(string value)
        {
            this.SetValue("parent_node", value);
            return this;
        }
        
        /// <summary>Return tasks with specified parent task id. Set to -1 to return all.</summary>
        /// <param name="value"></param>
        public virtual CatTasksParameters parent_task(long value)
        {
            this.SetValue("parent_task", value);
            return this;
        }
        
        /// <summary>Comma-separated list of column names to display</summary>
        /// <param name="value"></param>
        public virtual CatTasksParameters h(string value)
        {
            this.SetValue("h", value);
            return this;
        }
        
        /// <summary>Return help information</summary>
        /// <param name="value"><para>Default: False</para></param>
        public virtual CatTasksParameters help(bool value)
        {
            this.SetValue("help", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>Verbose mode. Display column headers</summary>
        /// <param name="value"><para>Default: False</para></param>
        public virtual CatTasksParameters v(bool value)
        {
            this.SetValue("v", value.ToString().ToLower());
            return this;
        }
    }
}