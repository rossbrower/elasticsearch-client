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
    
    
    public class ExplainParameters : Parameters
    {
        
        /// <summary>Specify whether wildcards and prefix queries in the query string query should be analyzed (default: false)</summary>
        /// <param name="value"></param>
        public virtual ExplainParameters analyze_wildcard(bool value)
        {
            this.SetValue("analyze_wildcard", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>The analyzer for the query string query</summary>
        /// <param name="value"></param>
        public virtual ExplainParameters analyzer(string value)
        {
            this.SetValue("analyzer", value);
            return this;
        }
        
        /// <summary>The default operator for query string query (AND or OR)</summary>
        /// <param name="value"><para>Options: AND,OR</para><para>Default: OR</para></param>
        public virtual ExplainParameters default_operator(string value)
        {
            this.SetValue("default_operator", value);
            return this;
        }
        
        /// <summary>The default field for query string query (default: _all)</summary>
        /// <param name="value"></param>
        public virtual ExplainParameters df(string value)
        {
            this.SetValue("df", value);
            return this;
        }
        
        /// <summary>A comma-separated list of fields to return in the response</summary>
        /// <param name="value"></param>
        public virtual ExplainParameters fields(string value)
        {
            this.SetValue("fields", value);
            return this;
        }
        
        /// <summary>Specify whether format-based query failures (such as providing text to a numeric field) should be ignored</summary>
        /// <param name="value"></param>
        public virtual ExplainParameters lenient(bool value)
        {
            this.SetValue("lenient", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>Specify whether query terms should be lowercased</summary>
        /// <param name="value"></param>
        public virtual ExplainParameters lowercase_expanded_terms(bool value)
        {
            this.SetValue("lowercase_expanded_terms", value.ToString().ToLower());
            return this;
        }
        
        /// <summary>The ID of the parent document</summary>
        /// <param name="value"></param>
        public virtual ExplainParameters parent(string value)
        {
            this.SetValue("parent", value);
            return this;
        }
        
        /// <summary>Specify the node or shard the operation should be performed on (default: random)</summary>
        /// <param name="value"></param>
        public virtual ExplainParameters preference(string value)
        {
            this.SetValue("preference", value);
            return this;
        }
        
        /// <summary>Query in the Lucene query string syntax</summary>
        /// <param name="value"></param>
        public virtual ExplainParameters q(string value)
        {
            this.SetValue("q", value);
            return this;
        }
        
        /// <summary>Specific routing value</summary>
        /// <param name="value"></param>
        public virtual ExplainParameters routing(string value)
        {
            this.SetValue("routing", value);
            return this;
        }
        
        /// <summary>True or false to return the _source field or not, or a list of fields to return</summary>
        /// <param name="value"></param>
        public virtual ExplainParameters _source(string value)
        {
            this.SetValue("_source", value);
            return this;
        }
        
        /// <summary>A list of fields to exclude from the returned _source field</summary>
        /// <param name="value"></param>
        public virtual ExplainParameters _source_exclude(string value)
        {
            this.SetValue("_source_exclude", value);
            return this;
        }
        
        /// <summary>A list of fields to extract and return from the _source field</summary>
        /// <param name="value"></param>
        public virtual ExplainParameters _source_include(string value)
        {
            this.SetValue("_source_include", value);
            return this;
        }
    }
}
