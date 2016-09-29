using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountPercolateGet(string index, string type, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate/count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountPercolateGetAsync(string index, string type, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate/count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="body">The count percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountPercolateGet(string index, string type, Stream body, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate/count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="body">The count percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountPercolateGetAsync(string index, string type, Stream body, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate/count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="body">The count percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountPercolateGet(string index, string type, byte[] body, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate/count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="body">The count percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountPercolateGetAsync(string index, string type, byte[] body, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate/count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="body">The count percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountPercolateGetString(string index, string type, string body, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate/count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="body">The count percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountPercolateGetStringAsync(string index, string type, string body, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate/count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountPercolatePost(string index, string type, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate/count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountPercolatePostAsync(string index, string type, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate/count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="body">The count percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountPercolatePost(string index, string type, Stream body, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate/count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="body">The count percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountPercolatePostAsync(string index, string type, Stream body, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate/count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="body">The count percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountPercolatePost(string index, string type, byte[] body, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate/count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="body">The count percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountPercolatePostAsync(string index, string type, byte[] body, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate/count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="body">The count percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountPercolatePostString(string index, string type, string body, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate/count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="body">The count percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountPercolatePostStringAsync(string index, string type, string body, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate/count", index, type);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountPercolateGet(string index, string type, string id, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate/count", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountPercolateGetAsync(string index, string type, string id, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate/count", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="body">The count percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountPercolateGet(string index, string type, string id, Stream body, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate/count", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="body">The count percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountPercolateGetAsync(string index, string type, string id, Stream body, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate/count", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="body">The count percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountPercolateGet(string index, string type, string id, byte[] body, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate/count", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="body">The count percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountPercolateGetAsync(string index, string type, string id, byte[] body, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate/count", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="body">The count percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountPercolateGetString(string index, string type, string id, string body, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate/count", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="body">The count percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountPercolateGetStringAsync(string index, string type, string id, string body, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate/count", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountPercolatePost(string index, string type, string id, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate/count", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountPercolatePostAsync(string index, string type, string id, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate/count", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="body">The count percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountPercolatePost(string index, string type, string id, Stream body, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate/count", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="body">The count percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountPercolatePostAsync(string index, string type, string id, Stream body, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate/count", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="body">The count percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountPercolatePost(string index, string type, string id, byte[] body, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate/count", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="body">The count percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountPercolatePostAsync(string index, string type, string id, byte[] body, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate/count", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="body">The count percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CountPercolatePostString(string index, string type, string id, string body, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate/count", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being count percolated.</param>
        ///<param name="type">The type of the document being count percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="body">The count percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CountPercolatePostStringAsync(string index, string type, string id, string body, Func<CountPercolateParameters, CountPercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate/count", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new CountPercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}