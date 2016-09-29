using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        ///<param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
        ///<param name="name">The name of the alias to be created or updated</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutAliasPut(string index, string name, Func<IndicesPutAliasParameters, IndicesPutAliasParameters> options = null)
        {
            var uri = $"{"/{0}/_alias/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutAliasParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        ///<param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
        ///<param name="name">The name of the alias to be created or updated</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutAliasPutAsync(string index, string name, Func<IndicesPutAliasParameters, IndicesPutAliasParameters> options = null)
        {
            var uri = $"{"/{0}/_alias/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutAliasParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        ///<param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
        ///<param name="name">The name of the alias to be created or updated</param>
        ///<param name="body">The settings for the alias, such as `routing` or `filter`</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutAliasPut(string index, string name, Stream body, Func<IndicesPutAliasParameters, IndicesPutAliasParameters> options = null)
        {
            var uri = $"{"/{0}/_alias/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutAliasParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        ///<param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
        ///<param name="name">The name of the alias to be created or updated</param>
        ///<param name="body">The settings for the alias, such as `routing` or `filter`</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutAliasPutAsync(string index, string name, Stream body, Func<IndicesPutAliasParameters, IndicesPutAliasParameters> options = null)
        {
            var uri = $"{"/{0}/_alias/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutAliasParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        ///<param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
        ///<param name="name">The name of the alias to be created or updated</param>
        ///<param name="body">The settings for the alias, such as `routing` or `filter`</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutAliasPut(string index, string name, byte[] body, Func<IndicesPutAliasParameters, IndicesPutAliasParameters> options = null)
        {
            var uri = $"{"/{0}/_alias/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutAliasParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        ///<param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
        ///<param name="name">The name of the alias to be created or updated</param>
        ///<param name="body">The settings for the alias, such as `routing` or `filter`</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutAliasPutAsync(string index, string name, byte[] body, Func<IndicesPutAliasParameters, IndicesPutAliasParameters> options = null)
        {
            var uri = $"{"/{0}/_alias/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutAliasParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        ///<param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
        ///<param name="name">The name of the alias to be created or updated</param>
        ///<param name="body">The settings for the alias, such as `routing` or `filter`</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutAliasPutString(string index, string name, string body, Func<IndicesPutAliasParameters, IndicesPutAliasParameters> options = null)
        {
            var uri = $"{"/{0}/_alias/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutAliasParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        ///<param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
        ///<param name="name">The name of the alias to be created or updated</param>
        ///<param name="body">The settings for the alias, such as `routing` or `filter`</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutAliasPutStringAsync(string index, string name, string body, Func<IndicesPutAliasParameters, IndicesPutAliasParameters> options = null)
        {
            var uri = $"{"/{0}/_alias/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutAliasParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        ///<param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
        ///<param name="name">The name of the alias to be created or updated</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutAliasPost(string index, string name, Func<IndicesPutAliasParameters, IndicesPutAliasParameters> options = null)
        {
            var uri = $"{"/{0}/_alias/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutAliasParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        ///<param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
        ///<param name="name">The name of the alias to be created or updated</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutAliasPostAsync(string index, string name, Func<IndicesPutAliasParameters, IndicesPutAliasParameters> options = null)
        {
            var uri = $"{"/{0}/_alias/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutAliasParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        ///<param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
        ///<param name="name">The name of the alias to be created or updated</param>
        ///<param name="body">The settings for the alias, such as `routing` or `filter`</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutAliasPost(string index, string name, Stream body, Func<IndicesPutAliasParameters, IndicesPutAliasParameters> options = null)
        {
            var uri = $"{"/{0}/_alias/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutAliasParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        ///<param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
        ///<param name="name">The name of the alias to be created or updated</param>
        ///<param name="body">The settings for the alias, such as `routing` or `filter`</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutAliasPostAsync(string index, string name, Stream body, Func<IndicesPutAliasParameters, IndicesPutAliasParameters> options = null)
        {
            var uri = $"{"/{0}/_alias/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutAliasParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        ///<param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
        ///<param name="name">The name of the alias to be created or updated</param>
        ///<param name="body">The settings for the alias, such as `routing` or `filter`</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutAliasPost(string index, string name, byte[] body, Func<IndicesPutAliasParameters, IndicesPutAliasParameters> options = null)
        {
            var uri = $"{"/{0}/_alias/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutAliasParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        ///<param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
        ///<param name="name">The name of the alias to be created or updated</param>
        ///<param name="body">The settings for the alias, such as `routing` or `filter`</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutAliasPostAsync(string index, string name, byte[] body, Func<IndicesPutAliasParameters, IndicesPutAliasParameters> options = null)
        {
            var uri = $"{"/{0}/_alias/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutAliasParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        ///<param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
        ///<param name="name">The name of the alias to be created or updated</param>
        ///<param name="body">The settings for the alias, such as `routing` or `filter`</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutAliasPostString(string index, string name, string body, Func<IndicesPutAliasParameters, IndicesPutAliasParameters> options = null)
        {
            var uri = $"{"/{0}/_alias/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutAliasParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-aliases.html"/></summary>
        ///<param name="index">A comma-separated list of index names the alias should point to (supports wildcards); use `_all` to perform the operation on all indices.</param>
        ///<param name="name">The name of the alias to be created or updated</param>
        ///<param name="body">The settings for the alias, such as `routing` or `filter`</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutAliasPostStringAsync(string index, string name, string body, Func<IndicesPutAliasParameters, IndicesPutAliasParameters> options = null)
        {
            var uri = $"{"/{0}/_alias/{1}"}";
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutAliasParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}