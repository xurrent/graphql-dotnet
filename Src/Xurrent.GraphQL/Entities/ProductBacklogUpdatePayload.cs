using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/productbacklogupdatepayload/">ProductBacklogUpdatePayload</see> object.
    /// </summary>
    public class ProductBacklogUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("productBacklog"), XurrentField(IsDefaultQueryProperty = true)]
        public ProductBacklog? ProductBacklog { get; internal set; }
    }
}
