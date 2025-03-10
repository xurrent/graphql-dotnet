﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/input_object/scrumworkspacecreateinput/">ScrumWorkspaceCreateInput</see> object.
    /// </summary>
    public class ScrumWorkspaceCreateInput : PropertyChangeSet
    {
        private string agileBoardId;
        private string? clientMutationId;
        private string? description;
        private List<AttachmentInput>? descriptionAttachments;
        private bool? disabled;
        private string name;
        private string? pictureUri;
        private string productBacklogId;
        private string? source;
        private string? sourceID;
        private long sprintLength;
        private string teamId;

        /// <summary>
        /// Identifier of the agile board used to track the progress of this workspace's active sprint.
        /// </summary>
        [JsonProperty("agileBoardId"), XurrentField(IsRequiredForMutation = true)]
        public string AgileBoardId
        {
            get => agileBoardId;
            set => agileBoardId = Set("agileBoardId", value);
        }

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
        /// Additional information regarding the scrum workspace.
        /// </summary>
        [JsonProperty("description")]
        public string? Description
        {
            get => description;
            set => description = Set("description", value);
        }

        /// <summary>
        /// The attachments used in the <c>description</c> field.
        /// </summary>
        [JsonProperty("descriptionAttachments")]
        public List<AttachmentInput>? DescriptionAttachments
        {
            get => descriptionAttachments;
            set => descriptionAttachments = Set("descriptionAttachments", value);
        }

        /// <summary>
        /// Whether the scrum workspace is in use.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// Name of the scrum workspace.
        /// </summary>
        [JsonProperty("name"), XurrentField(IsRequiredForMutation = true)]
        public string Name
        {
            get => name;
            set => name = Set("name", value);
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
        /// Identifier of the product backlog used when planning sprints.
        /// </summary>
        [JsonProperty("productBacklogId"), XurrentField(IsRequiredForMutation = true)]
        public string ProductBacklogId
        {
            get => productBacklogId;
            set => productBacklogId = Set("productBacklogId", value);
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
        /// Standard length in weeks of new sprints planned in this scrum workspace.
        /// </summary>
        [JsonProperty("sprintLength"), XurrentField(IsRequiredForMutation = true)]
        public long SprintLength
        {
            get => sprintLength;
            set => sprintLength = Set("sprintLength", value);
        }

        /// <summary>
        /// Identifier of the team planning their work using this scrum workspace.
        /// </summary>
        [JsonProperty("teamId"), XurrentField(IsRequiredForMutation = true)]
        public string TeamId
        {
            get => teamId;
            set => teamId = Set("teamId", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrumWorkspaceCreateInput"/> class without providing the required values.
        /// </summary>
        public ScrumWorkspaceCreateInput()
        {
            agileBoardId = string.Empty;
            name = string.Empty;
            productBacklogId = string.Empty;
            sprintLength = default(long);
            teamId = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrumWorkspaceCreateInput"/> class.
        /// </summary>
        /// <param name="agileBoardId">Identifier of the agile board used to track the progress of this workspace's active sprint.</param>
        /// <param name="name">Name of the scrum workspace.</param>
        /// <param name="productBacklogId">Identifier of the product backlog used when planning sprints.</param>
        /// <param name="sprintLength">Standard length in weeks of new sprints planned in this scrum workspace.</param>
        /// <param name="teamId">Identifier of the team planning their work using this scrum workspace.</param>
        public ScrumWorkspaceCreateInput(string agileBoardId, string name, string productBacklogId, long sprintLength, string teamId)
        {
            this.agileBoardId = Set("agileBoardId", agileBoardId);
            this.name = Set("name", name);
            this.productBacklogId = Set("productBacklogId", productBacklogId);
            this.sprintLength = Set("sprintLength", sprintLength);
            this.teamId = Set("teamId", teamId);
        }
    }
}
