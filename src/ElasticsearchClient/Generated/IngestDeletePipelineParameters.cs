namespace Elasticsearch.Client
{
    public class IngestDeletePipelineParameters : Parameters
    {
        ///<summary>Explicit operation timeout for connection to master node</summary>
        ///<param name="value"></param>
        public virtual IngestDeletePipelineParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }

        ///<summary>Explicit operation timeout</summary>
        ///<param name="value"></param>
        public virtual IngestDeletePipelineParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }
    }
}