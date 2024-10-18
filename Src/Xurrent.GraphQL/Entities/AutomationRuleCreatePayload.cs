using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/automationrulecreatepayload/">AutomationRuleCreatePayload</see> object.
    /// </summary>
    public class AutomationRuleCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("automationRule"), XurrentField(IsDefaultQueryProperty = true)]
        public AutomationRule? AutomationRule { get; internal set; }
    }
}
