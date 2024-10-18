using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/releasecreatepayload/">ReleaseCreatePayload</see> object.
    /// </summary>
    public class ReleaseCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("release"), XurrentField(IsDefaultQueryProperty = true)]
        public Release? Release { get; internal set; }
    }
}
