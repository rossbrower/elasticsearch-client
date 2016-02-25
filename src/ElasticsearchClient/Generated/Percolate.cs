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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being percolated.</param>
        /// <param name="type">The type of the document being percolated.</param>
        /// <param name="body">The percolator request definition using the percolate DSL</param>
        private HttpResponseMessage PercolateGet(string index, string type, Stream body)
        {
            string uri = string.Format("/{0}/{1}/_percolate", index, type);
            return this.Execute("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being percolated.</param>
        /// <param name="type">The type of the document being percolated.</param>
        /// <param name="body">The percolator request definition using the percolate DSL</param>
        private async Task<HttpResponseMessage> PercolateGetAsync(string index, string type, Stream body)
        {
            string uri = string.Format("/{0}/{1}/_percolate", index, type);
            return await this.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being percolated.</param>
        /// <param name="type">The type of the document being percolated.</param>
        /// <param name="body">The percolator request definition using the percolate DSL</param>
        private HttpResponseMessage PercolateGet(string index, string type, Byte[] body)
        {
            string uri = string.Format("/{0}/{1}/_percolate", index, type);
            return this.Execute("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being percolated.</param>
        /// <param name="type">The type of the document being percolated.</param>
        /// <param name="body">The percolator request definition using the percolate DSL</param>
        private async Task<HttpResponseMessage> PercolateGetAsync(string index, string type, Byte[] body)
        {
            string uri = string.Format("/{0}/{1}/_percolate", index, type);
            return await this.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being percolated.</param>
        /// <param name="type">The type of the document being percolated.</param>
        /// <param name="body">The percolator request definition using the percolate DSL</param>
        private HttpResponseMessage PercolateGet(string index, string type, string body)
        {
            string uri = string.Format("/{0}/{1}/_percolate", index, type);
            return this.Execute("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being percolated.</param>
        /// <param name="type">The type of the document being percolated.</param>
        /// <param name="body">The percolator request definition using the percolate DSL</param>
        private async Task<HttpResponseMessage> PercolateGetAsync(string index, string type, string body)
        {
            string uri = string.Format("/{0}/{1}/_percolate", index, type);
            return await this.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being percolated.</param>
        /// <param name="type">The type of the document being percolated.</param>
        /// <param name="body">The percolator request definition using the percolate DSL</param>
        private HttpResponseMessage PercolatePost(string index, string type, Stream body)
        {
            string uri = string.Format("/{0}/{1}/_percolate", index, type);
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being percolated.</param>
        /// <param name="type">The type of the document being percolated.</param>
        /// <param name="body">The percolator request definition using the percolate DSL</param>
        private async Task<HttpResponseMessage> PercolatePostAsync(string index, string type, Stream body)
        {
            string uri = string.Format("/{0}/{1}/_percolate", index, type);
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being percolated.</param>
        /// <param name="type">The type of the document being percolated.</param>
        /// <param name="body">The percolator request definition using the percolate DSL</param>
        private HttpResponseMessage PercolatePost(string index, string type, Byte[] body)
        {
            string uri = string.Format("/{0}/{1}/_percolate", index, type);
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being percolated.</param>
        /// <param name="type">The type of the document being percolated.</param>
        /// <param name="body">The percolator request definition using the percolate DSL</param>
        private async Task<HttpResponseMessage> PercolatePostAsync(string index, string type, Byte[] body)
        {
            string uri = string.Format("/{0}/{1}/_percolate", index, type);
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being percolated.</param>
        /// <param name="type">The type of the document being percolated.</param>
        /// <param name="body">The percolator request definition using the percolate DSL</param>
        private HttpResponseMessage PercolatePost(string index, string type, string body)
        {
            string uri = string.Format("/{0}/{1}/_percolate", index, type);
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being percolated.</param>
        /// <param name="type">The type of the document being percolated.</param>
        /// <param name="body">The percolator request definition using the percolate DSL</param>
        private async Task<HttpResponseMessage> PercolatePostAsync(string index, string type, string body)
        {
            string uri = string.Format("/{0}/{1}/_percolate", index, type);
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being percolated.</param>
        /// <param name="type">The type of the document being percolated.</param>
        /// <param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        /// <param name="body">The percolator request definition using the percolate DSL</param>
        private HttpResponseMessage PercolateGet(string index, string type, string id, Stream body)
        {
            string uri = string.Format("/{0}/{1}/{2}/_percolate", index, type, id);
            return this.Execute("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being percolated.</param>
        /// <param name="type">The type of the document being percolated.</param>
        /// <param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        /// <param name="body">The percolator request definition using the percolate DSL</param>
        private async Task<HttpResponseMessage> PercolateGetAsync(string index, string type, string id, Stream body)
        {
            string uri = string.Format("/{0}/{1}/{2}/_percolate", index, type, id);
            return await this.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being percolated.</param>
        /// <param name="type">The type of the document being percolated.</param>
        /// <param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        /// <param name="body">The percolator request definition using the percolate DSL</param>
        private HttpResponseMessage PercolateGet(string index, string type, string id, Byte[] body)
        {
            string uri = string.Format("/{0}/{1}/{2}/_percolate", index, type, id);
            return this.Execute("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being percolated.</param>
        /// <param name="type">The type of the document being percolated.</param>
        /// <param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        /// <param name="body">The percolator request definition using the percolate DSL</param>
        private async Task<HttpResponseMessage> PercolateGetAsync(string index, string type, string id, Byte[] body)
        {
            string uri = string.Format("/{0}/{1}/{2}/_percolate", index, type, id);
            return await this.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being percolated.</param>
        /// <param name="type">The type of the document being percolated.</param>
        /// <param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        /// <param name="body">The percolator request definition using the percolate DSL</param>
        private HttpResponseMessage PercolateGet(string index, string type, string id, string body)
        {
            string uri = string.Format("/{0}/{1}/{2}/_percolate", index, type, id);
            return this.Execute("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being percolated.</param>
        /// <param name="type">The type of the document being percolated.</param>
        /// <param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        /// <param name="body">The percolator request definition using the percolate DSL</param>
        private async Task<HttpResponseMessage> PercolateGetAsync(string index, string type, string id, string body)
        {
            string uri = string.Format("/{0}/{1}/{2}/_percolate", index, type, id);
            return await this.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being percolated.</param>
        /// <param name="type">The type of the document being percolated.</param>
        /// <param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        /// <param name="body">The percolator request definition using the percolate DSL</param>
        private HttpResponseMessage PercolatePost(string index, string type, string id, Stream body)
        {
            string uri = string.Format("/{0}/{1}/{2}/_percolate", index, type, id);
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being percolated.</param>
        /// <param name="type">The type of the document being percolated.</param>
        /// <param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        /// <param name="body">The percolator request definition using the percolate DSL</param>
        private async Task<HttpResponseMessage> PercolatePostAsync(string index, string type, string id, Stream body)
        {
            string uri = string.Format("/{0}/{1}/{2}/_percolate", index, type, id);
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being percolated.</param>
        /// <param name="type">The type of the document being percolated.</param>
        /// <param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        /// <param name="body">The percolator request definition using the percolate DSL</param>
        private HttpResponseMessage PercolatePost(string index, string type, string id, Byte[] body)
        {
            string uri = string.Format("/{0}/{1}/{2}/_percolate", index, type, id);
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being percolated.</param>
        /// <param name="type">The type of the document being percolated.</param>
        /// <param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        /// <param name="body">The percolator request definition using the percolate DSL</param>
        private async Task<HttpResponseMessage> PercolatePostAsync(string index, string type, string id, Byte[] body)
        {
            string uri = string.Format("/{0}/{1}/{2}/_percolate", index, type, id);
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being percolated.</param>
        /// <param name="type">The type of the document being percolated.</param>
        /// <param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        /// <param name="body">The percolator request definition using the percolate DSL</param>
        private HttpResponseMessage PercolatePost(string index, string type, string id, string body)
        {
            string uri = string.Format("/{0}/{1}/{2}/_percolate", index, type, id);
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being percolated.</param>
        /// <param name="type">The type of the document being percolated.</param>
        /// <param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        /// <param name="body">The percolator request definition using the percolate DSL</param>
        private async Task<HttpResponseMessage> PercolatePostAsync(string index, string type, string id, string body)
        {
            string uri = string.Format("/{0}/{1}/{2}/_percolate", index, type, id);
            return await this.ExecuteAsync("POST", uri, body);
        }
    }
}
