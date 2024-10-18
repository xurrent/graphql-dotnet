using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/productbacklogcreatepayload/">ProductBacklogCreatePayload</see> object.
    /// </summary>
    public class ProductBacklogCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("productBacklog"), XurrentField(IsDefaultQueryProperty = true)]
        public ProductBacklog? ProductBacklog { get; internal set; }
    }
}
