﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/input_object/reservationofferingcreateinput/">ReservationOfferingCreateInput</see> object.
    /// </summary>
    public class ReservationOfferingCreateInput : PropertyChangeSet
    {
        private bool? allowRepeat;
        private string calendarId;
        private string? clientMutationId;
        private List<string>? configurationItemIds;
        private bool? disabled;
        private List<string>? filters;
        private ReservationStatus? initialStatus;
        private long? maxAdvanceDuration;
        private long maxDuration;
        private long? minAdvanceDuration;
        private long minDuration;
        private bool? multiDay;
        private string name;
        private long? preparationDuration;
        private bool? privateReservations;
        private string? serviceInstanceId;
        private string? source;
        private string? sourceID;
        private long stepDuration;
        private string timeZone;

        /// <summary>
        /// Whether it is allowed to create recurrent reservations for this offering.
        /// </summary>
        [JsonProperty("allowRepeat")]
        public bool? AllowRepeat
        {
            get => allowRepeat;
            set => allowRepeat = Set("allowRepeat", value);
        }

        /// <summary>
        /// Calendar that defines the hours in which reservations may start and end.
        /// </summary>
        [JsonProperty("calendarId"), XurrentField(IsRequiredForMutation = true)]
        public string CalendarId
        {
            get => calendarId;
            set => calendarId = Set("calendarId", value);
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
        /// Identifiers of the configuration items that may be reserved using this offering.
        /// </summary>
        [JsonProperty("configurationItemIds")]
        public List<string>? ConfigurationItemIds
        {
            get => configurationItemIds;
            set => configurationItemIds = Set("configurationItemIds", value);
        }

        /// <summary>
        /// Whether the reservation offering may not be used to register requests for reservation.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// The filters of the reservation offering.
        /// </summary>
        [JsonProperty("filters")]
        public List<string>? Filters
        {
            get => filters;
            set => filters = Set("filters", value);
        }

        /// <summary>
        /// The initial status of the reservation.
        /// </summary>
        [JsonProperty("initialStatus")]
        public ReservationStatus? InitialStatus
        {
            get => initialStatus;
            set => initialStatus = Set("initialStatus", value);
        }

        /// <summary>
        /// The maximum duration between the creation time of a request for reservation and the requested start of the reservation.
        /// </summary>
        [JsonProperty("maxAdvanceDuration")]
        public long? MaxAdvanceDuration
        {
            get => maxAdvanceDuration;
            set => maxAdvanceDuration = Set("maxAdvanceDuration", value);
        }

        /// <summary>
        /// The maximum duration of the reservation within the hours of the calendar.
        /// </summary>
        [JsonProperty("maxDuration"), XurrentField(IsRequiredForMutation = true)]
        public long MaxDuration
        {
            get => maxDuration;
            set => maxDuration = Set("maxDuration", value);
        }

        /// <summary>
        /// The minimum duration between the creation time of a request for reservation and the requested start of the reservation.
        /// </summary>
        [JsonProperty("minAdvanceDuration")]
        public long? MinAdvanceDuration
        {
            get => minAdvanceDuration;
            set => minAdvanceDuration = Set("minAdvanceDuration", value);
        }

        /// <summary>
        /// The minimum duration of the reservation within the hours of the calendar.
        /// </summary>
        [JsonProperty("minDuration"), XurrentField(IsRequiredForMutation = true)]
        public long MinDuration
        {
            get => minDuration;
            set => minDuration = Set("minDuration", value);
        }

        /// <summary>
        /// Whether or not the reservation may span over multiple calendar days.
        /// </summary>
        [JsonProperty("multiDay")]
        public bool? MultiDay
        {
            get => multiDay;
            set => multiDay = Set("multiDay", value);
        }

        /// <summary>
        /// A short description of the reservation offering
        /// </summary>
        [JsonProperty("name"), XurrentField(IsRequiredForMutation = true)]
        public string Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// The duration required to prepare the asset before the reservation starts.
        /// </summary>
        [JsonProperty("preparationDuration")]
        public long? PreparationDuration
        {
            get => preparationDuration;
            set => preparationDuration = Set("preparationDuration", value);
        }

        /// <summary>
        /// Reservations of this reservation offering are private and can not be viewed by other end users.
        /// </summary>
        [JsonProperty("privateReservations")]
        public bool? PrivateReservations
        {
            get => privateReservations;
            set => privateReservations = Set("privateReservations", value);
        }

        /// <summary>
        /// Identifier of the service instance for which the reservations may be requested.
        /// </summary>
        [JsonProperty("serviceInstanceId")]
        public string? ServiceInstanceId
        {
            get => serviceInstanceId;
            set => serviceInstanceId = Set("serviceInstanceId", value);
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
        /// The increments with which the reservation may be prolonged.
        /// </summary>
        [JsonProperty("stepDuration"), XurrentField(IsRequiredForMutation = true)]
        public long StepDuration
        {
            get => stepDuration;
            set => stepDuration = Set("stepDuration", value);
        }

        /// <summary>
        /// <br>The time zone that applies to the selected calendar.</br>
        /// <br>The complete list is available on the <see href="https://developer.xurrent.com/graphql/scalar/timezone/">Xurrent developer site</see>.</br>
        /// </summary>
        [JsonProperty("timeZone"), XurrentField(IsRequiredForMutation = true)]
        public string TimeZone
        {
            get => timeZone;
            set => timeZone = Set("timeZone", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReservationOfferingCreateInput"/> class without providing the required values.
        /// </summary>
        public ReservationOfferingCreateInput()
        {
            calendarId = string.Empty;
            maxDuration = default(long);
            minDuration = default(long);
            name = string.Empty;
            stepDuration = default(long);
            timeZone = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReservationOfferingCreateInput"/> class.
        /// </summary>
        /// <param name="calendarId">Calendar that defines the hours in which reservations may start and end.</param>
        /// <param name="maxDuration">The maximum duration of the reservation within the hours of the calendar.</param>
        /// <param name="minDuration">The minimum duration of the reservation within the hours of the calendar.</param>
        /// <param name="name">A short description of the reservation offering</param>
        /// <param name="stepDuration">The increments with which the reservation may be prolonged.</param>
        /// <param name="timeZone">
        /// <br>The time zone that applies to the selected calendar.</br>
        /// <br>The complete list is available on the <see href="https://developer.Xurrent.com/graphql/scalar/timezone/">Xurrent developer site</see>.</br>
        /// </param>
        public ReservationOfferingCreateInput(string calendarId, long maxDuration, long minDuration, string name, long stepDuration, string timeZone)
        {
            this.calendarId = Set("calendarId", calendarId);
            this.maxDuration = Set("maxDuration", maxDuration);
            this.minDuration = Set("minDuration", minDuration);
            this.name = Set("name", name);
            this.stepDuration = Set("stepDuration", stepDuration);
            this.timeZone = Set("timeZone", timeZone);
        }
    }
}
