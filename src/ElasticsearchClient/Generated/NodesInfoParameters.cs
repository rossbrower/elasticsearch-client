namespace Elasticsearch.Client
{
    public class NodesInfoParameters : Parameters
    {
        ///<summary>Return settings in flat format (default: false)</summary>
        ///<param name="value"></param>
        public virtual NodesInfoParameters flat_settings(bool value)
        {
            SetValue("flat_settings", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to return time and byte values in human-readable format.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual NodesInfoParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Explicit operation timeout</summary>
        ///<param name="value"></param>
        public virtual NodesInfoParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }
    }
}