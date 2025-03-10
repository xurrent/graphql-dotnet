﻿using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// Creates a new timesheet setting.
    /// </summary>
    internal sealed class TimesheetSettingCreateMutation : Mutation<TimesheetSettingCreatePayload, TimesheetSettingCreateInput>
    {
        /// <summary>
        /// Initialize an new TimesheetSettingCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The timesheet setting response query.</param>
        internal TimesheetSettingCreateMutation(TimesheetSettingCreateInput data, TimesheetSettingQuery query)
            : base("timesheetSettingCreate", "TimesheetSettingCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The timesheet setting response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(TimesheetSettingQuery query)
        {
            query.FieldName = "timesheetSetting";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
