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
    
    
    public class MtermvectorsParameters : Parameters
    {
        
        /// <summary>A comma-separated list of documents ids. You must define ids as parameter or set "ids" or "docs" in the request body</summary>
        /// <param name="value"></param>
        public virtual MtermvectorsParameters ids(string value)
        {
            this.SetValue("ids", value);
            return this;
        }
        
        /// <summary>Specifies if total term frequency and document frequency should be returned. Applies to all returned documents unless otherwise specified in body "params" or "docs".</summary>
        /// <param name="value"><para>Default: False</para></param>
        public virtual MtermvectorsParameters term_statistics(bool value)
        {
            this.SetValue("term_statistics", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>Specifies if document count, sum of document frequencies and sum of total term frequencies should be returned. Applies to all returned documents unless otherwise specified in body "params" or "docs".</summary>
        /// <param name="value"><para>Default: True</para></param>
        public virtual MtermvectorsParameters field_statistics(bool value)
        {
            this.SetValue("field_statistics", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>A comma-separated list of fields to return. Applies to all returned documents unless otherwise specified in body "params" or "docs".</summary>
        /// <param name="value"></param>
        public virtual MtermvectorsParameters fields(string value)
        {
            this.SetValue("fields", value);
            return this;
        }
        
        /// <summary>Specifies if term offsets should be returned. Applies to all returned documents unless otherwise specified in body "params" or "docs".</summary>
        /// <param name="value"><para>Default: True</para></param>
        public virtual MtermvectorsParameters offsets(bool value)
        {
            this.SetValue("offsets", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>Specifies if term positions should be returned. Applies to all returned documents unless otherwise specified in body "params" or "docs".</summary>
        /// <param name="value"><para>Default: True</para></param>
        public virtual MtermvectorsParameters positions(bool value)
        {
            this.SetValue("positions", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>Specifies if term payloads should be returned. Applies to all returned documents unless otherwise specified in body "params" or "docs".</summary>
        /// <param name="value"><para>Default: True</para></param>
        public virtual MtermvectorsParameters payloads(bool value)
        {
            this.SetValue("payloads", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>Specify the node or shard the operation should be performed on (default: random) .Applies to all returned documents unless otherwise specified in body "params" or "docs".</summary>
        /// <param name="value"></param>
        public virtual MtermvectorsParameters preference(string value)
        {
            this.SetValue("preference", value);
            return this;
        }
        
        /// <summary>Specific routing value. Applies to all returned documents unless otherwise specified in body "params" or "docs".</summary>
        /// <param name="value"></param>
        public virtual MtermvectorsParameters routing(string value)
        {
            this.SetValue("routing", value);
            return this;
        }
        
        /// <summary>Parent id of documents. Applies to all returned documents unless otherwise specified in body "params" or "docs".</summary>
        /// <param name="value"></param>
        public virtual MtermvectorsParameters parent(string value)
        {
            this.SetValue("parent", value);
            return this;
        }
        
        /// <summary>Specifies if requests are real-time as opposed to near-real-time (default: true).</summary>
        /// <param name="value"></param>
        public virtual MtermvectorsParameters realtime(bool value)
        {
            this.SetValue("realtime", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>Explicit version number for concurrency control</summary>
        /// <param name="value"></param>
        public virtual MtermvectorsParameters version(long value)
        {
            this.SetValue("version", value);
            return this;
        }
        
        /// <summary>Specific version type</summary>
        /// <param name="value"><para>Options: internal,external,external_gte,force</para></param>
        public virtual MtermvectorsParameters version_type(string value)
        {
            this.SetValue("version_type", value);
            return this;
        }
    }
}
