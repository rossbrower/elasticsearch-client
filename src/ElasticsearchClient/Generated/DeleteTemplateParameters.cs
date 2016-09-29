namespace Elasticsearch.Client
{
    public class DeleteTemplateParameters : Parameters
    {
        ///<summary>Explicit version number for concurrency control</summary>
        ///<param name="value"></param>
        public virtual DeleteTemplateParameters version(long value)
        {
            SetValue("version", value);
            return this;
        }

        ///<summary>Specific version type</summary>
        ///<param name="value"><para>Options: internal,external,external_gte,force</para></param>
        public virtual DeleteTemplateParameters version_type(string value)
        {
            SetValue("version_type", value);
            return this;
        }
    }
}