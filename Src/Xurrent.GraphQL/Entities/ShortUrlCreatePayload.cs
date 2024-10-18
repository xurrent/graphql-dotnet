using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/shorturlcreatepayload/">ShortUrlCreatePayload</see> object.
    /// </summary>
    public class ShortUrlCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("shortUrl"), XurrentField(IsDefaultQueryProperty = true)]
        public ShortUrl? ShortUrl { get; internal set; }
    }
}
