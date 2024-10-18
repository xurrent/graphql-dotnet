using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/projectcategoryupdatepayload/">ProjectCategoryUpdatePayload</see> object.
    /// </summary>
    public class ProjectCategoryUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("projectCategory"), XurrentField(IsDefaultQueryProperty = true)]
        public ProjectCategory? ProjectCategory { get; internal set; }
    }
}
