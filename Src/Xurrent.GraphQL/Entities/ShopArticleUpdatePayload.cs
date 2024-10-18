using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/shoparticleupdatepayload/">ShopArticleUpdatePayload</see> object.
    /// </summary>
    public class ShopArticleUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("shopArticle"), XurrentField(IsDefaultQueryProperty = true)]
        public ShopArticle? ShopArticle { get; internal set; }
    }
}
