﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/input_object/discoveredconfigurationitemsinput/">DiscoveredConfigurationItemsInput</see> object.
    /// </summary>
    public class DiscoveredConfigurationItemsInput : PropertyChangeSet
    {
        private List<string>? alternativeSources;
        private string? clientMutationId;
        private List<DiscoveredProductCategoryInput>? physicalAssets;
        private DiscoveredReferenceStrategiesInput? referenceStrategies;
        private string source;
        private string? supportTeam;

        /// <summary>
        /// Alternative identifiers for the client application. When a configuration item or product with the given <c>sourceID</c> is found linked to one of these alternative sources it will be identified as the same. For configuration items the source field in Xurrent will be updated to the <c>source</c> value supplied.
        /// </summary>
        [JsonProperty("alternativeSources")]
        public List<string>? AlternativeSources
        {
            get => alternativeSources;
            set => alternativeSources = Set("alternativeSources", value);
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [JsonProperty("clientMutationId")]
        public string? ClientMutationId
        {
            get => clientMutationId;
            set => clientMutationId = Set("clientMutationId", value);
        }

        /// <summary>
        /// Physical assets to be uploaded, grouped by product category and product.
        /// </summary>
        [JsonProperty("physicalAssets")]
        public List<DiscoveredProductCategoryInput>? PhysicalAssets
        {
            get => physicalAssets;
            set => physicalAssets = Set("physicalAssets", value);
        }

        /// <summary>
        /// How to handle references to records already present in Xurrent.
        /// </summary>
        [JsonProperty("referenceStrategies")]
        public DiscoveredReferenceStrategiesInput? ReferenceStrategies
        {
            get => referenceStrategies;
            set => referenceStrategies = Set("referenceStrategies", value);
        }

        /// <summary>
        /// Identifier for the client application submitting the upload.
        /// </summary>
        [JsonProperty("source"), XurrentField(IsRequiredForMutation = true)]
        public string Source
        {
            get => source;
            set => source = Set("source", value);
        }

        /// <summary>
        /// Name of the support team to use as default for new products and configuration items uploaded.
        /// </summary>
        [JsonProperty("supportTeam")]
        public string? SupportTeam
        {
            get => supportTeam;
            set => supportTeam = Set("supportTeam", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveredConfigurationItemsInput"/> class without providing the required values.
        /// </summary>
        public DiscoveredConfigurationItemsInput()
        {
            source = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveredConfigurationItemsInput"/> class.
        /// </summary>
        /// <param name="source">Identifier for the client application submitting the upload.</param>
        public DiscoveredConfigurationItemsInput(string source)
        {
            this.source = Set("source", source);
        }
    }
}
