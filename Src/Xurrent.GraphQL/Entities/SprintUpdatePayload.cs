using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/sprintupdatepayload/">SprintUpdatePayload</see> object.
    /// </summary>
    public class SprintUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("sprint"), XurrentField(IsDefaultQueryProperty = true)]
        public Sprint? Sprint { get; internal set; }
    }
}
