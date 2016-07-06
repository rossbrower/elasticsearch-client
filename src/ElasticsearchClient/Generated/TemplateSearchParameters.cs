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
    
    
    public class TemplateSearchParameters : Parameters
    {
        
        /// <summary>Whether specified concrete indices should be ignored when unavailable (missing or closed)</summary>
        /// <param name="value"></param>
        public virtual TemplateSearchParameters ignore_unavailable(bool value)
        {
            this.SetValue("ignore_unavailable", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>Whether to ignore if a wildcard indices expression resolves into no concrete indices. (This includes `_all` string or when no indices have been specified)</summary>
        /// <param name="value"></param>
        public virtual TemplateSearchParameters allow_no_indices(bool value)
        {
            this.SetValue("allow_no_indices", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>Whether to expand wildcard expression to concrete indices that are open, closed or both.</summary>
        /// <param name="value"><para>Options: open,closed,none,all</para><para>Default: open</para></param>
        public virtual TemplateSearchParameters expand_wildcards(string value)
        {
            this.SetValue("expand_wildcards", value);
            return this;
        }
        
        /// <summary>Specify the node or shard the operation should be performed on (default: random)</summary>
        /// <param name="value"></param>
        public virtual TemplateSearchParameters preference(string value)
        {
            this.SetValue("preference", value);
            return this;
        }
        
        /// <summary>A comma-separated list of specific routing values</summary>
        /// <param name="value"></param>
        public virtual TemplateSearchParameters routing(string value)
        {
            this.SetValue("routing", value);
            return this;
        }
        
        /// <summary>Specify how long a consistent view of the index should be maintained for scrolled search</summary>
        /// <param name="value"></param>
        public virtual TemplateSearchParameters scroll(string value)
        {
            this.SetValue("scroll", value);
            return this;
        }
        
        /// <summary>Search operation type</summary>
        /// <param name="value"><para>Options: query_then_fetch,query_and_fetch,dfs_query_then_fetch,dfs_query_and_fetch</para></param>
        public virtual TemplateSearchParameters search_type(string value)
        {
            this.SetValue("search_type", value);
            return this;
        }
    }
}