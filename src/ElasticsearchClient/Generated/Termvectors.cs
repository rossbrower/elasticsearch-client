using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage TermvectorsGet(string index, string type, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_termvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> TermvectorsGetAsync(string index, string type, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_termvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage TermvectorsGet(string index, string type, Stream body, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_termvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> TermvectorsGetAsync(string index, string type, Stream body, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_termvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage TermvectorsGet(string index, string type, byte[] body, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_termvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> TermvectorsGetAsync(string index, string type, byte[] body, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_termvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage TermvectorsGetString(string index, string type, string body, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_termvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> TermvectorsGetStringAsync(string index, string type, string body, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_termvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage TermvectorsPost(string index, string type, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_termvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> TermvectorsPostAsync(string index, string type, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_termvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage TermvectorsPost(string index, string type, Stream body, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_termvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> TermvectorsPostAsync(string index, string type, Stream body, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_termvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage TermvectorsPost(string index, string type, byte[] body, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_termvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> TermvectorsPostAsync(string index, string type, byte[] body, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_termvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage TermvectorsPostString(string index, string type, string body, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_termvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> TermvectorsPostStringAsync(string index, string type, string body, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_termvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="id">The id of the document, when not specified a doc param should be supplied.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage TermvectorsGet(string index, string type, string id, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_termvectors", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="id">The id of the document, when not specified a doc param should be supplied.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> TermvectorsGetAsync(string index, string type, string id, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_termvectors", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="id">The id of the document, when not specified a doc param should be supplied.</param>
        ///<param name="body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage TermvectorsGet(string index, string type, string id, Stream body, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_termvectors", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="id">The id of the document, when not specified a doc param should be supplied.</param>
        ///<param name="body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> TermvectorsGetAsync(string index, string type, string id, Stream body, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_termvectors", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="id">The id of the document, when not specified a doc param should be supplied.</param>
        ///<param name="body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage TermvectorsGet(string index, string type, string id, byte[] body, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_termvectors", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="id">The id of the document, when not specified a doc param should be supplied.</param>
        ///<param name="body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> TermvectorsGetAsync(string index, string type, string id, byte[] body, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_termvectors", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="id">The id of the document, when not specified a doc param should be supplied.</param>
        ///<param name="body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage TermvectorsGetString(string index, string type, string id, string body, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_termvectors", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="id">The id of the document, when not specified a doc param should be supplied.</param>
        ///<param name="body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> TermvectorsGetStringAsync(string index, string type, string id, string body, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_termvectors", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="id">The id of the document, when not specified a doc param should be supplied.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage TermvectorsPost(string index, string type, string id, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_termvectors", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="id">The id of the document, when not specified a doc param should be supplied.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> TermvectorsPostAsync(string index, string type, string id, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_termvectors", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="id">The id of the document, when not specified a doc param should be supplied.</param>
        ///<param name="body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage TermvectorsPost(string index, string type, string id, Stream body, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_termvectors", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="id">The id of the document, when not specified a doc param should be supplied.</param>
        ///<param name="body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> TermvectorsPostAsync(string index, string type, string id, Stream body, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_termvectors", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="id">The id of the document, when not specified a doc param should be supplied.</param>
        ///<param name="body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage TermvectorsPost(string index, string type, string id, byte[] body, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_termvectors", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="id">The id of the document, when not specified a doc param should be supplied.</param>
        ///<param name="body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> TermvectorsPostAsync(string index, string type, string id, byte[] body, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_termvectors", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="id">The id of the document, when not specified a doc param should be supplied.</param>
        ///<param name="body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage TermvectorsPostString(string index, string type, string id, string body, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_termvectors", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="id">The id of the document, when not specified a doc param should be supplied.</param>
        ///<param name="body">Define parameters and or supply a document to get termvectors for. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> TermvectorsPostStringAsync(string index, string type, string id, string body, Func<TermvectorsParameters, TermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/{2}/_termvectors", index, type, id);
            if (options != null)
            {
                uri = options.Invoke(new TermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}