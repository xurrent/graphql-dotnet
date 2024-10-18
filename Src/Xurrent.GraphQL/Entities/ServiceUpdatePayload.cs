﻿using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/serviceupdatepayload/">ServiceUpdatePayload</see> object.
    /// </summary>
    public class ServiceUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("service"), XurrentField(IsDefaultQueryProperty = true)]
        public Service? Service { get; internal set; }
    }
}
