﻿using Newtonsoft.Json;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.xurrent.com/graphql/input_object/translationcreateinput/">TranslationCreateInput</see> object.
    /// </summary>
    public class TranslationCreateInput : PropertyChangeSet
    {
        private string? clientMutationId;
        private string @field;
        private string language;
        private string ownerId;
        private string text;

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
        /// The field of the record from which the translation is obtained.
        /// </summary>
        [JsonProperty("field"), XurrentField(IsRequiredForMutation = true)]
        public string Field
        {
            get => @field;
            set => @field = Set("field", value);
        }

        /// <summary>
        /// <br>The language in which the text is specified.</br>
        /// <br>The complete list is available on the <see href="https://developer.xurrent.com/graphql/scalar/language/">Xurrent developer site</see>.</br>
        /// </summary>
        [JsonProperty("language"), XurrentField(IsRequiredForMutation = true)]
        public string Language
        {
            get => language;
            set => language = Set("language", value);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// </summary>
        [JsonProperty("ownerId"), XurrentField(IsRequiredForMutation = true)]
        public string OwnerId
        {
            get => ownerId;
            set => ownerId = Set("ownerId", value);
        }

        /// <summary>
        /// The text of the translation.
        /// </summary>
        [JsonProperty("text"), XurrentField(IsRequiredForMutation = true)]
        public string Text
        {
            get => text;
            set => text = Set("text", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationCreateInput"/> class without providing the required values.
        /// </summary>
        public TranslationCreateInput()
        {
            @field = string.Empty;
            language = string.Empty;
            ownerId = string.Empty;
            text = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationCreateInput"/> class.
        /// </summary>
        /// <param name="field">The field of the record from which the translation is obtained.</param>
        /// <param name="language">
        /// <br>The language in which the text is specified.</br>
        /// <br>The complete list is available on the <see href="https://developer.Xurrent.com/graphql/scalar/language/">Xurrent developer site</see>.</br>
        /// </param>
        /// <param name="ownerId">The record from which the translation is obtained.</param>
        /// <param name="text">The text of the translation.</param>
        public TranslationCreateInput(string @field, string language, string ownerId, string text)
        {
            this.@field = Set("field", @field);
            this.language = Set("language", language);
            this.ownerId = Set("ownerId", ownerId);
            this.text = Set("text", text);
        }
    }
}
