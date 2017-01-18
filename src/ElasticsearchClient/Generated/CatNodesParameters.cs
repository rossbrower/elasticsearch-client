namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cat-nodes.html"/></summary>
    public class CatNodesParameters : Parameters
    {
        ///<summary>a short version of the Accept header, e.g. json, yaml</summary>
        ///<param name="value"></param>
        public virtual CatNodesParameters format(string value)
        {
            SetValue("format", value);
            return this;
        }

        ///<summary>Return the full node ID instead of the shortened version (default: false)</summary>
        ///<param name="value"></param>
        public virtual CatNodesParameters full_id(bool value)
        {
            SetValue("full_id", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return local information, do not retrieve the state from master node (default: false)</summary>
        ///<param name="value"></param>
        public virtual CatNodesParameters local(bool value)
        {
            SetValue("local", value.ToString().ToLower());
            return this;
        }

        ///<summary>Explicit operation timeout for connection to master node</summary>
        ///<param name="value"></param>
        public virtual CatNodesParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }

        ///<summary>Comma-separated list of column names to display</summary>
        ///<param name="value"></param>
        public virtual CatNodesParameters h(string value)
        {
            SetValue("h", value);
            return this;
        }

        ///<summary>Return help information</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual CatNodesParameters help(bool value)
        {
            SetValue("help", value.ToString().ToLower());
            return this;
        }

        ///<summary>Comma-separated list of column names or column aliases to sort by</summary>
        ///<param name="value"></param>
        public virtual CatNodesParameters s(string value)
        {
            SetValue("s", value);
            return this;
        }

        ///<summary>Verbose mode. Display column headers</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual CatNodesParameters v(bool value)
        {
            SetValue("v", value.ToString().ToLower());
            return this;
        }
    }
}