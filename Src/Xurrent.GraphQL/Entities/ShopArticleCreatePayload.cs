using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/shoparticlecreatepayload/">ShopArticleCreatePayload</see> object.
    /// </summary>
    public class ShopArticleCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("shopArticle"), XurrentField(IsDefaultQueryProperty = true)]
        public ShopArticle? ShopArticle { get; internal set; }
    }
}
