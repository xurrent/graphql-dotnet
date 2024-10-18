using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/surveyresponse/">SurveyResponse</see> object.
    /// </summary>
    public class SurveyResponse : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account")]
        public Account? Account { get; internal set; }

        [JsonProperty("answers")]
        internal NodeCollection<SurveyAnswer>? AnswersCollection { get; set; }

        /// <summary>
        /// Answers of this survey response.
        /// </summary>
        public DataList<SurveyAnswer>? Answers
        {
            get => AnswersCollection?.Data;
        }

        /// <summary>
        /// Whether the respondent completed the survey.
        /// </summary>
        [JsonProperty("completed")]
        public bool? Completed { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), XurrentField(IsDefaultQueryProperty = true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Rating calculated based on the answers.
        /// </summary>
        [JsonProperty("rating")]
        public string? Rating { get; internal set; }

        /// <summary>
        /// How the individual answers were combined to calculate the rating.
        /// </summary>
        [JsonProperty("ratingCalculation")]
        public JToken? RatingCalculation { get; internal set; }

        /// <summary>
        /// Time this response was submitted.
        /// </summary>
        [JsonProperty("respondedAt")]
        public DateTime? RespondedAt { get; internal set; }

        /// <summary>
        /// Service this response is about.
        /// </summary>
        [JsonProperty("service")]
        public Service? Service { get; internal set; }

        [JsonProperty("slas")]
        internal NodeCollection<ServiceLevelAgreement>? SlasCollection { get; set; }

        /// <summary>
        /// SLAs of this survey response.
        /// </summary>
        public DataList<ServiceLevelAgreement>? Slas
        {
            get => SlasCollection?.Data;
        }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source"), XurrentField(IsDefaultQueryProperty = true)]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID"), XurrentField(IsDefaultQueryProperty = true)]
        public string? SourceID { get; internal set; }

        /// <summary>
        /// Survey this response is for.
        /// </summary>
        [JsonProperty("survey")]
        public Survey? Survey { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), XurrentField(IsDefaultQueryProperty = true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(AnswersCollection?.GetQueryPageInfo("answers", depth + 1));
            retval.AddRange(SlasCollection?.GetQueryPageInfo("slas", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            Answers?.AddRange((data as SurveyResponse)?.Answers);
            Slas?.AddRange((data as SurveyResponse)?.Slas);
        }
    }
}
