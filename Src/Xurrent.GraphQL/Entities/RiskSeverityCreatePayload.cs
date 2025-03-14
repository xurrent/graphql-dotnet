﻿using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/riskseveritycreatepayload/">RiskSeverityCreatePayload</see> object.
    /// </summary>
    public class RiskSeverityCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("riskSeverity"), XurrentField(IsDefaultQueryProperty = true)]
        public RiskSeverity? RiskSeverity { get; internal set; }
    }
}
