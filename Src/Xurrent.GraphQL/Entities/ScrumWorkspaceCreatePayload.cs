using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/scrumworkspacecreatepayload/">ScrumWorkspaceCreatePayload</see> object.
    /// </summary>
    public class ScrumWorkspaceCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("scrumWorkspace"), XurrentField(IsDefaultQueryProperty = true)]
        public ScrumWorkspace? ScrumWorkspace { get; internal set; }
    }
}
