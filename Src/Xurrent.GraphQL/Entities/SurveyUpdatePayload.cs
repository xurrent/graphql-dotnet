using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/surveyupdatepayload/">SurveyUpdatePayload</see> object.
    /// </summary>
    public class SurveyUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("survey"), XurrentField(IsDefaultQueryProperty = true)]
        public Survey? Survey { get; internal set; }
    }
}
