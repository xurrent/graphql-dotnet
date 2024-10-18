using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/uiextensioncreatepayload/">UiExtensionCreatePayload</see> object.
    /// </summary>
    public class UiExtensionCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("uiExtension"), XurrentField(IsDefaultQueryProperty = true)]
        public UiExtension? UiExtension { get; internal set; }
    }
}
