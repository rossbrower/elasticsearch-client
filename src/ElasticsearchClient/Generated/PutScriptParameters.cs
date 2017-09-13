namespace Elasticsearch.Client
{
    ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-scripting.html"/></summary>
    public class PutScriptParameters : Parameters
    {
        ///<summary>Explicit operation timeout</summary>
        ///<param name="value"></param>
        public virtual PutScriptParameters timeout(string value)
        {
            SetValue("timeout", value);
            return this;
        }

        ///<summary>Specify timeout for connection to master</summary>
        ///<param name="value"></param>
        public virtual PutScriptParameters master_timeout(string value)
        {
            SetValue("master_timeout", value);
            return this;
        }

        ///<summary>Context name to compile script against</summary>
        ///<param name="value"></param>
        public virtual PutScriptParameters context(string value)
        {
            SetValue("context", value);
            return this;
        }

        ///<summary>Pretty format the returned JSON response.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual PutScriptParameters pretty(bool value)
        {
            SetValue("pretty", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return human readable values for statistics.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual PutScriptParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Include the stack trace of returned errors.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual PutScriptParameters error_trace(bool value)
        {
            SetValue("error_trace", value.ToString().ToLower());
            return this;
        }

        ///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
        ///<param name="value"></param>
        public virtual PutScriptParameters source(string value)
        {
            SetValue("source", value);
            return this;
        }

        ///<summary>A comma-separated list of filters used to reduce the respone.</summary>
        ///<param name="value"></param>
        public virtual PutScriptParameters filter_path(string value)
        {
            SetValue("filter_path", value);
            return this;
        }
    }
}