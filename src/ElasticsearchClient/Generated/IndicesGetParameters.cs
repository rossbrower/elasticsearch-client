namespace Elasticsearch.Client
{
    public class IndicesGetParameters : Parameters
    {
        ///<summary>Return local information, do not retrieve the state from master node (default: false)</summary>
        ///<param name="value"></param>
        public virtual IndicesGetParameters local(bool value)
        {
            SetValue("local", value.ToString().ToLower());
            return this;
        }

        ///<summary>Ignore unavailable indexes (default: false)</summary>
        ///<param name="value"></param>
        public virtual IndicesGetParameters ignore_unavailable(bool value)
        {
            SetValue("ignore_unavailable", value.ToString().ToLower());
            return this;
        }

        ///<summary>Ignore if a wildcard expression resolves to no concrete indices (default: false)</summary>
        ///<param name="value"></param>
        public virtual IndicesGetParameters allow_no_indices(bool value)
        {
            SetValue("allow_no_indices", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether wildcard expressions should get expanded to open or closed indices (default: open)</summary>
        ///<param name="value"><para>Options: open,closed,none,all</para><para>Default: open</para></param>
        public virtual IndicesGetParameters expand_wildcards(string value)
        {
            SetValue("expand_wildcards", value);
            return this;
        }

        ///<summary>Return settings in flat format (default: false)</summary>
        ///<param name="value"></param>
        public virtual IndicesGetParameters flat_settings(bool value)
        {
            SetValue("flat_settings", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to return version and creation date values in human-readable format.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual IndicesGetParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Whether to return all default setting for each of the indices.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual IndicesGetParameters include_defaults(bool value)
        {
            SetValue("include_defaults", value.ToString().ToLower());
            return this;
        }
    }
}