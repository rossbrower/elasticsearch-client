namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/cat.html"/></summary>
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