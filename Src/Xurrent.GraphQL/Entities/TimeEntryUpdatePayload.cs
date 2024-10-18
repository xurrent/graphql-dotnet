using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/timeentryupdatepayload/">TimeEntryUpdatePayload</see> object.
    /// </summary>
    public class TimeEntryUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("timeEntry"), XurrentField(IsDefaultQueryProperty = true)]
        public TimeEntry? TimeEntry { get; internal set; }
    }
}
