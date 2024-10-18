using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/riskupdatepayload/">RiskUpdatePayload</see> object.
    /// </summary>
    public class RiskUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("risk"), XurrentField(IsDefaultQueryProperty = true)]
        public Risk? Risk { get; internal set; }
    }
}
