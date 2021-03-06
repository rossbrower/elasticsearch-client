namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/docs-reindex.html"/></summary>
    public class ReindexParameters : Parameters
    {
        ///<summary>Should the effected indexes be refreshed?</summary>
        ///<param name="value"></param>
        public virtual ReindexParameters refresh(bool value)
        {
            SetValue("refresh", value.ToString().ToLower());
            return this;
        }

        ///<summary>Time each individual bulk request should wait for shards that are unavailable.</summary>
        ///<param name="value"><para>Default: 1m</para></param>
        public virtual ReindexParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }

        ///<summary>Sets the number of shard copies that must be active before proceeding with the reindex operation. Defaults to 1, meaning the primary shard only. Set to `all` for all shard copies, otherwise set to any non-negative value less than or equal to the total number of copies for the shard (number of replicas + 1)</summary>
        ///<param name="value"></param>
        public virtual ReindexParameters wait_for_active_shards(string value)
        {
            SetValue("wait_for_active_shards", value);
            return this;
        }

        ///<summary>Should the request should block until the reindex is complete.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual ReindexParameters wait_for_completion(bool value)
        {
            SetValue("wait_for_completion", value.ToString().ToLower());
            return this;
        }

        ///<summary>The throttle to set on this request in sub-requests per second. -1 means no throttle.</summary>
        ///<param name="value"><para>Default: 0</para></param>
        public virtual ReindexParameters requests_per_second(long value)
        {
            SetValue("requests_per_second", value);
            return this;
        }

        ///<summary>The number of slices this task should be divided into. Defaults to 1 meaning the task isn't sliced into subtasks.</summary>
        ///<param name="value"><para>Default: 1</para></param>
        public virtual ReindexParameters slices(long value)
        {
            SetValue("slices", value);
            return this;
        }

        ///<summary>Pretty format the returned JSON response.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual ReindexParameters pretty(bool value)
        {
            SetValue("pretty", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return human readable values for statistics.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual ReindexParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Include the stack trace of returned errors.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual ReindexParameters error_trace(bool value)
        {
            SetValue("error_trace", value.ToString().ToLower());
            return this;
        }

        ///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
        ///<param name="value"></param>
        public virtual ReindexParameters source(string value)
        {
            SetValue("source", value);
            return this;
        }

        ///<summary>A comma-separated list of filters used to reduce the respone.</summary>
        ///<param name="value"></param>
        public virtual ReindexParameters filter_path(string value)
        {
            SetValue("filter_path", value);
            return this;
        }
    }
}