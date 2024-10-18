using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/shoparticlecategoryupdatepayload/">ShopArticleCategoryUpdatePayload</see> object.
    /// </summary>
    public class ShopArticleCategoryUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("shopArticleCategory"), XurrentField(IsDefaultQueryProperty = true)]
        public ShopArticleCategory? ShopArticleCategory { get; internal set; }
    }
}
