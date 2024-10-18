using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/customcollectionelementupdatepayload/">CustomCollectionElementUpdatePayload</see> object.
    /// </summary>
    public class CustomCollectionElementUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("customCollectionElement"), XurrentField(IsDefaultQueryProperty = true)]
        public CustomCollectionElement? CustomCollectionElement { get; internal set; }
    }
}
