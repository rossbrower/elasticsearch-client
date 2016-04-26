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
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage FieldStatsGet(Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = "/_field_stats";
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> FieldStatsGetAsync(Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = "/_field_stats";
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage FieldStatsGet(Stream body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = "/_field_stats";
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> FieldStatsGetAsync(Stream body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = "/_field_stats";
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage FieldStatsGet(Byte[] body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = "/_field_stats";
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> FieldStatsGetAsync(Byte[] body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = "/_field_stats";
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage FieldStatsGetString(string body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = "/_field_stats";
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> FieldStatsGetStringAsync(string body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = "/_field_stats";
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage FieldStatsPost(Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = "/_field_stats";
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> FieldStatsPostAsync(Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = "/_field_stats";
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage FieldStatsPost(Stream body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = "/_field_stats";
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> FieldStatsPostAsync(Stream body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = "/_field_stats";
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage FieldStatsPost(Byte[] body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = "/_field_stats";
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> FieldStatsPostAsync(Byte[] body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = "/_field_stats";
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage FieldStatsPostString(string body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = "/_field_stats";
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> FieldStatsPostStringAsync(string body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = "/_field_stats";
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage FieldStatsGet(string index, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = string.Format("/{0}/_field_stats", index);
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> FieldStatsGetAsync(string index, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = string.Format("/{0}/_field_stats", index);
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage FieldStatsGet(string index, Stream body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = string.Format("/{0}/_field_stats", index);
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> FieldStatsGetAsync(string index, Stream body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = string.Format("/{0}/_field_stats", index);
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage FieldStatsGet(string index, Byte[] body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = string.Format("/{0}/_field_stats", index);
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> FieldStatsGetAsync(string index, Byte[] body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = string.Format("/{0}/_field_stats", index);
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage FieldStatsGetString(string index, string body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = string.Format("/{0}/_field_stats", index);
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> FieldStatsGetStringAsync(string index, string body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = string.Format("/{0}/_field_stats", index);
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage FieldStatsPost(string index, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = string.Format("/{0}/_field_stats", index);
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> FieldStatsPostAsync(string index, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = string.Format("/{0}/_field_stats", index);
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage FieldStatsPost(string index, Stream body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = string.Format("/{0}/_field_stats", index);
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> FieldStatsPostAsync(string index, Stream body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = string.Format("/{0}/_field_stats", index);
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage FieldStatsPost(string index, Byte[] body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = string.Format("/{0}/_field_stats", index);
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> FieldStatsPostAsync(string index, Byte[] body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = string.Format("/{0}/_field_stats", index);
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage FieldStatsPostString(string index, string body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = string.Format("/{0}/_field_stats", index);
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        /// <param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        /// <param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> FieldStatsPostStringAsync(string index, string body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            string uri = string.Format("/{0}/_field_stats", index);
            if ((options != null))
            {
                FieldStatsParameters parameters = options.Invoke(new FieldStatsParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}
