namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-reindex.html"/></summary>
    public class ReindexRethrottleParameters : Parameters
    {
        ///<summary>The throttle to set on this request in floating sub-requests per second. -1 means set no throttle.</summary>
        ///<param name="value"></param>
        public virtual ReindexRethrottleParameters requests_per_second(long value)
        {
            SetValue("requests_per_second", value);
            return this;
        }
    }
}