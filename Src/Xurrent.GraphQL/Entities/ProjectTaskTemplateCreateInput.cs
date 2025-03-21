﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/input_object/projecttasktemplatecreateinput/">ProjectTaskTemplateCreateInput</see> object.
    /// </summary>
    public class ProjectTaskTemplateCreateInput : PropertyChangeSet
    {
        private string? agileBoardColumnId;
        private string? agileBoardId;
        private bool? assignToProjectManager;
        private bool? assignToRequester;
        private bool? assignToRequesterBusinessUnitManager;
        private bool? assignToRequesterManager;
        private bool? assignToServiceOwner;
        private ProjectTaskCategory category;
        private string? clientMutationId;
        private bool? copyNotesToProject;
        private bool? disabled;
        private string? effortClassId;
        private string? instructions;
        private List<ProjectTaskTemplateAssignmentInput>? newAssignments;
        private string? note;
        private string? pdfDesignId;
        private long plannedDuration;
        private long? plannedEffort;
        private long? plannedEffortProjectManager;
        private long? plannedEffortRequester;
        private long? plannedEffortRequesterBusinessUnitManager;
        private long? plannedEffortRequesterManager;
        private long? plannedEffortServiceOwner;
        private long? requiredApprovals;
        private string? skillPoolId;
        private string? source;
        private string? sourceID;
        private string subject;
        private string? supplierId;
        private string? teamId;
        private string? uiExtensionId;
        private bool? workHoursAre24x7;

        /// <summary>
        /// Identifier of the Agile board column the project task will be placed in.
        /// </summary>
        [JsonProperty("agileBoardColumnId")]
        public string? AgileBoardColumnId
        {
            get => agileBoardColumnId;
            set => agileBoardColumnId = Set("agileBoardColumnId", value);
        }

        /// <summary>
        /// Identifier of the Agile board the project task will be placed on.
        /// </summary>
        [JsonProperty("agileBoardId")]
        public string? AgileBoardId
        {
            get => agileBoardId;
            set => agileBoardId = Set("agileBoardId", value);
        }

        /// <summary>
        /// Whether the project manager is to be selected in the Assignees field of a new project task when it is being created based on the template.
        /// </summary>
        [JsonProperty("assignToProjectManager")]
        public bool? AssignToProjectManager
        {
            get => assignToProjectManager;
            set => assignToProjectManager = Set("assignToProjectManager", value);
        }

        /// <summary>
        /// Whether a new project task that is being created based on the template is to be assigned to the person who is selected in the Requested for field of the request for which the project was registered.
        /// </summary>
        [JsonProperty("assignToRequester")]
        public bool? AssignToRequester
        {
            get => assignToRequester;
            set => assignToRequester = Set("assignToRequester", value);
        }

        /// <summary>
        /// Whether a new project task that is being created based on the template is to be assigned to the person who is selected in the Manager field of the business unit to which the organization belongs that is linked to the person who is selected in the Requested for field of the request for which the project was registered.
        /// </summary>
        [JsonProperty("assignToRequesterBusinessUnitManager")]
        public bool? AssignToRequesterBusinessUnitManager
        {
            get => assignToRequesterBusinessUnitManager;
            set => assignToRequesterBusinessUnitManager = Set("assignToRequesterBusinessUnitManager", value);
        }

        /// <summary>
        /// Whether a new project task that is being created based on the template is to be assigned to the manager of the project's requester.
        /// </summary>
        [JsonProperty("assignToRequesterManager")]
        public bool? AssignToRequesterManager
        {
            get => assignToRequesterManager;
            set => assignToRequesterManager = Set("assignToRequesterManager", value);
        }

        /// <summary>
        /// Whether a new project task that is being created based on the template is to be assigned to the person who is selected in the Service owner field of the service that is linked to the project that the new project task is a part of.
        /// </summary>
        [JsonProperty("assignToServiceOwner")]
        public bool? AssignToServiceOwner
        {
            get => assignToServiceOwner;
            set => assignToServiceOwner = Set("assignToServiceOwner", value);
        }

        /// <summary>
        /// The category that needs to be selected in the Category field of a new project task when it is being created based on the template.
        /// </summary>
        [JsonProperty("category"), XurrentField(IsRequiredForMutation = true)]
        public ProjectTaskCategory Category
        {
            get => category;
            set => category = Set("category", value);
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
        /// Whether the Copy note to project box of project tasks that were created based on the template needs to be checked by default. (The Copy notes to project checkbox is called "Copy notes to project by default" when the project task template is in Edit mode.)
        /// </summary>
        [JsonProperty("copyNotesToProject")]
        public bool? CopyNotesToProject
        {
            get => copyNotesToProject;
            set => copyNotesToProject = Set("copyNotesToProject", value);
        }

        /// <summary>
        /// Whether the project task template may not be used to help register new project tasks.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// Identifier of the effort class that is selected by default, when someone registers time on a project task created based on the template.
        /// </summary>
        [JsonProperty("effortClassId")]
        public string? EffortClassId
        {
            get => effortClassId;
            set => effortClassId = Set("effortClassId", value);
        }

        /// <summary>
        /// The information that needs to be copied to the Instructions field of a new project task when it is being created based on the template.
        /// </summary>
        [JsonProperty("instructions")]
        public string? Instructions
        {
            get => instructions;
            set => instructions = Set("instructions", value);
        }

        /// <summary>
        /// Assignments of the project task template.
        /// </summary>
        [JsonProperty("newAssignments")]
        public List<ProjectTaskTemplateAssignmentInput>? NewAssignments
        {
            get => newAssignments;
            set => newAssignments = Set("newAssignments", value);
        }

        /// <summary>
        /// The information that needs to be copied to the Note field of a new project task when it is being created based on the template.
        /// </summary>
        [JsonProperty("note")]
        public string? Note
        {
            get => note;
            set => note = Set("note", value);
        }

        /// <summary>
        /// Identifier of the PDF design that needs to be copied to the PDF design field of a new project task when it is being created based on the template.
        /// </summary>
        [JsonProperty("pdfDesignId")]
        public string? PdfDesignId
        {
            get => pdfDesignId;
            set => pdfDesignId = Set("pdfDesignId", value);
        }

        /// <summary>
        /// Used to specify the number of minutes that should be entered in the Planned duration field of a new project task when it is being created based on the template.
        /// </summary>
        [JsonProperty("plannedDuration"), XurrentField(IsRequiredForMutation = true)]
        public long PlannedDuration
        {
            get => plannedDuration;
            set => plannedDuration = Set("plannedDuration", value);
        }

        /// <summary>
        /// Used to specify the number of minutes that the team is expected to spend working on a project task that was created based on the template.
        /// </summary>
        [JsonProperty("plannedEffort")]
        public long? PlannedEffort
        {
            get => plannedEffort;
            set => plannedEffort = Set("plannedEffort", value);
        }

        /// <summary>
        /// Used to specify the number of minutes that the project manager is expected to spend working on a project task that was created based on the template.
        /// </summary>
        [JsonProperty("plannedEffortProjectManager")]
        public long? PlannedEffortProjectManager
        {
            get => plannedEffortProjectManager;
            set => plannedEffortProjectManager = Set("plannedEffortProjectManager", value);
        }

        /// <summary>
        /// Used to specify the number of minutes that the requester is expected to spend working on a project task that was created based on the template.
        /// </summary>
        [JsonProperty("plannedEffortRequester")]
        public long? PlannedEffortRequester
        {
            get => plannedEffortRequester;
            set => plannedEffortRequester = Set("plannedEffortRequester", value);
        }

        /// <summary>
        /// Used to specify the number of minutes that the requester's business unit manager is expected to spend working on a project task that was created based on the template.
        /// </summary>
        [JsonProperty("plannedEffortRequesterBusinessUnitManager")]
        public long? PlannedEffortRequesterBusinessUnitManager
        {
            get => plannedEffortRequesterBusinessUnitManager;
            set => plannedEffortRequesterBusinessUnitManager = Set("plannedEffortRequesterBusinessUnitManager", value);
        }

        /// <summary>
        /// Used to specify the number of minutes that the requester's manager is expected to spend working on a project task that was created based on the template.
        /// </summary>
        [JsonProperty("plannedEffortRequesterManager")]
        public long? PlannedEffortRequesterManager
        {
            get => plannedEffortRequesterManager;
            set => plannedEffortRequesterManager = Set("plannedEffortRequesterManager", value);
        }

        /// <summary>
        /// Used to specify the number of minutes that the service owner is expected to spend working on a project task that was created based on the template.
        /// </summary>
        [JsonProperty("plannedEffortServiceOwner")]
        public long? PlannedEffortServiceOwner
        {
            get => plannedEffortServiceOwner;
            set => plannedEffortServiceOwner = Set("plannedEffortServiceOwner", value);
        }

        /// <summary>
        /// The number that needs to be specified in the Required approvals field of a new approval project task when it is being created based on the template.
        /// </summary>
        [JsonProperty("requiredApprovals")]
        public long? RequiredApprovals
        {
            get => requiredApprovals;
            set => requiredApprovals = Set("requiredApprovals", value);
        }

        /// <summary>
        /// Identifier of the skill pool that should be selected in the Skill pool field of a new project task when it is being created based on the template.
        /// </summary>
        [JsonProperty("skillPoolId")]
        public string? SkillPoolId
        {
            get => skillPoolId;
            set => skillPoolId = Set("skillPoolId", value);
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
        /// A short description that needs to be copied to the Subject field of a new project task when it is being created based on the template.
        /// </summary>
        [JsonProperty("subject"), XurrentField(IsRequiredForMutation = true)]
        public string Subject
        {
            get => subject;
            set => subject = Set("subject", value);
        }

        /// <summary>
        /// Identifier of the supplier organization that should be selected in the Supplier field of a new project task when it is being created based on the template.
        /// </summary>
        [JsonProperty("supplierId")]
        public string? SupplierId
        {
            get => supplierId;
            set => supplierId = Set("supplierId", value);
        }

        /// <summary>
        /// Identifier of the Team that should be selected in the Team field of a new project task when it is being created based on the template.
        /// </summary>
        [JsonProperty("teamId")]
        public string? TeamId
        {
            get => teamId;
            set => teamId = Set("teamId", value);
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
        /// When set to true, the completion target of project tasks created based on the template are calculated using a 24x7 calendar rather than normal business hours.
        /// </summary>
        [JsonProperty("workHoursAre24x7")]
        public bool? WorkHoursAre24x7
        {
            get => workHoursAre24x7;
            set => workHoursAre24x7 = Set("workHoursAre24x7", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTaskTemplateCreateInput"/> class without providing the required values.
        /// </summary>
        public ProjectTaskTemplateCreateInput()
        {
            category = default(ProjectTaskCategory);
            plannedDuration = default(long);
            subject = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTaskTemplateCreateInput"/> class.
        /// </summary>
        /// <param name="category">The category that needs to be selected in the Category field of a new project task when it is being created based on the template.</param>
        /// <param name="plannedDuration">Used to specify the number of minutes that should be entered in the Planned duration field of a new project task when it is being created based on the template.</param>
        /// <param name="subject">A short description that needs to be copied to the Subject field of a new project task when it is being created based on the template.</param>
        public ProjectTaskTemplateCreateInput(ProjectTaskCategory category, long plannedDuration, string subject)
        {
            this.category = Set("category", category);
            this.plannedDuration = Set("plannedDuration", plannedDuration);
            this.subject = Set("subject", subject);
        }
    }
}
