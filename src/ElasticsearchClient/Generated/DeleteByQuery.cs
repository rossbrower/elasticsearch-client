using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-delete-by-query.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage DeleteByQuery(string index, Stream body, Func<DeleteByQueryParameters, DeleteByQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_delete_by_query", index);
            if (options != null)
            {
                uri = options.Invoke(new DeleteByQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-delete-by-query.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> DeleteByQueryAsync(string index, Stream body, Func<DeleteByQueryParameters, DeleteByQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_delete_by_query", index);
            if (options != null)
            {
                uri = options.Invoke(new DeleteByQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-delete-by-query.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage DeleteByQuery(string index, byte[] body, Func<DeleteByQueryParameters, DeleteByQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_delete_by_query", index);
            if (options != null)
            {
                uri = options.Invoke(new DeleteByQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-delete-by-query.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> DeleteByQueryAsync(string index, byte[] body, Func<DeleteByQueryParameters, DeleteByQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_delete_by_query", index);
            if (options != null)
            {
                uri = options.Invoke(new DeleteByQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-delete-by-query.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage DeleteByQueryString(string index, string body, Func<DeleteByQueryParameters, DeleteByQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_delete_by_query", index);
            if (options != null)
            {
                uri = options.Invoke(new DeleteByQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-delete-by-query.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> DeleteByQueryStringAsync(string index, string body, Func<DeleteByQueryParameters, DeleteByQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/_delete_by_query", index);
            if (options != null)
            {
                uri = options.Invoke(new DeleteByQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-delete-by-query.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage DeleteByQuery(string index, string type, Stream body, Func<DeleteByQueryParameters, DeleteByQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_delete_by_query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new DeleteByQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-delete-by-query.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> DeleteByQueryAsync(string index, string type, Stream body, Func<DeleteByQueryParameters, DeleteByQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_delete_by_query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new DeleteByQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-delete-by-query.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage DeleteByQuery(string index, string type, byte[] body, Func<DeleteByQueryParameters, DeleteByQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_delete_by_query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new DeleteByQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-delete-by-query.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> DeleteByQueryAsync(string index, string type, byte[] body, Func<DeleteByQueryParameters, DeleteByQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_delete_by_query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new DeleteByQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-delete-by-query.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage DeleteByQueryString(string index, string type, string body, Func<DeleteByQueryParameters, DeleteByQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_delete_by_query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new DeleteByQueryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-delete-by-query.html"/></summary>
        ///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
        ///<param name="body">The search definition using the Query DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> DeleteByQueryStringAsync(string index, string type, string body, Func<DeleteByQueryParameters, DeleteByQueryParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_delete_by_query", index, type);
            if (options != null)
            {
                uri = options.Invoke(new DeleteByQueryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}