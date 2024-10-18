using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/surveyresponsecreatepayload/">SurveyResponseCreatePayload</see> object.
    /// </summary>
    public class SurveyResponseCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("surveyResponse"), XurrentField(IsDefaultQueryProperty = true)]
        public SurveyResponse? SurveyResponse { get; internal set; }
    }
}
