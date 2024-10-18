using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/broadcastupdatepayload/">BroadcastUpdatePayload</see> object.
    /// </summary>
    public class BroadcastUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("broadcast"), XurrentField(IsDefaultQueryProperty = true)]
        public Broadcast? Broadcast { get; internal set; }
    }
}
