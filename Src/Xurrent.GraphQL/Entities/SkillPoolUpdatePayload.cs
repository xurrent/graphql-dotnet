using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/skillpoolupdatepayload/">SkillPoolUpdatePayload</see> object.
    /// </summary>
    public class SkillPoolUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("skillPool"), XurrentField(IsDefaultQueryProperty = true)]
        public SkillPool? SkillPool { get; internal set; }
    }
}
