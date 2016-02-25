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
    
    
    public partial class ElasticsearchClient
    {
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        /// <param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
        /// <param name="name">The name of the alias to be created or updated</param>
        /// <param name="body">The settings for the alias, such as `routing` or `filter`</param>
        private HttpResponseMessage IndicesPutAliasPut(string index, string name, Stream body)
        {
            string uri = string.Format("/{0}/_alias/{1}", index, name);
            return this.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        /// <param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
        /// <param name="name">The name of the alias to be created or updated</param>
        /// <param name="body">The settings for the alias, such as `routing` or `filter`</param>
        private async Task<HttpResponseMessage> IndicesPutAliasPutAsync(string index, string name, Stream body)
        {
            string uri = string.Format("/{0}/_alias/{1}", index, name);
            return await this.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        /// <param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
        /// <param name="name">The name of the alias to be created or updated</param>
        /// <param name="body">The settings for the alias, such as `routing` or `filter`</param>
        private HttpResponseMessage IndicesPutAliasPut(string index, string name, Byte[] body)
        {
            string uri = string.Format("/{0}/_alias/{1}", index, name);
            return this.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        /// <param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
        /// <param name="name">The name of the alias to be created or updated</param>
        /// <param name="body">The settings for the alias, such as `routing` or `filter`</param>
        private async Task<HttpResponseMessage> IndicesPutAliasPutAsync(string index, string name, Byte[] body)
        {
            string uri = string.Format("/{0}/_alias/{1}", index, name);
            return await this.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        /// <param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
        /// <param name="name">The name of the alias to be created or updated</param>
        /// <param name="body">The settings for the alias, such as `routing` or `filter`</param>
        private HttpResponseMessage IndicesPutAliasPut(string index, string name, string body)
        {
            string uri = string.Format("/{0}/_alias/{1}", index, name);
            return this.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        /// <param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
        /// <param name="name">The name of the alias to be created or updated</param>
        /// <param name="body">The settings for the alias, such as `routing` or `filter`</param>
        private async Task<HttpResponseMessage> IndicesPutAliasPutAsync(string index, string name, string body)
        {
            string uri = string.Format("/{0}/_alias/{1}", index, name);
            return await this.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        /// <param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
        /// <param name="name">The name of the alias to be created or updated</param>
        /// <param name="body">The settings for the alias, such as `routing` or `filter`</param>
        private HttpResponseMessage IndicesPutAliasPost(string index, string name, Stream body)
        {
            string uri = string.Format("/{0}/_alias/{1}", index, name);
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        /// <param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
        /// <param name="name">The name of the alias to be created or updated</param>
        /// <param name="body">The settings for the alias, such as `routing` or `filter`</param>
        private async Task<HttpResponseMessage> IndicesPutAliasPostAsync(string index, string name, Stream body)
        {
            string uri = string.Format("/{0}/_alias/{1}", index, name);
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        /// <param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
        /// <param name="name">The name of the alias to be created or updated</param>
        /// <param name="body">The settings for the alias, such as `routing` or `filter`</param>
        private HttpResponseMessage IndicesPutAliasPost(string index, string name, Byte[] body)
        {
            string uri = string.Format("/{0}/_alias/{1}", index, name);
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        /// <param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
        /// <param name="name">The name of the alias to be created or updated</param>
        /// <param name="body">The settings for the alias, such as `routing` or `filter`</param>
        private async Task<HttpResponseMessage> IndicesPutAliasPostAsync(string index, string name, Byte[] body)
        {
            string uri = string.Format("/{0}/_alias/{1}", index, name);
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        /// <param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
        /// <param name="name">The name of the alias to be created or updated</param>
        /// <param name="body">The settings for the alias, such as `routing` or `filter`</param>
        private HttpResponseMessage IndicesPutAliasPost(string index, string name, string body)
        {
            string uri = string.Format("/{0}/_alias/{1}", index, name);
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        /// <param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
        /// <param name="name">The name of the alias to be created or updated</param>
        /// <param name="body">The settings for the alias, such as `routing` or `filter`</param>
        private async Task<HttpResponseMessage> IndicesPutAliasPostAsync(string index, string name, string body)
        {
            string uri = string.Format("/{0}/_alias/{1}", index, name);
            return await this.ExecuteAsync("POST", uri, body);
        }
    }
}
