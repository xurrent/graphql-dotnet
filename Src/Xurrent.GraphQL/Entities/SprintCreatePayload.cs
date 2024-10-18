using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/sprintcreatepayload/">SprintCreatePayload</see> object.
    /// </summary>
    public class SprintCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("sprint"), XurrentField(IsDefaultQueryProperty = true)]
        public Sprint? Sprint { get; internal set; }
    }
}
