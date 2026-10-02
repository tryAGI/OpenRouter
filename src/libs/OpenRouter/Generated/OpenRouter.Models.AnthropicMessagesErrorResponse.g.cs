
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Error response from the Anthropic Messages API<br/>
    /// Example: {"error":{"error_type":"invalid_request","message":"Invalid request: messages field is required","type":"invalid_request_error"},"request_id":null,"type":"error"}
    /// </summary>
    public sealed partial class AnthropicMessagesErrorResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnthropicMessagesErrorResponseError Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openrouter_metadata")]
        public object? OpenrouterMetadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicMessagesErrorResponseTypeJsonConverter))]
        public global::OpenRouter.AnthropicMessagesErrorResponseType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicMessagesErrorResponse" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="metadata"></param>
        /// <param name="openrouterMetadata"></param>
        /// <param name="requestId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicMessagesErrorResponse(
            global::OpenRouter.AnthropicMessagesErrorResponseError error,
            object? metadata,
            object? openrouterMetadata,
            string? requestId,
            global::OpenRouter.AnthropicMessagesErrorResponseType type)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Metadata = metadata;
            this.OpenrouterMetadata = openrouterMetadata;
            this.RequestId = requestId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicMessagesErrorResponse" /> class.
        /// </summary>
        public AnthropicMessagesErrorResponse()
        {
        }

    }
}