using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/calendarcreatepayload/">CalendarCreatePayload</see> object.
    /// </summary>
    public class CalendarCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("calendar"), XurrentField(IsDefaultQueryProperty = true)]
        public Calendar? Calendar { get; internal set; }
    }
}
