﻿using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/shorturlupdatepayload/">ShortUrlUpdatePayload</see> object.
    /// </summary>
    public class ShortUrlUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("shortUrl"), XurrentField(IsDefaultQueryProperty = true)]
        public ShortUrl? ShortUrl { get; internal set; }
    }
}