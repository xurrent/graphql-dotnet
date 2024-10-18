using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/notecreatepayload/">NoteCreatePayload</see> object.
    /// </summary>
    public class NoteCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("note"), XurrentField(IsDefaultQueryProperty = true)]
        public Note? Note { get; internal set; }
    }
}
