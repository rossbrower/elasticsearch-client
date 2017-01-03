namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-update.html"/></summary>
    public class UpdateParameters : Parameters
    {
        ///<summary>Sets the number of shard copies that must be active before proceeding with the update operation. Defaults to 1, meaning the primary shard only. Set to `all` for all shard copies, otherwise set to any non-negative value less than or equal to the total number of copies for the shard (number of replicas + 1)</summary>
        ///<param name="value"></param>
        public virtual UpdateParameters wait_for_active_shards(string value)
        {
            SetValue("wait_for_active_shards", value);
            return this;
        }

        ///<summary>A comma-separated list of fields to return in the response</summary>
        ///<param name="value"></param>
        public virtual UpdateParameters fields(string value)
        {
            SetValue("fields", value);
            return this;
        }

        ///<summary>True or false to return the _source field or not, or a list of fields to return</summary>
        ///<param name="value"></param>
        public virtual UpdateParameters _source(string value)
        {
            SetValue("_source", value);
            return this;
        }

        ///<summary>A list of fields to exclude from the returned _source field</summary>
        ///<param name="value"></param>
        public virtual UpdateParameters _source_exclude(string value)
        {
            SetValue("_source_exclude", value);
            return this;
        }

        ///<summary>A list of fields to extract and return from the _source field</summary>
        ///<param name="value"></param>
        public virtual UpdateParameters _source_include(string value)
        {
            SetValue("_source_include", value);
            return this;
        }

        ///<summary>The script language (default: painless)</summary>
        ///<param name="value"></param>
        public virtual UpdateParameters lang(string value)
        {
            SetValue("lang", value);
            return this;
        }

        ///<summary>ID of the parent document. Is is only used for routing and when for the upsert request</summary>
        ///<param name="value"></param>
        public virtual UpdateParameters parent(string value)
        {
            SetValue("parent", value);
            return this;
        }

        ///<summary>If `true` then refresh the effected shards to make this operation visible to search, if `wait_for` then wait for a refresh to make this operation visible to search, if `false` (the default) then do nothing with refreshes.</summary>
        ///<param name="value"><para>Options: true,false,wait_for</para></param>
        public virtual UpdateParameters refresh(string value)
        {
            SetValue("refresh", value);
            return this;
        }

        ///<summary>Specify how many times should the operation be retried when a conflict occurs (default: 0)</summary>
        ///<param name="value"></param>
        public virtual UpdateParameters retry_on_conflict(long value)
        {
            SetValue("retry_on_conflict", value);
            return this;
        }

        ///<summary>Specific routing value</summary>
        ///<param name="value"></param>
        public virtual UpdateParameters routing(string value)
        {
            SetValue("routing", value);
            return this;
        }

        ///<summary>Explicit operation timeout</summary>
        ///<param name="value"></param>
        public virtual UpdateParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }

        ///<summary>Explicit timestamp for the document</summary>
        ///<param name="value"></param>
        public virtual UpdateParameters timestamp(string value)
        {
            SetValue("timestamp", value);
            return this;
        }

        ///<summary>Expiration time for the document</summary>
        ///<param name="value"></param>
        public virtual UpdateParameters ttl(string value)
        {
            SetValue("ttl", value);
            return this;
        }

        ///<summary>Explicit version number for concurrency control</summary>
        ///<param name="value"></param>
        public virtual UpdateParameters version(long value)
        {
            SetValue("version", value);
            return this;
        }

        ///<summary>Specific version type</summary>
        ///<param name="value"><para>Options: internal,force</para></param>
        public virtual UpdateParameters version_type(string value)
        {
            SetValue("version_type", value);
            return this;
        }
    }
}