namespace Elasticsearch.Client
{
    public class DeleteParameters : Parameters
    {
        ///<summary>Specific write consistency setting for the operation</summary>
        ///<param name="value"><para>Options: one,quorum,all</para></param>
        public virtual DeleteParameters consistency(string value)
        {
            SetValue("consistency", value);
            return this;
        }

        ///<summary>ID of parent document</summary>
        ///<param name="value"></param>
        public virtual DeleteParameters parent(string value)
        {
            SetValue("parent", value);
            return this;
        }

        ///<summary>Refresh the index after performing the operation</summary>
        ///<param name="value"></param>
        public virtual DeleteParameters refresh(bool value)
        {
            SetValue("refresh", value.ToString().ToLower());
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