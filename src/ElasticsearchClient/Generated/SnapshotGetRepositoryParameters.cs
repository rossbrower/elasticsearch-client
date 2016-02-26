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
    
    
    public class SnapshotGetRepositoryParameters : Parameters
    {
        
        /// <summary>Explicit operation timeout for connection to master node</summary>
        /// <param name="value"></param>
        public virtual SnapshotGetRepositoryParameters master_timeout(string value)
        {
            this.SetValue("master_timeout", value);
            return this;
        }
        
        /// <summary>Return local information, do not retrieve the state from master node (default: false)</summary>
        /// <param name="value"></param>
        public virtual SnapshotGetRepositoryParameters local(bool value)
        {
            this.SetValue("local", value);
            return this;
        }
    }
}
