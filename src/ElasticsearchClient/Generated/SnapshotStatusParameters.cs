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
    
    
    public class SnapshotStatusParameters : Parameters
    {
        
        /// <summary>Explicit operation timeout for connection to master node</summary>
        /// <param name="value"></param>
        public virtual SnapshotStatusParameters master_timeout(string value)
        {
            this.SetValue("master_timeout", value);
            return this;
        }
    }
}
