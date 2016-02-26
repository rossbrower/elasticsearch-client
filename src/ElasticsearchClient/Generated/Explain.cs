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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">The document ID</param>
        /// <param name="body">The query definition using the Query DSL</param>
        private HttpResponseMessage ExplainGet(string index, string type, string id, Stream body)
        {
            string uri = string.Format("/{0}/{1}/{2}/_explain", index, type, id);
            return this.Execute("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">The document ID</param>
        /// <param name="body">The query definition using the Query DSL</param>
        private async Task<HttpResponseMessage> ExplainGetAsync(string index, string type, string id, Stream body)
        {
            string uri = string.Format("/{0}/{1}/{2}/_explain", index, type, id);
            return await this.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">The document ID</param>
        /// <param name="body">The query definition using the Query DSL</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private HttpResponseMessage ExplainGet(string index, string type, string id, Stream body, Func<ExplainParameters, ExplainParameters> options)
        {
            string uri = string.Format("/{0}/{1}/{2}/_explain", index, type, id);
            ExplainParameters parameters = options.Invoke(new ExplainParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">The document ID</param>
        /// <param name="body">The query definition using the Query DSL</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private async Task<HttpResponseMessage> ExplainGetAsync(string index, string type, string id, Stream body, Func<ExplainParameters, ExplainParameters> options)
        {
            string uri = string.Format("/{0}/{1}/{2}/_explain", index, type, id);
            ExplainParameters parameters = options.Invoke(new ExplainParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">The document ID</param>
        /// <param name="body">The query definition using the Query DSL</param>
        private HttpResponseMessage ExplainGet(string index, string type, string id, Byte[] body)
        {
            string uri = string.Format("/{0}/{1}/{2}/_explain", index, type, id);
            return this.Execute("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">The document ID</param>
        /// <param name="body">The query definition using the Query DSL</param>
        private async Task<HttpResponseMessage> ExplainGetAsync(string index, string type, string id, Byte[] body)
        {
            string uri = string.Format("/{0}/{1}/{2}/_explain", index, type, id);
            return await this.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">The document ID</param>
        /// <param name="body">The query definition using the Query DSL</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private HttpResponseMessage ExplainGet(string index, string type, string id, Byte[] body, Func<ExplainParameters, ExplainParameters> options)
        {
            string uri = string.Format("/{0}/{1}/{2}/_explain", index, type, id);
            ExplainParameters parameters = options.Invoke(new ExplainParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">The document ID</param>
        /// <param name="body">The query definition using the Query DSL</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private async Task<HttpResponseMessage> ExplainGetAsync(string index, string type, string id, Byte[] body, Func<ExplainParameters, ExplainParameters> options)
        {
            string uri = string.Format("/{0}/{1}/{2}/_explain", index, type, id);
            ExplainParameters parameters = options.Invoke(new ExplainParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">The document ID</param>
        /// <param name="body">The query definition using the Query DSL</param>
        private HttpResponseMessage ExplainGet(string index, string type, string id, string body)
        {
            string uri = string.Format("/{0}/{1}/{2}/_explain", index, type, id);
            return this.Execute("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">The document ID</param>
        /// <param name="body">The query definition using the Query DSL</param>
        private async Task<HttpResponseMessage> ExplainGetAsync(string index, string type, string id, string body)
        {
            string uri = string.Format("/{0}/{1}/{2}/_explain", index, type, id);
            return await this.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">The document ID</param>
        /// <param name="body">The query definition using the Query DSL</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private HttpResponseMessage ExplainGet(string index, string type, string id, string body, Func<ExplainParameters, ExplainParameters> options)
        {
            string uri = string.Format("/{0}/{1}/{2}/_explain", index, type, id);
            ExplainParameters parameters = options.Invoke(new ExplainParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">The document ID</param>
        /// <param name="body">The query definition using the Query DSL</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private async Task<HttpResponseMessage> ExplainGetAsync(string index, string type, string id, string body, Func<ExplainParameters, ExplainParameters> options)
        {
            string uri = string.Format("/{0}/{1}/{2}/_explain", index, type, id);
            ExplainParameters parameters = options.Invoke(new ExplainParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">The document ID</param>
        /// <param name="body">The query definition using the Query DSL</param>
        private HttpResponseMessage ExplainPost(string index, string type, string id, Stream body)
        {
            string uri = string.Format("/{0}/{1}/{2}/_explain", index, type, id);
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">The document ID</param>
        /// <param name="body">The query definition using the Query DSL</param>
        private async Task<HttpResponseMessage> ExplainPostAsync(string index, string type, string id, Stream body)
        {
            string uri = string.Format("/{0}/{1}/{2}/_explain", index, type, id);
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">The document ID</param>
        /// <param name="body">The query definition using the Query DSL</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private HttpResponseMessage ExplainPost(string index, string type, string id, Stream body, Func<ExplainParameters, ExplainParameters> options)
        {
            string uri = string.Format("/{0}/{1}/{2}/_explain", index, type, id);
            ExplainParameters parameters = options.Invoke(new ExplainParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">The document ID</param>
        /// <param name="body">The query definition using the Query DSL</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private async Task<HttpResponseMessage> ExplainPostAsync(string index, string type, string id, Stream body, Func<ExplainParameters, ExplainParameters> options)
        {
            string uri = string.Format("/{0}/{1}/{2}/_explain", index, type, id);
            ExplainParameters parameters = options.Invoke(new ExplainParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">The document ID</param>
        /// <param name="body">The query definition using the Query DSL</param>
        private HttpResponseMessage ExplainPost(string index, string type, string id, Byte[] body)
        {
            string uri = string.Format("/{0}/{1}/{2}/_explain", index, type, id);
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">The document ID</param>
        /// <param name="body">The query definition using the Query DSL</param>
        private async Task<HttpResponseMessage> ExplainPostAsync(string index, string type, string id, Byte[] body)
        {
            string uri = string.Format("/{0}/{1}/{2}/_explain", index, type, id);
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">The document ID</param>
        /// <param name="body">The query definition using the Query DSL</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private HttpResponseMessage ExplainPost(string index, string type, string id, Byte[] body, Func<ExplainParameters, ExplainParameters> options)
        {
            string uri = string.Format("/{0}/{1}/{2}/_explain", index, type, id);
            ExplainParameters parameters = options.Invoke(new ExplainParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">The document ID</param>
        /// <param name="body">The query definition using the Query DSL</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private async Task<HttpResponseMessage> ExplainPostAsync(string index, string type, string id, Byte[] body, Func<ExplainParameters, ExplainParameters> options)
        {
            string uri = string.Format("/{0}/{1}/{2}/_explain", index, type, id);
            ExplainParameters parameters = options.Invoke(new ExplainParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">The document ID</param>
        /// <param name="body">The query definition using the Query DSL</param>
        private HttpResponseMessage ExplainPost(string index, string type, string id, string body)
        {
            string uri = string.Format("/{0}/{1}/{2}/_explain", index, type, id);
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">The document ID</param>
        /// <param name="body">The query definition using the Query DSL</param>
        private async Task<HttpResponseMessage> ExplainPostAsync(string index, string type, string id, string body)
        {
            string uri = string.Format("/{0}/{1}/{2}/_explain", index, type, id);
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">The document ID</param>
        /// <param name="body">The query definition using the Query DSL</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private HttpResponseMessage ExplainPost(string index, string type, string id, string body, Func<ExplainParameters, ExplainParameters> options)
        {
            string uri = string.Format("/{0}/{1}/{2}/_explain", index, type, id);
            ExplainParameters parameters = options.Invoke(new ExplainParameters());
            uri = parameters.GetUri(uri);
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-explain.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">The document ID</param>
        /// <param name="body">The query definition using the Query DSL</param>
        /// <param name="options">The function to set optional url parameters.</param>
        private async Task<HttpResponseMessage> ExplainPostAsync(string index, string type, string id, string body, Func<ExplainParameters, ExplainParameters> options)
        {
            string uri = string.Format("/{0}/{1}/{2}/_explain", index, type, id);
            ExplainParameters parameters = options.Invoke(new ExplainParameters());
            uri = parameters.GetUri(uri);
            return await this.ExecuteAsync("POST", uri, body);
        }
    }
}
