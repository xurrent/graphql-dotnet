﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/input_object/projectcategoryupdateinput/">ProjectCategoryUpdateInput</see> object.
    /// </summary>
    public class ProjectCategoryUpdateInput : PropertyChangeSet
    {
        private string? clientMutationId;
        private string? description;
        private bool? disabled;
        private string id;
        private string? information;
        private List<AttachmentInput>? informationAttachments;
        private string? name;
        private long? position;
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
        /// A very short description of the project category, for example "More than 200 workdays or $200K".
        /// </summary>
        [JsonProperty("description")]
        public string? Description
        {
            get => description;
            set => description = Set("description", value);
        }

        /// <summary>
        /// Whether the project category may not be related to any more projects.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// The node ID of the record to update.
        /// </summary>
        [JsonProperty("id"), XurrentField(IsRequiredForMutation = true)]
        public string ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// Any additional information about the project category that might prove useful, especially for project managers when they need to decide which project category to select for a project.
        /// </summary>
        [JsonProperty("information")]
        public string? Information
        {
            get => information;
            set => information = Set("information", value);
        }

        /// <summary>
        /// The attachments used in the <c>information</c> field.
        /// </summary>
        [JsonProperty("informationAttachments")]
        public List<AttachmentInput>? InformationAttachments
        {
            get => informationAttachments;
            set => informationAttachments = Set("informationAttachments", value);
        }

        /// <summary>
        /// The name of the project category. Ideally the name of a project category consists of a single word, such as "Large".
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// The position that the project category takes when it is displayed in a sorted list.
        /// </summary>
        [JsonProperty("position")]
        public long? Position
        {
            get => position;
            set => position = Set("position", value);
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
        /// Initializes a new instance of the <see cref="ProjectCategoryUpdateInput"/> class without providing the required values.
        /// </summary>
        public ProjectCategoryUpdateInput()
        {
            id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCategoryUpdateInput"/> class.
        /// </summary>
        /// <param name="id">The node ID of the record to update.</param>
        public ProjectCategoryUpdateInput(string id)
        {
            this.id = Set("id", id);
        }
    }
}
