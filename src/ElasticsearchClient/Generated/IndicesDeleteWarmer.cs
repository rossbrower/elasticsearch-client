using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to delete warmers from (supports wildcards); use `_all` to perform the operation on all indices.</param>
        ///<param name="name">A comma-separated list of warmer names to delete (supports wildcards); use `_all` to delete all warmers in the specified indices. You must specify a name either in the uri or in the parameters.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesDeleteWarmer(string index, string name, Func<IndicesDeleteWarmerParameters, IndicesDeleteWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/_warmer/{1}", index, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesDeleteWarmerParameters()).GetUri(uri);
            }

            return mConnection.Execute("DELETE", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-warmers.html"/></summary>
        ///<param name="index">A comma-separated list of index names to delete warmers from (supports wildcards); use `_all` to perform the operation on all indices.</param>
        ///<param name="name">A comma-separated list of warmer names to delete (supports wildcards); use `_all` to delete all warmers in the specified indices. You must specify a name either in the uri or in the parameters.</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesDeleteWarmerAsync(string index, string name, Func<IndicesDeleteWarmerParameters, IndicesDeleteWarmerParameters> options = null)
        {
            var uri = string.Format("/{0}/_warmer/{1}", index, name);
            if (options != null)
            {
                uri = options.Invoke(new IndicesDeleteWarmerParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("DELETE", uri);
        }
    }
}