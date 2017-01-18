namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/docs-reindex.html"/></summary>
    public class ReindexRethrottleParameters : Parameters
    {
        ///<summary>The throttle to set on this request in sub-requests per second. 0 means set no throttle. As does "unlimited". Otherwise it must be a float.</summary>
        ///<param name="value"></param>
        public virtual ReindexRethrottleParameters requests_per_second(long value)
        {
            SetValue("requests_per_second", value);
            return this;
        }
    }
}