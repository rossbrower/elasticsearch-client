namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/cluster-update-settings.html"/></summary>
    public class ClusterGetSettingsParameters : Parameters
    {
        ///<summary>Return settings in flat format (default: false)</summary>
        ///<param name="value"></param>
        public virtual ClusterGetSettingsParameters flat_settings(bool value)
        {
            SetValue("flat_settings", value.ToString().ToLower());
            return this;
        }

        ///<summary>Explicit operation timeout for connection to master node</summary>
        ///<param name="value"></param>
        public virtual ClusterGetSettingsParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }

        ///<summary>Explicit operation timeout</summary>
        ///<param name="value"></param>
        public virtual ClusterGetSettingsParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }

        ///<summary>Whether to return all default clusters setting.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual ClusterGetSettingsParameters include_defaults(bool value)
        {
            SetValue("include_defaults", value.ToString().ToLower());
            return this;
        }
    }
}