using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/notereactiondeletemutationpayload/">NoteReactionDeleteMutationPayload</see> object.
    /// </summary>
    public class NoteReactionDeleteMutationPayload : Payload
    {
        /// <summary>
        /// <c>true</c> when the record was successfully deleted, <c>false</c> otherwise.
        /// </summary>
        [JsonProperty("success"), XurrentField(IsDefaultQueryProperty = true)]
        public bool? Success { get; internal set; }
    }
}
