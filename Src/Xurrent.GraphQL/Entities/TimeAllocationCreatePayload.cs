using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/timeallocationcreatepayload/">TimeAllocationCreatePayload</see> object.
    /// </summary>
    public class TimeAllocationCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("timeAllocation"), XurrentField(IsDefaultQueryProperty = true)]
        public TimeAllocation? TimeAllocation { get; internal set; }
    }
}
