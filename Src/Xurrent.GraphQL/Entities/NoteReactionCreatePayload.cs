using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/notereactioncreatepayload/">NoteReactionCreatePayload</see> object.
    /// </summary>
    public class NoteReactionCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("noteReaction"), XurrentField(IsDefaultQueryProperty = true)]
        public NoteReaction? NoteReaction { get; internal set; }
    }
}
