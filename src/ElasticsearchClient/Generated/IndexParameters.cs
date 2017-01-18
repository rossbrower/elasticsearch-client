namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-index_.html"/></summary>
    public class IndexParameters : Parameters
    {
        ///<summary>Explicit write consistency setting for the operation</summary>
        ///<param name="value"><para>Options: one,quorum,all</para></param>
        public virtual IndexParameters consistency(string value)
        {
            SetValue("consistency", value);
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

        ///<summary>Refresh the affected shards after performing the operation</summary>
        ///<param name="value"></param>
        public virtual IndexParameters refresh(bool value)
        {
            SetValue("refresh", value.ToString().ToLower());
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
    }
}