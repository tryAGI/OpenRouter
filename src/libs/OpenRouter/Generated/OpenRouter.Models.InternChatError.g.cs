
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The OpenAI-compatible error object. `metadata` is present on refusals from the chat route. Authentication refusals (`401`), the departed-creator `403` and the programme `404` carry only `code` and `message`.<br/>
    /// Example: {"code":409,"message":"That question is no longer waiting for an answer.","metadata":{"reason":"interaction_not_pending","retryable":false}}
    /// </summary>
    public sealed partial class InternChatError
    {
        /// <summary>
        /// The HTTP status of the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Machine-readable detail for the failure.<br/>
        /// Example: {"reason":"interaction_not_pending","retryable":false}
        /// </summary>
        /// <example>{"reason":"interaction_not_pending","retryable":false}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::OpenRouter.InternChatErrorMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatError" /> class.
        /// </summary>
        /// <param name="code">
        /// The HTTP status of the response.
        /// </param>
        /// <param name="message"></param>
        /// <param name="metadata">
        /// Machine-readable detail for the failure.<br/>
        /// Example: {"reason":"interaction_not_pending","retryable":false}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternChatError(
            int code,
            string message,
            global::OpenRouter.InternChatErrorMetadata? metadata)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatError" /> class.
        /// </summary>
        public InternChatError()
        {
        }

    }
}