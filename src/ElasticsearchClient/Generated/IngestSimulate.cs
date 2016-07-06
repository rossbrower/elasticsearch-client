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
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        /// <param name="body">The simulate definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IngestSimulateGet(Stream body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            string uri = "/_ingest/pipeline/_simulate";
            if ((options != null))
            {
                IngestSimulateParameters parameters = options.Invoke(new IngestSimulateParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        /// <param name="body">The simulate definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IngestSimulateGetAsync(Stream body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            string uri = "/_ingest/pipeline/_simulate";
            if ((options != null))
            {
                IngestSimulateParameters parameters = options.Invoke(new IngestSimulateParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        /// <param name="body">The simulate definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IngestSimulateGet(Byte[] body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            string uri = "/_ingest/pipeline/_simulate";
            if ((options != null))
            {
                IngestSimulateParameters parameters = options.Invoke(new IngestSimulateParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        /// <param name="body">The simulate definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IngestSimulateGetAsync(Byte[] body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            string uri = "/_ingest/pipeline/_simulate";
            if ((options != null))
            {
                IngestSimulateParameters parameters = options.Invoke(new IngestSimulateParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        /// <param name="body">The simulate definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IngestSimulateGetString(string body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            string uri = "/_ingest/pipeline/_simulate";
            if ((options != null))
            {
                IngestSimulateParameters parameters = options.Invoke(new IngestSimulateParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        /// <param name="body">The simulate definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IngestSimulateGetStringAsync(string body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            string uri = "/_ingest/pipeline/_simulate";
            if ((options != null))
            {
                IngestSimulateParameters parameters = options.Invoke(new IngestSimulateParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        /// <param name="body">The simulate definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IngestSimulatePost(Stream body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            string uri = "/_ingest/pipeline/_simulate";
            if ((options != null))
            {
                IngestSimulateParameters parameters = options.Invoke(new IngestSimulateParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        /// <param name="body">The simulate definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IngestSimulatePostAsync(Stream body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            string uri = "/_ingest/pipeline/_simulate";
            if ((options != null))
            {
                IngestSimulateParameters parameters = options.Invoke(new IngestSimulateParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        /// <param name="body">The simulate definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IngestSimulatePost(Byte[] body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            string uri = "/_ingest/pipeline/_simulate";
            if ((options != null))
            {
                IngestSimulateParameters parameters = options.Invoke(new IngestSimulateParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        /// <param name="body">The simulate definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IngestSimulatePostAsync(Byte[] body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            string uri = "/_ingest/pipeline/_simulate";
            if ((options != null))
            {
                IngestSimulateParameters parameters = options.Invoke(new IngestSimulateParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        /// <param name="body">The simulate definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IngestSimulatePostString(string body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            string uri = "/_ingest/pipeline/_simulate";
            if ((options != null))
            {
                IngestSimulateParameters parameters = options.Invoke(new IngestSimulateParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        /// <param name="body">The simulate definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IngestSimulatePostStringAsync(string body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            string uri = "/_ingest/pipeline/_simulate";
            if ((options != null))
            {
                IngestSimulateParameters parameters = options.Invoke(new IngestSimulateParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        /// <param name="id">Pipeline ID</param>
        /// <param name="body">The simulate definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IngestSimulateGet(string id, Stream body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            string uri = string.Format("/_ingest/pipeline/{0}/_simulate", id);
            if ((options != null))
            {
                IngestSimulateParameters parameters = options.Invoke(new IngestSimulateParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        /// <param name="id">Pipeline ID</param>
        /// <param name="body">The simulate definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IngestSimulateGetAsync(string id, Stream body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            string uri = string.Format("/_ingest/pipeline/{0}/_simulate", id);
            if ((options != null))
            {
                IngestSimulateParameters parameters = options.Invoke(new IngestSimulateParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        /// <param name="id">Pipeline ID</param>
        /// <param name="body">The simulate definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IngestSimulateGet(string id, Byte[] body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            string uri = string.Format("/_ingest/pipeline/{0}/_simulate", id);
            if ((options != null))
            {
                IngestSimulateParameters parameters = options.Invoke(new IngestSimulateParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        /// <param name="id">Pipeline ID</param>
        /// <param name="body">The simulate definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IngestSimulateGetAsync(string id, Byte[] body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            string uri = string.Format("/_ingest/pipeline/{0}/_simulate", id);
            if ((options != null))
            {
                IngestSimulateParameters parameters = options.Invoke(new IngestSimulateParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        /// <param name="id">Pipeline ID</param>
        /// <param name="body">The simulate definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IngestSimulateGetString(string id, string body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            string uri = string.Format("/_ingest/pipeline/{0}/_simulate", id);
            if ((options != null))
            {
                IngestSimulateParameters parameters = options.Invoke(new IngestSimulateParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("GET", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        /// <param name="id">Pipeline ID</param>
        /// <param name="body">The simulate definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IngestSimulateGetStringAsync(string id, string body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            string uri = string.Format("/_ingest/pipeline/{0}/_simulate", id);
            if ((options != null))
            {
                IngestSimulateParameters parameters = options.Invoke(new IngestSimulateParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("GET", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        /// <param name="id">Pipeline ID</param>
        /// <param name="body">The simulate definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IngestSimulatePost(string id, Stream body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            string uri = string.Format("/_ingest/pipeline/{0}/_simulate", id);
            if ((options != null))
            {
                IngestSimulateParameters parameters = options.Invoke(new IngestSimulateParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        /// <param name="id">Pipeline ID</param>
        /// <param name="body">The simulate definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IngestSimulatePostAsync(string id, Stream body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            string uri = string.Format("/_ingest/pipeline/{0}/_simulate", id);
            if ((options != null))
            {
                IngestSimulateParameters parameters = options.Invoke(new IngestSimulateParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        /// <param name="id">Pipeline ID</param>
        /// <param name="body">The simulate definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IngestSimulatePost(string id, Byte[] body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            string uri = string.Format("/_ingest/pipeline/{0}/_simulate", id);
            if ((options != null))
            {
                IngestSimulateParameters parameters = options.Invoke(new IngestSimulateParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        /// <param name="id">Pipeline ID</param>
        /// <param name="body">The simulate definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IngestSimulatePostAsync(string id, Byte[] body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            string uri = string.Format("/_ingest/pipeline/{0}/_simulate", id);
            if ((options != null))
            {
                IngestSimulateParameters parameters = options.Invoke(new IngestSimulateParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        /// <param name="id">Pipeline ID</param>
        /// <param name="body">The simulate definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage IngestSimulatePostString(string id, string body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            string uri = string.Format("/_ingest/pipeline/{0}/_simulate", id);
            if ((options != null))
            {
                IngestSimulateParameters parameters = options.Invoke(new IngestSimulateParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        /// <param name="id">Pipeline ID</param>
        /// <param name="body">The simulate definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> IngestSimulatePostStringAsync(string id, string body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            string uri = string.Format("/_ingest/pipeline/{0}/_simulate", id);
            if ((options != null))
            {
                IngestSimulateParameters parameters = options.Invoke(new IngestSimulateParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}