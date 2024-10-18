namespace Xurrent.GraphQL.Helpers
{
    /// <summary>
    /// Get the Xurrent GraphQL URL.
    /// </summary>
    internal static class EndpointUrlBuilder
    {
        /// <summary>
        /// Returns the base URL for a specific environment.
        /// </summary>
        /// <param name="environment">The environment type.</param>
        /// <param name="environmentRegion">The environment region.</param>
        /// <returns>The API endpoint URL for the specified environment.</returns>
        internal static string GetBaseUrl(EnvironmentRegion environmentRegion, EnvironmentType environment)
        {
            return environmentRegion switch
            {
                EnvironmentRegion.AU => environment switch
                {
                    EnvironmentType.Quality => "au.xurrent.qa",
                    EnvironmentType.Demo => "xurrent-demo.com",
                    _ => "au.xurrent.com",
                },
                EnvironmentRegion.UK => environment switch
                {
                    EnvironmentType.Quality => "uk.xurrent.qa",
                    EnvironmentType.Demo => "xurrent-demo.com",
                    _ => "uk.xurrent.com",
                },
                EnvironmentRegion.US => environment switch
                {
                    EnvironmentType.Quality => "us.xurrent.qa",
                    EnvironmentType.Demo => "xurrent-demo.com",
                    _ => "us.xurrent.com",
                },
                EnvironmentRegion.CH => environment switch
                {
                    EnvironmentType.Quality => "ch.xurrent.qa",
                    EnvironmentType.Demo => "xurrent-demo.com",
                    _ => "ch.xurrent.com",
                },
                _ => environment switch
                {
                    EnvironmentType.Quality => "xurrent.qa",
                    EnvironmentType.Demo => "xurrent-demo.com",
                    _ => "xurrent.com",
                },
            };
        }

        /// <summary>
        /// Returns the API endpoint URL for a custom domain.
        /// </summary>
        /// <param name="domainName">The custom domain name.</param>
        /// <returns>The API endpoint URL for the specified custom domain.</returns>
        internal static string Get(string domainName)
        {
            return $"https://graphql.{domainName}";
        }

        /// <summary>
        /// Returns the REST API endpoint for a custom domain.
        /// </summary>
        /// <param name="domainName">The custom domain name.</param>
        /// <returns>The REST API endpoint URL for the specified custom domain.</returns>
        internal static string GetRest(string domainName)
        {
            return $"https://api.{domainName}/v1";
        }

        /// <summary>
        /// Returns the OAuth 2.0 authentication URL for a custom domain.
        /// </summary>
        /// <param name="domainName">The custom domain name.</param>
        /// <returns>The OAuth 2.0 authentication URL for the specified custom domain.</returns>
        internal static string GetOAuth2(string domainName)
        {
            return $"https://oauth.{domainName}/token";
        }
    }
}
