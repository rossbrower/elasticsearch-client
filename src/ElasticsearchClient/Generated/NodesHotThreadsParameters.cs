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
    
    
    public class NodesHotThreadsParameters : Parameters
    {
        
        /// <summary>The interval for the second sampling of threads</summary>
        /// <param name="value"></param>
        public virtual NodesHotThreadsParameters interval(string value)
        {
            this.SetValue("interval", value);
            return this;
        }
        
        /// <summary>Number of samples of thread stacktrace (default: 10)</summary>
        /// <param name="value"></param>
        public virtual NodesHotThreadsParameters snapshots(long value)
        {
            this.SetValue("snapshots", value);
            return this;
        }
        
        /// <summary>Specify the number of threads to provide information for (default: 3)</summary>
        /// <param name="value"></param>
        public virtual NodesHotThreadsParameters threads(long value)
        {
            this.SetValue("threads", value);
            return this;
        }
        
        /// <summary>Don't show threads that are in known-idle places, such as waiting on a socket select or pulling from an empty task queue (default: true)</summary>
        /// <param name="value"></param>
        public virtual NodesHotThreadsParameters ignore_idle_threads(bool value)
        {
            this.SetValue("ignore_idle_threads", value);
            return this;
        }
        
        /// <summary>The type to sample (default: cpu)</summary>
        /// <param name="value"><para>Options: cpu,wait,block</para></param>
        public virtual NodesHotThreadsParameters type(string value)
        {
            this.SetValue("type", value);
            return this;
        }
        
        /// <summary>Explicit operation timeout</summary>
        /// <param name="value"></param>
        public virtual NodesHotThreadsParameters timeout(string value)
        {
            this.SetValue("timeout", value);
            return this;
        }
    }
}
