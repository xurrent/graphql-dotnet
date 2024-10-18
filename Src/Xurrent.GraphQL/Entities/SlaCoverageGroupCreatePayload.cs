using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/slacoveragegroupcreatepayload/">SlaCoverageGroupCreatePayload</see> object.
    /// </summary>
    public class SlaCoverageGroupCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("slaCoverageGroup"), XurrentField(IsDefaultQueryProperty = true)]
        public SlaCoverageGroup? SlaCoverageGroup { get; internal set; }
    }
}
