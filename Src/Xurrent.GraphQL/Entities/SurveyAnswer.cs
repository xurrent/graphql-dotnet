﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/surveyanswer/">SurveyAnswer</see> object.
    /// </summary>
    public class SurveyAnswer : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Question this answer is for.
        /// </summary>
        [JsonProperty("question"), XurrentField(IsDefaultQueryProperty = true)]
        public SurveyQuestion? Question { get; internal set; }

        /// <summary>
        /// Content of the answer for rating questions.
        /// </summary>
        [JsonProperty("rating"), XurrentField(IsDefaultQueryProperty = true)]
        public string? Rating { get; internal set; }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source")]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID")]
        public string? SourceID { get; internal set; }

        /// <summary>
        /// Survey response the answer is part of.
        /// </summary>
        [JsonProperty("surveyResponse")]
        public SurveyResponse? SurveyResponse { get; internal set; }

        /// <summary>
        /// Content of the answer for text questions.
        /// </summary>
        [JsonProperty("text")]
        public string? Text { get; internal set; }

        [JsonProperty("textAttachments")]
        internal NodeCollection<Attachment>? TextAttachmentsCollection { get; set; }

        /// <summary>
        /// Files and inline images linked to the Text field.
        /// </summary>
        public DataList<Attachment>? TextAttachments
        {
            get => TextAttachmentsCollection?.Data;
        }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(TextAttachmentsCollection?.GetQueryPageInfo("textAttachments", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            TextAttachments?.AddRange((data as SurveyAnswer)?.TextAttachments);
        }
    }
}
