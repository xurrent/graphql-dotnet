using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/slanotificationschemeupdatepayload/">SlaNotificationSchemeUpdatePayload</see> object.
    /// </summary>
    public class SlaNotificationSchemeUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("slaNotificationScheme"), XurrentField(IsDefaultQueryProperty = true)]
        public SlaNotificationScheme? SlaNotificationScheme { get; internal set; }
    }
}
