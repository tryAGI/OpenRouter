
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Structured error metadata
    /// </summary>
    public sealed partial class ChatStreamChunkErrorMetadata
    {
        /// <summary>
        /// Canonical OpenRouter error type, stable across all API formats<br/>
        /// Example: rate_limit_exceeded
        /// </summary>
        /// <example>rate_limit_exceeded</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ApiErrorTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ApiErrorType ErrorType { get; set; }

        /// <summary>
        /// Upstream provider-specific error code, when available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_code")]
        public string? ProviderCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamChunkErrorMetadata" /> class.
        /// </summary>
        /// <param name="errorType">
        /// Canonical OpenRouter error type, stable across all API formats<br/>
        /// Example: rate_limit_exceeded
        /// </param>
        /// <param name="providerCode">
        /// Upstream provider-specific error code, when available
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatStreamChunkErrorMetadata(
            global::OpenRouter.ApiErrorType errorType,
            string? providerCode)
        {
            this.ErrorType = errorType;
            this.ProviderCode = providerCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamChunkErrorMetadata" /> class.
        /// </summary>
        public ChatStreamChunkErrorMetadata()
        {
        }

    }
}