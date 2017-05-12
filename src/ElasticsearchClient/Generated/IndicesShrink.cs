using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-shrink-index.html"/></summary>
        ///<param name="index">The name of the source index to shrink</param>
        ///<param name="target">The name of the target index to shrink into</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesShrinkPut(string index, string target, Func<IndicesShrinkParameters, IndicesShrinkParameters> options = null)
        {
            var uri = string.Format("/{0}/_shrink/{1}", index, target);
            if (options != null)
            {
                uri = options.Invoke(new IndicesShrinkParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-shrink-index.html"/></summary>
        ///<param name="index">The name of the source index to shrink</param>
        ///<param name="target">The name of the target index to shrink into</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesShrinkPutAsync(string index, string target, Func<IndicesShrinkParameters, IndicesShrinkParameters> options = null)
        {
            var uri = string.Format("/{0}/_shrink/{1}", index, target);
            if (options != null)
            {
                uri = options.Invoke(new IndicesShrinkParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-shrink-index.html"/></summary>
        ///<param name="index">The name of the source index to shrink</param>
        ///<param name="target">The name of the target index to shrink into</param>
        ///<param name="body">The configuration for the target index (`settings` and `aliases`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesShrinkPut(string index, string target, Stream body, Func<IndicesShrinkParameters, IndicesShrinkParameters> options = null)
        {
            var uri = string.Format("/{0}/_shrink/{1}", index, target);
            if (options != null)
            {
                uri = options.Invoke(new IndicesShrinkParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-shrink-index.html"/></summary>
        ///<param name="index">The name of the source index to shrink</param>
        ///<param name="target">The name of the target index to shrink into</param>
        ///<param name="body">The configuration for the target index (`settings` and `aliases`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesShrinkPutAsync(string index, string target, Stream body, Func<IndicesShrinkParameters, IndicesShrinkParameters> options = null)
        {
            var uri = string.Format("/{0}/_shrink/{1}", index, target);
            if (options != null)
            {
                uri = options.Invoke(new IndicesShrinkParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-shrink-index.html"/></summary>
        ///<param name="index">The name of the source index to shrink</param>
        ///<param name="target">The name of the target index to shrink into</param>
        ///<param name="body">The configuration for the target index (`settings` and `aliases`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesShrinkPut(string index, string target, byte[] body, Func<IndicesShrinkParameters, IndicesShrinkParameters> options = null)
        {
            var uri = string.Format("/{0}/_shrink/{1}", index, target);
            if (options != null)
            {
                uri = options.Invoke(new IndicesShrinkParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-shrink-index.html"/></summary>
        ///<param name="index">The name of the source index to shrink</param>
        ///<param name="target">The name of the target index to shrink into</param>
        ///<param name="body">The configuration for the target index (`settings` and `aliases`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesShrinkPutAsync(string index, string target, byte[] body, Func<IndicesShrinkParameters, IndicesShrinkParameters> options = null)
        {
            var uri = string.Format("/{0}/_shrink/{1}", index, target);
            if (options != null)
            {
                uri = options.Invoke(new IndicesShrinkParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-shrink-index.html"/></summary>
        ///<param name="index">The name of the source index to shrink</param>
        ///<param name="target">The name of the target index to shrink into</param>
        ///<param name="body">The configuration for the target index (`settings` and `aliases`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesShrinkPutString(string index, string target, string body, Func<IndicesShrinkParameters, IndicesShrinkParameters> options = null)
        {
            var uri = string.Format("/{0}/_shrink/{1}", index, target);
            if (options != null)
            {
                uri = options.Invoke(new IndicesShrinkParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-shrink-index.html"/></summary>
        ///<param name="index">The name of the source index to shrink</param>
        ///<param name="target">The name of the target index to shrink into</param>
        ///<param name="body">The configuration for the target index (`settings` and `aliases`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesShrinkPutStringAsync(string index, string target, string body, Func<IndicesShrinkParameters, IndicesShrinkParameters> options = null)
        {
            var uri = string.Format("/{0}/_shrink/{1}", index, target);
            if (options != null)
            {
                uri = options.Invoke(new IndicesShrinkParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-shrink-index.html"/></summary>
        ///<param name="index">The name of the source index to shrink</param>
        ///<param name="target">The name of the target index to shrink into</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesShrinkPost(string index, string target, Func<IndicesShrinkParameters, IndicesShrinkParameters> options = null)
        {
            var uri = string.Format("/{0}/_shrink/{1}", index, target);
            if (options != null)
            {
                uri = options.Invoke(new IndicesShrinkParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-shrink-index.html"/></summary>
        ///<param name="index">The name of the source index to shrink</param>
        ///<param name="target">The name of the target index to shrink into</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesShrinkPostAsync(string index, string target, Func<IndicesShrinkParameters, IndicesShrinkParameters> options = null)
        {
            var uri = string.Format("/{0}/_shrink/{1}", index, target);
            if (options != null)
            {
                uri = options.Invoke(new IndicesShrinkParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-shrink-index.html"/></summary>
        ///<param name="index">The name of the source index to shrink</param>
        ///<param name="target">The name of the target index to shrink into</param>
        ///<param name="body">The configuration for the target index (`settings` and `aliases`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesShrinkPost(string index, string target, Stream body, Func<IndicesShrinkParameters, IndicesShrinkParameters> options = null)
        {
            var uri = string.Format("/{0}/_shrink/{1}", index, target);
            if (options != null)
            {
                uri = options.Invoke(new IndicesShrinkParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-shrink-index.html"/></summary>
        ///<param name="index">The name of the source index to shrink</param>
        ///<param name="target">The name of the target index to shrink into</param>
        ///<param name="body">The configuration for the target index (`settings` and `aliases`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesShrinkPostAsync(string index, string target, Stream body, Func<IndicesShrinkParameters, IndicesShrinkParameters> options = null)
        {
            var uri = string.Format("/{0}/_shrink/{1}", index, target);
            if (options != null)
            {
                uri = options.Invoke(new IndicesShrinkParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-shrink-index.html"/></summary>
        ///<param name="index">The name of the source index to shrink</param>
        ///<param name="target">The name of the target index to shrink into</param>
        ///<param name="body">The configuration for the target index (`settings` and `aliases`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesShrinkPost(string index, string target, byte[] body, Func<IndicesShrinkParameters, IndicesShrinkParameters> options = null)
        {
            var uri = string.Format("/{0}/_shrink/{1}", index, target);
            if (options != null)
            {
                uri = options.Invoke(new IndicesShrinkParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-shrink-index.html"/></summary>
        ///<param name="index">The name of the source index to shrink</param>
        ///<param name="target">The name of the target index to shrink into</param>
        ///<param name="body">The configuration for the target index (`settings` and `aliases`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesShrinkPostAsync(string index, string target, byte[] body, Func<IndicesShrinkParameters, IndicesShrinkParameters> options = null)
        {
            var uri = string.Format("/{0}/_shrink/{1}", index, target);
            if (options != null)
            {
                uri = options.Invoke(new IndicesShrinkParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-shrink-index.html"/></summary>
        ///<param name="index">The name of the source index to shrink</param>
        ///<param name="target">The name of the target index to shrink into</param>
        ///<param name="body">The configuration for the target index (`settings` and `aliases`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesShrinkPostString(string index, string target, string body, Func<IndicesShrinkParameters, IndicesShrinkParameters> options = null)
        {
            var uri = string.Format("/{0}/_shrink/{1}", index, target);
            if (options != null)
            {
                uri = options.Invoke(new IndicesShrinkParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-shrink-index.html"/></summary>
        ///<param name="index">The name of the source index to shrink</param>
        ///<param name="target">The name of the target index to shrink into</param>
        ///<param name="body">The configuration for the target index (`settings` and `aliases`)</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesShrinkPostStringAsync(string index, string target, string body, Func<IndicesShrinkParameters, IndicesShrinkParameters> options = null)
        {
            var uri = string.Format("/{0}/_shrink/{1}", index, target);
            if (options != null)
            {
                uri = options.Invoke(new IndicesShrinkParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}