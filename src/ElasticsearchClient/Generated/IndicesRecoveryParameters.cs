namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/indices-recovery.html"/></summary>
    public class IndicesRecoveryParameters : Parameters
    {
        ///<summary>Whether to display detailed information about shard recovery</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual IndicesRecoveryParameters detailed(bool value)
        {
            SetValue("detailed", value.ToString().ToLower());
            return this;
        }

        ///<summary>Display only those recoveries that are currently on-going</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual IndicesRecoveryParameters active_only(bool value)
        {
            SetValue("active_only", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to return time and byte values in human-readable format.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual IndicesRecoveryParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }
    }
}