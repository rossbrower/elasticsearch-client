using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PercolateGet(string index, string type, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate", index, type);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PercolateGetAsync(string index, string type, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate", index, type);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="body">The percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PercolateGet(string index, string type, Stream body, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate", index, type);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="body">The percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PercolateGetAsync(string index, string type, Stream body, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate", index, type);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="body">The percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PercolateGet(string index, string type, byte[] body, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate", index, type);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="body">The percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PercolateGetAsync(string index, string type, byte[] body, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate", index, type);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="body">The percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PercolateGetString(string index, string type, string body, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate", index, type);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="body">The percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PercolateGetStringAsync(string index, string type, string body, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate", index, type);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PercolatePost(string index, string type, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate", index, type);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PercolatePostAsync(string index, string type, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate", index, type);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="body">The percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PercolatePost(string index, string type, Stream body, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate", index, type);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="body">The percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PercolatePostAsync(string index, string type, Stream body, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate", index, type);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="body">The percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PercolatePost(string index, string type, byte[] body, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate", index, type);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="body">The percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PercolatePostAsync(string index, string type, byte[] body, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate", index, type);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="body">The percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PercolatePostString(string index, string type, string body, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate", index, type);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="body">The percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PercolatePostStringAsync(string index, string type, string body, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_percolate", index, type);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PercolateGet(string index, string type, string id, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PercolateGetAsync(string index, string type, string id, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="body">The percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PercolateGet(string index, string type, string id, Stream body, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="body">The percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PercolateGetAsync(string index, string type, string id, Stream body, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="body">The percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PercolateGet(string index, string type, string id, byte[] body, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="body">The percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PercolateGetAsync(string index, string type, string id, byte[] body, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="body">The percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PercolateGetString(string index, string type, string id, string body, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="body">The percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PercolateGetStringAsync(string index, string type, string id, string body, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PercolatePost(string index, string type, string id, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PercolatePostAsync(string index, string type, string id, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="body">The percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PercolatePost(string index, string type, string id, Stream body, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="body">The percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PercolatePostAsync(string index, string type, string id, Stream body, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="body">The percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PercolatePost(string index, string type, string id, byte[] body, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="body">The percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PercolatePostAsync(string index, string type, string id, byte[] body, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="body">The percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage PercolatePostString(string index, string type, string id, string body, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/search-percolate.html"/></summary>
        ///<param name="index">The index of the document being percolated.</param>
        ///<param name="type">The type of the document being percolated.</param>
        ///<param name="id">Substitute the document in the request body with a document that is known by the specified id. On top of the id, the index and type parameter will be used to retrieve the document from within the cluster.</param>
        ///<param name="body">The percolator request definition using the percolate DSL</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> PercolatePostStringAsync(string index, string type, string id, string body, Func<PercolateParameters, PercolateParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_percolate", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new PercolateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}