﻿using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The OAuth 2.0 authentication response.
    /// </summary>
    internal sealed class AuthenticationOAuth2Reponse
    {
        /// <summary>
        /// The access token.
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; } = string.Empty;

        /// <summary>
        /// The token type.
        /// </summary>
        [JsonProperty("token_type")]
        public string TokenType { get; set; } = string.Empty;

        /// <summary>
        /// Expires in seconds.
        /// </summary>
        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; } = 0;
    }
}
