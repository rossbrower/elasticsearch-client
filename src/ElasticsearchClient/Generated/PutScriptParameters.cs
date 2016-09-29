namespace Elasticsearch.Client
{
    public class PutScriptParameters : Parameters
    {
        ///<summary>Explicit operation type</summary>
        ///<param name="value"><para>Options: index,create</para><para>Default: index</para></param>
        public virtual PutScriptParameters op_type(string value)
        {
            SetValue("op_type", value);
            return this;
        }

        ///<summary>Explicit version number for concurrency control</summary>
        ///<param name="value"></param>
        public virtual PutScriptParameters version(long value)
        {
            SetValue("version", value);
            return this;
        }

        ///<summary>Specific version type</summary>
        ///<param name="value"><para>Options: internal,external,external_gte,force</para></param>
        public virtual PutScriptParameters version_type(string value)
        {
            SetValue("version_type", value);
            return this;
        }
    }
}