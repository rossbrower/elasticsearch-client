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
    
    
    public class BulkParameters : Parameters
    {
        
        /// <summary>Explicit write consistency setting for the operation</summary>
        /// <param name="value"><para>Options: one,quorum,all</para></param>
        public virtual BulkParameters consistency(string value)
        {
            this.SetValue("consistency", value);
            return this;
        }
        
        /// <summary>Refresh the index after performing the operation</summary>
        /// <param name="value"></param>
        public virtual BulkParameters refresh(bool value)
        {
            this.SetValue("refresh", value);
            return this;
        }
        
        /// <summary>Specific routing value</summary>
        /// <param name="value"></param>
        public virtual BulkParameters routing(string value)
        {
            this.SetValue("routing", value);
            return this;
        }
        
        /// <summary>Explicit operation timeout</summary>
        /// <param name="value"></param>
        public virtual BulkParameters timeout(string value)
        {
            this.SetValue("timeout", value);
            return this;
        }
        
        /// <summary>Default document type for items which don't provide one</summary>
        /// <param name="value"></param>
        public virtual BulkParameters type(string value)
        {
            this.SetValue("type", value);
            return this;
        }
        
        /// <summary>Default comma-separated list of fields to return in the response for updates</summary>
        /// <param name="value"></param>
        public virtual BulkParameters fields(string value)
        {
            this.SetValue("fields", value);
            return this;
        }
    }
}
