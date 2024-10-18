using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/customcollectionelementcreatepayload/">CustomCollectionElementCreatePayload</see> object.
    /// </summary>
    public class CustomCollectionElementCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("customCollectionElement"), XurrentField(IsDefaultQueryProperty = true)]
        public CustomCollectionElement? CustomCollectionElement { get; internal set; }
    }
}
