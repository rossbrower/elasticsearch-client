namespace Elasticsearch.Client
{
    public class MgetParameters : Parameters
    {
        ///<summary>A comma-separated list of fields to return in the response</summary>
        ///<param name="value"></param>
        public virtual MgetParameters fields(string value)
        {
            SetValue("fields", value);
            return this;
        }

        ///<summary>Specify the node or shard the operation should be performed on (default: random)</summary>
        ///<param name="value"></param>
        public virtual MgetParameters preference(string value)
        {
            SetValue("preference", value);
            return this;
        }

        ///<summary>Specify whether to perform the operation in realtime or search mode</summary>
        ///<param name="value"></param>
        public virtual MgetParameters realtime(bool value)
        {
            SetValue("realtime", value.ToString().ToLower());
            return this;
        }

        ///<summary>Refresh the shard containing the document before performing the operation</summary>
        ///<param name="value"></param>
        public virtual MgetParameters refresh(bool value)
        {
            SetValue("refresh", value.ToString().ToLower());
            return this;
        }

        ///<summary>True or false to return the _source field or not, or a list of fields to return</summary>
        ///<param name="value"></param>
        public virtual MgetParameters _source(string value)
        {
            SetValue("_source", value);
            return this;
        }

        ///<summary>A list of fields to exclude from the returned _source field</summary>
        ///<param name="value"></param>
        public virtual MgetParameters _source_exclude(string value)
        {
            SetValue("_source_exclude", value);
            return this;
        }

        ///<summary>A list of fields to extract and return from the _source field</summary>
        ///<param name="value"></param>
        public virtual MgetParameters _source_include(string value)
        {
            SetValue("_source_include", value);
            return this;
        }
    }
}