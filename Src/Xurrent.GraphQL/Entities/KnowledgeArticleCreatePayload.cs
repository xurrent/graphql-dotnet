using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/knowledgearticlecreatepayload/">KnowledgeArticleCreatePayload</see> object.
    /// </summary>
    public class KnowledgeArticleCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("knowledgeArticle"), XurrentField(IsDefaultQueryProperty = true)]
        public KnowledgeArticle? KnowledgeArticle { get; internal set; }
    }
}
