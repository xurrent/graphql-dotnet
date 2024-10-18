using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/appofferingautomationruleupdatepayload/">AppOfferingAutomationRuleUpdatePayload</see> object.
    /// </summary>
    public class AppOfferingAutomationRuleUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("appOfferingAutomationRule"), XurrentField(IsDefaultQueryProperty = true)]
        public AppOfferingAutomationRule? AppOfferingAutomationRule { get; internal set; }
    }
}
