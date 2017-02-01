using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-suggesters.html"/></summary>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage Suggest(Stream body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = "/_suggest";
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-suggesters.html"/></summary>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SuggestAsync(Stream body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = "/_suggest";
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-suggesters.html"/></summary>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage Suggest(byte[] body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = "/_suggest";
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-suggesters.html"/></summary>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SuggestAsync(byte[] body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = "/_suggest";
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-suggesters.html"/></summary>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SuggestString(string body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = "/_suggest";
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-suggesters.html"/></summary>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SuggestStringAsync(string body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = "/_suggest";
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-suggesters.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage Suggest(string index, Stream body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = string.Format("/{0}/_suggest", index);
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-suggesters.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SuggestAsync(string index, Stream body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = string.Format("/{0}/_suggest", index);
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-suggesters.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage Suggest(string index, byte[] body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = string.Format("/{0}/_suggest", index);
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-suggesters.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SuggestAsync(string index, byte[] body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = string.Format("/{0}/_suggest", index);
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-suggesters.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SuggestString(string index, string body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = string.Format("/{0}/_suggest", index);
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/search-suggesters.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The request definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SuggestStringAsync(string index, string body, Func<SuggestParameters, SuggestParameters> options = null)
        {
            var uri = string.Format("/{0}/_suggest", index);
            if (options != null)
            {
                uri = options.Invoke(new SuggestParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}