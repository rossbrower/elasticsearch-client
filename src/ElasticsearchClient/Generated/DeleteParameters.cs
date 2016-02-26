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
    
    
    public class DeleteParameters : Parameters
    {
        
        /// <summary>Specific write consistency setting for the operation</summary>
        /// <param name="value"><para>Options: one,quorum,all</para></param>
        public virtual DeleteParameters consistency(string value)
        {
            this.SetValue("consistency", value);
            return this;
        }
        
        /// <summary>ID of parent document</summary>
        /// <param name="value"></param>
        public virtual DeleteParameters parent(string value)
        {
            this.SetValue("parent", value);
            return this;
        }
        
        /// <summary>Refresh the index after performing the operation</summary>
        /// <param name="value"></param>
        public virtual DeleteParameters refresh(bool value)
        {
            this.SetValue("refresh", value);
            return this;
        }
        
        /// <summary>Specific routing value</summary>
        /// <param name="value"></param>
        public virtual DeleteParameters routing(string value)
        {
            this.SetValue("routing", value);
            return this;
        }
        
        /// <summary>Explicit operation timeout</summary>
        /// <param name="value"></param>
        public virtual DeleteParameters timeout(string value)
        {
            this.SetValue("timeout", value);
            return this;
        }
        
        /// <summary>Explicit version number for concurrency control</summary>
        /// <param name="value"></param>
        public virtual DeleteParameters version(long value)
        {
            this.SetValue("version", value);
            return this;
        }
        
        /// <summary>Specific version type</summary>
        /// <param name="value"><para>Options: internal,external,external_gte,force</para></param>
        public virtual DeleteParameters version_type(string value)
        {
            this.SetValue("version_type", value);
            return this;
        }
    }
}
