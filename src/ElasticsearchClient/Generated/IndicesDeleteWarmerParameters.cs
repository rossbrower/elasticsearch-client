namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-warmers.html"/></summary>
    public class IndicesDeleteWarmerParameters : Parameters
    {
        ///<summary>Specify timeout for connection to master</summary>
        ///<param name="value"></param>
        public virtual IndicesDeleteWarmerParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }

        ///<summary>A comma-separated list of warmer names to delete (supports wildcards); use `_all` to delete all warmers in the specified indices. You must specify a name either in the uri or in the parameters.</summary>
        ///<param name="value"></param>
        public virtual IndicesDeleteWarmerParameters name(string value)
        {
            SetValue("name", value);
            return this;
        }
    }
}