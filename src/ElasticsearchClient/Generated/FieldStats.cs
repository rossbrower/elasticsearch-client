using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldStatsGet(Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = "/_field_stats";
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldStatsGetAsync(Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = "/_field_stats";
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldStatsGet(Stream body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = "/_field_stats";
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldStatsGetAsync(Stream body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = "/_field_stats";
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldStatsGet(byte[] body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = "/_field_stats";
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldStatsGetAsync(byte[] body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = "/_field_stats";
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldStatsGetString(string body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = "/_field_stats";
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldStatsGetStringAsync(string body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = "/_field_stats";
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldStatsPost(Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = "/_field_stats";
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldStatsPostAsync(Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = "/_field_stats";
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldStatsPost(Stream body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = "/_field_stats";
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldStatsPostAsync(Stream body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = "/_field_stats";
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldStatsPost(byte[] body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = "/_field_stats";
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldStatsPostAsync(byte[] body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = "/_field_stats";
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldStatsPostString(string body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = "/_field_stats";
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldStatsPostStringAsync(string body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = "/_field_stats";
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldStatsGet(string index, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_stats", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldStatsGetAsync(string index, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_stats", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldStatsGet(string index, Stream body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_stats", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldStatsGetAsync(string index, Stream body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_stats", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldStatsGet(string index, byte[] body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_stats", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldStatsGetAsync(string index, byte[] body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_stats", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldStatsGetString(string index, string body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_stats", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldStatsGetStringAsync(string index, string body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_stats", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldStatsPost(string index, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_stats", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldStatsPostAsync(string index, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_stats", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldStatsPost(string index, Stream body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_stats", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldStatsPostAsync(string index, Stream body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_stats", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldStatsPost(string index, byte[] body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_stats", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldStatsPostAsync(string index, byte[] body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_stats", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage FieldStatsPostString(string index, string body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_stats", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-field-stats.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">Field json objects containing the name and optionally a range to filter out indices result, that have results outside the defined bounds</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> FieldStatsPostStringAsync(string index, string body, Func<FieldStatsParameters, FieldStatsParameters> options = null)
        {
            var uri = string.Format("/{0}/_field_stats", index);
            if (options != null)
            {
                uri = options.Invoke(new FieldStatsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}