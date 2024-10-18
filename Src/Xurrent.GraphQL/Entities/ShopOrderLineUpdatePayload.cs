using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/shoporderlineupdatepayload/">ShopOrderLineUpdatePayload</see> object.
    /// </summary>
    public class ShopOrderLineUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("shopOrderLine"), XurrentField(IsDefaultQueryProperty = true)]
        public ShopOrderLine? ShopOrderLine { get; internal set; }
    }
}
