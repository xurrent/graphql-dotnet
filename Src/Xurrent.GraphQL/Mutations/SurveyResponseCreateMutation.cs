﻿using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// Creates a new survey response.
    /// </summary>
    internal sealed class SurveyResponseCreateMutation : Mutation<SurveyResponseCreatePayload, SurveyResponseCreateInput>
    {
        /// <summary>
        /// Initialize an new SurveyResponseCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The survey response response query.</param>
        internal SurveyResponseCreateMutation(SurveyResponseCreateInput data, SurveyResponseQuery query)
            : base("surveyResponseCreate", "SurveyResponseCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The survey response response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(SurveyResponseQuery query)
        {
            query.FieldName = "surveyResponse";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
