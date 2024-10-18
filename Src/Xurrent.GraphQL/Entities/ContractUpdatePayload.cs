using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/contractupdatepayload/">ContractUpdatePayload</see> object.
    /// </summary>
    public class ContractUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("contract"), XurrentField(IsDefaultQueryProperty = true)]
        public Contract? Contract { get; internal set; }
    }
}
