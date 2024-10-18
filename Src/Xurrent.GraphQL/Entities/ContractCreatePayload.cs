using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/contractcreatepayload/">ContractCreatePayload</see> object.
    /// </summary>
    public class ContractCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("contract"), XurrentField(IsDefaultQueryProperty = true)]
        public Contract? Contract { get; internal set; }
    }
}
