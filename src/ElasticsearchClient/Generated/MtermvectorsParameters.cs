namespace Elasticsearch.Client
{
    ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/docs-multi-termvectors.html"/></summary>
    public class MtermvectorsParameters : Parameters
    {
        ///<summary>A comma-separated list of documents ids. You must define ids as parameter or set "ids" or "docs" in the request body</summary>
        ///<param name="value"></param>
        public virtual MtermvectorsParameters ids(string value)
        {
            SetValue("ids", value);
            return this;
        }

        ///<summary>Specifies if total term frequency and document frequency should be returned. Applies to all returned documents unless otherwise specified in body "params" or "docs".</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual MtermvectorsParameters term_statistics(bool value)
        {
            SetValue("term_statistics", value.ToString().ToLower());
            return this;
        }

        ///<summary>Specifies if document count, sum of document frequencies and sum of total term frequencies should be returned. Applies to all returned documents unless otherwise specified in body "params" or "docs".</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual MtermvectorsParameters field_statistics(bool value)
        {
            SetValue("field_statistics", value.ToString().ToLower());
            return this;
        }

        ///<summary>A comma-separated list of fields to return. Applies to all returned documents unless otherwise specified in body "params" or "docs".</summary>
        ///<param name="value"></param>
        public virtual MtermvectorsParameters fields(string value)
        {
            SetValue("fields", value);
            return this;
        }

        ///<summary>Specifies if term offsets should be returned. Applies to all returned documents unless otherwise specified in body "params" or "docs".</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual MtermvectorsParameters offsets(bool value)
        {
            SetValue("offsets", value.ToString().ToLower());
            return this;
        }

        ///<summary>Specifies if term positions should be returned. Applies to all returned documents unless otherwise specified in body "params" or "docs".</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual MtermvectorsParameters positions(bool value)
        {
            SetValue("positions", value.ToString().ToLower());
            return this;
        }

        ///<summary>Specifies if term payloads should be returned. Applies to all returned documents unless otherwise specified in body "params" or "docs".</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual MtermvectorsParameters payloads(bool value)
        {
            SetValue("payloads", value.ToString().ToLower());
            return this;
        }

        ///<summary>Specify the node or shard the operation should be performed on (default: random) .Applies to all returned documents unless otherwise specified in body "params" or "docs".</summary>
        ///<param name="value"></param>
        public virtual MtermvectorsParameters preference(string value)
        {
            SetValue("preference", value);
            return this;
        }

        ///<summary>Specific routing value. Applies to all returned documents unless otherwise specified in body "params" or "docs".</summary>
        ///<param name="value"></param>
        public virtual MtermvectorsParameters routing(string value)
        {
            SetValue("routing", value);
            return this;
        }

        ///<summary>Parent id of documents. Applies to all returned documents unless otherwise specified in body "params" or "docs".</summary>
        ///<param name="value"></param>
        public virtual MtermvectorsParameters parent(string value)
        {
            SetValue("parent", value);
            return this;
        }

        ///<summary>Specifies if requests are real-time as opposed to near-real-time (default: true).</summary>
        ///<param name="value"></param>
        public virtual MtermvectorsParameters realtime(bool value)
        {
            SetValue("realtime", value.ToString().ToLower());
            return this;
        }

        ///<summary>Explicit version number for concurrency control</summary>
        ///<param name="value"></param>
        public virtual MtermvectorsParameters version(long value)
        {
            SetValue("version", value);
            return this;
        }

        ///<summary>Specific version type</summary>
        ///<param name="value"><para>Options: internal,external,external_gte,force</para></param>
        public virtual MtermvectorsParameters version_type(string value)
        {
            SetValue("version_type", value);
            return this;
        }

        ///<summary>Pretty format the returned JSON response.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual MtermvectorsParameters pretty(bool value)
        {
            SetValue("pretty", value.ToString().ToLower());
            return this;
        }

        ///<summary>Return human readable values for statistics.</summary>
        ///<param name="value"><para>Default: True</para></param>
        public virtual MtermvectorsParameters human(bool value)
        {
            SetValue("human", value.ToString().ToLower());
            return this;
        }

        ///<summary>Include the stack trace of returned errors.</summary>
        ///<param name="value"><para>Default: False</para></param>
        public virtual MtermvectorsParameters error_trace(bool value)
        {
            SetValue("error_trace", value.ToString().ToLower());
            return this;
        }

        ///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
        ///<param name="value"></param>
        public virtual MtermvectorsParameters source(string value)
        {
            SetValue("source", value);
            return this;
        }

        ///<summary>A comma-separated list of filters used to reduce the respone.</summary>
        ///<param name="value"></param>
        public virtual MtermvectorsParameters filter_path(string value)
        {
            SetValue("filter_path", value);
            return this;
        }
    }
}