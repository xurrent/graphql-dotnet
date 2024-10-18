using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/siteupdatepayload/">SiteUpdatePayload</see> object.
    /// </summary>
    public class SiteUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("site"), XurrentField(IsDefaultQueryProperty = true)]
        public Site? Site { get; internal set; }
    }
}
