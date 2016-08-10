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
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-update-by-query.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage UpdateByQuery(string index, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            string uri = string.Format("/{0}/_update_by_query", index);
            if ((options != null))
            {
                UpdateByQueryParameters parameters = options.Invoke(new UpdateByQueryParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-update-by-query.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> UpdateByQueryAsync(string index, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            string uri = string.Format("/{0}/_update_by_query", index);
            if ((options != null))
            {
                UpdateByQueryParameters parameters = options.Invoke(new UpdateByQueryParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-update-by-query.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="body">The search definition using the Query DSL</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage UpdateByQuery(string index, Stream body, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            string uri = string.Format("/{0}/_update_by_query", index);
            if ((options != null))
            {
                UpdateByQueryParameters parameters = options.Invoke(new UpdateByQueryParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-update-by-query.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="body">The search definition using the Query DSL</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> UpdateByQueryAsync(string index, Stream body, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            string uri = string.Format("/{0}/_update_by_query", index);
            if ((options != null))
            {
                UpdateByQueryParameters parameters = options.Invoke(new UpdateByQueryParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-update-by-query.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="body">The search definition using the Query DSL</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage UpdateByQuery(string index, Byte[] body, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            string uri = string.Format("/{0}/_update_by_query", index);
            if ((options != null))
            {
                UpdateByQueryParameters parameters = options.Invoke(new UpdateByQueryParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-update-by-query.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="body">The search definition using the Query DSL</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> UpdateByQueryAsync(string index, Byte[] body, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            string uri = string.Format("/{0}/_update_by_query", index);
            if ((options != null))
            {
                UpdateByQueryParameters parameters = options.Invoke(new UpdateByQueryParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-update-by-query.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="body">The search definition using the Query DSL</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage UpdateByQueryString(string index, string body, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            string uri = string.Format("/{0}/_update_by_query", index);
            if ((options != null))
            {
                UpdateByQueryParameters parameters = options.Invoke(new UpdateByQueryParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-update-by-query.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="body">The search definition using the Query DSL</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> UpdateByQueryStringAsync(string index, string body, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            string uri = string.Format("/{0}/_update_by_query", index);
            if ((options != null))
            {
                UpdateByQueryParameters parameters = options.Invoke(new UpdateByQueryParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-update-by-query.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage UpdateByQuery(string index, string type, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_update_by_query", index, type);
            if ((options != null))
            {
                UpdateByQueryParameters parameters = options.Invoke(new UpdateByQueryParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-update-by-query.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> UpdateByQueryAsync(string index, string type, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_update_by_query", index, type);
            if ((options != null))
            {
                UpdateByQueryParameters parameters = options.Invoke(new UpdateByQueryParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-update-by-query.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        /// <param name="body">The search definition using the Query DSL</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage UpdateByQuery(string index, string type, Stream body, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_update_by_query", index, type);
            if ((options != null))
            {
                UpdateByQueryParameters parameters = options.Invoke(new UpdateByQueryParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-update-by-query.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        /// <param name="body">The search definition using the Query DSL</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> UpdateByQueryAsync(string index, string type, Stream body, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_update_by_query", index, type);
            if ((options != null))
            {
                UpdateByQueryParameters parameters = options.Invoke(new UpdateByQueryParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-update-by-query.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        /// <param name="body">The search definition using the Query DSL</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage UpdateByQuery(string index, string type, Byte[] body, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_update_by_query", index, type);
            if ((options != null))
            {
                UpdateByQueryParameters parameters = options.Invoke(new UpdateByQueryParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-update-by-query.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        /// <param name="body">The search definition using the Query DSL</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> UpdateByQueryAsync(string index, string type, Byte[] body, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_update_by_query", index, type);
            if ((options != null))
            {
                UpdateByQueryParameters parameters = options.Invoke(new UpdateByQueryParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-update-by-query.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        /// <param name="body">The search definition using the Query DSL</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage UpdateByQueryString(string index, string type, string body, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_update_by_query", index, type);
            if ((options != null))
            {
                UpdateByQueryParameters parameters = options.Invoke(new UpdateByQueryParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.3/docs-update-by-query.html"/></summary>
        /// <param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        /// <param name="body">The search definition using the Query DSL</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> UpdateByQueryStringAsync(string index, string type, string body, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            string uri = string.Format("/{0}/{1}/_update_by_query", index, type);
            if ((options != null))
            {
                UpdateByQueryParameters parameters = options.Invoke(new UpdateByQueryParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}
