using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/projectcreatepayload/">ProjectCreatePayload</see> object.
    /// </summary>
    public class ProjectCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("project"), XurrentField(IsDefaultQueryProperty = true)]
        public Project? Project { get; internal set; }
    }
}
