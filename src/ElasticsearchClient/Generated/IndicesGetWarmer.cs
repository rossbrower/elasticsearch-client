using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesGetWarmer(Func<IndicesGetWarmerParameters, IndicesGetWarmerParameters> options = null)
        {
            var uri = "/_warmer";
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetWarmerParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesGetWarmerAsync(Func<IndicesGetWarmerParameters, IndicesGetWarmerParameters> options = null)
        {
            var uri = "/_warmer";
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetWarmerParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesGetWarmer(string index, Func<IndicesGetWarmerParameters, IndicesGetWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/_warmer", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetWarmerParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesGetWarmerAsync(string index, Func<IndicesGetWarmerParameters, IndicesGetWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/_warmer", index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetWarmerParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
        ///<param name="name">The name of the warmer (supports wildcards); leave empty to get all warmers</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesGetWarmer(string index, string name, Func<IndicesGetWarmerParameters, IndicesGetWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/_warmer/{1}", index, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetWarmerParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
        ///<param name="name">The name of the warmer (supports wildcards); leave empty to get all warmers</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesGetWarmerAsync(string index, string name, Func<IndicesGetWarmerParameters, IndicesGetWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/_warmer/{1}", index, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetWarmerParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
        ///<param name="name">The name of the warmer (supports wildcards); leave empty to get all warmers</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesGetWarmer(string index, string type, string name, Func<IndicesGetWarmerParameters, IndicesGetWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_warmer/{2}", index, type, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetWarmerParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
        ///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
        ///<param name="name">The name of the warmer (supports wildcards); leave empty to get all warmers</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesGetWarmerAsync(string index, string type, string name, Func<IndicesGetWarmerParameters, IndicesGetWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/{1}/_warmer/{2}", index, type, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesGetWarmerParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}