using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/modules-snapshots.html"/></summary>
        ///<param name="repository">A repository name</param>
        ///<param name="body">The repository definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SnapshotCreateRepositoryPut(string repository, Stream body, Func<SnapshotCreateRepositoryParameters, SnapshotCreateRepositoryParameters> options = null)
        {
            var uri = string.Format("/_snapshot/{0}", repository);
            if (options != null)
            {
                uri = options.Invoke(new SnapshotCreateRepositoryParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/modules-snapshots.html"/></summary>
        ///<param name="repository">A repository name</param>
        ///<param name="body">The repository definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SnapshotCreateRepositoryPutAsync(string repository, Stream body, Func<SnapshotCreateRepositoryParameters, SnapshotCreateRepositoryParameters> options = null)
        {
            var uri = string.Format("/_snapshot/{0}", repository);
            if (options != null)
            {
                uri = options.Invoke(new SnapshotCreateRepositoryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/modules-snapshots.html"/></summary>
        ///<param name="repository">A repository name</param>
        ///<param name="body">The repository definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SnapshotCreateRepositoryPut(string repository, byte[] body, Func<SnapshotCreateRepositoryParameters, SnapshotCreateRepositoryParameters> options = null)
        {
            var uri = string.Format("/_snapshot/{0}", repository);
            if (options != null)
            {
                uri = options.Invoke(new SnapshotCreateRepositoryParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/modules-snapshots.html"/></summary>
        ///<param name="repository">A repository name</param>
        ///<param name="body">The repository definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SnapshotCreateRepositoryPutAsync(string repository, byte[] body, Func<SnapshotCreateRepositoryParameters, SnapshotCreateRepositoryParameters> options = null)
        {
            var uri = string.Format("/_snapshot/{0}", repository);
            if (options != null)
            {
                uri = options.Invoke(new SnapshotCreateRepositoryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/modules-snapshots.html"/></summary>
        ///<param name="repository">A repository name</param>
        ///<param name="body">The repository definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SnapshotCreateRepositoryPutString(string repository, string body, Func<SnapshotCreateRepositoryParameters, SnapshotCreateRepositoryParameters> options = null)
        {
            var uri = string.Format("/_snapshot/{0}", repository);
            if (options != null)
            {
                uri = options.Invoke(new SnapshotCreateRepositoryParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/modules-snapshots.html"/></summary>
        ///<param name="repository">A repository name</param>
        ///<param name="body">The repository definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SnapshotCreateRepositoryPutStringAsync(string repository, string body, Func<SnapshotCreateRepositoryParameters, SnapshotCreateRepositoryParameters> options = null)
        {
            var uri = string.Format("/_snapshot/{0}", repository);
            if (options != null)
            {
                uri = options.Invoke(new SnapshotCreateRepositoryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/modules-snapshots.html"/></summary>
        ///<param name="repository">A repository name</param>
        ///<param name="body">The repository definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SnapshotCreateRepositoryPost(string repository, Stream body, Func<SnapshotCreateRepositoryParameters, SnapshotCreateRepositoryParameters> options = null)
        {
            var uri = string.Format("/_snapshot/{0}", repository);
            if (options != null)
            {
                uri = options.Invoke(new SnapshotCreateRepositoryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/modules-snapshots.html"/></summary>
        ///<param name="repository">A repository name</param>
        ///<param name="body">The repository definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SnapshotCreateRepositoryPostAsync(string repository, Stream body, Func<SnapshotCreateRepositoryParameters, SnapshotCreateRepositoryParameters> options = null)
        {
            var uri = string.Format("/_snapshot/{0}", repository);
            if (options != null)
            {
                uri = options.Invoke(new SnapshotCreateRepositoryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/modules-snapshots.html"/></summary>
        ///<param name="repository">A repository name</param>
        ///<param name="body">The repository definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SnapshotCreateRepositoryPost(string repository, byte[] body, Func<SnapshotCreateRepositoryParameters, SnapshotCreateRepositoryParameters> options = null)
        {
            var uri = string.Format("/_snapshot/{0}", repository);
            if (options != null)
            {
                uri = options.Invoke(new SnapshotCreateRepositoryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/modules-snapshots.html"/></summary>
        ///<param name="repository">A repository name</param>
        ///<param name="body">The repository definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SnapshotCreateRepositoryPostAsync(string repository, byte[] body, Func<SnapshotCreateRepositoryParameters, SnapshotCreateRepositoryParameters> options = null)
        {
            var uri = string.Format("/_snapshot/{0}", repository);
            if (options != null)
            {
                uri = options.Invoke(new SnapshotCreateRepositoryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/modules-snapshots.html"/></summary>
        ///<param name="repository">A repository name</param>
        ///<param name="body">The repository definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SnapshotCreateRepositoryPostString(string repository, string body, Func<SnapshotCreateRepositoryParameters, SnapshotCreateRepositoryParameters> options = null)
        {
            var uri = string.Format("/_snapshot/{0}", repository);
            if (options != null)
            {
                uri = options.Invoke(new SnapshotCreateRepositoryParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="https://www.elastic.co/guide/en/elasticsearch/reference/5.x/modules-snapshots.html"/></summary>
        ///<param name="repository">A repository name</param>
        ///<param name="body">The repository definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SnapshotCreateRepositoryPostStringAsync(string repository, string body, Func<SnapshotCreateRepositoryParameters, SnapshotCreateRepositoryParameters> options = null)
        {
            var uri = string.Format("/_snapshot/{0}", repository);
            if (options != null)
            {
                uri = options.Invoke(new SnapshotCreateRepositoryParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}