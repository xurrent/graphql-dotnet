using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/requesttemplatecreatepayload/">RequestTemplateCreatePayload</see> object.
    /// </summary>
    public class RequestTemplateCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("requestTemplate"), XurrentField(IsDefaultQueryProperty = true)]
        public RequestTemplate? RequestTemplate { get; internal set; }
    }
}
