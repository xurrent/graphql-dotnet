using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/translationcreatepayload/">TranslationCreatePayload</see> object.
    /// </summary>
    public class TranslationCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("translation"), XurrentField(IsDefaultQueryProperty = true)]
        public Translation? Translation { get; internal set; }
    }
}
