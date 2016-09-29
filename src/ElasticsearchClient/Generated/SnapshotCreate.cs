using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    public partial class ElasticsearchClient
    {
        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A snapshot name</param>
        ///<param name="repository">A repository name</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SnapshotCreatePut(string snapshot, string repository, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            var uri = $"{"/_0/{1}/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotCreateParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A snapshot name</param>
        ///<param name="repository">A repository name</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SnapshotCreatePutAsync(string snapshot, string repository, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            var uri = $"{"/_0/{1}/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotCreateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A snapshot name</param>
        ///<param name="repository">A repository name</param>
        ///<param name="body">The snapshot definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SnapshotCreatePut(string snapshot, string repository, Stream body, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            var uri = $"{"/_0/{1}/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotCreateParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A snapshot name</param>
        ///<param name="repository">A repository name</param>
        ///<param name="body">The snapshot definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SnapshotCreatePutAsync(string snapshot, string repository, Stream body, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            var uri = $"{"/_0/{1}/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotCreateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A snapshot name</param>
        ///<param name="repository">A repository name</param>
        ///<param name="body">The snapshot definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SnapshotCreatePut(string snapshot, string repository, byte[] body, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            var uri = $"{"/_0/{1}/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotCreateParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A snapshot name</param>
        ///<param name="repository">A repository name</param>
        ///<param name="body">The snapshot definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SnapshotCreatePutAsync(string snapshot, string repository, byte[] body, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            var uri = $"{"/_0/{1}/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotCreateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A snapshot name</param>
        ///<param name="repository">A repository name</param>
        ///<param name="body">The snapshot definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SnapshotCreatePutString(string snapshot, string repository, string body, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            var uri = $"{"/_0/{1}/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotCreateParameters()).GetUri(uri);
            }

            return mConnection.Execute("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A snapshot name</param>
        ///<param name="repository">A repository name</param>
        ///<param name="body">The snapshot definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SnapshotCreatePutStringAsync(string snapshot, string repository, string body, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            var uri = $"{"/_0/{1}/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotCreateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("PUT", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A snapshot name</param>
        ///<param name="repository">A repository name</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SnapshotCreatePost(string snapshot, string repository, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            var uri = $"{"/_0/{1}/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotCreateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A snapshot name</param>
        ///<param name="repository">A repository name</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SnapshotCreatePostAsync(string snapshot, string repository, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            var uri = $"{"/_0/{1}/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotCreateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A snapshot name</param>
        ///<param name="repository">A repository name</param>
        ///<param name="body">The snapshot definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SnapshotCreatePost(string snapshot, string repository, Stream body, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            var uri = $"{"/_0/{1}/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotCreateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A snapshot name</param>
        ///<param name="repository">A repository name</param>
        ///<param name="body">The snapshot definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SnapshotCreatePostAsync(string snapshot, string repository, Stream body, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            var uri = $"{"/_0/{1}/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotCreateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A snapshot name</param>
        ///<param name="repository">A repository name</param>
        ///<param name="body">The snapshot definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SnapshotCreatePost(string snapshot, string repository, byte[] body, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            var uri = $"{"/_0/{1}/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotCreateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A snapshot name</param>
        ///<param name="repository">A repository name</param>
        ///<param name="body">The snapshot definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SnapshotCreatePostAsync(string snapshot, string repository, byte[] body, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            var uri = $"{"/_0/{1}/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotCreateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A snapshot name</param>
        ///<param name="repository">A repository name</param>
        ///<param name="body">The snapshot definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public HttpResponseMessage SnapshotCreatePostString(string snapshot, string repository, string body, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            var uri = $"{"/_0/{1}/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotCreateParameters()).GetUri(uri);
            }

            return mConnection.Execute("POST", uri, body);
        }

        ///<summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html"/></summary>
        ///<param name="snapshot">A snapshot name</param>
        ///<param name="repository">A repository name</param>
        ///<param name="body">The snapshot definition</param>
        ///<param name="options">The function to set optional url parameters.</param>
        public async Task<HttpResponseMessage> SnapshotCreatePostStringAsync(string snapshot, string repository, string body, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            var uri = $"{"/_0/{1}/{0}"}";
            if (options != null)
            {
                uri = options.Invoke(new SnapshotCreateParameters()).GetUri(uri);
            }

            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}