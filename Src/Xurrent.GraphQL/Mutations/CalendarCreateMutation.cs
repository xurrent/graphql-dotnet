﻿using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// Creates a new calendar.
    /// </summary>
    internal sealed class CalendarCreateMutation : Mutation<CalendarCreatePayload, CalendarCreateInput>
    {
        /// <summary>
        /// Initialize an new CalendarCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The calendar response query.</param>
        internal CalendarCreateMutation(CalendarCreateInput data, CalendarQuery query)
            : base("calendarCreate", "CalendarCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The calendar response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(CalendarQuery query)
        {
            query.FieldName = "calendar";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
