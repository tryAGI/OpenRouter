
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An OpenAI-compatible streaming chat completion request for one intern. Other OpenAI fields such as `temperature` or `tools` are ignored. The intern owns its sampling and its tools.<br/>
    /// Example: {"approval_mode":"manual","messages":[{"content":"Summarize the open pull requests.","role":"user"}],"stream":true}
    /// </summary>
    public sealed partial class InternChatCompletionRequest
    {
        /// <summary>
        /// How the run started by this prompt handles tool approvals. `self-drive` (the default when omitted) consents on your behalf and runs the shell unsandboxed. `manual` asks you before an approval-bearing tool runs, as an `openrouter.provide_input` permission request, and keeps the shell sandboxed until an escalation is allowed. The mode applies to the run this prompt starts and is not remembered by the session. Repeat it on each new prompt that should use it. A `tool` reply continues the run under the mode it started with.<br/>
        /// Example: manual
        /// </summary>
        /// <example>manual</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("approval_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InternApprovalModeJsonConverter))]
        public global::OpenRouter.InternApprovalMode? ApprovalMode { get; set; }

        /// <summary>
        /// The conversation. Only the last message is read. A last `user` message starts a run. A last `tool` message answers the interaction named by its `tool_call_id` and requires `session_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.InternChatMessage> Messages { get; set; }

        /// <summary>
        /// Accepted for OpenAI compatibility and never used. The intern runs the model configured on it (`PATCH` the intern to change it). Streamed chunks report the runtime's identifier for that model as the intern reports it, or `openrouter/intern` on chunks whose event carries no model (before the intern reports one, and on the chunks the API emits itself: the timeout, run-ended and severed-stream error chunks, the stop chunk of a replay that ends without a terminal daemon event, and the final usage chunk after any of them). A usage chunk that follows a daemon completion event carries the model the intern reported.<br/>
        /// Example: openrouter/intern
        /// </summary>
        /// <example>openrouter/intern</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The daemon session to continue, as returned in `session_id` on the final chunk of an earlier response. Omit it to start a new session. An id the intern has not seen before is not an error: it starts a new session under that id, so a mistyped id forks the conversation. Sessions are scoped to the intern's own daemon. Required when the last message has role `tool`.<br/>
        /// Example: ses_7f3c9a
        /// </summary>
        /// <example>ses_7f3c9a</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Must be `true`. This endpoint only streams. `false` or an omitted `stream` is refused with `400` and reason `bad_request`.<br/>
        /// Example: true
        /// </summary>
        /// <default>true</default>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool Stream { get; set; } = true;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatCompletionRequest" /> class.
        /// </summary>
        /// <param name="messages">
        /// The conversation. Only the last message is read. A last `user` message starts a run. A last `tool` message answers the interaction named by its `tool_call_id` and requires `session_id`.
        /// </param>
        /// <param name="approvalMode">
        /// How the run started by this prompt handles tool approvals. `self-drive` (the default when omitted) consents on your behalf and runs the shell unsandboxed. `manual` asks you before an approval-bearing tool runs, as an `openrouter.provide_input` permission request, and keeps the shell sandboxed until an escalation is allowed. The mode applies to the run this prompt starts and is not remembered by the session. Repeat it on each new prompt that should use it. A `tool` reply continues the run under the mode it started with.<br/>
        /// Example: manual
        /// </param>
        /// <param name="model">
        /// Accepted for OpenAI compatibility and never used. The intern runs the model configured on it (`PATCH` the intern to change it). Streamed chunks report the runtime's identifier for that model as the intern reports it, or `openrouter/intern` on chunks whose event carries no model (before the intern reports one, and on the chunks the API emits itself: the timeout, run-ended and severed-stream error chunks, the stop chunk of a replay that ends without a terminal daemon event, and the final usage chunk after any of them). A usage chunk that follows a daemon completion event carries the model the intern reported.<br/>
        /// Example: openrouter/intern
        /// </param>
        /// <param name="sessionId">
        /// The daemon session to continue, as returned in `session_id` on the final chunk of an earlier response. Omit it to start a new session. An id the intern has not seen before is not an error: it starts a new session under that id, so a mistyped id forks the conversation. Sessions are scoped to the intern's own daemon. Required when the last message has role `tool`.<br/>
        /// Example: ses_7f3c9a
        /// </param>
        /// <param name="stream">
        /// Must be `true`. This endpoint only streams. `false` or an omitted `stream` is refused with `400` and reason `bad_request`.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternChatCompletionRequest(
            global::System.Collections.Generic.IList<global::OpenRouter.InternChatMessage> messages,
            global::OpenRouter.InternApprovalMode? approvalMode,
            string? model,
            string? sessionId,
            bool stream = true)
        {
            this.ApprovalMode = approvalMode;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Model = model;
            this.SessionId = sessionId;
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatCompletionRequest" /> class.
        /// </summary>
        public InternChatCompletionRequest()
        {
        }

    }
}