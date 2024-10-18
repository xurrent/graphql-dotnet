using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/riskseverityupdatepayload/">RiskSeverityUpdatePayload</see> object.
    /// </summary>
    public class RiskSeverityUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("riskSeverity"), XurrentField(IsDefaultQueryProperty = true)]
        public RiskSeverity? RiskSeverity { get; internal set; }
    }
}
