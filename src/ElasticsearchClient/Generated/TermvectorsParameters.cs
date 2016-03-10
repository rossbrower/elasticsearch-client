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
    
    
    public class TermvectorsParameters : Parameters
    {
        
        /// <summary>Specifies if total term frequency and document frequency should be returned.</summary>
        /// <param name="value"><para>Default: False</para></param>
        public virtual TermvectorsParameters term_statistics(bool value)
        {
            this.SetValue("term_statistics", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>Specifies if document count, sum of document frequencies and sum of total term frequencies should be returned.</summary>
        /// <param name="value"><para>Default: True</para></param>
        public virtual TermvectorsParameters field_statistics(bool value)
        {
            this.SetValue("field_statistics", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>Specifies if distributed frequencies should be returned instead shard frequencies.</summary>
        /// <param name="value"><para>Default: False</para></param>
        public virtual TermvectorsParameters dfs(bool value)
        {
            this.SetValue("dfs", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>A comma-separated list of fields to return.</summary>
        /// <param name="value"></param>
        public virtual TermvectorsParameters fields(string value)
        {
            this.SetValue("fields", value);
            return this;
        }
        
        /// <summary>Specifies if term offsets should be returned.</summary>
        /// <param name="value"><para>Default: True</para></param>
        public virtual TermvectorsParameters offsets(bool value)
        {
            this.SetValue("offsets", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>Specifies if term positions should be returned.</summary>
        /// <param name="value"><para>Default: True</para></param>
        public virtual TermvectorsParameters positions(bool value)
        {
            this.SetValue("positions", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>Specifies if term payloads should be returned.</summary>
        /// <param name="value"><para>Default: True</para></param>
        public virtual TermvectorsParameters payloads(bool value)
        {
            this.SetValue("payloads", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>Specify the node or shard the operation should be performed on (default: random).</summary>
        /// <param name="value"></param>
        public virtual TermvectorsParameters preference(string value)
        {
            this.SetValue("preference", value);
            return this;
        }
        
        /// <summary>Specific routing value.</summary>
        /// <param name="value"></param>
        public virtual TermvectorsParameters routing(string value)
        {
            this.SetValue("routing", value);
            return this;
        }
        
        /// <summary>Parent id of documents.</summary>
        /// <param name="value"></param>
        public virtual TermvectorsParameters parent(string value)
        {
            this.SetValue("parent", value);
            return this;
        }
        
        /// <summary>Specifies if request is real-time as opposed to near-real-time (default: true).</summary>
        /// <param name="value"></param>
        public virtual TermvectorsParameters realtime(bool value)
        {
            this.SetValue("realtime", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>Explicit version number for concurrency control</summary>
        /// <param name="value"></param>
        public virtual TermvectorsParameters version(long value)
        {
            this.SetValue("version", value);
            return this;
        }
        
        /// <summary>Specific version type</summary>
        /// <param name="value"><para>Options: internal,external,external_gte,force</para></param>
        public virtual TermvectorsParameters version_type(string value)
        {
            this.SetValue("version_type", value);
            return this;
        }
    }
}
