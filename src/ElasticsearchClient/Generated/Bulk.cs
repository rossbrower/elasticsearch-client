using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage BulkPost(Stream body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = "/_bulk";
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> BulkPostAsync(Stream body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = "/_bulk";
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage BulkPost(byte[] body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = "/_bulk";
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> BulkPostAsync(byte[] body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = "/_bulk";
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage BulkPostString(string body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = "/_bulk";
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> BulkPostStringAsync(string body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = "/_bulk";
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage BulkPut(Stream body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = "/_bulk";
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> BulkPutAsync(Stream body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = "/_bulk";
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage BulkPut(byte[] body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = "/_bulk";
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> BulkPutAsync(byte[] body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = "/_bulk";
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage BulkPutString(string body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = "/_bulk";
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> BulkPutStringAsync(string body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = "/_bulk";
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="index">Default index for items which don't provide one</param>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage BulkPost(string index, Stream body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = string.Format("/{0}/_bulk", index);
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="index">Default index for items which don't provide one</param>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> BulkPostAsync(string index, Stream body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = string.Format("/{0}/_bulk", index);
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="index">Default index for items which don't provide one</param>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage BulkPost(string index, byte[] body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = string.Format("/{0}/_bulk", index);
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="index">Default index for items which don't provide one</param>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> BulkPostAsync(string index, byte[] body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = string.Format("/{0}/_bulk", index);
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="index">Default index for items which don't provide one</param>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage BulkPostString(string index, string body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = string.Format("/{0}/_bulk", index);
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="index">Default index for items which don't provide one</param>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> BulkPostStringAsync(string index, string body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = string.Format("/{0}/_bulk", index);
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="index">Default index for items which don't provide one</param>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage BulkPut(string index, Stream body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = string.Format("/{0}/_bulk", index);
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="index">Default index for items which don't provide one</param>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> BulkPutAsync(string index, Stream body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = string.Format("/{0}/_bulk", index);
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="index">Default index for items which don't provide one</param>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage BulkPut(string index, byte[] body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = string.Format("/{0}/_bulk", index);
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="index">Default index for items which don't provide one</param>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> BulkPutAsync(string index, byte[] body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = string.Format("/{0}/_bulk", index);
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="index">Default index for items which don't provide one</param>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage BulkPutString(string index, string body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = string.Format("/{0}/_bulk", index);
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="index">Default index for items which don't provide one</param>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> BulkPutStringAsync(string index, string body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = string.Format("/{0}/_bulk", index);
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="index">Default index for items which don't provide one</param>
        ///<param name="type">Default document type for items which don't provide one</param>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage BulkPost(string index, string type, Stream body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_bulk", index, type);
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="index">Default index for items which don't provide one</param>
        ///<param name="type">Default document type for items which don't provide one</param>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> BulkPostAsync(string index, string type, Stream body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_bulk", index, type);
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="index">Default index for items which don't provide one</param>
        ///<param name="type">Default document type for items which don't provide one</param>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage BulkPost(string index, string type, byte[] body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_bulk", index, type);
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="index">Default index for items which don't provide one</param>
        ///<param name="type">Default document type for items which don't provide one</param>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> BulkPostAsync(string index, string type, byte[] body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_bulk", index, type);
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="index">Default index for items which don't provide one</param>
        ///<param name="type">Default document type for items which don't provide one</param>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage BulkPostString(string index, string type, string body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_bulk", index, type);
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="index">Default index for items which don't provide one</param>
        ///<param name="type">Default document type for items which don't provide one</param>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> BulkPostStringAsync(string index, string type, string body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_bulk", index, type);
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="index">Default index for items which don't provide one</param>
        ///<param name="type">Default document type for items which don't provide one</param>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage BulkPut(string index, string type, Stream body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_bulk", index, type);
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="index">Default index for items which don't provide one</param>
        ///<param name="type">Default document type for items which don't provide one</param>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> BulkPutAsync(string index, string type, Stream body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_bulk", index, type);
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="index">Default index for items which don't provide one</param>
        ///<param name="type">Default document type for items which don't provide one</param>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage BulkPut(string index, string type, byte[] body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_bulk", index, type);
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="index">Default index for items which don't provide one</param>
        ///<param name="type">Default document type for items which don't provide one</param>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> BulkPutAsync(string index, string type, byte[] body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_bulk", index, type);
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="index">Default index for items which don't provide one</param>
        ///<param name="type">Default document type for items which don't provide one</param>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage BulkPutString(string index, string type, string body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_bulk", index, type);
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
        ///<param name="index">Default index for items which don't provide one</param>
        ///<param name="type">Default document type for items which don't provide one</param>
        ///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> BulkPutStringAsync(string index, string type, string body, Func<BulkParameters, BulkParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_bulk", index, type);
            if (options != null)
            {
                uri = options.Invoke(new BulkParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }
    }
}