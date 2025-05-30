﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/projecttasktemplateassignment/">ProjectTaskTemplateAssignment</see> object.
    /// </summary>
    public class ProjectTaskTemplateAssignment : Node
    {
        /// <summary>
        /// The person who is selected as the assignee for the project task template assignment.
        /// </summary>
        [JsonProperty("assignee"), XurrentField(IsDefaultQueryProperty = true)]
        public Person? Assignee { get; internal set; }

        /// <summary>
        /// The number of minutes the assignee is expected to spend working on a project task that was created based on the project task template to which the assignment belongs.
        /// </summary>
        [JsonProperty("plannedEffort"), XurrentField(IsDefaultQueryProperty = true)]
        public long? PlannedEffort { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
