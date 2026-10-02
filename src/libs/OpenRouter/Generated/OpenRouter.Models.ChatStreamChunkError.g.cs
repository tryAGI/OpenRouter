
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Error information<br/>
    /// Example: {"code":429,"message":"Rate limit exceeded","metadata":{"error_type":"rate_limit_exceeded"}}
    /// </summary>
    public sealed partial class ChatStreamChunkError
    {
        /// <summary>
        /// Error code<br/>
        /// Example: 429
        /// </summary>
        /// <example>429</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Code { get; set; }

        /// <summary>
        /// Error message<br/>
        /// Example: Rate limit exceeded
        /// </summary>
        /// <example>Rate limit exceeded</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Structured error metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::OpenRouter.ChatStreamChunkErrorMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamChunkError" /> class.
        /// </summary>
        /// <param name="code">
        /// Error code<br/>
        /// Example: 429
        /// </param>
        /// <param name="message">
        /// Error message<br/>
        /// Example: Rate limit exceeded
        /// </param>
        /// <param name="metadata">
        /// Structured error metadata
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatStreamChunkError(
            int code,
            string message,
            global::OpenRouter.ChatStreamChunkErrorMetadata? metadata)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamChunkError" /> class.
        /// </summary>
        public ChatStreamChunkError()
        {
        }

    }
}