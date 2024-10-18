using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/uiextensionversion/">UiExtensionVersion</see> object.
    /// </summary>
    public class UiExtensionVersion : Node
    {
        /// <summary>
        /// The date and time at which this version of the UI extension was activated.
        /// </summary>
        [JsonProperty("activatedAt")]
        public DateTime? ActivatedAt { get; internal set; }

        /// <summary>
        /// The date and time at which this version of the UI extension was archived.
        /// </summary>
        [JsonProperty("archivedAt")]
        public DateTime? ArchivedAt { get; internal set; }

        /// <summary>
        /// The date and time at which this version of the UI extension was created.
        /// </summary>
        [JsonProperty("createdAt"), XurrentField(IsDefaultQueryProperty = true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The CSS stylesheet.
        /// </summary>
        [JsonProperty("css")]
        public string? Css { get; internal set; }

        /// <summary>
        /// The Form Definition.
        /// </summary>
        [JsonProperty("formDefinition")]
        public JToken? FormDefinition { get; internal set; }

        /// <summary>
        /// The HTML code.
        /// </summary>
        [JsonProperty("html")]
        public string? Html { get; internal set; }

        /// <summary>
        /// The Javascript code.
        /// </summary>
        [JsonProperty("javascript")]
        public string? Javascript { get; internal set; }

        /// <summary>
        /// Indicates the location in the life-cycle.
        /// </summary>
        [JsonProperty("status")]
        public UiExtensionVersionStatus? Status { get; internal set; }

        /// <summary>
        /// UI extension this version belongs to.
        /// </summary>
        [JsonProperty("uiExtension")]
        public UiExtension? UiExtension { get; internal set; }

        /// <summary>
        /// The date and time of the last update of this version of the UI extension. If this version of the UI extension has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), XurrentField(IsDefaultQueryProperty = true)]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// The version number (1..) of this version of the UI extension.
        /// </summary>
        [JsonProperty("versionNr")]
        public long? VersionNr { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
