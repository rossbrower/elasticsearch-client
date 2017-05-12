namespace Elasticsearch.Client
{
    ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-health.html"/></summary>
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
        public virtual ClusterHealthParameters wait_for_active_shards(string value)
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

        ///<summary>Wait until all currently queued events with the given priority are processed</summary>
        ///<param name="value"><para>Options: immediate,urgent,high,normal,low,languid</para></param>
        public virtual ClusterHealthParameters wait_for_events(string value)
        {
            SetValue("wait_for_events", value);
            return this;
        }

        ///<summary>Whether to wait until there are no relocating shards in the cluster</summary>
        ///<param name="value"></param>
        public virtual ClusterHealthParameters wait_for_no_relocating_shards(bool value)
        {
            SetValue("wait_for_no_relocating_shards", value.ToString().ToLower());
            return this;
        }

        ///<summary>Wait until cluster is in a specific state</summary>
        ///<param name="value"><para>Options: green,yellow,red</para></param>
        public virtual ClusterHealthParameters wait_for_status(string value)
        {
            SetValue("wait_for_status", value);
            return this;
        }

        ///<summary>Pretty format the returned JSON response.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual ClusterHealthParameters pretty(bool value)
        {
            SetValue("pretty", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return human readable values for statistics.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual ClusterHealthParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Include the stack trace of returned errors.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual ClusterHealthParameters error_trace(bool value)
        {
            SetValue("error_trace", value.ToString().ToLower());
            return this;
        }

        ///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
        ///<param name="value"></param>
        public virtual ClusterHealthParameters source(string value)
        {
            SetValue("source", value);
            return this;
        }

        ///<summary>A comma-separated list of filters used to reduce the respone.</summary>
        ///<param name="value"></param>
        public virtual ClusterHealthParameters filter_path(string value)
        {
            SetValue("filter_path", value);
            return this;
        }
    }
}