﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/input_object/calendarcreateinput/">CalendarCreateInput</see> object.
    /// </summary>
    public class CalendarCreateInput : PropertyChangeSet
    {
        private string? clientMutationId;
        private bool? disabled;
        private List<string>? holidayIds;
        private string name;
        private List<CalendarHoursInput>? newCalendarHours;
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
        /// Whether the calendar may no longer be related to other records.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// Identifiers of the holidays of the calendar.
        /// </summary>
        [JsonProperty("holidayIds")]
        public List<string>? HolidayIds
        {
            get => holidayIds;
            set => holidayIds = Set("holidayIds", value);
        }

        /// <summary>
        /// The name of the calendar.
        /// </summary>
        [JsonProperty("name"), XurrentField(IsRequiredForMutation = true)]
        public string Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// Calendar hours of the calendar.
        /// </summary>
        [JsonProperty("newCalendarHours")]
        public List<CalendarHoursInput>? NewCalendarHours
        {
            get => newCalendarHours;
            set => newCalendarHours = Set("newCalendarHours", value);
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
        /// Initializes a new instance of the <see cref="CalendarCreateInput"/> class without providing the required values.
        /// </summary>
        public CalendarCreateInput()
        {
            name = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarCreateInput"/> class.
        /// </summary>
        /// <param name="name">The name of the calendar.</param>
        public CalendarCreateInput(string name)
        {
            this.name = Set("name", name);
        }
    }
}
