using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MtermvectorsGet(Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = "/_mtermvectors";
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MtermvectorsGetAsync(Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = "/_mtermvectors";
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MtermvectorsGet(Stream body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = "/_mtermvectors";
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MtermvectorsGetAsync(Stream body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = "/_mtermvectors";
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MtermvectorsGet(byte[] body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = "/_mtermvectors";
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MtermvectorsGetAsync(byte[] body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = "/_mtermvectors";
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MtermvectorsGetString(string body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = "/_mtermvectors";
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MtermvectorsGetStringAsync(string body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = "/_mtermvectors";
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MtermvectorsPost(Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = "/_mtermvectors";
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MtermvectorsPostAsync(Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = "/_mtermvectors";
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MtermvectorsPost(Stream body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = "/_mtermvectors";
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MtermvectorsPostAsync(Stream body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = "/_mtermvectors";
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MtermvectorsPost(byte[] body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = "/_mtermvectors";
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MtermvectorsPostAsync(byte[] body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = "/_mtermvectors";
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MtermvectorsPostString(string body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = "/_mtermvectors";
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MtermvectorsPostStringAsync(string body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = "/_mtermvectors";
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MtermvectorsGet(string index, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/_mtermvectors", index);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MtermvectorsGetAsync(string index, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/_mtermvectors", index);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MtermvectorsGet(string index, Stream body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/_mtermvectors", index);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MtermvectorsGetAsync(string index, Stream body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/_mtermvectors", index);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MtermvectorsGet(string index, byte[] body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/_mtermvectors", index);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MtermvectorsGetAsync(string index, byte[] body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/_mtermvectors", index);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MtermvectorsGetString(string index, string body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/_mtermvectors", index);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MtermvectorsGetStringAsync(string index, string body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/_mtermvectors", index);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MtermvectorsPost(string index, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/_mtermvectors", index);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MtermvectorsPostAsync(string index, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/_mtermvectors", index);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MtermvectorsPost(string index, Stream body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/_mtermvectors", index);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MtermvectorsPostAsync(string index, Stream body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/_mtermvectors", index);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MtermvectorsPost(string index, byte[] body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/_mtermvectors", index);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MtermvectorsPostAsync(string index, byte[] body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/_mtermvectors", index);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MtermvectorsPostString(string index, string body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/_mtermvectors", index);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MtermvectorsPostStringAsync(string index, string body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/_mtermvectors", index);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MtermvectorsGet(string index, string type, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mtermvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MtermvectorsGetAsync(string index, string type, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mtermvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MtermvectorsGet(string index, string type, Stream body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mtermvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MtermvectorsGetAsync(string index, string type, Stream body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mtermvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MtermvectorsGet(string index, string type, byte[] body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mtermvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MtermvectorsGetAsync(string index, string type, byte[] body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mtermvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MtermvectorsGetString(string index, string type, string body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mtermvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MtermvectorsGetStringAsync(string index, string type, string body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mtermvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MtermvectorsPost(string index, string type, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mtermvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MtermvectorsPostAsync(string index, string type, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mtermvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MtermvectorsPost(string index, string type, Stream body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mtermvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MtermvectorsPostAsync(string index, string type, Stream body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mtermvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MtermvectorsPost(string index, string type, byte[] body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mtermvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MtermvectorsPostAsync(string index, string type, byte[] body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mtermvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage MtermvectorsPostString(string index, string type, string body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mtermvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
        ///<param name="index">The index in which the document resides.</param>
        ///<param name="type">The type of the document.</param>
        ///<param name="body">Define ids, documents, parameters or a list of parameters per document here. You must at least provide a list of document ids. See documentation.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> MtermvectorsPostStringAsync(string index, string type, string body, Func<MtermvectorsParameters, MtermvectorsParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_mtermvectors", index, type);
            if (options != null)
            {
                uri = options.Invoke(new MtermvectorsParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}