using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/configurationitemcreatepayload/">ConfigurationItemCreatePayload</see> object.
    /// </summary>
    public class ConfigurationItemCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("configurationItem"), XurrentField(IsDefaultQueryProperty = true)]
        public ConfigurationItem? ConfigurationItem { get; internal set; }
    }
}
