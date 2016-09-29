namespace Elasticsearch.Client
{
    public class CatHelpParameters : Parameters
    {
        ///<summary>Return help information</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual CatHelpParameters help(bool value)
        {
            SetValue("help", value.ToString().ToLower());
            return this;
        }
    }
}