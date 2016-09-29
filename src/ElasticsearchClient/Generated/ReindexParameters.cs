namespace Elasticsearch.Client
{
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

        ///<summary>Explicit write consistency setting for the operation</summary>
        ///<param name="value"><para>Options: one,quorum,all</para></param>
        public virtual ReindexParameters consistency(string value)
        {
            SetValue("consistency", value);
            return this;
        }

        ///<summary>Should the request should block until the reindex is complete.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual ReindexParameters wait_for_completion(bool value)
        {
            SetValue("wait_for_completion", value.ToString().ToLower());
            return this;
        }

        ///<summary>The throttle for this request in sub-requests per second. 0 means set no throttle.</summary>
        ///<param name="value"><para>Default: 0</para></param>
        public virtual ReindexParameters requests_per_second(long value)
        {
            SetValue("requests_per_second", value);
            return this;
        }
    }
}