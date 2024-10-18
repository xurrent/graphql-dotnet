using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/scrumworkspaceupdatepayload/">ScrumWorkspaceUpdatePayload</see> object.
    /// </summary>
    public class ScrumWorkspaceUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("scrumWorkspace"), XurrentField(IsDefaultQueryProperty = true)]
        public ScrumWorkspace? ScrumWorkspace { get; internal set; }
    }
}
