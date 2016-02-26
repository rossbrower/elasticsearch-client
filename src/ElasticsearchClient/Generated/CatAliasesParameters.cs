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
    
    
    public class CatAliasesParameters : Parameters
    {
        
        /// <summary>Return local information, do not retrieve the state from master node (default: false)</summary>
        /// <param name="value"></param>
        public virtual CatAliasesParameters local(bool value)
        {
            this.SetValue("local", value);
            return this;
        }
        
        /// <summary>Explicit operation timeout for connection to master node</summary>
        /// <param name="value"></param>
        public virtual CatAliasesParameters master_timeout(string value)
        {
            this.SetValue("master_timeout", value);
            return this;
        }
        
        /// <summary>Comma-separated list of column names to display</summary>
        /// <param name="value"></param>
        public virtual CatAliasesParameters h(string value)
        {
            this.SetValue("h", value);
            return this;
        }
        
        /// <summary>Return help information</summary>
        /// <param name="value"><para>Default: False</para></param>
        public virtual CatAliasesParameters help(bool value)
        {
            this.SetValue("help", value);
            return this;
        }
        
        /// <summary>Verbose mode. Display column headers</summary>
        /// <param name="value"><para>Default: False</para></param>
        public virtual CatAliasesParameters v(bool value)
        {
            this.SetValue("v", value);
            return this;
        }
    }
}
