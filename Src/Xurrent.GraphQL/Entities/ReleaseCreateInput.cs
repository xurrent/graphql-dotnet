﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/input_object/releasecreateinput/">ReleaseCreateInput</see> object.
    /// </summary>
    public class ReleaseCreateInput : PropertyChangeSet
    {
        private string? clientMutationId;
        private CustomFieldCollection? customFields;
        private List<AttachmentInput>? customFieldsAttachments;
        private string managerId;
        private string? note;
        private string? source;
        private string? sourceID;
        private string subject;
        private string? uiExtensionId;
        private List<string>? workflowIds;

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
        /// Values for custom fields to be used by the UI Extension that is linked to the record.
        /// </summary>
        [JsonProperty("customFields")]
        public CustomFieldCollection? CustomFields
        {
            get => customFields;
            set => customFields = Set("customFields", value);
        }

        /// <summary>
        /// The attachments used in the custom fields' values.
        /// </summary>
        [JsonProperty("customFieldsAttachments")]
        public List<AttachmentInput>? CustomFieldsAttachments
        {
            get => customFieldsAttachments;
            set => customFieldsAttachments = Set("customFieldsAttachments", value);
        }

        /// <summary>
        /// Identifier of the person who is responsible for coordinating the implementation of the release. The person must have the release Manager role.
        /// </summary>
        [JsonProperty("managerId"), XurrentField(IsRequiredForMutation = true)]
        public string ManagerId
        {
            get => managerId;
            set => managerId = Set("managerId", value);
        }

        /// <summary>
        /// High-level description of the result that should be accomplished by the implementation of the release's workflows. It is also used to add any information that could prove useful for anyone affected by the release.
        /// </summary>
        [JsonProperty("note")]
        public string? Note
        {
            get => note;
            set => note = Set("note", value);
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
        /// A short description of the objective of the release.
        /// </summary>
        [JsonProperty("subject"), XurrentField(IsRequiredForMutation = true)]
        public string Subject
        {
            get => subject;
            set => subject = Set("subject", value);
        }

        /// <summary>
        /// UI extension that is to be applied to the record.
        /// </summary>
        [JsonProperty("uiExtensionId")]
        public string? UiExtensionId
        {
            get => uiExtensionId;
            set => uiExtensionId = Set("uiExtensionId", value);
        }

        /// <summary>
        /// Identifiers of the workflows of the release.
        /// </summary>
        [JsonProperty("workflowIds")]
        public List<string>? WorkflowIds
        {
            get => workflowIds;
            set => workflowIds = Set("workflowIds", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseCreateInput"/> class without providing the required values.
        /// </summary>
        public ReleaseCreateInput()
        {
            managerId = string.Empty;
            subject = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseCreateInput"/> class.
        /// </summary>
        /// <param name="managerId">Identifier of the person who is responsible for coordinating the implementation of the release. The person must have the release Manager role.</param>
        /// <param name="subject">A short description of the objective of the release.</param>
        public ReleaseCreateInput(string managerId, string subject)
        {
            this.managerId = Set("managerId", managerId);
            this.subject = Set("subject", subject);
        }
    }
}
