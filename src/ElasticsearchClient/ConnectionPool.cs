using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    /// <summary>
    /// Retries requests if exceptions are thrown and maintains a list of known good and bad uris.
    /// </summary>
    public class ConnectionPool : IConnection
    {
        private readonly ConcurrentDictionary<string, byte> mFailedUris;
        private readonly ConcurrentDictionary<string, HttpClient> mClients;
        private readonly IDispatcher mDispatcher;

        public ConnectionPool(IEnumerable<string> uris, IDispatcher dispatcher = null)
        {
            mFailedUris = new ConcurrentDictionary<string, byte>();
            mClients = new ConcurrentDictionary<string, HttpClient>();
            mDispatcher = dispatcher ?? new Dispatcher();
            foreach (var uri in uris.Select(u => u.ToLower()).Distinct())
            {
                var client = new HttpClient {BaseAddress = new Uri(uri)};
                mClients.TryAdd(client.BaseAddress.ToString(), client);
            }
        }

        public HttpResponseMessage Execute(string httpMethod, string uri, HttpContent content = null)
        {
            Exception exception = null;
            foreach (var client in mClients.Values)
            {
                try
                {
                    return mDispatcher.Execute(client, httpMethod, uri, content);
                }
                catch (Exception e)
                {
                    exception = e;
                    RemoveClient(client);
                }                
            }
            foreach (var failedUri in mFailedUris.Keys)
            {
                var client = new HttpClient {BaseAddress = new Uri(failedUri)};
                try
                {
                    var resp = mDispatcher.Execute(client, httpMethod, uri, content);
                    AddClient(failedUri, client);
                    return resp;
                }
                catch (Exception e)
                {
                    exception = e;
                    client.Dispose();
                }                
            }
            throw exception ?? new InvalidOperationException("No clients available to service the request.");
        }

        public async Task<HttpResponseMessage> ExecuteAsync(string httpMethod, string uri, HttpContent content = null)
        {
            Exception exception = null;
            foreach (var client in mClients.Values)
            {
                try
                {
                    return await mDispatcher.ExecuteAsync(client, httpMethod, uri, content);
                }
                catch (Exception e)
                {
                    exception = e;
                    RemoveClient(client);
                }
            }
            foreach (var failedUri in mFailedUris.Keys)
            {
                var client = new HttpClient {BaseAddress = new Uri(failedUri)};
                try
                {
                    var resp = await mDispatcher.ExecuteAsync(client, httpMethod, uri, content);
                    AddClient(failedUri, client);
                    return resp;
                }
                catch (Exception e)
                {
                    exception = e;
                    client.Dispose();
                }
            }
            throw exception ?? new InvalidOperationException("No clients available to service the request.");
        }

        public void Dispose()
        {
            foreach (var httpClient in mClients.Values)
            {
                httpClient.Dispose();
            }
            mClients.Clear();
        }

        private void RemoveClient(HttpClient client)
        {
            var clientUri = client.BaseAddress.ToString();
            mFailedUris.TryAdd(clientUri, 0);
            HttpClient failed;
            if (mClients.TryRemove(clientUri, out failed))
            {
                failed.Dispose();
            }
            client.Dispose();
        }

        private void AddClient(string failedUri, HttpClient client)
        {
            mClients.TryAdd(failedUri, client);
            byte x;
            mFailedUris.TryRemove(failedUri, out x);
        }
    }
}
