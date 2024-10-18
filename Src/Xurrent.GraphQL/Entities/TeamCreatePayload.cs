using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/teamcreatepayload/">TeamCreatePayload</see> object.
    /// </summary>
    public class TeamCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("team"), XurrentField(IsDefaultQueryProperty = true)]
        public Team? Team { get; internal set; }
    }
}
