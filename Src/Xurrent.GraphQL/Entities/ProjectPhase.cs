﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/projectphase/">ProjectPhase</see> object.
    /// </summary>
    public class ProjectPhase : Node
    {
        /// <summary>
        /// The date and time at which the project phase was set to the status "Completed".
        /// </summary>
        [JsonProperty("completedAt")]
        public DateTime? CompletedAt { get; internal set; }

        /// <summary>
        /// The date and time at which the project phase was created.
        /// </summary>
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The name of the project phase.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; internal set; }

        /// <summary>
        /// The position that the project phase takes when it is presented in the project's Gantt chart.
        /// </summary>
        [JsonProperty("position")]
        public long? Position { get; internal set; }

        /// <summary>
        /// Indicates the date and time at which the first project task of the phase was set to a status other than <c>registered</c> or <c>canceled</c>.
        /// </summary>
        [JsonProperty("startedAt")]
        public DateTime? StartedAt { get; internal set; }

        /// <summary>
        /// The current status of the project phase.
        /// </summary>
        [JsonProperty("status"), XurrentField(IsDefaultQueryProperty = true)]
        public ProjectPhaseStatus? Status { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the project phase. If the phase has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
