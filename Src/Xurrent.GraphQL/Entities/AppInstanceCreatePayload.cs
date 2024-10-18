﻿using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/appinstancecreatepayload/">AppInstanceCreatePayload</see> object.
    /// </summary>
    public class AppInstanceCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("appInstance"), XurrentField(IsDefaultQueryProperty = true)]
        public AppInstance? AppInstance { get; internal set; }
    }
}
