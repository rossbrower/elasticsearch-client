namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-allocation-explain.html"/></summary>
    public class ClusterAllocationExplainParameters : Parameters
    {
        ///<summary>Return 'YES' decisions in explanation (default: false)</summary>
        ///<param name="value"></param>
        public virtual ClusterAllocationExplainParameters include_yes_decisions(bool value)
        {
            SetValue("include_yes_decisions", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return information about disk usage and shard sizes (default: false)</summary>
        ///<param name="value"></param>
        public virtual ClusterAllocationExplainParameters include_disk_info(bool value)
        {
            SetValue("include_disk_info", value.ToString().ToLower());
            return this;
        }
    }
}