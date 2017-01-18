using System.Net;
using System.Text;

namespace Elasticsearch.Client
{
    /// <summary>
    /// Base class for handling URI parameters. 
    /// </summary>
    public abstract class Parameters
    {
        private readonly StringBuilder mStringBuilder;

        /// <summary>
        /// Contstruct a new instance.
        /// </summary>
        protected internal Parameters()
        {
            mStringBuilder = new StringBuilder();
        }
            
        internal string GetUri(string uri)
        {
            return uri + mStringBuilder;
        }

        /// <summary>
        /// Add the given name-value pair to the query string.
        /// </summary>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="value">The value of the parameter. It will be URI encoded for safety.</param>
        protected internal void SetValue(string name, object value)
        {
            var keyValue = $"{name}={WebUtility.UrlEncode(value.ToString())}";
            mStringBuilder.Append(mStringBuilder.Length == 0
                ? "?" + keyValue
                : "&" + keyValue);
        }
    }
}
