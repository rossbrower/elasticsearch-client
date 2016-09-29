namespace Elasticsearch.Client
{
    public class IngestSimulateParameters : Parameters
    {
        ///<summary>Verbose mode. Display data output for each processor in executed pipeline</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual IngestSimulateParameters verbose(bool value)
        {
            SetValue("verbose", value.ToString().ToLower());
            return this;
        }
    }
}