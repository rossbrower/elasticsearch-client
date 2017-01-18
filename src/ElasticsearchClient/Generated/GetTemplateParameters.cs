namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-template.html"/></summary>
    public class GetTemplateParameters : Parameters
    {
        ///<summary>Explicit version number for concurrency control</summary>
        ///<param name="value"></param>
        public virtual GetTemplateParameters version(long value)
        {
            SetValue("version", value);
            return this;
        }

        ///<summary>Specific version type</summary>
        ///<param name="value"><para>Options: internal,external,external_gte,force</para></param>
        public virtual GetTemplateParameters version_type(string value)
        {
            SetValue("version_type", value);
            return this;
        }
    }
}