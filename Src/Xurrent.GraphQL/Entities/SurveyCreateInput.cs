﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/input_object/surveycreateinput/">SurveyCreateInput</see> object.
    /// </summary>
    public class SurveyCreateInput : PropertyChangeSet
    {
        private string? clientMutationId;
        private bool? disabled;
        private string name;
        private List<SurveyQuestionInput>? newQuestions;
        private string? pictureUri;
        private string? source;
        private string? sourceID;

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [JsonProperty("clientMutationId")]
        public string? ClientMutationId
        {
            get => clientMutationId;
            set => clientMutationId = Set("clientMutationId", value);
        }

        /// <summary>
        /// Whether the survey may not be used.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// Name of the survey.
        /// </summary>
        [JsonProperty("name"), XurrentField(IsRequiredForMutation = true)]
        public string Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// Questions of this survey.
        /// </summary>
        [JsonProperty("newQuestions")]
        public List<SurveyQuestionInput>? NewQuestions
        {
            get => newQuestions;
            set => newQuestions = Set("newQuestions", value);
        }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [JsonProperty("pictureUri")]
        public string? PictureUri
        {
            get => pictureUri;
            set => pictureUri = Set("pictureUri", value);
        }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source")]
        public string? Source
        {
            get => source;
            set => source = Set("source", value);
        }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID")]
        public string? SourceID
        {
            get => sourceID;
            set => sourceID = Set("sourceID", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyCreateInput"/> class without providing the required values.
        /// </summary>
        public SurveyCreateInput()
        {
            name = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyCreateInput"/> class.
        /// </summary>
        /// <param name="name">Name of the survey.</param>
        public SurveyCreateInput(string name)
        {
            this.name = Set("name", name);
        }
    }
}
