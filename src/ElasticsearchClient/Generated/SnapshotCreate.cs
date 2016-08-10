//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Elasticsearch.Client
{
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    
    
    public partial class ElasticsearchClient
    {
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/modules-snapshots.html"/></summary>
        /// <param name="snapshot">A snapshot name</param>
        /// <param name="repository">A repository name</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage SnapshotCreatePut(string snapshot, string repository, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            string uri = string.Format("/_0/{1}/{0}", snapshot, repository);
            if ((options != null))
            {
                SnapshotCreateParameters parameters = options.Invoke(new SnapshotCreateParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("PUT", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/modules-snapshots.html"/></summary>
        /// <param name="snapshot">A snapshot name</param>
        /// <param name="repository">A repository name</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> SnapshotCreatePutAsync(string snapshot, string repository, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            string uri = string.Format("/_0/{1}/{0}", snapshot, repository);
            if ((options != null))
            {
                SnapshotCreateParameters parameters = options.Invoke(new SnapshotCreateParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("PUT", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/modules-snapshots.html"/></summary>
        /// <param name="snapshot">A snapshot name</param>
        /// <param name="repository">A repository name</param>
        /// <param name="body">The snapshot definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage SnapshotCreatePut(string snapshot, string repository, Stream body, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            string uri = string.Format("/_0/{1}/{0}", snapshot, repository);
            if ((options != null))
            {
                SnapshotCreateParameters parameters = options.Invoke(new SnapshotCreateParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/modules-snapshots.html"/></summary>
        /// <param name="snapshot">A snapshot name</param>
        /// <param name="repository">A repository name</param>
        /// <param name="body">The snapshot definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> SnapshotCreatePutAsync(string snapshot, string repository, Stream body, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            string uri = string.Format("/_0/{1}/{0}", snapshot, repository);
            if ((options != null))
            {
                SnapshotCreateParameters parameters = options.Invoke(new SnapshotCreateParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/modules-snapshots.html"/></summary>
        /// <param name="snapshot">A snapshot name</param>
        /// <param name="repository">A repository name</param>
        /// <param name="body">The snapshot definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage SnapshotCreatePut(string snapshot, string repository, Byte[] body, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            string uri = string.Format("/_0/{1}/{0}", snapshot, repository);
            if ((options != null))
            {
                SnapshotCreateParameters parameters = options.Invoke(new SnapshotCreateParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/modules-snapshots.html"/></summary>
        /// <param name="snapshot">A snapshot name</param>
        /// <param name="repository">A repository name</param>
        /// <param name="body">The snapshot definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> SnapshotCreatePutAsync(string snapshot, string repository, Byte[] body, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            string uri = string.Format("/_0/{1}/{0}", snapshot, repository);
            if ((options != null))
            {
                SnapshotCreateParameters parameters = options.Invoke(new SnapshotCreateParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/modules-snapshots.html"/></summary>
        /// <param name="snapshot">A snapshot name</param>
        /// <param name="repository">A repository name</param>
        /// <param name="body">The snapshot definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage SnapshotCreatePutString(string snapshot, string repository, string body, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            string uri = string.Format("/_0/{1}/{0}", snapshot, repository);
            if ((options != null))
            {
                SnapshotCreateParameters parameters = options.Invoke(new SnapshotCreateParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/modules-snapshots.html"/></summary>
        /// <param name="snapshot">A snapshot name</param>
        /// <param name="repository">A repository name</param>
        /// <param name="body">The snapshot definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> SnapshotCreatePutStringAsync(string snapshot, string repository, string body, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            string uri = string.Format("/_0/{1}/{0}", snapshot, repository);
            if ((options != null))
            {
                SnapshotCreateParameters parameters = options.Invoke(new SnapshotCreateParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("PUT", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/modules-snapshots.html"/></summary>
        /// <param name="snapshot">A snapshot name</param>
        /// <param name="repository">A repository name</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage SnapshotCreatePost(string snapshot, string repository, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            string uri = string.Format("/_0/{1}/{0}", snapshot, repository);
            if ((options != null))
            {
                SnapshotCreateParameters parameters = options.Invoke(new SnapshotCreateParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/modules-snapshots.html"/></summary>
        /// <param name="snapshot">A snapshot name</param>
        /// <param name="repository">A repository name</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> SnapshotCreatePostAsync(string snapshot, string repository, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            string uri = string.Format("/_0/{1}/{0}", snapshot, repository);
            if ((options != null))
            {
                SnapshotCreateParameters parameters = options.Invoke(new SnapshotCreateParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/modules-snapshots.html"/></summary>
        /// <param name="snapshot">A snapshot name</param>
        /// <param name="repository">A repository name</param>
        /// <param name="body">The snapshot definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage SnapshotCreatePost(string snapshot, string repository, Stream body, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            string uri = string.Format("/_0/{1}/{0}", snapshot, repository);
            if ((options != null))
            {
                SnapshotCreateParameters parameters = options.Invoke(new SnapshotCreateParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/modules-snapshots.html"/></summary>
        /// <param name="snapshot">A snapshot name</param>
        /// <param name="repository">A repository name</param>
        /// <param name="body">The snapshot definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> SnapshotCreatePostAsync(string snapshot, string repository, Stream body, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            string uri = string.Format("/_0/{1}/{0}", snapshot, repository);
            if ((options != null))
            {
                SnapshotCreateParameters parameters = options.Invoke(new SnapshotCreateParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/modules-snapshots.html"/></summary>
        /// <param name="snapshot">A snapshot name</param>
        /// <param name="repository">A repository name</param>
        /// <param name="body">The snapshot definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage SnapshotCreatePost(string snapshot, string repository, Byte[] body, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            string uri = string.Format("/_0/{1}/{0}", snapshot, repository);
            if ((options != null))
            {
                SnapshotCreateParameters parameters = options.Invoke(new SnapshotCreateParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/modules-snapshots.html"/></summary>
        /// <param name="snapshot">A snapshot name</param>
        /// <param name="repository">A repository name</param>
        /// <param name="body">The snapshot definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> SnapshotCreatePostAsync(string snapshot, string repository, Byte[] body, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            string uri = string.Format("/_0/{1}/{0}", snapshot, repository);
            if ((options != null))
            {
                SnapshotCreateParameters parameters = options.Invoke(new SnapshotCreateParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/modules-snapshots.html"/></summary>
        /// <param name="snapshot">A snapshot name</param>
        /// <param name="repository">A repository name</param>
        /// <param name="body">The snapshot definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual HttpResponseMessage SnapshotCreatePostString(string snapshot, string repository, string body, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            string uri = string.Format("/_0/{1}/{0}", snapshot, repository);
            if ((options != null))
            {
                SnapshotCreateParameters parameters = options.Invoke(new SnapshotCreateParameters());
                uri = parameters.GetUri(uri);
            }
            return mConnection.Execute("POST", uri, body);
        }
        
        /// <summary><see href="http://www.elastic.co/guide/en/elasticsearch/reference/2.3/modules-snapshots.html"/></summary>
        /// <param name="snapshot">A snapshot name</param>
        /// <param name="repository">A repository name</param>
        /// <param name="body">The snapshot definition</param>
        /// <param name="options">The function to set optional url parameters.</param>
        public virtual async Task<HttpResponseMessage> SnapshotCreatePostStringAsync(string snapshot, string repository, string body, Func<SnapshotCreateParameters, SnapshotCreateParameters> options = null)
        {
            string uri = string.Format("/_0/{1}/{0}", snapshot, repository);
            if ((options != null))
            {
                SnapshotCreateParameters parameters = options.Invoke(new SnapshotCreateParameters());
                uri = parameters.GetUri(uri);
            }
            return await mConnection.ExecuteAsync("POST", uri, body);
        }
    }
}
