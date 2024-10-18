using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/slanotificationschemecreatepayload/">SlaNotificationSchemeCreatePayload</see> object.
    /// </summary>
    public class SlaNotificationSchemeCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("slaNotificationScheme"), XurrentField(IsDefaultQueryProperty = true)]
        public SlaNotificationScheme? SlaNotificationScheme { get; internal set; }
    }
}
