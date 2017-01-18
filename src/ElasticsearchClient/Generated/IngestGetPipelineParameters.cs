namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
    public class IngestGetPipelineParameters : Parameters
    {
        ///<summary>Explicit operation timeout for connection to master node</summary>
        ///<param name="value"></param>
        public virtual IngestGetPipelineParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }
    }
}