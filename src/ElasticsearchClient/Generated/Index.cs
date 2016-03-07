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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndexPost(string index, string type, Stream body, Func<IndexParameters, IndexParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}", index, type);
            if ((options != null))
            {
                IndexParameters parameters = options.Invoke(new IndexParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndexPostAsync(string index, string type, Stream body, Func<IndexParameters, IndexParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}", index, type);
            if ((options != null))
            {
                IndexParameters parameters = options.Invoke(new IndexParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndexPost(string index, string type, Byte[] body, Func<IndexParameters, IndexParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}", index, type);
            if ((options != null))
            {
                IndexParameters parameters = options.Invoke(new IndexParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndexPostAsync(string index, string type, Byte[] body, Func<IndexParameters, IndexParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}", index, type);
            if ((options != null))
            {
                IndexParameters parameters = options.Invoke(new IndexParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndexPostString(string index, string type, string body, Func<IndexParameters, IndexParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}", index, type);
            if ((options != null))
            {
                IndexParameters parameters = options.Invoke(new IndexParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndexPostStringAsync(string index, string type, string body, Func<IndexParameters, IndexParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}", index, type);
            if ((options != null))
            {
                IndexParameters parameters = options.Invoke(new IndexParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndexPut(string index, string type, Stream body, Func<IndexParameters, IndexParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}", index, type);
            if ((options != null))
            {
                IndexParameters parameters = options.Invoke(new IndexParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndexPutAsync(string index, string type, Stream body, Func<IndexParameters, IndexParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}", index, type);
            if ((options != null))
            {
                IndexParameters parameters = options.Invoke(new IndexParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndexPut(string index, string type, Byte[] body, Func<IndexParameters, IndexParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}", index, type);
            if ((options != null))
            {
                IndexParameters parameters = options.Invoke(new IndexParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndexPutAsync(string index, string type, Byte[] body, Func<IndexParameters, IndexParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}", index, type);
            if ((options != null))
            {
                IndexParameters parameters = options.Invoke(new IndexParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndexPutString(string index, string type, string body, Func<IndexParameters, IndexParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}", index, type);
            if ((options != null))
            {
                IndexParameters parameters = options.Invoke(new IndexParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndexPutStringAsync(string index, string type, string body, Func<IndexParameters, IndexParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}", index, type);
            if ((options != null))
            {
                IndexParameters parameters = options.Invoke(new IndexParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">Document ID</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndexPost(string index, string type, string id, Stream body, Func<IndexParameters, IndexParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/{2}", index, type, id);
            if ((options != null))
            {
                IndexParameters parameters = options.Invoke(new IndexParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">Document ID</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndexPostAsync(string index, string type, string id, Stream body, Func<IndexParameters, IndexParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/{2}", index, type, id);
            if ((options != null))
            {
                IndexParameters parameters = options.Invoke(new IndexParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">Document ID</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndexPost(string index, string type, string id, Byte[] body, Func<IndexParameters, IndexParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/{2}", index, type, id);
            if ((options != null))
            {
                IndexParameters parameters = options.Invoke(new IndexParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">Document ID</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndexPostAsync(string index, string type, string id, Byte[] body, Func<IndexParameters, IndexParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/{2}", index, type, id);
            if ((options != null))
            {
                IndexParameters parameters = options.Invoke(new IndexParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">Document ID</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndexPostString(string index, string type, string id, string body, Func<IndexParameters, IndexParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/{2}", index, type, id);
            if ((options != null))
            {
                IndexParameters parameters = options.Invoke(new IndexParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">Document ID</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndexPostStringAsync(string index, string type, string id, string body, Func<IndexParameters, IndexParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/{2}", index, type, id);
            if ((options != null))
            {
                IndexParameters parameters = options.Invoke(new IndexParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">Document ID</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndexPut(string index, string type, string id, Stream body, Func<IndexParameters, IndexParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/{2}", index, type, id);
            if ((options != null))
            {
                IndexParameters parameters = options.Invoke(new IndexParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">Document ID</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndexPutAsync(string index, string type, string id, Stream body, Func<IndexParameters, IndexParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/{2}", index, type, id);
            if ((options != null))
            {
                IndexParameters parameters = options.Invoke(new IndexParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">Document ID</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndexPut(string index, string type, string id, Byte[] body, Func<IndexParameters, IndexParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/{2}", index, type, id);
            if ((options != null))
            {
                IndexParameters parameters = options.Invoke(new IndexParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">Document ID</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndexPutAsync(string index, string type, string id, Byte[] body, Func<IndexParameters, IndexParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/{2}", index, type, id);
            if ((options != null))
            {
                IndexParameters parameters = options.Invoke(new IndexParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">Document ID</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IndexPutString(string index, string type, string id, string body, Func<IndexParameters, IndexParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/{2}", index, type, id);
            if ((options != null))
            {
                IndexParameters parameters = options.Invoke(new IndexParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-index_.html"/></summary>
        /// <param name="index">The name of the index</param>
        /// <param name="type">The type of the document</param>
        /// <param name="id">Document ID</param>
        /// <param name="body">The document</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IndexPutStringAsync(string index, string type, string id, string body, Func<IndexParameters, IndexParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/{2}", index, type, id);
            if ((options != null))
            {
                IndexParameters parameters = options.Invoke(new IndexParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("PUT", uri, body);
        }
    }
}
