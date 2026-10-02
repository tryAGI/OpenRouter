
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// One `data:` line of the stream. A run streams a role chunk, content and reasoning chunks, then a finish chunk: `stop`, `tool_calls` (the run is paused for input) or `error` (with an `error` object). A final chunk with empty `choices` follows in every case, carrying `session_id` and `usage` (`null` unless the daemon reported usage, and always `null` after `tool_calls`). Every stream ends with `[DONE]`.<br/>
    /// Example: {"choices":[{"delta":{"content":"Hello"},"finish_reason":null,"index":0}],"created":1789537541,"id":"chatcmpl-f727571a-3bad-4e0d-8a9e-f18f8cda9750","model":"openrouter/intern","object":"chat.completion.chunk"}
    /// </summary>
    public sealed partial class InternChatCompletionChunk
    {
        /// <summary>
        /// One choice on content, tool-call and error chunks. Empty on the final chunk that carries `session_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.InternChatChoice> Choices { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Created { get; set; }

        /// <summary>
        /// A failure after the response headers were sent. The chunk that carries it has `finish_reason: "error"`, then the final empty-`choices` chunk and `[DONE]` follow. Reasons here are `attachment_failed`, `busy`, `client_closed_request`, `interaction_not_pending`, `interaction_unknown`, `intern_unreachable`, `run_ended`, `stream_severed`, `timeout` or `turn_failed`. `run_ended` reports an ending the intern confirmed, such as a cancellation or a deadline, while `stream_severed` reports a connection lost without that confirmation.<br/>
        /// Example: {"code":502,"message":"The intern could not continue this run.","metadata":{"reason":"attachment_failed","retryable":false}}
        /// </summary>
        /// <example>{"code":502,"message":"The intern could not continue this run.","metadata":{"reason":"attachment_failed","retryable":false}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::OpenRouter.InternChatStreamError? Error { get; set; }

        /// <summary>
        /// The completion id, constant for the whole response.<br/>
        /// Example: chatcmpl-f727571a-3bad-4e0d-8a9e-f18f8cda9750
        /// </summary>
        /// <example>chatcmpl-f727571a-3bad-4e0d-8a9e-f18f8cda9750</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The runtime's identifier for the model the intern is running, as the intern reports it. Each chunk carries the model from the event behind it: `openrouter/intern` on chunks emitted before the intern has reported one and on chunks the API emits itself (timeout, run-ended and severed-stream errors and their final usage chunk), even after an earlier chunk named a model. It can change within a stream. It is not an OpenRouter model slug, and the request `model` is never used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InternChatCompletionChunkObjectJsonConverter))]
        public global::OpenRouter.InternChatCompletionChunkObject Object { get; set; }

        /// <summary>
        /// On the final chunk of every response, the daemon session to continue with, or `null` when the run failed before the intern reported one. Send it as `session_id` on the next request, including the `tool` reply to an interaction. Session ids are client-visible and scoped to the intern's own daemon.<br/>
        /// Example: ses_7f3c9a
        /// </summary>
        /// <example>ses_7f3c9a</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Token usage for the run as the daemon reported it, on the final chunk before `[DONE]`. `null` when the daemon reported none, and always `null` after `tool_calls` because the turn is not over.<br/>
        /// Example: {"completion_tokens":12,"prompt_tokens":40,"total_tokens":52}
        /// </summary>
        /// <example>{"completion_tokens":12,"prompt_tokens":40,"total_tokens":52}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::OpenRouter.InternChatUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatCompletionChunk" /> class.
        /// </summary>
        /// <param name="choices">
        /// One choice on content, tool-call and error chunks. Empty on the final chunk that carries `session_id`.
        /// </param>
        /// <param name="created"></param>
        /// <param name="id">
        /// The completion id, constant for the whole response.<br/>
        /// Example: chatcmpl-f727571a-3bad-4e0d-8a9e-f18f8cda9750
        /// </param>
        /// <param name="model">
        /// The runtime's identifier for the model the intern is running, as the intern reports it. Each chunk carries the model from the event behind it: `openrouter/intern` on chunks emitted before the intern has reported one and on chunks the API emits itself (timeout, run-ended and severed-stream errors and their final usage chunk), even after an earlier chunk named a model. It can change within a stream. It is not an OpenRouter model slug, and the request `model` is never used.
        /// </param>
        /// <param name="error">
        /// A failure after the response headers were sent. The chunk that carries it has `finish_reason: "error"`, then the final empty-`choices` chunk and `[DONE]` follow. Reasons here are `attachment_failed`, `busy`, `client_closed_request`, `interaction_not_pending`, `interaction_unknown`, `intern_unreachable`, `run_ended`, `stream_severed`, `timeout` or `turn_failed`. `run_ended` reports an ending the intern confirmed, such as a cancellation or a deadline, while `stream_severed` reports a connection lost without that confirmation.<br/>
        /// Example: {"code":502,"message":"The intern could not continue this run.","metadata":{"reason":"attachment_failed","retryable":false}}
        /// </param>
        /// <param name="object"></param>
        /// <param name="sessionId">
        /// On the final chunk of every response, the daemon session to continue with, or `null` when the run failed before the intern reported one. Send it as `session_id` on the next request, including the `tool` reply to an interaction. Session ids are client-visible and scoped to the intern's own daemon.<br/>
        /// Example: ses_7f3c9a
        /// </param>
        /// <param name="usage">
        /// Token usage for the run as the daemon reported it, on the final chunk before `[DONE]`. `null` when the daemon reported none, and always `null` after `tool_calls` because the turn is not over.<br/>
        /// Example: {"completion_tokens":12,"prompt_tokens":40,"total_tokens":52}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternChatCompletionChunk(
            global::System.Collections.Generic.IList<global::OpenRouter.InternChatChoice> choices,
            int created,
            string id,
            string model,
            global::OpenRouter.InternChatStreamError? error,
            global::OpenRouter.InternChatCompletionChunkObject @object,
            string? sessionId,
            global::OpenRouter.InternChatUsage? usage)
        {
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.Created = created;
            this.Error = error;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Object = @object;
            this.SessionId = sessionId;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatCompletionChunk" /> class.
        /// </summary>
        public InternChatCompletionChunk()
        {
        }

    }
}