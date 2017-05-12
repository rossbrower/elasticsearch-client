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
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IngestDeletePipeline(string id, Func<IngestDeletePipelineParameters, IngestDeletePipelineParameters> options = null)
        {
            var uri = string.Format("/_ingest/pipeline/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new IngestDeletePipelineParameters()).GetUri(uri);
            }

            return mConnection.Execute("DELETE", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        ///<param name="id">Pipeline ID</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IngestDeletePipelineAsync(string id, Func<IngestDeletePipelineParameters, IngestDeletePipelineParameters> options = null)
        {
            var uri = string.Format("/_ingest/pipeline/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new IngestDeletePipelineParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("DELETE", uri);
        }
    }
}