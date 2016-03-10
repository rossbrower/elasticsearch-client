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
    
    
    public class UpdateParameters : Parameters
    {
        
        /// <summary>Explicit write consistency setting for the operation</summary>
        /// <param name="value"><para>Options: one,quorum,all</para></param>
        public virtual UpdateParameters consistency(string value)
        {
            this.SetValue("consistency", value);
            return this;
        }
        
        /// <summary>A comma-separated list of fields to return in the response</summary>
        /// <param name="value"></param>
        public virtual UpdateParameters fields(string value)
        {
            this.SetValue("fields", value);
            return this;
        }
        
        /// <summary>The script language (default: groovy)</summary>
        /// <param name="value"></param>
        public virtual UpdateParameters lang(string value)
        {
            this.SetValue("lang", value);
            return this;
        }
        
        /// <summary>ID of the parent document. Is is only used for routing and when for the upsert request</summary>
        /// <param name="value"></param>
        public virtual UpdateParameters parent(string value)
        {
            this.SetValue("parent", value);
            return this;
        }
        
        /// <summary>Refresh the index after performing the operation</summary>
        /// <param name="value"></param>
        public virtual UpdateParameters refresh(bool value)
        {
            this.SetValue("refresh", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>Specify how many times should the operation be retried when a conflict occurs (default: 0)</summary>
        /// <param name="value"></param>
        public virtual UpdateParameters retry_on_conflict(long value)
        {
            this.SetValue("retry_on_conflict", value);
            return this;
        }
        
        /// <summary>Specific routing value</summary>
        /// <param name="value"></param>
        public virtual UpdateParameters routing(string value)
        {
            this.SetValue("routing", value);
            return this;
        }
        
        /// <summary>True if the script referenced in script or script_id should be called to perform inserts - defaults to false</summary>
        /// <param name="value"></param>
        public virtual UpdateParameters scripted_upsert(bool value)
        {
            this.SetValue("scripted_upsert", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>Explicit operation timeout</summary>
        /// <param name="value"></param>
        public virtual UpdateParameters timeout(string value)
        {
            this.SetValue("timeout", value);
            return this;
        }
        
        /// <summary>Explicit timestamp for the document</summary>
        /// <param name="value"></param>
        public virtual UpdateParameters timestamp(string value)
        {
            this.SetValue("timestamp", value);
            return this;
        }
        
        /// <summary>Expiration time for the document</summary>
        /// <param name="value"></param>
        public virtual UpdateParameters ttl(string value)
        {
            this.SetValue("ttl", value);
            return this;
        }
        
        /// <summary>Explicit version number for concurrency control</summary>
        /// <param name="value"></param>
        public virtual UpdateParameters version(long value)
        {
            this.SetValue("version", value);
            return this;
        }
        
        /// <summary>Specific version type</summary>
        /// <param name="value"><para>Options: internal,force</para></param>
        public virtual UpdateParameters version_type(string value)
        {
            this.SetValue("version_type", value);
            return this;
        }
    }
}
