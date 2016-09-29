namespace Elasticsearch.Client
{
    public class MsearchParameters : Parameters
    {
        ///<summary>Search operation type</summary>
        ///<param name="value"><para>Options: query_then_fetch,query_and_fetch,dfs_query_then_fetch,dfs_query_and_fetch</para></param>
        public virtual MsearchParameters search_type(string value)
        {
            SetValue("search_type", value);
            return this;
        }

        ///<summary>Controls the maximum number of concurrent searches the multi search api will execute</summary>
        ///<param name="value"></param>
        public virtual MsearchParameters max_concurrent_searches(long value)
        {
            SetValue("max_concurrent_searches", value);
            return this;
        }
    }
}