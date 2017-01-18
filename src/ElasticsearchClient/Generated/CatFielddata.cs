using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/cat-fielddata.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CatFielddata(Func<CatFielddataParameters, CatFielddataParameters> options = null)
        {
            var uri = "/_cat/fielddata";
            if (options != null)
            {
                uri = options.Invoke(new CatFielddataParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/cat-fielddata.html"/></summary>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatFielddataAsync(Func<CatFielddataParameters, CatFielddataParameters> options = null)
        {
            var uri = "/_cat/fielddata";
            if (options != null)
            {
                uri = options.Invoke(new CatFielddataParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/cat-fielddata.html"/></summary>
        ///<param name="fields">A comma-separated list of fields to return the fielddata size</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage CatFielddata(string fields, Func<CatFielddataParameters, CatFielddataParameters> options = null)
        {
            var uri = string.Format("/_cat/fielddata/{0}", fields);
            if (options != null)
            {
                uri = options.Invoke(new CatFielddataParameters()).GetUri(uri);
            }

            return mConnection.Execute("GET", uri);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/2.4/cat-fielddata.html"/></summary>
        ///<param name="fields">A comma-separated list of fields to return the fielddata size</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> CatFielddataAsync(string fields, Func<CatFielddataParameters, CatFielddataParameters> options = null)
        {
            var uri = string.Format("/_cat/fielddata/{0}", fields);
            if (options != null)
            {
                uri = options.Invoke(new CatFielddataParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("GET", uri);
        }
    }
}