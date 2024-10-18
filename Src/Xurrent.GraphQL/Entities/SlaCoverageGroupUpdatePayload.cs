using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/slacoveragegroupupdatepayload/">SlaCoverageGroupUpdatePayload</see> object.
    /// </summary>
    public class SlaCoverageGroupUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("slaCoverageGroup"), XurrentField(IsDefaultQueryProperty = true)]
        public SlaCoverageGroup? SlaCoverageGroup { get; internal set; }
    }
}
