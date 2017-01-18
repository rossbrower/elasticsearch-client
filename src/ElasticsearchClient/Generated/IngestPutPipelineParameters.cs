namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/plugins/5.x/ingest.html"/></summary>
    public class IngestPutPipelineParameters : Parameters
    {
        ///<summary>Explicit operation timeout for connection to master node</summary>
        ///<param name="value"></param>
        public virtual IngestPutPipelineParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }

        ///<summary>Explicit operation timeout</summary>
        ///<param name="value"></param>
        public virtual IngestPutPipelineParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }
    }
}