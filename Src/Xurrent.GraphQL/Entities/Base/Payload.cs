using Newtonsoft.Json;
using System.Collections.Generic;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The Xurrent GraphQL Mutation response.
    /// </summary>
    public abstract class Payload
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [JsonProperty("clientMutationId"), XurrentField(IsDefaultQueryProperty = true)]
        public string? ClientMutationId { get; internal set; }

        /// <summary>
        /// Errors encountered during the mutation.
        /// </summary>
        [JsonProperty("errors"), XurrentField(IsDefaultQueryProperty = true)]
        public List<ValidationError>? Errors { get; internal set; }

        /// <summary>
        /// Determines if the response contains an error message.
        /// </summary>
        /// <returns>True if the response contains an error; otherwise false.</returns>
        public bool IsError()
        {
            return Errors != null && Errors.Count > 0;
        }
    }
}
