using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/shoparticlecategorycreatepayload/">ShopArticleCategoryCreatePayload</see> object.
    /// </summary>
    public class ShopArticleCategoryCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("shopArticleCategory"), XurrentField(IsDefaultQueryProperty = true)]
        public ShopArticleCategory? ShopArticleCategory { get; internal set; }
    }
}
