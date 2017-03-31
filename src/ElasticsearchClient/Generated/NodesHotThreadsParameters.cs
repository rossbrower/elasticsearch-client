namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-nodes-hot-threads.html"/></summary>
    public class NodesHotThreadsParameters : Parameters
    {
        ///<summary>The interval for the second sampling of threads</summary>
        ///<param name="value"></param>
        public virtual NodesHotThreadsParameters interval(string value)
        {
            SetValue("interval", value);
            return this;
        }

        ///<summary>Number of samples of thread stacktrace (default: 10)</summary>
        ///<param name="value"></param>
        public virtual NodesHotThreadsParameters snapshots(long value)
        {
            SetValue("snapshots", value);
            return this;
        }

        ///<summary>Specify the number of threads to provide information for (default: 3)</summary>
        ///<param name="value"></param>
        public virtual NodesHotThreadsParameters threads(long value)
        {
            SetValue("threads", value);
            return this;
        }

        ///<summary>Don't show threads that are in known-idle places, such as waiting on a socket select or pulling from an empty task queue (default: true)</summary>
        ///<param name="value"></param>
        public virtual NodesHotThreadsParameters ignore_idle_threads(bool value)
        {
            SetValue("ignore_idle_threads", value.ToString().ToLower());
            return this;
        }

        ///<summary>The type to sample (default: cpu)</summary>
        ///<param name="value"><para>Options: cpu,wait,block</para></param>
        public virtual NodesHotThreadsParameters type(string value)
        {
            SetValue("type", value);
            return this;
        }

        ///<summary>Explicit operation timeout</summary>
        ///<param name="value"></param>
        public virtual NodesHotThreadsParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }

        ///<summary>Pretty format the returned JSON response.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual NodesHotThreadsParameters pretty(bool value)
        {
            SetValue("pretty", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return human readable values for statistics.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual NodesHotThreadsParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Include the stack trace of returned errors.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual NodesHotThreadsParameters error_trace(bool value)
        {
            SetValue("error_trace", value.ToString().ToLower());
            return this;
        }

        ///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
        ///<param name="value"></param>
        public virtual NodesHotThreadsParameters source(string value)
        {
            SetValue("source", value);
            return this;
        }

        ///<summary>A comma-separated list of filters used to reduce the respone.</summary>
        ///<param name="value"></param>
        public virtual NodesHotThreadsParameters filter_path(string value)
        {
            SetValue("filter_path", value);
            return this;
        }
    }
}