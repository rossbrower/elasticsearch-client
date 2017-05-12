using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-rollover-index.html"/></summary>
        ///<param name="alias">The name of the alias to rollover</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesRollover(string alias, Func<IndicesRolloverParameters, IndicesRolloverParameters> options = null)
        {
            var uri = string.Format("/{0}/_rollover", alias);
            if (options != null)
            {
                uri = options.Invoke(new IndicesRolloverParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-rollover-index.html"/></summary>
        ///<param name="alias">The name of the alias to rollover</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesRolloverAsync(string alias, Func<IndicesRolloverParameters, IndicesRolloverParameters> options = null)
        {
            var uri = string.Format("/{0}/_rollover", alias);
            if (options != null)
            {
                uri = options.Invoke(new IndicesRolloverParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-rollover-index.html"/></summary>
        ///<param name="alias">The name of the alias to rollover</param>
        ///<param name="body">The conditions that needs to be met for executing rollover</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesRollover(string alias, Stream body, Func<IndicesRolloverParameters, IndicesRolloverParameters> options = null)
        {
            var uri = string.Format("/{0}/_rollover", alias);
            if (options != null)
            {
                uri = options.Invoke(new IndicesRolloverParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-rollover-index.html"/></summary>
        ///<param name="alias">The name of the alias to rollover</param>
        ///<param name="body">The conditions that needs to be met for executing rollover</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesRolloverAsync(string alias, Stream body, Func<IndicesRolloverParameters, IndicesRolloverParameters> options = null)
        {
            var uri = string.Format("/{0}/_rollover", alias);
            if (options != null)
            {
                uri = options.Invoke(new IndicesRolloverParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-rollover-index.html"/></summary>
        ///<param name="alias">The name of the alias to rollover</param>
        ///<param name="body">The conditions that needs to be met for executing rollover</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesRollover(string alias, byte[] body, Func<IndicesRolloverParameters, IndicesRolloverParameters> options = null)
        {
            var uri = string.Format("/{0}/_rollover", alias);
            if (options != null)
            {
                uri = options.Invoke(new IndicesRolloverParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-rollover-index.html"/></summary>
        ///<param name="alias">The name of the alias to rollover</param>
        ///<param name="body">The conditions that needs to be met for executing rollover</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesRolloverAsync(string alias, byte[] body, Func<IndicesRolloverParameters, IndicesRolloverParameters> options = null)
        {
            var uri = string.Format("/{0}/_rollover", alias);
            if (options != null)
            {
                uri = options.Invoke(new IndicesRolloverParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-rollover-index.html"/></summary>
        ///<param name="alias">The name of the alias to rollover</param>
        ///<param name="body">The conditions that needs to be met for executing rollover</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesRolloverString(string alias, string body, Func<IndicesRolloverParameters, IndicesRolloverParameters> options = null)
        {
            var uri = string.Format("/{0}/_rollover", alias);
            if (options != null)
            {
                uri = options.Invoke(new IndicesRolloverParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-rollover-index.html"/></summary>
        ///<param name="alias">The name of the alias to rollover</param>
        ///<param name="body">The conditions that needs to be met for executing rollover</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesRolloverStringAsync(string alias, string body, Func<IndicesRolloverParameters, IndicesRolloverParameters> options = null)
        {
            var uri = string.Format("/{0}/_rollover", alias);
            if (options != null)
            {
                uri = options.Invoke(new IndicesRolloverParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-rollover-index.html"/></summary>
        ///<param name="alias">The name of the alias to rollover</param>
        ///<param name="new_index">The name of the rollover index</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesRollover(string alias, string new_index, Func<IndicesRolloverParameters, IndicesRolloverParameters> options = null)
        {
            var uri = string.Format("/{0}/_rollover/{1}", alias, new_index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesRolloverParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-rollover-index.html"/></summary>
        ///<param name="alias">The name of the alias to rollover</param>
        ///<param name="new_index">The name of the rollover index</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesRolloverAsync(string alias, string new_index, Func<IndicesRolloverParameters, IndicesRolloverParameters> options = null)
        {
            var uri = string.Format("/{0}/_rollover/{1}", alias, new_index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesRolloverParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-rollover-index.html"/></summary>
        ///<param name="alias">The name of the alias to rollover</param>
        ///<param name="new_index">The name of the rollover index</param>
        ///<param name="body">The conditions that needs to be met for executing rollover</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesRollover(string alias, string new_index, Stream body, Func<IndicesRolloverParameters, IndicesRolloverParameters> options = null)
        {
            var uri = string.Format("/{0}/_rollover/{1}", alias, new_index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesRolloverParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-rollover-index.html"/></summary>
        ///<param name="alias">The name of the alias to rollover</param>
        ///<param name="new_index">The name of the rollover index</param>
        ///<param name="body">The conditions that needs to be met for executing rollover</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesRolloverAsync(string alias, string new_index, Stream body, Func<IndicesRolloverParameters, IndicesRolloverParameters> options = null)
        {
            var uri = string.Format("/{0}/_rollover/{1}", alias, new_index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesRolloverParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-rollover-index.html"/></summary>
        ///<param name="alias">The name of the alias to rollover</param>
        ///<param name="new_index">The name of the rollover index</param>
        ///<param name="body">The conditions that needs to be met for executing rollover</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesRollover(string alias, string new_index, byte[] body, Func<IndicesRolloverParameters, IndicesRolloverParameters> options = null)
        {
            var uri = string.Format("/{0}/_rollover/{1}", alias, new_index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesRolloverParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-rollover-index.html"/></summary>
        ///<param name="alias">The name of the alias to rollover</param>
        ///<param name="new_index">The name of the rollover index</param>
        ///<param name="body">The conditions that needs to be met for executing rollover</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesRolloverAsync(string alias, string new_index, byte[] body, Func<IndicesRolloverParameters, IndicesRolloverParameters> options = null)
        {
            var uri = string.Format("/{0}/_rollover/{1}", alias, new_index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesRolloverParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-rollover-index.html"/></summary>
        ///<param name="alias">The name of the alias to rollover</param>
        ///<param name="new_index">The name of the rollover index</param>
        ///<param name="body">The conditions that needs to be met for executing rollover</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage IndicesRolloverString(string alias, string new_index, string body, Func<IndicesRolloverParameters, IndicesRolloverParameters> options = null)
        {
            var uri = string.Format("/{0}/_rollover/{1}", alias, new_index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesRolloverParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/indices-rollover-index.html"/></summary>
        ///<param name="alias">The name of the alias to rollover</param>
        ///<param name="new_index">The name of the rollover index</param>
        ///<param name="body">The conditions that needs to be met for executing rollover</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> IndicesRolloverStringAsync(string alias, string new_index, string body, Func<IndicesRolloverParameters, IndicesRolloverParameters> options = null)
        {
            var uri = string.Format("/{0}/_rollover/{1}", alias, new_index);
            if (options != null)
            {
                uri = options.Invoke(new IndicesRolloverParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}