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
    
    
    public class IndicesExistsTypeParameters : Parameters
    {
        
        /// <summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
        /// <param name="value"></param>
        public virtual IndicesExistsTypeParameters ignore_unavailable(bool value)
        {
            this.SetValue("ignore_unavailable", value);
            return this;
        }
        
        /// <summary>Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have been specified)</summary>
        /// <param name="value"></param>
        public virtual IndicesExistsTypeParameters allow_no_indices(bool value)
        {
            this.SetValue("allow_no_indices", value);
            return this;
        }
        
        /// <summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
        /// <param name="value"><para>Options: open,closed,none,all</para><para>Default: open</para></param>
        public virtual IndicesExistsTypeParameters expand_wildcards(string value)
        {
            this.SetValue("expand_wildcards", value);
            return this;
        }
        
        /// <summary>Return local information, do not retrieve the state from master node (default: false)</summary>
        /// <param name="value"></param>
        public virtual IndicesExistsTypeParameters local(bool value)
        {
            this.SetValue("local", value);
            return this;
        }
    }
}
