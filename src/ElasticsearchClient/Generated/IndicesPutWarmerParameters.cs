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
    
    
    public class IndicesPutWarmerParameters : Parameters
    {
        
        /// <summary>Specify timeout for connection to master</summary>
        /// <param name="value"></param>
        public virtual IndicesPutWarmerParameters master_timeout(string value)
        {
            this.SetValue("master_timeout", value);
            return this;
        }
        
        /// <summary>Whether specified concrete indices should be ignored when unavailable (missing or closed) in the search request to warm</summary>
        /// <param name="value"></param>
        public virtual IndicesPutWarmerParameters ignore_unavailable(bool value)
        {
            this.SetValue("ignore_unavailable", value);
            return this;
        }
        
        /// <summary>Whether to ignore if a wildcard indices expression resolves into no concrete indices in the search request to warm. (This includes `_all` string or when no indices have been specified)</summary>
        /// <param name="value"></param>
        public virtual IndicesPutWarmerParameters allow_no_indices(bool value)
        {
            this.SetValue("allow_no_indices", value);
            return this;
        }
        
        /// <summary>Whether to expand wildcard expression to concrete indices that are open, closed or both, in the search request to warm.</summary>
        /// <param name="value"><para>Options: open,closed,none,all</para><para>Default: open</para></param>
        public virtual IndicesPutWarmerParameters expand_wildcards(string value)
        {
            this.SetValue("expand_wildcards", value);
            return this;
        }
        
        /// <summary>Specify whether the request to be warmed should use the request cache, defaults to index level setting</summary>
        /// <param name="value"></param>
        public virtual IndicesPutWarmerParameters request_cache(bool value)
        {
            this.SetValue("request_cache", value);
            return this;
        }
    }
}
