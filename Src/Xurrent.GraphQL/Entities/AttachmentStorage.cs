using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/object/attachmentstorage/">AttachmentStorage</see> object.
    /// </summary>
    [XurrentEntity(ignoreIdentifier: true)]
    public class AttachmentStorage : Node
    {
        /// <summary>
        /// The display debugger value.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal override string? DebuggerValue
        {
            get => UploadUri ?? ToString();
        }

        /// <summary>
        /// The unique identifier used by <see cref="DataList{T}"/>.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal override string UniqueIdentifier
        {
            get => GetHashCode().ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// The permitted file extensions for uploads.
        /// </summary>
        [JsonProperty("allowedExtensions"), XurrentField(IsDefaultQueryProperty = true)]
        public List<string>? AllowedExtensions { get; internal set; }

        /// <summary>
        /// <br>Type of storage facility in use. One of:</br>
        /// <br>• <c>local</c>: On-premise environment storage.</br>
        /// <br>• <c>s3</c>: Cloud environment storage.</br>
        /// </summary>
        [JsonProperty("provider"), XurrentField(IsDefaultQueryProperty = true)]
        public string? Provider { get; internal set; }

        /// <summary>
        /// The mandatory fields and their values that should be added to an upload POST to the <c>uploadUri</c>.
        /// </summary>
        [JsonProperty("providerParameters"), XurrentField(IsDefaultQueryProperty = true)]
        public JToken? ProviderParameters { get; internal set; }

        /// <summary>
        /// The maximum size (in bytes) for uploads.
        /// </summary>
        [JsonProperty("sizeLimit"), XurrentField(IsDefaultQueryProperty = true)]
        public long? SizeLimit { get; internal set; }

        /// <summary>
        /// The URI that attachments should be uploaded to.
        /// </summary>
        [JsonProperty("uploadUri"), XurrentField(IsDefaultQueryProperty = true)]
        public string? UploadUri { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
