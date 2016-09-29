namespace Elasticsearch.Client
{
    public class CatIndicesParameters : Parameters
    {
        ///<summary>a short version of the Accept header, e.g. json, yaml</summary>
        ///<param name="value"></param>
        public virtual CatIndicesParameters format(string value)
        {
            SetValue("format", value);
            return this;
        }

        ///<summary>The unit in which to display byte values</summary>
        ///<param name="value"><para>Options: b,k,m,g</para></param>
        public virtual CatIndicesParameters bytes(string value)
        {
            SetValue("bytes", value);
            return this;
        }

        ///<summary>Return local information, do not retrieve the state from master node (default: false)</summary>
        ///<param name="value"></param>
        public virtual CatIndicesParameters local(bool value)
        {
            SetValue("local", value.ToString().ToLower());
            return this;
        }

        ///<summary>Explicit operation timeout for connection to master node</summary>
        ///<param name="value"></param>
        public virtual CatIndicesParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }

        ///<summary>Comma-separated list of column names to display</summary>
        ///<param name="value"></param>
        public virtual CatIndicesParameters h(string value)
        {
            SetValue("h", value);
            return this;
        }

        ///<summary>A health status ("green", "yellow", or "red" to filter only indices matching the specified health status</summary>
        ///<param name="value"></param>
        public virtual CatIndicesParameters health(string value)
        {
            SetValue("health", value);
            return this;
        }

        ///<summary>Return help information</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual CatIndicesParameters help(bool value)
        {
            SetValue("help", value.ToString().ToLower());
            return this;
        }

        ///<summary>Set to true to return stats only for primary shards</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual CatIndicesParameters pri(bool value)
        {
            SetValue("pri", value.ToString().ToLower());
            return this;
        }

        ///<summary>Verbose mode. Display column headers</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual CatIndicesParameters v(bool value)
        {
            SetValue("v", value.ToString().ToLower());
            return this;
        }
    }
}