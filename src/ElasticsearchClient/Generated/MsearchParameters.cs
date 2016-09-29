namespace Elasticsearch.Client
{
    public class MsearchParameters : Parameters
    {
        ///<summary>Search operation type</summary>
        ///<param name="value"><para>Options: query_then_fetch,query_and_fetch,dfs_query_then_fetch,dfs_query_and_fetch,count,scan</para></param>
        public virtual MsearchParameters search_type(string value)
        {
            SetValue("search_type", value);
            return this;
        }
    }
}