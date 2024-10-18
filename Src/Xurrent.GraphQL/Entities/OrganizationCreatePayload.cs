using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/organizationcreatepayload/">OrganizationCreatePayload</see> object.
    /// </summary>
    public class OrganizationCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("organization"), XurrentField(IsDefaultQueryProperty = true)]
        public Organization? Organization { get; internal set; }
    }
}
