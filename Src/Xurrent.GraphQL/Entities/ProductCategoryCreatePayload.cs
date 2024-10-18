using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/productcategorycreatepayload/">ProductCategoryCreatePayload</see> object.
    /// </summary>
    public class ProductCategoryCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("productCategory"), XurrentField(IsDefaultQueryProperty = true)]
        public ProductCategory? ProductCategory { get; internal set; }
    }
}
