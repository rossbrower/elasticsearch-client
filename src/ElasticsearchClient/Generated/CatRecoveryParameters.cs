namespace Elasticsearch.Client
{
    public class CatRecoveryParameters : Parameters
    {
        ///<summary>a short version of the Accept header, e.g. json, yaml</summary>
        ///<param name="value"></param>
        public virtual CatRecoveryParameters format(string value)
        {
            SetValue("format", value);
            return this;
        }

        ///<summary>The unit in which to display byte values</summary>
        ///<param name="value"><para>Options: b,k,kb,m,mb,g,gb,t,tb,p,pb</para></param>
        public virtual CatRecoveryParameters bytes(string value)
        {
            SetValue("bytes", value);
            return this;
        }

        ///<summary>Explicit operation timeout for connection to master node</summary>
        ///<param name="value"></param>
        public virtual CatRecoveryParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }

        ///<summary>Comma-separated list of column names to display</summary>
        ///<param name="value"></param>
        public virtual CatRecoveryParameters h(string value)
        {
            SetValue("h", value);
            return this;
        }

        ///<summary>Return help information</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual CatRecoveryParameters help(bool value)
        {
            SetValue("help", value.ToString().ToLower());
            return this;
        }

        ///<summary>Verbose mode. Display column headers</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual CatRecoveryParameters v(bool value)
        {
            SetValue("v", value.ToString().ToLower());
            return this;
        }
    }
}