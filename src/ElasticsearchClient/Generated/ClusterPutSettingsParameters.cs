namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/cluster-update-settings.html"/></summary>
    public class ClusterPutSettingsParameters : Parameters
    {
        ///<summary>Return settings in flat format (default: false)</summary>
        ///<param name="value"></param>
        public virtual ClusterPutSettingsParameters flat_settings(bool value)
        {
            SetValue("flat_settings", value.ToString().ToLower());
            return this;
        }

        ///<summary>Explicit operation timeout for connection to master node</summary>
        ///<param name="value"></param>
        public virtual ClusterPutSettingsParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }

        ///<summary>Explicit operation timeout</summary>
        ///<param name="value"></param>
        public virtual ClusterPutSettingsParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }
    }
}