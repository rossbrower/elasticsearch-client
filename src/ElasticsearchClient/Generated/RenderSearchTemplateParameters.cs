namespace Elasticsearch.Client
{
    ///<summary><see href="http://www.elasticsearch.org/guide/en/elasticsearch/reference/master/search-template.html"/></summary>
    public class RenderSearchTemplateParameters : Parameters
    {
        ///<summary>Pretty format the returned JSON response.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual RenderSearchTemplateParameters pretty(bool value)
        {
            SetValue("pretty", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return human readable values for statistics.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual RenderSearchTemplateParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Include the stack trace of returned errors.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual RenderSearchTemplateParameters error_trace(bool value)
        {
            SetValue("error_trace", value.ToString().ToLower());
            return this;
        }

        ///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
        ///<param name="value"></param>
        public virtual RenderSearchTemplateParameters source(string value)
        {
            SetValue("source", value);
            return this;
        }

        ///<summary>A comma-separated list of filters used to reduce the respone.</summary>
        ///<param name="value"></param>
        public virtual RenderSearchTemplateParameters filter_path(string value)
        {
            SetValue("filter_path", value);
            return this;
        }
    }
}