using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        ///<param name="id">Pipeline ID</param>
        ///<param name="body">The ingest definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IngestPutPipeline(string id, Stream body, Func<IngestPutPipelineParameters, IngestPutPipelineParameters> options = null)
        {
            var uri = string.Format("/_ingest/pipeline/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new IngestPutPipelineParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        ///<param name="id">Pipeline ID</param>
        ///<param name="body">The ingest definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IngestPutPipelineAsync(string id, Stream body, Func<IngestPutPipelineParameters, IngestPutPipelineParameters> options = null)
        {
            var uri = string.Format("/_ingest/pipeline/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new IngestPutPipelineParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        ///<param name="id">Pipeline ID</param>
        ///<param name="body">The ingest definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IngestPutPipeline(string id, byte[] body, Func<IngestPutPipelineParameters, IngestPutPipelineParameters> options = null)
        {
            var uri = string.Format("/_ingest/pipeline/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new IngestPutPipelineParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        ///<param name="id">Pipeline ID</param>
        ///<param name="body">The ingest definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IngestPutPipelineAsync(string id, byte[] body, Func<IngestPutPipelineParameters, IngestPutPipelineParameters> options = null)
        {
            var uri = string.Format("/_ingest/pipeline/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new IngestPutPipelineParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        ///<param name="id">Pipeline ID</param>
        ///<param name="body">The ingest definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IngestPutPipelineString(string id, string body, Func<IngestPutPipelineParameters, IngestPutPipelineParameters> options = null)
        {
            var uri = string.Format("/_ingest/pipeline/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new IngestPutPipelineParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        ///<param name="id">Pipeline ID</param>
        ///<param name="body">The ingest definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IngestPutPipelineStringAsync(string id, string body, Func<IngestPutPipelineParameters, IngestPutPipelineParameters> options = null)
        {
            var uri = string.Format("/_ingest/pipeline/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new IngestPutPipelineParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }
    }
}