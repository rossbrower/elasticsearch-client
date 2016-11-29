using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IngestGetPipeline(Func<IngestGetPipelineParameters, IngestGetPipelineParameters> options = null)
        {
            var uri = "/_ingest/pipeline";
            if (options != null)
            {
                uri = options.Invoke(new IngestGetPipelineParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IngestGetPipelineAsync(Func<IngestGetPipelineParameters, IngestGetPipelineParameters> options = null)
        {
            var uri = "/_ingest/pipeline";
            if (options != null)
            {
                uri = options.Invoke(new IngestGetPipelineParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
        ///<param name="id">Comma separated list of pipeline ids. Wildcards supported</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IngestGetPipeline(string id, Func<IngestGetPipelineParameters, IngestGetPipelineParameters> options = null)
        {
            var uri = string.Format("/_ingest/pipeline/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new IngestGetPipelineParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
        ///<param name="id">Comma separated list of pipeline ids. Wildcards supported</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IngestGetPipelineAsync(string id, Func<IngestGetPipelineParameters, IngestGetPipelineParameters> options = null)
        {
            var uri = string.Format("/_ingest/pipeline/{0}", id);
            if (options != null)
            {
                uri = options.Invoke(new IngestGetPipelineParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}