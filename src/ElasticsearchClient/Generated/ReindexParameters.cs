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

        ///<summary>Sets the number of shard copies that must be active before proceeding with the reindex operation. Defaults to 1, meaning the primary shard only. Set to `all` for all shard copies, otherwise set to any non-negative value less than or equal to the total number of copies for the shard (number of replicas + 1)</summary>
        ///<param name="value"></param>
        public virtual ReindexParameters wait_for_active_shards(string value)
        {
            SetValue("wait_for_active_shards", value);
            return this;
        }

        ///<summary>Should the request should block until the reindex is complete.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual ReindexParameters wait_for_completion(bool value)
        {
            SetValue("wait_for_completion", value.ToString().ToLower());
            return this;
        }

        ///<summary>The throttle to set on this request in sub-requests per second. -1 means set no throttle as does "unlimited" which is the only non-float this accepts.</summary>
        ///<param name="value"><para>Default: 0</para></param>
        public virtual ReindexParameters requests_per_second(long value)
        {
            SetValue("requests_per_second", value);
            return this;
        }
    }
}