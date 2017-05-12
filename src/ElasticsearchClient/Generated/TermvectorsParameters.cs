namespace Elasticsearch.Client
{
    ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/docs-termvectors.html"/></summary>
    public class TermvectorsParameters : Parameters
    {
        ///<summary>Specifies if total term frequency and document frequency should be returned.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual TermvectorsParameters term_statistics(bool value)
        {
            SetValue("term_statistics", value.ToString().ToLower());
            return this;
        }

        ///<summary>Specifies if document count, sum of document frequencies and sum of total term frequencies should be returned.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual TermvectorsParameters field_statistics(bool value)
        {
            SetValue("field_statistics", value.ToString().ToLower());
            return this;
        }

        ///<summary>A comma-separated list of fields to return.</summary>
        ///<param name="value"></param>
        public virtual TermvectorsParameters fields(string value)
        {
            SetValue("fields", value);
            return this;
        }

        ///<summary>Specifies if term offsets should be returned.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual TermvectorsParameters offsets(bool value)
        {
            SetValue("offsets", value.ToString().ToLower());
            return this;
        }

        ///<summary>Specifies if term positions should be returned.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual TermvectorsParameters positions(bool value)
        {
            SetValue("positions", value.ToString().ToLower());
            return this;
        }

        ///<summary>Specifies if term payloads should be returned.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual TermvectorsParameters payloads(bool value)
        {
            SetValue("payloads", value.ToString().ToLower());
            return this;
        }

        ///<summary>Specify the node or shard the operation should be performed on (default: random).</summary>
        ///<param name="value"></param>
        public virtual TermvectorsParameters preference(string value)
        {
            SetValue("preference", value);
            return this;
        }

        ///<summary>Specific routing value.</summary>
        ///<param name="value"></param>
        public virtual TermvectorsParameters routing(string value)
        {
            SetValue("routing", value);
            return this;
        }

        ///<summary>Parent id of documents.</summary>
        ///<param name="value"></param>
        public virtual TermvectorsParameters parent(string value)
        {
            SetValue("parent", value);
            return this;
        }

        ///<summary>Specifies if request is real-time as opposed to near-real-time (default: true).</summary>
        ///<param name="value"></param>
        public virtual TermvectorsParameters realtime(bool value)
        {
            SetValue("realtime", value.ToString().ToLower());
            return this;
        }

        ///<summary>Explicit version number for concurrency control</summary>
        ///<param name="value"></param>
        public virtual TermvectorsParameters version(long value)
        {
            SetValue("version", value);
            return this;
        }

        ///<summary>Specific version type</summary>
        ///<param name="value"><para>Options: internal,external,external_gte,force</para></param>
        public virtual TermvectorsParameters version_type(string value)
        {
            SetValue("version_type", value);
            return this;
        }

        ///<summary>Pretty format the returned JSON response.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual TermvectorsParameters pretty(bool value)
        {
            SetValue("pretty", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return human readable values for statistics.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual TermvectorsParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Include the stack trace of returned errors.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual TermvectorsParameters error_trace(bool value)
        {
            SetValue("error_trace", value.ToString().ToLower());
            return this;
        }

        ///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
        ///<param name="value"></param>
        public virtual TermvectorsParameters source(string value)
        {
            SetValue("source", value);
            return this;
        }

        ///<summary>A comma-separated list of filters used to reduce the respone.</summary>
        ///<param name="value"></param>
        public virtual TermvectorsParameters filter_path(string value)
        {
            SetValue("filter_path", value);
            return this;
        }
    }
}