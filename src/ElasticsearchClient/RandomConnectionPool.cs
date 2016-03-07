using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace Elasticsearch.Client
{
    public class RandomConnectionPool : IConnectionPool, IDisposable
    {
        private readonly List<HttpClient> mServers;
        private readonly Random mRandom;

        public RandomConnectionPool(IEnumerable<string> servers)
            : this(servers.Select(s => new Uri(s)))
        {
        }

        public RandomConnectionPool(IEnumerable<Uri> uris)
        {
            mRandom = new Random();
            mServers = new List<HttpClient>(uris.Select(uri =>
                new HttpClient
                {
                    BaseAddress = uri
                }));
        }

        public HttpClient GetClient()
        {
            //todo could add Fisher-Yates Shuffle.
            return mServers[mRandom.Next(mServers.Count)];
        }

        public void Dispose()
        {
            foreach (var httpClient in mServers)
            {
                try
                {
                    httpClient.Dispose();
                }
                catch (Exception)
                {
                    //todo log?            
                }
            }
            mServers.Clear();
        }
    }
}
