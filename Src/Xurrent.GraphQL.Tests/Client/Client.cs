using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Xurrent.GraphQL.Tests
{
    internal sealed class Client
    {
        private static XurrentClient? client;
        private static readonly AuthenticationTokenCollection authenticationTokens = new();

        public static AuthenticationTokenCollection AuthenticationTokens 
        {
            get => authenticationTokens;
        }

        public static XurrentClient Get() 
        {
            if (client != null)
                return client;

            //get all information
            IConfigurationProvider secretProvider = new ConfigurationBuilder().AddUserSecrets<ConnectionSecret>().Build().Providers.First();
            if (!secretProvider.TryGet("Account", out string? account) 
                || !secretProvider.TryGet("Token", out string? token) 
                || !secretProvider.TryGet("ClientID", out string? clientID)
                || !secretProvider.TryGet("ClientSecret", out string? clientSecret))
            {
                Assert.Fail("Missing information in the user secret file");
                return null;
            }

            if (account == null || token == null || clientID == null || clientSecret == null)
            {
                Assert.Fail("Null value information in the user secret file");
                return null;
            }

            if (!string.IsNullOrEmpty(clientID) && !string.IsNullOrWhiteSpace(clientSecret))
            {
                authenticationTokens.Add(clientID, clientSecret);
                client = new(authenticationTokens, account, EnvironmentType.Demo, EnvironmentRegion.EU, 5)
                {
                    MaximumQueryDepthLevelConnections = 3
                };
            }
            else if (!string.IsNullOrEmpty(token))
            {
                authenticationTokens.Add(token);
                client = new(authenticationTokens, account, EnvironmentType.Demo, EnvironmentRegion.EU, 5)
                {
                    MaximumQueryDepthLevelConnections = 3
                };
            }
            else
            {
                Assert.Fail("Invalid information in the user secret file");
                return null;
            }
            return client;
        }
    }
}
