using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Elasticsearch.Client
{
    /// <summary>
    /// Executes requests and handles retry logic if the server requests throttling.
    /// </summary>
    public class Dispatcher : IDispatcher
    {
        private const int TooManyRequests = 429;
        private readonly Random mRandom;
        private readonly int mMaxRetries;
        private readonly int mDelayBase;

        /// <summary>
        /// Create a new Dispatcher.
        /// </summary>
        /// <param name="maxRetries">The maximum retries when the server requests throttling.</param>
        /// <param name="delayBase">The starting delay in milliseconds.</param>
        public Dispatcher(int maxRetries = 5, int delayBase = 100)
        {
            if (maxRetries < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(maxRetries), maxRetries,
                    "Max retries must be greater than or equal to 0.");
            }
            if (delayBase <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(delayBase), delayBase,
                    "The base delay must be greater than 0.");
            }
            mRandom = new Random();
            mMaxRetries = maxRetries;
            mDelayBase = delayBase;
        }

        /// <summary>
        /// Send the request using the given client and return the response.
        /// If the response is 429 (TooManyRequests) then exponentially back off.
        /// </summary>
        /// <param name="client">The client to use to send the request.</param>
        /// <param name="httpMethod">The HTTP method to use for the request.</param>
        /// <param name="uri">The URI to use for the request.</param>
        /// <param name="content">The content (if any) to send with the request.</param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> ExecuteAsync(HttpClient client, string httpMethod, string uri,
            HttpContent content = null)
        {
            if(content != null)
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            }
            HttpResponseMessage response;
            int attempt = 0;            
            do
            {
                var message = new HttpRequestMessage(new HttpMethod(httpMethod), uri)
                {
                    Content = content
                };
                response = await client.SendAsync(message, CancellationToken.None).ConfigureAwait(false);
                if ((int) response.StatusCode != TooManyRequests)
                {
                    return response;
                }
                attempt++;
                var delay = mRandom.Next(2 ^ attempt*mDelayBase);
                await Task.Delay(delay).ConfigureAwait(false);
            } while (attempt <= mMaxRetries);
            return response;
        }
    }
}
