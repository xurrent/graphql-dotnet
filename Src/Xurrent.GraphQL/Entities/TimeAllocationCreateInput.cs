﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/input_object/timeallocationcreateinput/">TimeAllocationCreateInput</see> object.
    /// </summary>
    public class TimeAllocationCreateInput : PropertyChangeSet
    {
        private string? clientMutationId;
        private TimeAllocationCustomerCategory customerCategory;
        private List<string>? customerIds;
        private TimeAllocationDescriptionCategory descriptionCategory;
        private bool? disabled;
        private string? effortClassId;
        private string? group;
        private string name;
        private List<string>? organizationIds;
        private TimeAllocationServiceCategory serviceCategory;
        private List<string>? serviceIds;
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
        /// Whether a person who spent on the time allocation needs to select a customer organization, and if this is the case, whether this person may only select from the customer organizations linked to the time allocation or is allowed to select any customer organization.
        /// </summary>
        [JsonProperty("customerCategory"), XurrentField(IsRequiredForMutation = true)]
        public TimeAllocationCustomerCategory CustomerCategory
        {
            get => customerCategory;
            set => customerCategory = Set("customerCategory", value);
        }

        /// <summary>
        /// Identifiers of the customer organizations of the time allocation.
        /// </summary>
        [JsonProperty("customerIds")]
        public List<string>? CustomerIds
        {
            get => customerIds;
            set => customerIds = Set("customerIds", value);
        }

        /// <summary>
        /// Whether the Description field should be available, and if so, whether it should be required, in the time entries to which the time allocation is related.
        /// </summary>
        [JsonProperty("descriptionCategory"), XurrentField(IsRequiredForMutation = true)]
        public TimeAllocationDescriptionCategory DescriptionCategory
        {
            get => descriptionCategory;
            set => descriptionCategory = Set("descriptionCategory", value);
        }

        /// <summary>
        /// Whether the time allocation may no longer be related to any more organizations.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// Identifier of the effort class that is selected by default, when someone registers time on this time allocation.
        /// </summary>
        [JsonProperty("effortClassId")]
        public string? EffortClassId
        {
            get => effortClassId;
            set => effortClassId = Set("effortClassId", value);
        }

        /// <summary>
        /// Which group to include the time allocation in.
        /// </summary>
        [JsonProperty("group")]
        public string? Group
        {
            get => group;
            set => group = Set("group", value);
        }

        /// <summary>
        /// The name of the time allocation.
        /// </summary>
        [JsonProperty("name"), XurrentField(IsRequiredForMutation = true)]
        public string Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// Identifiers of the organizations of the time allocation.
        /// </summary>
        [JsonProperty("organizationIds")]
        public List<string>? OrganizationIds
        {
            get => organizationIds;
            set => organizationIds = Set("organizationIds", value);
        }

        /// <summary>
        /// Whether a Person who spent on the time allocation needs to select a service, and if this is the case, whether this person may only select from the services linked to the time allocation or is allowed to select any service.
        /// </summary>
        [JsonProperty("serviceCategory"), XurrentField(IsRequiredForMutation = true)]
        public TimeAllocationServiceCategory ServiceCategory
        {
            get => serviceCategory;
            set => serviceCategory = Set("serviceCategory", value);
        }

        /// <summary>
        /// Identifiers of the services of the time allocation.
        /// </summary>
        [JsonProperty("serviceIds")]
        public List<string>? ServiceIds
        {
            get => serviceIds;
            set => serviceIds = Set("serviceIds", value);
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
        /// Initializes a new instance of the <see cref="TimeAllocationCreateInput"/> class without providing the required values.
        /// </summary>
        public TimeAllocationCreateInput()
        {
            customerCategory = default(TimeAllocationCustomerCategory);
            descriptionCategory = default(TimeAllocationDescriptionCategory);
            name = string.Empty;
            serviceCategory = default(TimeAllocationServiceCategory);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeAllocationCreateInput"/> class.
        /// </summary>
        /// <param name="customerCategory">Whether a person who spent on the time allocation needs to select a customer organization, and if this is the case, whether this person may only select from the customer organizations linked to the time allocation or is allowed to select any customer organization.</param>
        /// <param name="descriptionCategory">Whether the Description field should be available, and if so, whether it should be required, in the time entries to which the time allocation is related.</param>
        /// <param name="name">The name of the time allocation.</param>
        /// <param name="serviceCategory">Whether a Person who spent on the time allocation needs to select a service, and if this is the case, whether this person may only select from the services linked to the time allocation or is allowed to select any service.</param>
        public TimeAllocationCreateInput(TimeAllocationCustomerCategory customerCategory, TimeAllocationDescriptionCategory descriptionCategory, string name, TimeAllocationServiceCategory serviceCategory)
        {
            this.customerCategory = Set("customerCategory", customerCategory);
            this.descriptionCategory = Set("descriptionCategory", descriptionCategory);
            this.name = Set("name", name);
            this.serviceCategory = Set("serviceCategory", serviceCategory);
        }
    }
}
