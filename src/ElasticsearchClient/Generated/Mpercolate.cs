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
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage MpercolateGet(Stream body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = "/_mpercolate";
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> MpercolateGetAsync(Stream body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = "/_mpercolate";
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage MpercolateGet(Byte[] body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = "/_mpercolate";
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> MpercolateGetAsync(Byte[] body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = "/_mpercolate";
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage MpercolateGetString(string body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = "/_mpercolate";
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> MpercolateGetStringAsync(string body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = "/_mpercolate";
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage MpercolatePost(Stream body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = "/_mpercolate";
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> MpercolatePostAsync(Stream body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = "/_mpercolate";
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage MpercolatePost(Byte[] body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = "/_mpercolate";
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> MpercolatePostAsync(Byte[] body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = "/_mpercolate";
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage MpercolatePostString(string body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = "/_mpercolate";
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> MpercolatePostStringAsync(string body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = "/_mpercolate";
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being count percolated to use as default</param>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage MpercolateGet(string index, Stream body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = string.Format("/{0}/_mpercolate", index);
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being count percolated to use as default</param>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> MpercolateGetAsync(string index, Stream body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = string.Format("/{0}/_mpercolate", index);
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being count percolated to use as default</param>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage MpercolateGet(string index, Byte[] body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = string.Format("/{0}/_mpercolate", index);
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being count percolated to use as default</param>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> MpercolateGetAsync(string index, Byte[] body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = string.Format("/{0}/_mpercolate", index);
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being count percolated to use as default</param>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage MpercolateGetString(string index, string body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = string.Format("/{0}/_mpercolate", index);
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being count percolated to use as default</param>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> MpercolateGetStringAsync(string index, string body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = string.Format("/{0}/_mpercolate", index);
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being count percolated to use as default</param>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage MpercolatePost(string index, Stream body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = string.Format("/{0}/_mpercolate", index);
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being count percolated to use as default</param>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> MpercolatePostAsync(string index, Stream body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = string.Format("/{0}/_mpercolate", index);
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being count percolated to use as default</param>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage MpercolatePost(string index, Byte[] body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = string.Format("/{0}/_mpercolate", index);
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being count percolated to use as default</param>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> MpercolatePostAsync(string index, Byte[] body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = string.Format("/{0}/_mpercolate", index);
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being count percolated to use as default</param>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage MpercolatePostString(string index, string body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = string.Format("/{0}/_mpercolate", index);
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being count percolated to use as default</param>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> MpercolatePostStringAsync(string index, string body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = string.Format("/{0}/_mpercolate", index);
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being count percolated to use as default</param>
        /// <param name="type">The type of the document being percolated to use as default.</param>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage MpercolateGet(string index, string type, Stream body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_mpercolate", index, type);
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being count percolated to use as default</param>
        /// <param name="type">The type of the document being percolated to use as default.</param>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> MpercolateGetAsync(string index, string type, Stream body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_mpercolate", index, type);
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being count percolated to use as default</param>
        /// <param name="type">The type of the document being percolated to use as default.</param>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage MpercolateGet(string index, string type, Byte[] body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_mpercolate", index, type);
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being count percolated to use as default</param>
        /// <param name="type">The type of the document being percolated to use as default.</param>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> MpercolateGetAsync(string index, string type, Byte[] body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_mpercolate", index, type);
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being count percolated to use as default</param>
        /// <param name="type">The type of the document being percolated to use as default.</param>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage MpercolateGetString(string index, string type, string body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_mpercolate", index, type);
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being count percolated to use as default</param>
        /// <param name="type">The type of the document being percolated to use as default.</param>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> MpercolateGetStringAsync(string index, string type, string body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_mpercolate", index, type);
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being count percolated to use as default</param>
        /// <param name="type">The type of the document being percolated to use as default.</param>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage MpercolatePost(string index, string type, Stream body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_mpercolate", index, type);
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being count percolated to use as default</param>
        /// <param name="type">The type of the document being percolated to use as default.</param>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> MpercolatePostAsync(string index, string type, Stream body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_mpercolate", index, type);
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being count percolated to use as default</param>
        /// <param name="type">The type of the document being percolated to use as default.</param>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage MpercolatePost(string index, string type, Byte[] body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_mpercolate", index, type);
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being count percolated to use as default</param>
        /// <param name="type">The type of the document being percolated to use as default.</param>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> MpercolatePostAsync(string index, string type, Byte[] body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_mpercolate", index, type);
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being count percolated to use as default</param>
        /// <param name="type">The type of the document being percolated to use as default.</param>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage MpercolatePostString(string index, string type, string body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_mpercolate", index, type);
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return this.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        /// <param name="index">The index of the document being count percolated to use as default</param>
        /// <param name="type">The type of the document being percolated to use as default.</param>
        /// <param name="body">The percolate request definitions (header & body pair), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> MpercolatePostStringAsync(string index, string type, string body, Func<MpercolateParameters, MpercolateParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_mpercolate", index, type);
            if ((options != null))
            {
                MpercolateParameters parameters = options.Invoke(new MpercolateParameters());
                uri = parameters.GetUri(uri);
            }
            return await this.ExecuteAsync("POST", uri, body);
        }
    }
}
