namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/interface/hasautomationrules/">HasAutomationRules</see> interface.
    /// </summary>
    public interface IHasAutomationRules
    {
        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        public DataList<AutomationRule>? AutomationRules { get; }
    }
}
