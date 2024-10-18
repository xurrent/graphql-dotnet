using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/riskcreatepayload/">RiskCreatePayload</see> object.
    /// </summary>
    public class RiskCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("risk"), XurrentField(IsDefaultQueryProperty = true)]
        public Risk? Risk { get; internal set; }
    }
}
