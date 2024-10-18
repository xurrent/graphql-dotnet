using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/timeentrycreatepayload/">TimeEntryCreatePayload</see> object.
    /// </summary>
    public class TimeEntryCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("timeEntry"), XurrentField(IsDefaultQueryProperty = true)]
        public TimeEntry? TimeEntry { get; internal set; }
    }
}
