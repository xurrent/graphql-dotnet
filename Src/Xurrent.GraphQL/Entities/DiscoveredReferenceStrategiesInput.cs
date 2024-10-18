using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/input_object/discoveredreferencestrategiesinput/">DiscoveredReferenceStrategiesInput</see> object.
    /// </summary>
    public class DiscoveredReferenceStrategiesInput : PropertyChangeSet
    {
        private DiscoveredReferenceArrayStrategyInput? ciUserIds;

        /// <summary>
        /// How to process the <c>userIds</c> supplied for configuration items.
        /// </summary>
        [JsonProperty("ciUserIds")]
        public DiscoveredReferenceArrayStrategyInput? CiUserIds
        {
            get => ciUserIds;
            set => ciUserIds = Set("ciUserIds", value);
        }
    }
}
