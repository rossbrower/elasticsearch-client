using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IngestProcessorGrok(Func<IngestProcessorGrokParameters, IngestProcessorGrokParameters> options = null)
        {
            var uri = "/_ingest/processor/grok";
            if (options != null)
            {
                uri = options.Invoke(new IngestProcessorGrokParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/master/ingest.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IngestProcessorGrokAsync(Func<IngestProcessorGrokParameters, IngestProcessorGrokParameters> options = null)
        {
            var uri = "/_ingest/processor/grok";
            if (options != null)
            {
                uri = options.Invoke(new IngestProcessorGrokParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}