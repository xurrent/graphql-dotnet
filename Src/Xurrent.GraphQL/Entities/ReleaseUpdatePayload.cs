using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/releaseupdatepayload/">ReleaseUpdatePayload</see> object.
    /// </summary>
    public class ReleaseUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("release"), XurrentField(IsDefaultQueryProperty = true)]
        public Release? Release { get; internal set; }
    }
}
