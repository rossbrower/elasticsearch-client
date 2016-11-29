using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
        ///<param name="body">The simulate definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IngestSimulateGet(Stream body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            var uri = "/_ingest/pipeline/_simulate";
            if (options != null)
            {
                uri = options.Invoke(new IngestSimulateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
        ///<param name="body">The simulate definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IngestSimulateGetAsync(Stream body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            var uri = "/_ingest/pipeline/_simulate";
            if (options != null)
            {
                uri = options.Invoke(new IngestSimulateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
        ///<param name="body">The simulate definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IngestSimulateGet(byte[] body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            var uri = "/_ingest/pipeline/_simulate";
            if (options != null)
            {
                uri = options.Invoke(new IngestSimulateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
        ///<param name="body">The simulate definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IngestSimulateGetAsync(byte[] body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            var uri = "/_ingest/pipeline/_simulate";
            if (options != null)
            {
                uri = options.Invoke(new IngestSimulateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
        ///<param name="body">The simulate definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IngestSimulateGetString(string body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            var uri = "/_ingest/pipeline/_simulate";
            if (options != null)
            {
                uri = options.Invoke(new IngestSimulateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
        ///<param name="body">The simulate definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IngestSimulateGetStringAsync(string body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            var uri = "/_ingest/pipeline/_simulate";
            if (options != null)
            {
                uri = options.Invoke(new IngestSimulateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
        ///<param name="body">The simulate definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IngestSimulatePost(Stream body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            var uri = "/_ingest/pipeline/_simulate";
            if (options != null)
            {
                uri = options.Invoke(new IngestSimulateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
        ///<param name="body">The simulate definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IngestSimulatePostAsync(Stream body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            var uri = "/_ingest/pipeline/_simulate";
            if (options != null)
            {
                uri = options.Invoke(new IngestSimulateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
        ///<param name="body">The simulate definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IngestSimulatePost(byte[] body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            var uri = "/_ingest/pipeline/_simulate";
            if (options != null)
            {
                uri = options.Invoke(new IngestSimulateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
        ///<param name="body">The simulate definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IngestSimulatePostAsync(byte[] body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            var uri = "/_ingest/pipeline/_simulate";
            if (options != null)
            {
                uri = options.Invoke(new IngestSimulateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
        ///<param name="body">The simulate definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IngestSimulatePostString(string body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            var uri = "/_ingest/pipeline/_simulate";
            if (options != null)
            {
                uri = options.Invoke(new IngestSimulateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
        ///<param name="body">The simulate definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IngestSimulatePostStringAsync(string body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            var uri = "/_ingest/pipeline/_simulate";
            if (options != null)
            {
                uri = options.Invoke(new IngestSimulateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
        ///<param name="id">Pipeline ID</param>
        ///<param name="body">The simulate definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IngestSimulateGet(string id, Stream body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            var uri = string.Format("/_ingest/pipeline/{0}/_simulate", id);
            if (options != null)
            {
                uri = options.Invoke(new IngestSimulateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
        ///<param name="id">Pipeline ID</param>
        ///<param name="body">The simulate definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IngestSimulateGetAsync(string id, Stream body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            var uri = string.Format("/_ingest/pipeline/{0}/_simulate", id);
            if (options != null)
            {
                uri = options.Invoke(new IngestSimulateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
        ///<param name="id">Pipeline ID</param>
        ///<param name="body">The simulate definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IngestSimulateGet(string id, byte[] body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            var uri = string.Format("/_ingest/pipeline/{0}/_simulate", id);
            if (options != null)
            {
                uri = options.Invoke(new IngestSimulateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
        ///<param name="id">Pipeline ID</param>
        ///<param name="body">The simulate definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IngestSimulateGetAsync(string id, byte[] body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            var uri = string.Format("/_ingest/pipeline/{0}/_simulate", id);
            if (options != null)
            {
                uri = options.Invoke(new IngestSimulateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
        ///<param name="id">Pipeline ID</param>
        ///<param name="body">The simulate definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IngestSimulateGetString(string id, string body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            var uri = string.Format("/_ingest/pipeline/{0}/_simulate", id);
            if (options != null)
            {
                uri = options.Invoke(new IngestSimulateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
        ///<param name="id">Pipeline ID</param>
        ///<param name="body">The simulate definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IngestSimulateGetStringAsync(string id, string body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            var uri = string.Format("/_ingest/pipeline/{0}/_simulate", id);
            if (options != null)
            {
                uri = options.Invoke(new IngestSimulateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
        ///<param name="id">Pipeline ID</param>
        ///<param name="body">The simulate definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IngestSimulatePost(string id, Stream body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            var uri = string.Format("/_ingest/pipeline/{0}/_simulate", id);
            if (options != null)
            {
                uri = options.Invoke(new IngestSimulateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
        ///<param name="id">Pipeline ID</param>
        ///<param name="body">The simulate definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IngestSimulatePostAsync(string id, Stream body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            var uri = string.Format("/_ingest/pipeline/{0}/_simulate", id);
            if (options != null)
            {
                uri = options.Invoke(new IngestSimulateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
        ///<param name="id">Pipeline ID</param>
        ///<param name="body">The simulate definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IngestSimulatePost(string id, byte[] body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            var uri = string.Format("/_ingest/pipeline/{0}/_simulate", id);
            if (options != null)
            {
                uri = options.Invoke(new IngestSimulateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
        ///<param name="id">Pipeline ID</param>
        ///<param name="body">The simulate definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IngestSimulatePostAsync(string id, byte[] body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            var uri = string.Format("/_ingest/pipeline/{0}/_simulate", id);
            if (options != null)
            {
                uri = options.Invoke(new IngestSimulateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
        ///<param name="id">Pipeline ID</param>
        ///<param name="body">The simulate definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IngestSimulatePostString(string id, string body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            var uri = string.Format("/_ingest/pipeline/{0}/_simulate", id);
            if (options != null)
            {
                uri = options.Invoke(new IngestSimulateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
        ///<param name="id">Pipeline ID</param>
        ///<param name="body">The simulate definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IngestSimulatePostStringAsync(string id, string body, Func<IngestSimulateParameters, IngestSimulateParameters> options = null)
        {
            var uri = string.Format("/_ingest/pipeline/{0}/_simulate", id);
            if (options != null)
            {
                uri = options.Invoke(new IngestSimulateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}