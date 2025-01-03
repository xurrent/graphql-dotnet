using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Xurrent.GraphQL.Helpers
{
    /// <summary>
    /// A singleton rate limiter that manages multiple tokens and their respective rate limits.
    /// </summary>
    internal sealed class RateLimiter
    {
        private readonly ConcurrentDictionary<int, Queue<DateTime>> tokenRequestQueues;
        private readonly int maxRequestsPerToken;
        private readonly TimeSpan window;

        private static Lazy<RateLimiter> instance = new(() => new RateLimiter(20, TimeSpan.FromSeconds(2)));
        private static readonly object syncRoot = new();

        /// <summary>
        /// Gets the singleton instance of the <see cref="RateLimiter"/> class.
        /// </summary>
        public static RateLimiter Instance => instance.Value;

        /// <summary>
        /// Configures the singleton instance with custom rate limits.
        /// </summary>
        /// <param name="maxRequestsPerToken">Maximum number of requests per token.</param>
        /// <param name="window">Time window for rate limiting.</param>
        public static void Configure(int maxRequestsPerToken, TimeSpan window)
        {
            if (maxRequestsPerToken <= 0)
                throw new ArgumentOutOfRangeException(nameof(maxRequestsPerToken), "Maximum requests must be greater than zero.");

            if (window <= TimeSpan.Zero)
                throw new ArgumentOutOfRangeException(nameof(window), "Time window must be greater than zero.");

            lock (syncRoot)
            {
                instance = new Lazy<RateLimiter>(() => new RateLimiter(maxRequestsPerToken, window));
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimiter"/> class.
        /// This constructor is private to enforce the singleton pattern.
        /// </summary>
        /// <param name="maxRequestsPerToken">The maximum number of requests allowed per token within the rate-limiting window.</param>
        /// <param name="window">The time window during which the rate limit applies.</param>
        /// <remarks>
        /// This constructor is invoked only internally by the <see cref="Lazy{T}"/> instance to initialize the singleton.
        /// </remarks>
        private RateLimiter(int maxRequestsPerToken, TimeSpan window)
        {
            this.maxRequestsPerToken = maxRequestsPerToken;
            this.window = window;
            tokenRequestQueues = new ConcurrentDictionary<int, Queue<DateTime>>();
        }

        /// <summary>
        /// Asynchronously waits for a permit for the given token.
        /// </summary>
        /// <param name="token">The authentication token to be rate-limited.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A task that completes when the rate limit allows the request to proceed.</returns>
        public async System.Threading.Tasks.Task WaitForToken(AuthenticationToken token, CancellationToken cancellationToken)
        {
            if (token == null)
                throw new ArgumentNullException(nameof(token), "The authentication token cannot be null.");

            Queue<DateTime> queue = tokenRequestQueues.GetOrAdd(token.Identifier, _ => new Queue<DateTime>());

            while (true)
            {
                DateTime now = DateTime.UtcNow;
                TimeSpan waitTime = TimeSpan.Zero;

                lock (queue)
                {
                    while (queue.Count > 0 && (now - queue.Peek()) > window)
                    {
                        queue.Dequeue();
                    }

                    if (queue.Count < maxRequestsPerToken)
                    {
                        queue.Enqueue(now);
                        return;
                    }
                    else
                    {
                        DateTime earliest = queue.Peek();
                        waitTime = earliest.Add(window) - now;
                    }
                }

                if (waitTime > TimeSpan.Zero)
                {
                    try
                    {
                        await System.Threading.Tasks.Task.Delay(waitTime, cancellationToken);
                    }
                    catch (TaskCanceledException)
                    {
                        throw new OperationCanceledException("The rate limiter wait was canceled.", cancellationToken);
                    }
                }
                else
                {
                    await System.Threading.Tasks.Task.Yield();
                }
            }
        }
    }
}
