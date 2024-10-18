using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/outofofficeperiodcreatepayload/">OutOfOfficePeriodCreatePayload</see> object.
    /// </summary>
    public class OutOfOfficePeriodCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("outOfOfficePeriod"), XurrentField(IsDefaultQueryProperty = true)]
        public OutOfOfficePeriod? OutOfOfficePeriod { get; internal set; }
    }
}
