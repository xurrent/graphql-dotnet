﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/webhookpolicycreateresponse/">WebhookPolicyCreateResponse</see> object.
    /// </summary>
    public class WebhookPolicyCreateResponse : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Whether the webhook policy will be applied.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The algorithm to use for cryptographic signing of webhook messages.
        /// </summary>
        [JsonProperty("jwtAlg"), XurrentField(IsDefaultQueryProperty = true)]
        public WebhookPolicyJwtAlg? JwtAlg { get; internal set; }

        /// <summary>
        /// The audience claim identifies the recipients that the encrypted message is intended for.
        /// </summary>
        [JsonProperty("jwtAudience"), XurrentField(IsDefaultQueryProperty = true)]
        public string? JwtAudience { get; internal set; }

        /// <summary>
        /// The number of minutes within which the claim expires.
        /// </summary>
        [JsonProperty("jwtClaimExpiresIn"), XurrentField(IsDefaultQueryProperty = true)]
        public long? JwtClaimExpiresIn { get; internal set; }

        /// <summary>
        /// Unique identifier of this webhook policy
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; internal set; }

        /// <summary>
        /// Generated public key for this policy.
        /// </summary>
        [JsonProperty("publicKeyPem"), XurrentField(IsDefaultQueryProperty = true)]
        public string? PublicKeyPem { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
