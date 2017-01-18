namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/search-template.html"/></summary>
    public class PutTemplateParameters : Parameters
    {
        ///<summary>Explicit operation type</summary>
        ///<param name="value"><para>Options: index,create</para><para>Default: index</para></param>
        public virtual PutTemplateParameters op_type(string value)
        {
            SetValue("op_type", value);
            return this;
        }

        ///<summary>Explicit version number for concurrency control</summary>
        ///<param name="value"></param>
        public virtual PutTemplateParameters version(long value)
        {
            SetValue("version", value);
            return this;
        }

        ///<summary>Specific version type</summary>
        ///<param name="value"><para>Options: internal,external,external_gte,force</para></param>
        public virtual PutTemplateParameters version_type(string value)
        {
            SetValue("version_type", value);
            return this;
        }
    }
}