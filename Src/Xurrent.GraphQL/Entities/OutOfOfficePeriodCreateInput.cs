﻿using Newtonsoft.Json;
using System;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/input_object/outofofficeperiodcreateinput/">OutOfOfficePeriodCreateInput</see> object.
    /// </summary>
    public class OutOfOfficePeriodCreateInput : PropertyChangeSet
    {
        private string? approvalDelegateId;
        private string? clientMutationId;
        private string? effortClassId;
        private DateTime endAt;
        private string personId;
        private string? reason;
        private string? source;
        private string? sourceID;
        private DateTime startAt;
        private string? timeAllocationId;

        /// <summary>
        /// Identifier of the person who is selected as the approval delegate for the out of office period.
        /// </summary>
        [JsonProperty("approvalDelegateId")]
        public string? ApprovalDelegateId
        {
            get => approvalDelegateId;
            set => approvalDelegateId = Set("approvalDelegateId", value);
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
        /// Used to generate time entries for the out of office period. This field is required if the timesheet settings linked to the person's organization has one or more effort classes.
        /// </summary>
        [JsonProperty("effortClassId")]
        public string? EffortClassId
        {
            get => effortClassId;
            set => effortClassId = Set("effortClassId", value);
        }

        /// <summary>
        /// End time of the out of office period.
        /// </summary>
        [JsonProperty("endAt"), XurrentField(IsRequiredForMutation = true)]
        public DateTime EndAt
        {
            get => endAt;
            set => endAt = Set("endAt", value);
        }

        /// <summary>
        /// Identifier of the person who is out of office.
        /// </summary>
        [JsonProperty("personId"), XurrentField(IsRequiredForMutation = true)]
        public string PersonId
        {
            get => personId;
            set => personId = Set("personId", value);
        }

        /// <summary>
        /// The reason of the out of office period. Required when the description category of the time allocation is required.
        /// </summary>
        [JsonProperty("reason")]
        public string? Reason
        {
            get => reason;
            set => reason = Set("reason", value);
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
        /// Start time of the out of office period.
        /// </summary>
        [JsonProperty("startAt"), XurrentField(IsRequiredForMutation = true)]
        public DateTime StartAt
        {
            get => startAt;
            set => startAt = Set("startAt", value);
        }

        /// <summary>
        /// Used to generate time entries for the out of office period. Only the time allocations without service and customer that are linked to the person's organization can be selected. This field is required if at least one time allocation exists that meets those conditions.
        /// </summary>
        [JsonProperty("timeAllocationId")]
        public string? TimeAllocationId
        {
            get => timeAllocationId;
            set => timeAllocationId = Set("timeAllocationId", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutOfOfficePeriodCreateInput"/> class without providing the required values.
        /// </summary>
        public OutOfOfficePeriodCreateInput()
        {
            endAt = default(DateTime);
            personId = string.Empty;
            startAt = default(DateTime);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutOfOfficePeriodCreateInput"/> class.
        /// </summary>
        /// <param name="endAt">End time of the out of office period.</param>
        /// <param name="personId">Identifier of the person who is out of office.</param>
        /// <param name="startAt">Start time of the out of office period.</param>
        public OutOfOfficePeriodCreateInput(DateTime endAt, string personId, DateTime startAt)
        {
            this.endAt = Set("endAt", endAt);
            this.personId = Set("personId", personId);
            this.startAt = Set("startAt", startAt);
        }
    }
}
