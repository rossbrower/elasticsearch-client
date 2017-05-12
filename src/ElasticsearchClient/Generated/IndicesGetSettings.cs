using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-settings.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesGetSettings(Func<IndicesGetSettingsParameters, IndicesGetSettingsParameters> options = null)
        {
            var uri = "/_settings";
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetSettingsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-settings.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesGetSettingsAsync(Func<IndicesGetSettingsParameters, IndicesGetSettingsParameters> options = null)
        {
            var uri = "/_settings";
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetSettingsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-settings.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesGetSettings(string index, Func<IndicesGetSettingsParameters, IndicesGetSettingsParameters> options = null)
        {
            var uri = string.Format("/{0}/_settings", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetSettingsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-settings.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesGetSettingsAsync(string index, Func<IndicesGetSettingsParameters, IndicesGetSettingsParameters> options = null)
        {
            var uri = string.Format("/{0}/_settings", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetSettingsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-settings.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="name">The name of the settings that should be included</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesGetSettings(string index, string name, Func<IndicesGetSettingsParameters, IndicesGetSettingsParameters> options = null)
        {
            var uri = string.Format("/{0}/_settings/{1}", index, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetSettingsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-get-settings.html"/></summary>
        ///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="name">The name of the settings that should be included</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesGetSettingsAsync(string index, string name, Func<IndicesGetSettingsParameters, IndicesGetSettingsParameters> options = null)
        {
            var uri = string.Format("/{0}/_settings/{1}", index, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetSettingsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}