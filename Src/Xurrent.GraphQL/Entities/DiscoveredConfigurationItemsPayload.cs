using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/discoveredconfigurationitemspayload/">DiscoveredConfigurationItemsPayload</see> object.
    /// </summary>
    public class DiscoveredConfigurationItemsPayload : Payload
    {
        /// <summary>
        /// Metadata about asynchronous query execution. The <c>asyncQuery { resultUrl }</c> contains an expiring link to the file with the full results.
        /// </summary>
        [JsonProperty("asyncQuery"), XurrentField(IsDefaultQueryProperty = true)]
        public AsyncQuery? AsyncQuery { get; internal set; }

        /// <summary>
        /// Configuration items will be <c>null</c> on initial submission. The <c>asyncQuery { resultUrl }</c> contains an expiring link to the file with the full results.
        /// </summary>
        [JsonProperty("configurationItems"), XurrentField(IsDefaultQueryProperty = true)]
        public List<ConfigurationItem>? ConfigurationItems { get; internal set; }
    }
}
