namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/indices-templates.html"/></summary>
    public class IndicesPutTemplateParameters : Parameters
    {
        ///<summary>The order for this template when merging multiple matching ones (higher numbers are merged later, overriding the lower numbers)</summary>
        ///<param name="value"></param>
        public virtual IndicesPutTemplateParameters order(long value)
        {
            SetValue("order", value);
            return this;
        }

        ///<summary>Whether the index template should only be added if new or can also replace an existing one</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual IndicesPutTemplateParameters create(bool value)
        {
            SetValue("create", value.ToString().ToLower());
            return this;
        }

        ///<summary>Explicit operation timeout</summary>
        ///<param name="value"></param>
        public virtual IndicesPutTemplateParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }

        ///<summary>Specify timeout for connection to master</summary>
        ///<param name="value"></param>
        public virtual IndicesPutTemplateParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }

        ///<summary>Return settings in flat format (default: false)</summary>
        ///<param name="value"></param>
        public virtual IndicesPutTemplateParameters flat_settings(bool value)
        {
            SetValue("flat_settings", value.ToString().ToLower());
            return this;
        }
    }
}