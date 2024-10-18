using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/productcreatepayload/">ProductCreatePayload</see> object.
    /// </summary>
    public class ProductCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("product"), XurrentField(IsDefaultQueryProperty = true)]
        public Product? Product { get; internal set; }
    }
}
