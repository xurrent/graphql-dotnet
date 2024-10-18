using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/outofofficeperiodupdatepayload/">OutOfOfficePeriodUpdatePayload</see> object.
    /// </summary>
    public class OutOfOfficePeriodUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("outOfOfficePeriod"), XurrentField(IsDefaultQueryProperty = true)]
        public OutOfOfficePeriod? OutOfOfficePeriod { get; internal set; }
    }
}
