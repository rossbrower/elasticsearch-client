namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cat-repositories.html"/></summary>
    public class CatRepositoriesParameters : Parameters
    {
        ///<summary>Return local information, do not retrieve the state from master node</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual CatRepositoriesParameters local(bool value)
        {
            SetValue("local", value.ToString().ToLower());
            return this;
        }

        ///<summary>Explicit operation timeout for connection to master node</summary>
        ///<param name="value"></param>
        public virtual CatRepositoriesParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }

        ///<summary>Comma-separated list of column names to display</summary>
        ///<param name="value"></param>
        public virtual CatRepositoriesParameters h(string value)
        {
            SetValue("h", value);
            return this;
        }

        ///<summary>Return help information</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual CatRepositoriesParameters help(bool value)
        {
            SetValue("help", value.ToString().ToLower());
            return this;
        }

        ///<summary>Comma-separated list of column names or column aliases to sort by</summary>
        ///<param name="value"></param>
        public virtual CatRepositoriesParameters s(string value)
        {
            SetValue("s", value);
            return this;
        }

        ///<summary>Verbose mode. Display column headers</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual CatRepositoriesParameters v(bool value)
        {
            SetValue("v", value.ToString().ToLower());
            return this;
        }
    }
}