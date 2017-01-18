namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/cluster-health.html"/></summary>
    public class ClusterHealthParameters : Parameters
    {
        ///<summary>Specify the level of detail for returned information</summary>
        ///<param name="value"><para>Options: cluster,indices,shards</para><para>Default: cluster</para></param>
        public virtual ClusterHealthParameters level(string value)
        {
            SetValue("level", value);
            return this;
        }

        ///<summary>Return local information, do not retrieve the state from master node (default: false)</summary>
        ///<param name="value"></param>
        public virtual ClusterHealthParameters local(bool value)
        {
            SetValue("local", value.ToString().ToLower());
            return this;
        }

        ///<summary>Explicit operation timeout for connection to master node</summary>
        ///<param name="value"></param>
        public virtual ClusterHealthParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }

        ///<summary>Explicit operation timeout</summary>
        ///<param name="value"></param>
        public virtual ClusterHealthParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }

        ///<summary>Wait until the specified number of shards is active</summary>
        ///<param name="value"></param>
        public virtual ClusterHealthParameters wait_for_active_shards(long value)
        {
            SetValue("wait_for_active_shards", value);
            return this;
        }

        ///<summary>Wait until the specified number of nodes is available</summary>
        ///<param name="value"></param>
        public virtual ClusterHealthParameters wait_for_nodes(string value)
        {
            SetValue("wait_for_nodes", value);
            return this;
        }

        ///<summary>Wait until the specified number of relocating shards is finished</summary>
        ///<param name="value"></param>
        public virtual ClusterHealthParameters wait_for_relocating_shards(long value)
        {
            SetValue("wait_for_relocating_shards", value);
            return this;
        }

        ///<summary>Wait until cluster is in a specific state</summary>
        ///<param name="value"><para>Options: green,yellow,red</para></param>
        public virtual ClusterHealthParameters wait_for_status(string value)
        {
            SetValue("wait_for_status", value);
            return this;
        }
    }
}