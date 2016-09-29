namespace Elasticsearch.Client
{
    public class CatSegmentsParameters : Parameters
    {
        ///<summary>Comma-separated list of column names to display</summary>
        ///<param name="value"></param>
        public virtual CatSegmentsParameters h(string value)
        {
            SetValue("h", value);
            return this;
        }

        ///<summary>Return help information</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual CatSegmentsParameters help(bool value)
        {
            SetValue("help", value.ToString().ToLower());
            return this;
        }

        ///<summary>Verbose mode. Display column headers</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual CatSegmentsParameters v(bool value)
        {
            SetValue("v", value.ToString().ToLower());
            return this;
        }
    }
}