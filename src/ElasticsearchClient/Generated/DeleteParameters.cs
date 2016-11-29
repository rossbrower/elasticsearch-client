namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-delete.html"/></summary>
    public class DeleteParameters : Parameters
    {
        ///<summary>Sets the number of shard copies that must be active before proceeding with the delete operation. Defaults to 1, meaning the primary shard only. Set to `all` for all shard copies, otherwise set to any non-negative value less than or equal to the total number of copies for the shard (number of replicas + 1)</summary>
        ///<param name="value"></param>
        public virtual DeleteParameters wait_for_active_shards(string value)
        {
            SetValue("wait_for_active_shards", value);
            return this;
        }

        ///<summary>ID of parent document</summary>
        ///<param name="value"></param>
        public virtual DeleteParameters parent(string value)
        {
            SetValue("parent", value);
            return this;
        }

        ///<summary>If `true` then refresh the effected shards to make this operation visible to search, if `wait_for` then wait for a refresh to make this operation visible to search, if `false` (the default) then do nothing with refreshes.</summary>
        ///<param name="value"><para>Options: true,false,wait_for</para></param>
        public virtual DeleteParameters refresh(string value)
        {
            SetValue("refresh", value);
            return this;
        }

        ///<summary>Specific routing value</summary>
        ///<param name="value"></param>
        public virtual DeleteParameters routing(string value)
        {
            SetValue("routing", value);
            return this;
        }

        ///<summary>Explicit operation timeout</summary>
        ///<param name="value"></param>
        public virtual DeleteParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }

        ///<summary>Explicit version number for concurrency control</summary>
        ///<param name="value"></param>
        public virtual DeleteParameters version(long value)
        {
            SetValue("version", value);
            return this;
        }

        ///<summary>Specific version type</summary>
        ///<param name="value"><para>Options: internal,external,external_gte,force</para></param>
        public virtual DeleteParameters version_type(string value)
        {
            SetValue("version_type", value);
            return this;
        }
    }
}