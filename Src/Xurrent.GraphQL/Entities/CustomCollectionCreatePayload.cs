using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/customcollectioncreatepayload/">CustomCollectionCreatePayload</see> object.
    /// </summary>
    public class CustomCollectionCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("customCollection"), XurrentField(IsDefaultQueryProperty = true)]
        public CustomCollection? CustomCollection { get; internal set; }
    }
}
