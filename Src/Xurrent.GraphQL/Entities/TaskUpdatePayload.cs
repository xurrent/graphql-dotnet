using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/taskupdatepayload/">TaskUpdatePayload</see> object.
    /// </summary>
    public class TaskUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("task"), XurrentField(IsDefaultQueryProperty = true)]
        public Task? Task { get; internal set; }
    }
}
