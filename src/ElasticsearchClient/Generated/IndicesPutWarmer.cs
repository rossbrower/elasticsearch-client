using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutWarmerPut(string name, Stream body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/_warmer/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutWarmerPutAsync(string name, Stream body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/_warmer/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutWarmerPut(string name, byte[] body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/_warmer/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutWarmerPutAsync(string name, byte[] body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/_warmer/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutWarmerPutString(string name, string body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/_warmer/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutWarmerPutStringAsync(string name, string body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/_warmer/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutWarmerPost(string name, Stream body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/_warmer/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutWarmerPostAsync(string name, Stream body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/_warmer/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutWarmerPost(string name, byte[] body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/_warmer/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutWarmerPostAsync(string name, byte[] body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/_warmer/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutWarmerPostString(string name, string body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/_warmer/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutWarmerPostStringAsync(string name, string body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/_warmer/{0}", name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutWarmerPut(string index, string name, Stream body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/_warmer/{1}", index, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutWarmerPutAsync(string index, string name, Stream body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/_warmer/{1}", index, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutWarmerPut(string index, string name, byte[] body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/_warmer/{1}", index, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutWarmerPutAsync(string index, string name, byte[] body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/_warmer/{1}", index, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutWarmerPutString(string index, string name, string body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/_warmer/{1}", index, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutWarmerPutStringAsync(string index, string name, string body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/_warmer/{1}", index, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutWarmerPost(string index, string name, Stream body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/_warmer/{1}", index, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutWarmerPostAsync(string index, string name, Stream body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/_warmer/{1}", index, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutWarmerPost(string index, string name, byte[] body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/_warmer/{1}", index, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutWarmerPostAsync(string index, string name, byte[] body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/_warmer/{1}", index, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutWarmerPostString(string index, string name, string body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/_warmer/{1}", index, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutWarmerPostStringAsync(string index, string name, string body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/_warmer/{1}", index, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to register the warmer for; leave empty to perform the operation on all types</param>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutWarmerPut(string index, string type, string name, Stream body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_warmer/{2}", index, type, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to register the warmer for; leave empty to perform the operation on all types</param>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutWarmerPutAsync(string index, string type, string name, Stream body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_warmer/{2}", index, type, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to register the warmer for; leave empty to perform the operation on all types</param>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutWarmerPut(string index, string type, string name, byte[] body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_warmer/{2}", index, type, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to register the warmer for; leave empty to perform the operation on all types</param>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutWarmerPutAsync(string index, string type, string name, byte[] body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_warmer/{2}", index, type, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to register the warmer for; leave empty to perform the operation on all types</param>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutWarmerPutString(string index, string type, string name, string body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_warmer/{2}", index, type, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to register the warmer for; leave empty to perform the operation on all types</param>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutWarmerPutStringAsync(string index, string type, string name, string body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_warmer/{2}", index, type, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to register the warmer for; leave empty to perform the operation on all types</param>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutWarmerPost(string index, string type, string name, Stream body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_warmer/{2}", index, type, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to register the warmer for; leave empty to perform the operation on all types</param>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutWarmerPostAsync(string index, string type, string name, Stream body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_warmer/{2}", index, type, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to register the warmer for; leave empty to perform the operation on all types</param>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutWarmerPost(string index, string type, string name, byte[] body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_warmer/{2}", index, type, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to register the warmer for; leave empty to perform the operation on all types</param>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutWarmerPostAsync(string index, string type, string name, byte[] body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_warmer/{2}", index, type, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to register the warmer for; leave empty to perform the operation on all types</param>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesPutWarmerPostString(string index, string type, string name, string body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_warmer/{2}", index, type, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or omit to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to register the warmer for; leave empty to perform the operation on all types</param>
        ///<param name="name">The name of the warmer</param>
        ///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesPutWarmerPostStringAsync(string index, string type, string name, string body, Func<IndicesPutWarmerParameters, IndicesPutWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_warmer/{2}", index, type, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesPutWarmerParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}