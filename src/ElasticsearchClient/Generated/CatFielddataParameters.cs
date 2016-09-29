namespace Elasticsearch.Client
{
    public class CatFielddataParameters : Parameters
    {
        ///<summary>a short version of the Accept header, e.g. json, yaml</summary>
        ///<param name="value"></param>
        public virtual CatFielddataParameters format(string value)
        {
            SetValue("format", value);
            return this;
        }

        ///<summary>The unit in which to display byte values</summary>
        ///<param name="value"><para>Options: b,k,kb,m,mb,g,gb,t,tb,p,pb</para></param>
        public virtual CatFielddataParameters bytes(string value)
        {
            SetValue("bytes", value);
            return this;
        }

        ///<summary>Return local information, do not retrieve the state from master node (default: false)</summary>
        ///<param name="value"></param>
        public virtual CatFielddataParameters local(bool value)
        {
            SetValue("local", value.ToString().ToLower());
            return this;
        }

        ///<summary>Explicit operation timeout for connection to master node</summary>
        ///<param name="value"></param>
        public virtual CatFielddataParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }

        ///<summary>Comma-separated list of column names to display</summary>
        ///<param name="value"></param>
        public virtual CatFielddataParameters h(string value)
        {
            SetValue("h", value);
            return this;
        }

        ///<summary>Return help information</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual CatFielddataParameters help(bool value)
        {
            SetValue("help", value.ToString().ToLower());
            return this;
        }

        ///<summary>Verbose mode. Display column headers</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual CatFielddataParameters v(bool value)
        {
            SetValue("v", value.ToString().ToLower());
            return this;
        }

        ///<summary>A comma-separated list of fields to return in the output</summary>
        ///<param name="value"></param>
        public virtual CatFielddataParameters fields(string value)
        {
            SetValue("fields", value);
            return this;
        }
    }
}