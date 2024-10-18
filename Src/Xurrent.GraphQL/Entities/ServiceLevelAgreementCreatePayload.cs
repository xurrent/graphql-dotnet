using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/servicelevelagreementcreatepayload/">ServiceLevelAgreementCreatePayload</see> object.
    /// </summary>
    public class ServiceLevelAgreementCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("serviceLevelAgreement"), XurrentField(IsDefaultQueryProperty = true)]
        public ServiceLevelAgreement? ServiceLevelAgreement { get; internal set; }
    }
}
