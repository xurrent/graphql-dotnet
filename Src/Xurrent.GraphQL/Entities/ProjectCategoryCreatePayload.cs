using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/projectcategorycreatepayload/">ProjectCategoryCreatePayload</see> object.
    /// </summary>
    public class ProjectCategoryCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("projectCategory"), XurrentField(IsDefaultQueryProperty = true)]
        public ProjectCategory? ProjectCategory { get; internal set; }
    }
}
