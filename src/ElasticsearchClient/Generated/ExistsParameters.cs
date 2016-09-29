namespace Elasticsearch.Client
{
    public class ExistsParameters : Parameters
    {
        ///<summary>The ID of the parent document</summary>
        ///<param name="value"></param>
        public virtual ExistsParameters parent(string value)
        {
            SetValue("parent", value);
            return this;
        }

        ///<summary>Specify the node or shard the operation should be performed on (default: random)</summary>
        ///<param name="value"></param>
        public virtual ExistsParameters preference(string value)
        {
            SetValue("preference", value);
            return this;
        }

        ///<summary>Specify whether to perform the operation in realtime or search mode</summary>
        ///<param name="value"></param>
        public virtual ExistsParameters realtime(bool value)
        {
            SetValue("realtime", value.ToString().ToLower());
            return this;
        }

        ///<summary>Refresh the shard containing the document before performing the operation</summary>
        ///<param name="value"></param>
        public virtual ExistsParameters refresh(bool value)
        {
            SetValue("refresh", value.ToString().ToLower());
            return this;
        }

        ///<summary>Specific routing value</summary>
        ///<param name="value"></param>
        public virtual ExistsParameters routing(string value)
        {
            SetValue("routing", value);
            return this;
        }
    }
}