using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/holidaycreatepayload/">HolidayCreatePayload</see> object.
    /// </summary>
    public class HolidayCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("holiday"), XurrentField(IsDefaultQueryProperty = true)]
        public Holiday? Holiday { get; internal set; }
    }
}
