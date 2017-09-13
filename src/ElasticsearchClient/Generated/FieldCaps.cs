using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldCapsGet(Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = "/_field_caps";
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldCapsGetAsync(Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = "/_field_caps";
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="body">Field json objects containing an array of field names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldCapsGet(Stream body, Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = "/_field_caps";
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="body">Field json objects containing an array of field names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldCapsGetAsync(Stream body, Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = "/_field_caps";
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="body">Field json objects containing an array of field names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldCapsGet(byte[] body, Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = "/_field_caps";
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="body">Field json objects containing an array of field names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldCapsGetAsync(byte[] body, Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = "/_field_caps";
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="body">Field json objects containing an array of field names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldCapsGetString(string body, Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = "/_field_caps";
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="body">Field json objects containing an array of field names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldCapsGetStringAsync(string body, Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = "/_field_caps";
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldCapsPost(Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = "/_field_caps";
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldCapsPostAsync(Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = "/_field_caps";
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="body">Field json objects containing an array of field names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldCapsPost(Stream body, Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = "/_field_caps";
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="body">Field json objects containing an array of field names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldCapsPostAsync(Stream body, Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = "/_field_caps";
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="body">Field json objects containing an array of field names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldCapsPost(byte[] body, Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = "/_field_caps";
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="body">Field json objects containing an array of field names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldCapsPostAsync(byte[] body, Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = "/_field_caps";
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="body">Field json objects containing an array of field names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldCapsPostString(string body, Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = "/_field_caps";
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="body">Field json objects containing an array of field names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldCapsPostStringAsync(string body, Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = "/_field_caps";
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldCapsGet(string index, Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_caps", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldCapsGetAsync(string index, Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_caps", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">Field json objects containing an array of field names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldCapsGet(string index, Stream body, Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_caps", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">Field json objects containing an array of field names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldCapsGetAsync(string index, Stream body, Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_caps", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">Field json objects containing an array of field names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldCapsGet(string index, byte[] body, Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_caps", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">Field json objects containing an array of field names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldCapsGetAsync(string index, byte[] body, Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_caps", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">Field json objects containing an array of field names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldCapsGetString(string index, string body, Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_caps", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">Field json objects containing an array of field names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldCapsGetStringAsync(string index, string body, Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_caps", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldCapsPost(string index, Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_caps", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldCapsPostAsync(string index, Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_caps", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">Field json objects containing an array of field names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldCapsPost(string index, Stream body, Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_caps", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">Field json objects containing an array of field names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldCapsPostAsync(string index, Stream body, Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_caps", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">Field json objects containing an array of field names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldCapsPost(string index, byte[] body, Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_caps", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">Field json objects containing an array of field names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldCapsPostAsync(string index, byte[] body, Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_caps", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">Field json objects containing an array of field names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldCapsPostString(string index, string body, Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_caps", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-field-caps.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">Field json objects containing an array of field names</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldCapsPostStringAsync(string index, string body, Func<FieldCapsParameters, FieldCapsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_caps", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldCapsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}