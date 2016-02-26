using System.Net;
using System.Text;

namespace Elasticsearch.Client
{
    public abstract class Parameters
    {
        private readonly StringBuilder mStringBuilder;

        protected internal Parameters()
        {
            mStringBuilder = new StringBuilder();
        }
            
        internal string GetUri(string uri)
        {
            return uri + mStringBuilder;
        }

        protected internal void SetValue(string name, object value)
        {
            var keyValue = $"{name}={WebUtility.UrlEncode(value.ToString())}";
            mStringBuilder.Append(mStringBuilder.Length == 0
                ? "?" + keyValue
                : "&" + keyValue);
        }
    }
}
