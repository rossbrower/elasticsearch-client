namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cat-templates.html"/></summary>
    public class CatTemplatesParameters : Parameters
    {
        ///<summary>a short version of the Accept header, e.g. json, yaml</summary>
        ///<param name="value"></param>
        public virtual CatTemplatesParameters format(string value)
        {
            SetValue("format", value);
            return this;
        }

        ///<summary>Return local information, do not retrieve the state from master node (default: false)</summary>
        ///<param name="value"></param>
        public virtual CatTemplatesParameters local(bool value)
        {
            SetValue("local", value.ToString().ToLower());
            return this;
        }

        ///<summary>Explicit operation timeout for connection to master node</summary>
        ///<param name="value"></param>
        public virtual CatTemplatesParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }

        ///<summary>Comma-separated list of column names to display</summary>
        ///<param name="value"></param>
        public virtual CatTemplatesParameters h(string value)
        {
            SetValue("h", value);
            return this;
        }

        ///<summary>Return help information</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual CatTemplatesParameters help(bool value)
        {
            SetValue("help", value.ToString().ToLower());
            return this;
        }

        ///<summary>Comma-separated list of column names or column aliases to sort by</summary>
        ///<param name="value"></param>
        public virtual CatTemplatesParameters s(string value)
        {
            SetValue("s", value);
            return this;
        }

        ///<summary>Verbose mode. Display column headers</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual CatTemplatesParameters v(bool value)
        {
            SetValue("v", value.ToString().ToLower());
            return this;
        }
    }
}