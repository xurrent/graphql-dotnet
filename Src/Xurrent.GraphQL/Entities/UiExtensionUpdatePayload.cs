using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/uiextensionupdatepayload/">UiExtensionUpdatePayload</see> object.
    /// </summary>
    public class UiExtensionUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("uiExtension"), XurrentField(IsDefaultQueryProperty = true)]
        public UiExtension? UiExtension { get; internal set; }
    }
}
