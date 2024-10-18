using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/input_object/discovereditemmetadata/">DiscoveredItemMetaData</see> object.
    /// </summary>
    public class DiscoveredItemMetaData : PropertyChangeSet
    {
        private DiscoveredItemStrategy? strategy;

        /// <summary>
        /// How to handle records already present in Xurrent.
        /// </summary>
        [JsonProperty("strategy")]
        public DiscoveredItemStrategy? Strategy
        {
            get => strategy;
            set => strategy = Set("strategy", value);
        }
    }
}
