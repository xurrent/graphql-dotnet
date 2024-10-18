using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/configurationitemupdatepayload/">ConfigurationItemUpdatePayload</see> object.
    /// </summary>
    public class ConfigurationItemUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("configurationItem"), XurrentField(IsDefaultQueryProperty = true)]
        public ConfigurationItem? ConfigurationItem { get; internal set; }
    }
}
