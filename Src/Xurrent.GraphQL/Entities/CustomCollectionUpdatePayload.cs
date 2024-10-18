using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/customcollectionupdatepayload/">CustomCollectionUpdatePayload</see> object.
    /// </summary>
    public class CustomCollectionUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("customCollection"), XurrentField(IsDefaultQueryProperty = true)]
        public CustomCollection? CustomCollection { get; internal set; }
    }
}
