using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/input_object/discoveredcirelationinput/">DiscoveredCiRelationInput</see> object.
    /// </summary>
    public class DiscoveredCiRelationInput : PropertyChangeSet
    {
        private List<string>? childIds;

        /// <summary>
        /// Identifiers of other configuration items that are children of this item.
        /// </summary>
        [JsonProperty("childIds")]
        public List<string>? ChildIds
        {
            get => childIds;
            set => childIds = Set("childIds", value);
        }
    }
}
