
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Machine-readable detail for the failure.<br/>
    /// Example: {"reason":"interaction_not_pending","retryable":false}
    /// </summary>
    public sealed partial class InternChatErrorMetadata
    {
        /// <summary>
        /// A stable reason a client can branch on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InternChatErrorMetadataReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.InternChatErrorMetadataReason Reason { get; set; }

        /// <summary>
        /// Whether the same request may be sent again unchanged. Always `true` for the transient refusals — `busy`, `intern_not_ready`, `intern_unreachable`, `rate_limited`, `stream_severed` and `timeout` — and always `false` for the ones a retry cannot fix. For `turn_failed` it varies by failure and is the intern's own classification of what went wrong: `true` for an upstream overload, rate limit, timeout or transport fault, `false` for an authentication or bad-request failure that would be rejected the same way again. Branch on this field rather than on `reason` when deciding whether to retry. A `429`, and a `409` or `503` with reason `busy`, also carry a `Retry-After` header saying how long to wait.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retryable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Retryable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatErrorMetadata" /> class.
        /// </summary>
        /// <param name="reason">
        /// A stable reason a client can branch on.
        /// </param>
        /// <param name="retryable">
        /// Whether the same request may be sent again unchanged. Always `true` for the transient refusals — `busy`, `intern_not_ready`, `intern_unreachable`, `rate_limited`, `stream_severed` and `timeout` — and always `false` for the ones a retry cannot fix. For `turn_failed` it varies by failure and is the intern's own classification of what went wrong: `true` for an upstream overload, rate limit, timeout or transport fault, `false` for an authentication or bad-request failure that would be rejected the same way again. Branch on this field rather than on `reason` when deciding whether to retry. A `429`, and a `409` or `503` with reason `busy`, also carry a `Retry-After` header saying how long to wait.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternChatErrorMetadata(
            global::OpenRouter.InternChatErrorMetadataReason reason,
            bool retryable)
        {
            this.Reason = reason;
            this.Retryable = retryable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatErrorMetadata" /> class.
        /// </summary>
        public InternChatErrorMetadata()
        {
        }

    }
}