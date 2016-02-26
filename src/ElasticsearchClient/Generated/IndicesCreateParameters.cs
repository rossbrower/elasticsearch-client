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
    
    
    public class IndicesCreateParameters : Parameters
    {
        
        /// <summary>Explicit operation timeout</summary>
        /// <param name="value"></param>
        public virtual IndicesCreateParameters timeout(string value)
        {
            this.SetValue("timeout", value);
            return this;
        }
        
        /// <summary>Specify timeout for connection to master</summary>
        /// <param name="value"></param>
        public virtual IndicesCreateParameters master_timeout(string value)
        {
            this.SetValue("master_timeout", value);
            return this;
        }
        
        /// <summary>Whether to update the mapping for all fields with the same name across all types or not</summary>
        /// <param name="value"></param>
        public virtual IndicesCreateParameters update_all_types(bool value)
        {
            this.SetValue("update_all_types", value);
            return this;
        }
    }
}
