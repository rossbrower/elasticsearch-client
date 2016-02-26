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
    
    
    public class IndicesPutTemplateParameters : Parameters
    {
        
        /// <summary>The order for this template when merging multiple matching ones (higher numbers are merged later, overriding the lower numbers)</summary>
        /// <param name="value"></param>
        public virtual IndicesPutTemplateParameters order(long value)
        {
            this.SetValue("order", value);
            return this;
        }
        
        /// <summary>Whether the index template should only be added if new or can also replace an existing one</summary>
        /// <param name="value"><para>Default: False</para></param>
        public virtual IndicesPutTemplateParameters create(bool value)
        {
            this.SetValue("create", value);
            return this;
        }
        
        /// <summary>Explicit operation timeout</summary>
        /// <param name="value"></param>
        public virtual IndicesPutTemplateParameters timeout(string value)
        {
            this.SetValue("timeout", value);
            return this;
        }
        
        /// <summary>Specify timeout for connection to master</summary>
        /// <param name="value"></param>
        public virtual IndicesPutTemplateParameters master_timeout(string value)
        {
            this.SetValue("master_timeout", value);
            return this;
        }
        
        /// <summary>Return settings in flat format (default: false)</summary>
        /// <param name="value"></param>
        public virtual IndicesPutTemplateParameters flat_settings(bool value)
        {
            this.SetValue("flat_settings", value);
            return this;
        }
    }
}
