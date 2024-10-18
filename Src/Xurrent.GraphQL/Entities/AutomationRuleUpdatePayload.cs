using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/automationruleupdatepayload/">AutomationRuleUpdatePayload</see> object.
    /// </summary>
    public class AutomationRuleUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("automationRule"), XurrentField(IsDefaultQueryProperty = true)]
        public AutomationRule? AutomationRule { get; internal set; }
    }
}
