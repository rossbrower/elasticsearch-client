namespace Elasticsearch.Client
{
    public class ScrollParameters : Parameters
    {
        ///<summary>Specify how long a consistent view of the index should be maintained for scrolled search</summary>
        ///<param name="value"></param>
        public virtual ScrollParameters scroll(string value)
        {
            SetValue("scroll", value);
            return this;
        }

        ///<summary>The scroll ID for scrolled search</summary>
        ///<param name="value"></param>
        public virtual ScrollParameters scroll_id(string value)
        {
            SetValue("scroll_id", value);
            return this;
        }
    }
}