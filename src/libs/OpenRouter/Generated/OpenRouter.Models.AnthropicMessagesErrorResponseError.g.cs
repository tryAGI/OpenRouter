
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnthropicMessagesErrorResponseError
    {
        /// <summary>
        /// Canonical OpenRouter error type, stable across all API formats<br/>
        /// Example: rate_limit_exceeded
        /// </summary>
        /// <example>rate_limit_exceeded</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ApiErrorTypeJsonConverter))]
        public global::OpenRouter.ApiErrorType? ErrorType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicMessagesErrorResponseErrorTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnthropicMessagesErrorResponseErrorType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicMessagesErrorResponseError" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="type"></param>
        /// <param name="errorType">
        /// Canonical OpenRouter error type, stable across all API formats<br/>
        /// Example: rate_limit_exceeded
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicMessagesErrorResponseError(
            string message,
            global::OpenRouter.AnthropicMessagesErrorResponseErrorType type,
            global::OpenRouter.ApiErrorType? errorType)
        {
            this.ErrorType = errorType;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicMessagesErrorResponseError" /> class.
        /// </summary>
        public AnthropicMessagesErrorResponseError()
        {
        }

    }
}