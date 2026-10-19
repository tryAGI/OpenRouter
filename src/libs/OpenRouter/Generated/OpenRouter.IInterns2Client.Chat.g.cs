#nullable enable

namespace OpenRouter
{
    public partial interface IInterns2Client
    {
        /// <summary>
        /// Stream a chat completion with an intern<br/>
        /// Sends a prompt to one of your interns and streams the reply as OpenAI-compatible server-sent events ending with `[DONE]`. The run executes on the intern, which may pause to ask you something. It then streams one `openrouter.provide_input` tool call and finishes with `finish_reason: "tool_calls"`, and the run stays open on the intern.<br/>
        /// Every response, whether it ends with `stop`, `tool_calls` or `error`, is followed by a final chunk with empty `choices` that carries `session_id`, then `data: [DONE]`. That chunk carries the `usage` the intern reported for the run, after `stop` or `error`, and `null` when the intern reported none. After `tool_calls` its `usage` is `null` because the turn is not over. Read through `[DONE]`: the `session_id` you need to reply arrives after the `tool_calls` finish chunk.<br/>
        /// To answer, send a second request with the same `session_id`, the assistant message echoing that tool call, and a `tool` message whose `tool_call_id` is the tool call id and whose `content` is the answer. The answer is delivered to the run that asked and the stream continues from where it paused. A question stays open for its interaction deadline (5 minutes by default) and the run is cancelled when that passes. Rejected replies do not extend the deadline.<br/>
        /// Closing the connection after the `[DONE]` that follows `finish_reason: "tool_calls"` keeps the run alive. Disconnecting while a response is still streaming cancels the run. The stream writes a `: keepalive` comment whenever nothing else has been written for 30 seconds, so a disconnect is noticed within that interval even while the intern is silent.<br/>
        /// A run the intern ends while you are still connected, by cancellation or by a deadline, ends the stream with a `finish_reason: "error"` chunk carrying `410` and reason `run_ended`, then the final empty-`choices` chunk and `[DONE]`. That error reports only an ending the intern confirmed. A connection that breaks without that confirmation ends with reason `stream_severed`, and a client that has already disconnected is promised no final event.<br/>
        /// Set `approval_mode` to `manual` to have the intern ask before approval-bearing tools such as the shell. Omitted, the run self-drives and consents on your behalf. The mode belongs to the run started by that prompt and must be repeated on later prompts.<br/>
        /// Available to interns programme members. Callers outside the programme receive `404` for every path under `/api/v1/interns`.
        /// </summary>
        /// <param name="internId">
        /// The intern to talk to.<br/>
        /// Example: a11e0000-0000-4000-8000-000000000005
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.InternChatSteeredResponse> ChatAsync(
            string internId,

            global::OpenRouter.InternChatCompletionRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream a chat completion with an intern<br/>
        /// Sends a prompt to one of your interns and streams the reply as OpenAI-compatible server-sent events ending with `[DONE]`. The run executes on the intern, which may pause to ask you something. It then streams one `openrouter.provide_input` tool call and finishes with `finish_reason: "tool_calls"`, and the run stays open on the intern.<br/>
        /// Every response, whether it ends with `stop`, `tool_calls` or `error`, is followed by a final chunk with empty `choices` that carries `session_id`, then `data: [DONE]`. That chunk carries the `usage` the intern reported for the run, after `stop` or `error`, and `null` when the intern reported none. After `tool_calls` its `usage` is `null` because the turn is not over. Read through `[DONE]`: the `session_id` you need to reply arrives after the `tool_calls` finish chunk.<br/>
        /// To answer, send a second request with the same `session_id`, the assistant message echoing that tool call, and a `tool` message whose `tool_call_id` is the tool call id and whose `content` is the answer. The answer is delivered to the run that asked and the stream continues from where it paused. A question stays open for its interaction deadline (5 minutes by default) and the run is cancelled when that passes. Rejected replies do not extend the deadline.<br/>
        /// Closing the connection after the `[DONE]` that follows `finish_reason: "tool_calls"` keeps the run alive. Disconnecting while a response is still streaming cancels the run. The stream writes a `: keepalive` comment whenever nothing else has been written for 30 seconds, so a disconnect is noticed within that interval even while the intern is silent.<br/>
        /// A run the intern ends while you are still connected, by cancellation or by a deadline, ends the stream with a `finish_reason: "error"` chunk carrying `410` and reason `run_ended`, then the final empty-`choices` chunk and `[DONE]`. That error reports only an ending the intern confirmed. A connection that breaks without that confirmation ends with reason `stream_severed`, and a client that has already disconnected is promised no final event.<br/>
        /// Set `approval_mode` to `manual` to have the intern ask before approval-bearing tools such as the shell. Omitted, the run self-drives and consents on your behalf. The mode belongs to the run started by that prompt and must be repeated on later prompts.<br/>
        /// Available to interns programme members. Callers outside the programme receive `404` for every path under `/api/v1/interns`.
        /// </summary>
        /// <param name="internId">
        /// The intern to talk to.<br/>
        /// Example: a11e0000-0000-4000-8000-000000000005
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.InternChatSteeredResponse>> ChatAsResponseAsync(
            string internId,

            global::OpenRouter.InternChatCompletionRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream a chat completion with an intern<br/>
        /// Sends a prompt to one of your interns and streams the reply as OpenAI-compatible server-sent events ending with `[DONE]`. The run executes on the intern, which may pause to ask you something. It then streams one `openrouter.provide_input` tool call and finishes with `finish_reason: "tool_calls"`, and the run stays open on the intern.<br/>
        /// Every response, whether it ends with `stop`, `tool_calls` or `error`, is followed by a final chunk with empty `choices` that carries `session_id`, then `data: [DONE]`. That chunk carries the `usage` the intern reported for the run, after `stop` or `error`, and `null` when the intern reported none. After `tool_calls` its `usage` is `null` because the turn is not over. Read through `[DONE]`: the `session_id` you need to reply arrives after the `tool_calls` finish chunk.<br/>
        /// To answer, send a second request with the same `session_id`, the assistant message echoing that tool call, and a `tool` message whose `tool_call_id` is the tool call id and whose `content` is the answer. The answer is delivered to the run that asked and the stream continues from where it paused. A question stays open for its interaction deadline (5 minutes by default) and the run is cancelled when that passes. Rejected replies do not extend the deadline.<br/>
        /// Closing the connection after the `[DONE]` that follows `finish_reason: "tool_calls"` keeps the run alive. Disconnecting while a response is still streaming cancels the run. The stream writes a `: keepalive` comment whenever nothing else has been written for 30 seconds, so a disconnect is noticed within that interval even while the intern is silent.<br/>
        /// A run the intern ends while you are still connected, by cancellation or by a deadline, ends the stream with a `finish_reason: "error"` chunk carrying `410` and reason `run_ended`, then the final empty-`choices` chunk and `[DONE]`. That error reports only an ending the intern confirmed. A connection that breaks without that confirmation ends with reason `stream_severed`, and a client that has already disconnected is promised no final event.<br/>
        /// Set `approval_mode` to `manual` to have the intern ask before approval-bearing tools such as the shell. Omitted, the run self-drives and consents on your behalf. The mode belongs to the run started by that prompt and must be repeated on later prompts.<br/>
        /// Available to interns programme members. Callers outside the programme receive `404` for every path under `/api/v1/interns`.
        /// </summary>
        /// <param name="internId">
        /// The intern to talk to.<br/>
        /// Example: a11e0000-0000-4000-8000-000000000005
        /// </param>
        /// <param name="approvalMode">
        /// How the run started by this prompt handles tool approvals. `self-drive` (the default when omitted) consents on your behalf and runs the shell unsandboxed. `manual` asks you before an approval-bearing tool runs, as an `openrouter.provide_input` permission request, and keeps the shell sandboxed until an escalation is allowed. The mode applies to the run this prompt starts and is not remembered by the session. Repeat it on each new prompt that should use it. A `tool` reply continues the run under the mode it started with.<br/>
        /// Example: manual
        /// </param>
        /// <param name="messages">
        /// The conversation. Only the last message is read. A last `user` message starts a run. A last `tool` message answers the interaction named by its `tool_call_id` and requires `session_id`.
        /// </param>
        /// <param name="model">
        /// Accepted for OpenAI compatibility and never used. The intern runs the model configured on it (`PATCH` the intern to change it). Streamed chunks report the runtime's identifier for that model as the intern reports it, or `openrouter/intern` on chunks whose event carries no model (before the intern reports one, and on the chunks the API emits itself: the timeout, run-ended and severed-stream error chunks, the stop chunk of a replay that ends without a terminal daemon event, and the final usage chunk after any of them). A usage chunk that follows a daemon completion event carries the model the intern reported.<br/>
        /// Example: openrouter/intern
        /// </param>
        /// <param name="sessionId">
        /// The daemon session to continue, as returned in `session_id` on the final chunk of an earlier response. Omit it to start a new session. An id the intern has not seen before is not an error: it starts a new session under that id, so a mistyped id forks the conversation. Sessions are scoped to the intern's own daemon. Required when the last message has role `tool`.<br/>
        /// Example: ses_7f3c9a
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.InternChatSteeredResponse> ChatAsync(
            string internId,
            global::System.Collections.Generic.IList<global::OpenRouter.InternChatMessage> messages,
            global::OpenRouter.InternApprovalMode? approvalMode = default,
            string? model = default,
            string? sessionId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}