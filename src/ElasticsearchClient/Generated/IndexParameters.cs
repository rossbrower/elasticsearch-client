namespace Elasticsearch.Client
{
    public class IndexParameters : Parameters
    {
        ///<summary>Sets the number of shard copies that must be active before proceeding with the index operation. Defaults to 1, meaning the primary shard only. Set to `all` for all shard copies, otherwise set to any non-negative value less than or equal to the total number of copies for the shard (number of replicas + 1)</summary>
        ///<param name="value"></param>
        public virtual IndexParameters wait_for_active_shards(string value)
        {
            SetValue("wait_for_active_shards", value);
            return this;
        }

        ///<summary>Explicit operation type</summary>
        ///<param name="value"><para>Options: index,create</para><para>Default: index</para></param>
        public virtual IndexParameters op_type(string value)
        {
            SetValue("op_type", value);
            return this;
        }

        ///<summary>ID of the parent document</summary>
        ///<param name="value"></param>
        public virtual IndexParameters parent(string value)
        {
            SetValue("parent", value);
            return this;
        }

        ///<summary>If `true` then refresh the affected shards to make this operation visible to search, if `wait_for` then wait for a refresh to make this operation visible to search, if `false` (the default) then do nothing with refreshes.</summary>
        ///<param name="value"><para>Options: true,false,wait_for</para></param>
        public virtual IndexParameters refresh(string value)
        {
            SetValue("refresh", value);
            return this;
        }

        ///<summary>Specific routing value</summary>
        ///<param name="value"></param>
        public virtual IndexParameters routing(string value)
        {
            SetValue("routing", value);
            return this;
        }

        ///<summary>Explicit operation timeout</summary>
        ///<param name="value"></param>
        public virtual IndexParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }

        ///<summary>Explicit timestamp for the document</summary>
        ///<param name="value"></param>
        public virtual IndexParameters timestamp(string value)
        {
            SetValue("timestamp", value);
            return this;
        }

        ///<summary>Expiration time for the document</summary>
        ///<param name="value"></param>
        public virtual IndexParameters ttl(string value)
        {
            SetValue("ttl", value);
            return this;
        }

        ///<summary>Explicit version number for concurrency control</summary>
        ///<param name="value"></param>
        public virtual IndexParameters version(long value)
        {
            SetValue("version", value);
            return this;
        }

        ///<summary>Specific version type</summary>
        ///<param name="value"><para>Options: internal,external,external_gte,force</para></param>
        public virtual IndexParameters version_type(string value)
        {
            SetValue("version_type", value);
            return this;
        }

        ///<summary>The pipeline id to preprocess incoming documents with</summary>
        ///<param name="value"></param>
        public virtual IndexParameters pipeline(string value)
        {
            SetValue("pipeline", value);
            return this;
        }
    }
}