namespace Elasticsearch.Client
{
    public class GetScriptParameters : Parameters
    {
        ///<summary>Explicit version number for concurrency control</summary>
        ///<param name="value"></param>
        public virtual GetScriptParameters version(long value)
        {
            SetValue("version", value);
            return this;
        }

        ///<summary>Specific version type</summary>
        ///<param name="value"><para>Options: internal,external,external_gte,force</para></param>
        public virtual GetScriptParameters version_type(string value)
        {
            SetValue("version_type", value);
            return this;
        }
    }
}