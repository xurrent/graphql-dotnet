using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/timesheetsettingupdatepayload/">TimesheetSettingUpdatePayload</see> object.
    /// </summary>
    public class TimesheetSettingUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("timesheetSetting"), XurrentField(IsDefaultQueryProperty = true)]
        public TimesheetSetting? TimesheetSetting { get; internal set; }
    }
}
