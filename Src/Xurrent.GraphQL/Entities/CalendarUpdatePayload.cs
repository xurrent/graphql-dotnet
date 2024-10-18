using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/calendarupdatepayload/">CalendarUpdatePayload</see> object.
    /// </summary>
    public class CalendarUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("calendar"), XurrentField(IsDefaultQueryProperty = true)]
        public Calendar? Calendar { get; internal set; }
    }
}
