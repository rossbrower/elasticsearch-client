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
    
    
    public class ClusterRerouteParameters : Parameters
    {
        
        /// <summary>Simulate the operation only and return the resulting state</summary>
        /// <param name="value"></param>
        public virtual ClusterRerouteParameters dry_run(bool value)
        {
            this.SetValue("dry_run", value);
            return this;
        }
        
        /// <summary>Return an explanation of why the commands can or cannot be executed</summary>
        /// <param name="value"></param>
        public virtual ClusterRerouteParameters explain(bool value)
        {
            this.SetValue("explain", value);
            return this;
        }
        
        /// <summary>Limit the information returned to the specified metrics. Defaults to all but metadata</summary>
        /// <param name="value"><para>Options: _all,blocks,metadata,nodes,routing_table,master_node,version</para></param>
        public virtual ClusterRerouteParameters metric(string value)
        {
            this.SetValue("metric", value);
            return this;
        }
        
        /// <summary>Explicit operation timeout for connection to master node</summary>
        /// <param name="value"></param>
        public virtual ClusterRerouteParameters master_timeout(string value)
        {
            this.SetValue("master_timeout", value);
            return this;
        }
        
        /// <summary>Explicit operation timeout</summary>
        /// <param name="value"></param>
        public virtual ClusterRerouteParameters timeout(string value)
        {
            this.SetValue("timeout", value);
            return this;
        }
    }
}
