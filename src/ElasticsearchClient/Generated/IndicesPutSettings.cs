using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-update-settings.html"/></summary>
        ///<param name="body">The index settings to be updated</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutSettings(Stream body, Func<IndicesPutSettingsParameters, IndicesPutSettingsParameters> options = null)
        {
            var uri = "/_settings";
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutSettingsParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-update-settings.html"/></summary>
        ///<param name="body">The index settings to be updated</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutSettingsAsync(Stream body, Func<IndicesPutSettingsParameters, IndicesPutSettingsParameters> options = null)
        {
            var uri = "/_settings";
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutSettingsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-update-settings.html"/></summary>
        ///<param name="body">The index settings to be updated</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutSettings(byte[] body, Func<IndicesPutSettingsParameters, IndicesPutSettingsParameters> options = null)
        {
            var uri = "/_settings";
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutSettingsParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-update-settings.html"/></summary>
        ///<param name="body">The index settings to be updated</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutSettingsAsync(byte[] body, Func<IndicesPutSettingsParameters, IndicesPutSettingsParameters> options = null)
        {
            var uri = "/_settings";
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutSettingsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-update-settings.html"/></summary>
        ///<param name="body">The index settings to be updated</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutSettingsString(string body, Func<IndicesPutSettingsParameters, IndicesPutSettingsParameters> options = null)
        {
            var uri = "/_settings";
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutSettingsParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-update-settings.html"/></summary>
        ///<param name="body">The index settings to be updated</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutSettingsStringAsync(string body, Func<IndicesPutSettingsParameters, IndicesPutSettingsParameters> options = null)
        {
            var uri = "/_settings";
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutSettingsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-update-settings.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The index settings to be updated</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutSettings(string index, Stream body, Func<IndicesPutSettingsParameters, IndicesPutSettingsParameters> options = null)
        {
            var uri = $"{"/{0}/_settings"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutSettingsParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-update-settings.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The index settings to be updated</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutSettingsAsync(string index, Stream body, Func<IndicesPutSettingsParameters, IndicesPutSettingsParameters> options = null)
        {
            var uri = $"{"/{0}/_settings"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutSettingsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-update-settings.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The index settings to be updated</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutSettings(string index, byte[] body, Func<IndicesPutSettingsParameters, IndicesPutSettingsParameters> options = null)
        {
            var uri = $"{"/{0}/_settings"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutSettingsParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-update-settings.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The index settings to be updated</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutSettingsAsync(string index, byte[] body, Func<IndicesPutSettingsParameters, IndicesPutSettingsParameters> options = null)
        {
            var uri = $"{"/{0}/_settings"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutSettingsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-update-settings.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The index settings to be updated</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutSettingsString(string index, string body, Func<IndicesPutSettingsParameters, IndicesPutSettingsParameters> options = null)
        {
            var uri = $"{"/{0}/_settings"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutSettingsParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-update-settings.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The index settings to be updated</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutSettingsStringAsync(string index, string body, Func<IndicesPutSettingsParameters, IndicesPutSettingsParameters> options = null)
        {
            var uri = $"{"/{0}/_settings"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutSettingsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }
    }
}