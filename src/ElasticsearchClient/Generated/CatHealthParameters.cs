namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cat-health.html"/></summary>
    public class CatHealthParameters : Parameters
    {
        ///<summary>a short version of the Accept header, e.g. json, yaml</summary>
        ///<param name="value"></param>
        public virtual CatHealthParameters format(string value)
        {
            SetValue("format", value);
            return this;
        }

        ///<summary>Return local information, do not retrieve the state from master node (default: false)</summary>
        ///<param name="value"></param>
        public virtual CatHealthParameters local(bool value)
        {
            SetValue("local", value.ToString().ToLower());
            return this;
        }

        ///<summary>Explicit operation timeout for connection to master node</summary>
        ///<param name="value"></param>
        public virtual CatHealthParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }

        ///<summary>Comma-separated list of column names to display</summary>
        ///<param name="value"></param>
        public virtual CatHealthParameters h(string value)
        {
            SetValue("h", value);
            return this;
        }

        ///<summary>Return help information</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual CatHealthParameters help(bool value)
        {
            SetValue("help", value.ToString().ToLower());
            return this;
        }

        ///<summary>Set to false to disable timestamping</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual CatHealthParameters ts(bool value)
        {
            SetValue("ts", value.ToString().ToLower());
            return this;
        }

        ///<summary>Verbose mode. Display column headers</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual CatHealthParameters v(bool value)
        {
            SetValue("v", value.ToString().ToLower());
            return this;
        }
    }
}