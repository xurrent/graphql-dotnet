using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/sitecreatepayload/">SiteCreatePayload</see> object.
    /// </summary>
    public class SiteCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("site"), XurrentField(IsDefaultQueryProperty = true)]
        public Site? Site { get; internal set; }
    }
}
