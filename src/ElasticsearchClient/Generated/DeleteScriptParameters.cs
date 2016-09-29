namespace Elasticsearch.Client
{
    public class DeleteScriptParameters : Parameters
    {
        ///<summary>Explicit version number for concurrency control</summary>
        ///<param name="value"></param>
        public virtual DeleteScriptParameters version(long value)
        {
            SetValue("version", value);
            return this;
        }

        ///<summary>Specific version type</summary>
        ///<param name="value"><para>Options: internal,external,external_gte,force</para></param>
        public virtual DeleteScriptParameters version_type(string value)
        {
            SetValue("version_type", value);
            return this;
        }
    }
}