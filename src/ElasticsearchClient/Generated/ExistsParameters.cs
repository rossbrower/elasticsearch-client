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
    
    
    public class ExistsParameters : Parameters
    {
        
        /// <summary>The ID of the parent document</summary>
        /// <param name="value"></param>
        public virtual ExistsParameters parent(string value)
        {
            this.SetValue("parent", value);
            return this;
        }
        
        /// <summary>Specify the node or shard the operation should be performed on (default: random)</summary>
        /// <param name="value"></param>
        public virtual ExistsParameters preference(string value)
        {
            this.SetValue("preference", value);
            return this;
        }
        
        /// <summary>Specify whether to perform the operation in realtime or search mode</summary>
        /// <param name="value"></param>
        public virtual ExistsParameters realtime(bool value)
        {
            this.SetValue("realtime", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>Refresh the shard containing the document before performing the operation</summary>
        /// <param name="value"></param>
        public virtual ExistsParameters refresh(bool value)
        {
            this.SetValue("refresh", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>Specific routing value</summary>
        /// <param name="value"></param>
        public virtual ExistsParameters routing(string value)
        {
            this.SetValue("routing", value);
            return this;
        }
    }
}
