namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="SlaNotificationRule">SlaNotificationRule</see> query.
    /// </summary>
    public class SlaNotificationRuleQuery : Query<SlaNotificationRuleQuery, SlaNotificationRuleField, DefaultView, DefaultFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new sla notification rule query instance.
        /// </summary>
        public SlaNotificationRuleQuery()
            : base("", typeof(SlaNotificationRule), true)
        {
        }
    }
}
