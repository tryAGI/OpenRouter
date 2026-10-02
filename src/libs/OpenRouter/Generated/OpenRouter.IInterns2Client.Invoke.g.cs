#nullable enable

namespace OpenRouter
{
    public partial interface IInterns2Client
    {
        /// <summary>
        /// Start an intern run without waiting for it<br/>
        /// Starts a run on one of your interns and answers `202` with the `session_id` as soon as the intern accepts it. The run keeps going on the intern after the response. Nothing about its progress comes back on this request; the intern reports through its own tools, such as Slack.<br/>
        /// Send the same `session_id` later to continue the conversation, for example to hand the intern a decision on work it started. If that session already has a run going, the prompt is delivered into it and the status is `steered`. A `session_id` is accepted only from the caller it was issued to, on the same intern; any other, including sessions started from Slack or the chat endpoint, is refused with `404`.<br/>
        /// Runs started here self-drive: the intern consents to its own tool approvals, and a question it asks is answered by its own fallback. A run ends when the intern finishes it or after its execution deadline (1 hour by default).<br/>
        /// Available to interns programme members. Callers outside the programme receive `404` for every path under `/api/v1/interns`.
        /// </summary>
        /// <param name="internId">
        /// The intern to run.<br/>
        /// Example: a11e0000-0000-4000-8000-000000000005
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.InternInvokeAcceptedResponse> InvokeAsync(
            string internId,

            global::OpenRouter.InternInvokeRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start an intern run without waiting for it<br/>
        /// Starts a run on one of your interns and answers `202` with the `session_id` as soon as the intern accepts it. The run keeps going on the intern after the response. Nothing about its progress comes back on this request; the intern reports through its own tools, such as Slack.<br/>
        /// Send the same `session_id` later to continue the conversation, for example to hand the intern a decision on work it started. If that session already has a run going, the prompt is delivered into it and the status is `steered`. A `session_id` is accepted only from the caller it was issued to, on the same intern; any other, including sessions started from Slack or the chat endpoint, is refused with `404`.<br/>
        /// Runs started here self-drive: the intern consents to its own tool approvals, and a question it asks is answered by its own fallback. A run ends when the intern finishes it or after its execution deadline (1 hour by default).<br/>
        /// Available to interns programme members. Callers outside the programme receive `404` for every path under `/api/v1/interns`.
        /// </summary>
        /// <param name="internId">
        /// The intern to run.<br/>
        /// Example: a11e0000-0000-4000-8000-000000000005
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.InternInvokeAcceptedResponse>> InvokeAsResponseAsync(
            string internId,

            global::OpenRouter.InternInvokeRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start an intern run without waiting for it<br/>
        /// Starts a run on one of your interns and answers `202` with the `session_id` as soon as the intern accepts it. The run keeps going on the intern after the response. Nothing about its progress comes back on this request; the intern reports through its own tools, such as Slack.<br/>
        /// Send the same `session_id` later to continue the conversation, for example to hand the intern a decision on work it started. If that session already has a run going, the prompt is delivered into it and the status is `steered`. A `session_id` is accepted only from the caller it was issued to, on the same intern; any other, including sessions started from Slack or the chat endpoint, is refused with `404`.<br/>
        /// Runs started here self-drive: the intern consents to its own tool approvals, and a question it asks is answered by its own fallback. A run ends when the intern finishes it or after its execution deadline (1 hour by default).<br/>
        /// Available to interns programme members. Callers outside the programme receive `404` for every path under `/api/v1/interns`.
        /// </summary>
        /// <param name="internId">
        /// The intern to run.<br/>
        /// Example: a11e0000-0000-4000-8000-000000000005
        /// </param>
        /// <param name="input">
        /// The prompt for the run, at most 32000 characters.<br/>
        /// Example: New support ticket 48213. Case token: ct_9f2c. Investigate and reply.
        /// </param>
        /// <param name="sessionId">
        /// The session to run in. Send the `session_id` from an earlier `202` to continue that conversation, for example to hand the intern a decision on a case it is working. Omit it to start a new session. Only a `session_id` this endpoint issued to the same caller on the same intern is accepted; any other is refused with `404`.<br/>
        /// Example: b51a0e21-368b-4780-a220-14655bf28c55
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.InternInvokeAcceptedResponse> InvokeAsync(
            string internId,
            string input,
            string? sessionId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}