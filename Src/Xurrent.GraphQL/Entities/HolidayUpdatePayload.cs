using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/holidayupdatepayload/">HolidayUpdatePayload</see> object.
    /// </summary>
    public class HolidayUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("holiday"), XurrentField(IsDefaultQueryProperty = true)]
        public Holiday? Holiday { get; internal set; }
    }
}
