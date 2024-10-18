using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/servicecategoryupdatepayload/">ServiceCategoryUpdatePayload</see> object.
    /// </summary>
    public class ServiceCategoryUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("serviceCategory"), XurrentField(IsDefaultQueryProperty = true)]
        public ServiceCategory? ServiceCategory { get; internal set; }
    }
}
