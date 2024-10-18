using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/servicecategorycreatepayload/">ServiceCategoryCreatePayload</see> object.
    /// </summary>
    public class ServiceCategoryCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("serviceCategory"), XurrentField(IsDefaultQueryProperty = true)]
        public ServiceCategory? ServiceCategory { get; internal set; }
    }
}
