namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-reroute.html"/></summary>
    public class ClusterRerouteParameters : Parameters
    {
        ///<summary>Simulate the operation only and return the resulting state</summary>
        ///<param name="value"></param>
        public virtual ClusterRerouteParameters dry_run(bool value)
        {
            SetValue("dry_run", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return an explanation of why the commands can or cannot be executed</summary>
        ///<param name="value"></param>
        public virtual ClusterRerouteParameters explain(bool value)
        {
            SetValue("explain", value.ToString().ToLower());
            return this;
        }

        ///<summary>Retries allocation of shards that are blocked due to too many subsequent allocation failures</summary>
        ///<param name="value"></param>
        public virtual ClusterRerouteParameters retry_failed(bool value)
        {
            SetValue("retry_failed", value.ToString().ToLower());
            return this;
        }

        ///<summary>Limit the information returned to the specified metrics. Defaults to all but metadata</summary>
        ///<param name="value"><para>Options: _all,blocks,metadata,nodes,routing_table,master_node,version</para></param>
        public virtual ClusterRerouteParameters metric(string value)
        {
            SetValue("metric", value);
            return this;
        }

        ///<summary>Explicit operation timeout for connection to master node</summary>
        ///<param name="value"></param>
        public virtual ClusterRerouteParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }

        ///<summary>Explicit operation timeout</summary>
        ///<param name="value"></param>
        public virtual ClusterRerouteParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }

        ///<summary>Pretty format the returned JSON response.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual ClusterRerouteParameters pretty(bool value)
        {
            SetValue("pretty", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return human readable values for statistics.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual ClusterRerouteParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Include the stack trace of returned errors.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual ClusterRerouteParameters error_trace(bool value)
        {
            SetValue("error_trace", value.ToString().ToLower());
            return this;
        }

        ///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
        ///<param name="value"></param>
        public virtual ClusterRerouteParameters source(string value)
        {
            SetValue("source", value);
            return this;
        }

        ///<summary>A comma-separated list of filters used to reduce the respone.</summary>
        ///<param name="value"></param>
        public virtual ClusterRerouteParameters filter_path(string value)
        {
            SetValue("filter_path", value);
            return this;
        }
    }
}