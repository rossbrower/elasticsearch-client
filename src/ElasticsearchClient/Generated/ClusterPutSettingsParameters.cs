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
    
    
    public class ClusterPutSettingsParameters : Parameters
    {
        
        /// <summary>Return settings in flat format (default: false)</summary>
        /// <param name="value"></param>
        public virtual ClusterPutSettingsParameters flat_settings(bool value)
        {
            this.SetValue("flat_settings", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>Explicit operation timeout for connection to master node</summary>
        /// <param name="value"></param>
        public virtual ClusterPutSettingsParameters master_timeout(string value)
        {
            this.SetValue("master_timeout", value);
            return this;
        }
        
        /// <summary>Explicit operation timeout</summary>
        /// <param name="value"></param>
        public virtual ClusterPutSettingsParameters timeout(string value)
        {
            this.SetValue("timeout", value);
            return this;
        }
    }
}
