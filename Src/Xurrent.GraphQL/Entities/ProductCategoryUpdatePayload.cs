using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/productcategoryupdatepayload/">ProductCategoryUpdatePayload</see> object.
    /// </summary>
    public class ProductCategoryUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("productCategory"), XurrentField(IsDefaultQueryProperty = true)]
        public ProductCategory? ProductCategory { get; internal set; }
    }
}
