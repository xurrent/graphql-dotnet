﻿using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// Deletes an existing app offering automation rule.
    /// </summary>
    internal sealed class AppOfferingAutomationRuleDeleteMutation : Mutation<AppOfferingAutomationRuleDeleteMutationPayload, AppOfferingAutomationRuleDeleteMutationInput>
    {
        /// <summary>
        /// Initialize an new AppOfferingAutomationRuleDelete mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        internal AppOfferingAutomationRuleDeleteMutation(AppOfferingAutomationRuleDeleteMutationInput data)
            : base("appOfferingAutomationRuleDelete", "AppOfferingAutomationRuleDeleteMutationInput!", data, new HashSet<IQuery>())
        {
        }
    }
}
