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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage BulkPost(Stream body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = "/_bulk";
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> BulkPostAsync(Stream body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = "/_bulk";
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage BulkPost(Byte[] body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = "/_bulk";
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> BulkPostAsync(Byte[] body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = "/_bulk";
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage BulkPostString(string body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = "/_bulk";
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> BulkPostStringAsync(string body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = "/_bulk";
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage BulkPut(Stream body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = "/_bulk";
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> BulkPutAsync(Stream body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = "/_bulk";
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage BulkPut(Byte[] body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = "/_bulk";
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> BulkPutAsync(Byte[] body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = "/_bulk";
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage BulkPutString(string body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = "/_bulk";
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> BulkPutStringAsync(string body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = "/_bulk";
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="index">Default index for items which don't provide one</param>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage BulkPost(string index, Stream body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = string.Format("/{0}/_bulk", index);
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="index">Default index for items which don't provide one</param>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> BulkPostAsync(string index, Stream body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = string.Format("/{0}/_bulk", index);
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="index">Default index for items which don't provide one</param>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage BulkPost(string index, Byte[] body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = string.Format("/{0}/_bulk", index);
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="index">Default index for items which don't provide one</param>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> BulkPostAsync(string index, Byte[] body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = string.Format("/{0}/_bulk", index);
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="index">Default index for items which don't provide one</param>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage BulkPostString(string index, string body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = string.Format("/{0}/_bulk", index);
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="index">Default index for items which don't provide one</param>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> BulkPostStringAsync(string index, string body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = string.Format("/{0}/_bulk", index);
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="index">Default index for items which don't provide one</param>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage BulkPut(string index, Stream body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = string.Format("/{0}/_bulk", index);
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="index">Default index for items which don't provide one</param>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> BulkPutAsync(string index, Stream body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = string.Format("/{0}/_bulk", index);
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="index">Default index for items which don't provide one</param>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage BulkPut(string index, Byte[] body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = string.Format("/{0}/_bulk", index);
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="index">Default index for items which don't provide one</param>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> BulkPutAsync(string index, Byte[] body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = string.Format("/{0}/_bulk", index);
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="index">Default index for items which don't provide one</param>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage BulkPutString(string index, string body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = string.Format("/{0}/_bulk", index);
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="index">Default index for items which don't provide one</param>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> BulkPutStringAsync(string index, string body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = string.Format("/{0}/_bulk", index);
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="index">Default index for items which don't provide one</param>
        /// <param name="type">Default document type for items which don't provide one</param>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage BulkPost(string index, string type, Stream body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_bulk", index, type);
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="index">Default index for items which don't provide one</param>
        /// <param name="type">Default document type for items which don't provide one</param>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> BulkPostAsync(string index, string type, Stream body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_bulk", index, type);
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="index">Default index for items which don't provide one</param>
        /// <param name="type">Default document type for items which don't provide one</param>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage BulkPost(string index, string type, Byte[] body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_bulk", index, type);
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="index">Default index for items which don't provide one</param>
        /// <param name="type">Default document type for items which don't provide one</param>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> BulkPostAsync(string index, string type, Byte[] body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_bulk", index, type);
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="index">Default index for items which don't provide one</param>
        /// <param name="type">Default document type for items which don't provide one</param>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage BulkPostString(string index, string type, string body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_bulk", index, type);
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="index">Default index for items which don't provide one</param>
        /// <param name="type">Default document type for items which don't provide one</param>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> BulkPostStringAsync(string index, string type, string body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_bulk", index, type);
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="index">Default index for items which don't provide one</param>
        /// <param name="type">Default document type for items which don't provide one</param>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage BulkPut(string index, string type, Stream body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_bulk", index, type);
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="index">Default index for items which don't provide one</param>
        /// <param name="type">Default document type for items which don't provide one</param>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> BulkPutAsync(string index, string type, Stream body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_bulk", index, type);
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="index">Default index for items which don't provide one</param>
        /// <param name="type">Default document type for items which don't provide one</param>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage BulkPut(string index, string type, Byte[] body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_bulk", index, type);
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="index">Default index for items which don't provide one</param>
        /// <param name="type">Default document type for items which don't provide one</param>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> BulkPutAsync(string index, string type, Byte[] body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_bulk", index, type);
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="index">Default index for items which don't provide one</param>
        /// <param name="type">Default document type for items which don't provide one</param>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage BulkPutString(string index, string type, string body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_bulk", index, type);
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-bulk.html"/></summary>
        /// <param name="index">Default index for items which don't provide one</param>
        /// <param name="type">Default document type for items which don't provide one</param>
        /// <param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> BulkPutStringAsync(string index, string type, string body, Func<BulkParameters, BulkParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_bulk", index, type);
            if ((options != null))
            {
                BulkParameters parameters = options.Invoke(new BulkParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("PUT", uri, body);
        }
    }
}
