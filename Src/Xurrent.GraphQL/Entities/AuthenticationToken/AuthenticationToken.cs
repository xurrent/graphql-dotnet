﻿using System;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// A Xurrent authentication token.
    /// </summary>
    public sealed class AuthenticationToken
    {
        private readonly int identifier;
        private readonly string clientID = string.Empty;
        private readonly string clientSecret = string.Empty;
        private string authenticationToken = string.Empty;
        private string tokenType = string.Empty;
        private int requestLimit = int.MaxValue;
        private int requestsRemaining = int.MaxValue;
        private DateTime requestLimitReset = DateTime.MinValue;
        private int costLimit = int.MaxValue;
        private int costLimitRemaining = int.MaxValue;
        private DateTime costLimitReset = DateTime.MinValue;
        private DateTime authenticationTokenExpires = DateTime.MinValue;

        /// <summary>
        /// Gets the unique identifier.
        /// </summary>
        internal int Identifier
        {
            get => identifier;
        }

        /// <summary>
        /// Get the Xurrent authentication token.
        /// </summary>
        internal string Token
        {
            get => authenticationToken;
            set => authenticationToken = value;
        }

        /// <summary>
        /// Get or set the token type.
        /// </summary>
        internal string TokenType
        {
            get => tokenType;
            set => tokenType = value;
        }

        /// <summary>
        /// Get the Xurrent OAuth 2.0 client grant client ID.
        /// </summary>
        public string ClientID
        {
            get => clientID;
        }

        /// <summary>
        /// Get the Xurrent OAuth 2.0 client grant client secret.
        /// </summary>
        internal string ClientSecret
        {
            get => clientSecret;
        }

        /// <summary>
        /// The maximum number of requests permitted to make in the current rate limit window.
        /// <br>The initial value is <see cref="int.MaxValue"/> because the actual value is still unknown.</br>
        /// </summary>
        public int RequestLimit
        {
            get => requestLimit;
            internal set => requestLimit = value;
        }

        /// <summary>
        /// The number of requests remaining in the current rate limit window.
        /// <br>The initial value is <see cref="int.MaxValue"/> because the actual value is still unknown.</br>
        /// </summary>
        public int RequestsRemaining
        {
            get => requestsRemaining;
            internal set => requestsRemaining = value;
        }

        /// <summary>
        /// The local time at which the current rate limit window resets.
        /// </summary>
        public DateTime RequestLimitReset
        {
            get => requestLimitReset;
            internal set => requestLimitReset = value;
        }

        /// <summary>
        /// The maximum number of points the client is permitted to consume in a 60-minutes window.
        /// </summary>
        public int CostLimit
        {
            get => costLimit;
            internal set => costLimit = value;
        }

        /// <summary>
        /// The number of points remaining in the current query cost rate limit window.
        /// </summary>
        public int CostLimitRemaining
        {
            get => costLimitRemaining;
            internal set => costLimitRemaining = value;
        }

        /// <summary>
        /// The local time at which the current query cost rate limit window resets.
        /// </summary>
        public DateTime CostLimitReset
        {
            get => costLimitReset;
            internal set => costLimitReset = value;
        }

        /// <summary>
        /// Create a new instance of an <see cref="AuthenticationToken"/> with <b>Personal Access Token</b> authentication.
        /// </summary>
        /// <param name="authenticationToken">The Xurrent authentication token.</param>
        public AuthenticationToken(string authenticationToken)
        {
            this.authenticationToken = authenticationToken;
            authenticationTokenExpires = DateTime.MaxValue;
            tokenType = "bearer";
            identifier = authenticationToken.GetHashCode();
        }

        /// <summary>
        /// Create a new instance of an <see cref="AuthenticationToken"/> with <b>OAuth 2.0 Client Credentials Grant</b> authentication.
        /// </summary>
        /// <param name="clientID">The Xurrent OAuth 2.0 client grant ID.</param>
        /// <param name="clientSecret">The Xurrent OAuth 2.0 client grant secret.</param>
        public AuthenticationToken(string clientID, string clientSecret)
        {
            this.clientID = clientID;
            this.clientSecret = clientSecret;
            authenticationTokenExpires = DateTime.MinValue;
            tokenType = string.Empty;
            identifier = (clientID + clientSecret).GetHashCode();
        }

        /// <summary>
        /// Updates the expiration date and time for the authentication token based on the specified duration in seconds.
        /// </summary>
        /// <param name="expiresInSeconds">The number of seconds from the current time after which the token will expire.</param>
        internal void UpdateTokenExpiration(int expiresInSeconds)
        {
            authenticationTokenExpires = DateTime.UtcNow.AddSeconds(expiresInSeconds);
        }

        /// <summary>
        /// Check if the current token is expired.
        /// </summary>
        /// <returns>True if the current token is expired or will expire in less than a minute; otherwise false.</returns>
        internal bool IsTokenExpired()
        {
            return authenticationTokenExpires < DateTime.UtcNow.AddMinutes(+1);
        }
    }
}
