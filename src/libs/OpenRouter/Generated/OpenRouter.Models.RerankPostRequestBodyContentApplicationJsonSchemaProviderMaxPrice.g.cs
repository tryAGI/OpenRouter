
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The object specifying the maximum price you want to pay for this request. USD price per million tokens, for prompt and completion.
    /// </summary>
    public sealed partial class RerankPostRequestBodyContentApplicationJsonSchemaProviderMaxPrice
    {
        /// <summary>
        /// Price per million prompt tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public string? Audio { get; set; }

        /// <summary>
        /// Price per million prompt tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion")]
        public string? Completion { get; set; }

        /// <summary>
        /// Price per million prompt tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Price per million prompt tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Price per million prompt tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public string? Request { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankPostRequestBodyContentApplicationJsonSchemaProviderMaxPrice" /> class.
        /// </summary>
        /// <param name="audio">
        /// Price per million prompt tokens
        /// </param>
        /// <param name="completion">
        /// Price per million prompt tokens
        /// </param>
        /// <param name="image">
        /// Price per million prompt tokens
        /// </param>
        /// <param name="prompt">
        /// Price per million prompt tokens
        /// </param>
        /// <param name="request">
        /// Price per million prompt tokens
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankPostRequestBodyContentApplicationJsonSchemaProviderMaxPrice(
            string? audio,
            string? completion,
            string? image,
            string? prompt,
            string? request)
        {
            this.Audio = audio;
            this.Completion = completion;
            this.Image = image;
            this.Prompt = prompt;
            this.Request = request;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankPostRequestBodyContentApplicationJsonSchemaProviderMaxPrice" /> class.
        /// </summary>
        public RerankPostRequestBodyContentApplicationJsonSchemaProviderMaxPrice()
        {
        }

    }
}