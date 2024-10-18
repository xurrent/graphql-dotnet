using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/knowledgearticleupdatepayload/">KnowledgeArticleUpdatePayload</see> object.
    /// </summary>
    public class KnowledgeArticleUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("knowledgeArticle"), XurrentField(IsDefaultQueryProperty = true)]
        public KnowledgeArticle? KnowledgeArticle { get; internal set; }
    }
}
