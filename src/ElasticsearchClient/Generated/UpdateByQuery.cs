using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/plugins-reindex.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage UpdateByQuery(string index, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_update_by_query", index);
            if (options != null)
            {
                uri = options.Invoke(new UpdateByQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/plugins-reindex.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> UpdateByQueryAsync(string index, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_update_by_query", index);
            if (options != null)
            {
                uri = options.Invoke(new UpdateByQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/plugins-reindex.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage UpdateByQuery(string index, Stream body, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_update_by_query", index);
            if (options != null)
            {
                uri = options.Invoke(new UpdateByQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/plugins-reindex.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> UpdateByQueryAsync(string index, Stream body, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_update_by_query", index);
            if (options != null)
            {
                uri = options.Invoke(new UpdateByQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/plugins-reindex.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage UpdateByQuery(string index, byte[] body, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_update_by_query", index);
            if (options != null)
            {
                uri = options.Invoke(new UpdateByQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/plugins-reindex.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> UpdateByQueryAsync(string index, byte[] body, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_update_by_query", index);
            if (options != null)
            {
                uri = options.Invoke(new UpdateByQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/plugins-reindex.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage UpdateByQueryString(string index, string body, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_update_by_query", index);
            if (options != null)
            {
                uri = options.Invoke(new UpdateByQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/plugins-reindex.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> UpdateByQueryStringAsync(string index, string body, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_update_by_query", index);
            if (options != null)
            {
                uri = options.Invoke(new UpdateByQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/plugins-reindex.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage UpdateByQuery(string index, string type, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_update_by_query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new UpdateByQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/plugins-reindex.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> UpdateByQueryAsync(string index, string type, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_update_by_query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new UpdateByQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/plugins-reindex.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage UpdateByQuery(string index, string type, Stream body, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_update_by_query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new UpdateByQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/plugins-reindex.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> UpdateByQueryAsync(string index, string type, Stream body, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_update_by_query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new UpdateByQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/plugins-reindex.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage UpdateByQuery(string index, string type, byte[] body, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_update_by_query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new UpdateByQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/plugins-reindex.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> UpdateByQueryAsync(string index, string type, byte[] body, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_update_by_query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new UpdateByQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/plugins-reindex.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage UpdateByQueryString(string index, string type, string body, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_update_by_query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new UpdateByQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/plugins-reindex.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> UpdateByQueryStringAsync(string index, string type, string body, Func<UpdateByQueryParameters, UpdateByQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_update_by_query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new UpdateByQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}