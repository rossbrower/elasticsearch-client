namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-bulk.html"/></summary>
    public class BulkParameters : Parameters
    {
        ///<summary>Explicit write consistency setting for the operation</summary>
        ///<param name="value"><para>Options: one,quorum,all</para></param>
        public virtual BulkParameters consistency(string value)
        {
            SetValue("consistency", value);
            return this;
        }

        ///<summary>Refresh the index after performing the operation</summary>
        ///<param name="value"></param>
        public virtual BulkParameters refresh(bool value)
        {
            SetValue("refresh", value.ToString().ToLower());
            return this;
        }

        ///<summary>Specific routing value</summary>
        ///<param name="value"></param>
        public virtual BulkParameters routing(string value)
        {
            SetValue("routing", value);
            return this;
        }

        ///<summary>Explicit operation timeout</summary>
        ///<param name="value"></param>
        public virtual BulkParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }

        ///<summary>Default document type for items which don't provide one</summary>
        ///<param name="value"></param>
        public virtual BulkParameters type(string value)
        {
            SetValue("type", value);
            return this;
        }

        ///<summary>Default comma-separated list of fields to return in the response for updates</summary>
        ///<param name="value"></param>
        public virtual BulkParameters fields(string value)
        {
            SetValue("fields", value);
            return this;
        }
    }
}