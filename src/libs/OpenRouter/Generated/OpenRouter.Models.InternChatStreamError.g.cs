
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A failure after the response headers were sent. The chunk that carries it has `finish_reason: "error"`, then the final empty-`choices` chunk and `[DONE]` follow. Reasons here are `attachment_failed`, `busy`, `client_closed_request`, `interaction_not_pending`, `interaction_unknown`, `intern_unreachable`, `run_ended`, `stream_severed`, `timeout` or `turn_failed`. `run_ended` reports an ending the intern confirmed, such as a cancellation or a deadline, while `stream_severed` reports a connection lost without that confirmation.<br/>
    /// Example: {"code":502,"message":"The intern could not continue this run.","metadata":{"reason":"attachment_failed","retryable":false}}
    /// </summary>
    public sealed partial class InternChatStreamError
    {
        /// <summary>
        /// The HTTP status this failure would have had before the stream opened.
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.InternChatErrorMetadata Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatStreamError" /> class.
        /// </summary>
        /// <param name="code">
        /// The HTTP status this failure would have had before the stream opened.
        /// </param>
        /// <param name="message"></param>
        /// <param name="metadata">
        /// Machine-readable detail for the failure.<br/>
        /// Example: {"reason":"interaction_not_pending","retryable":false}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternChatStreamError(
            int code,
            string message,
            global::OpenRouter.InternChatErrorMetadata metadata)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatStreamError" /> class.
        /// </summary>
        public InternChatStreamError()
        {
        }

    }
}