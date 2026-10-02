
#nullable enable

namespace OpenRouter
{
    public partial class Interns2Client
    {


        private static readonly global::OpenRouter.EndPointSecurityRequirement s_ChatAsStreamSecurityRequirement0 =
            new global::OpenRouter.EndPointSecurityRequirement
            {
                Authorizations = new global::OpenRouter.EndPointAuthorizationRequirement[]
                {                    new global::OpenRouter.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "Bearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::OpenRouter.EndPointSecurityRequirement[] s_ChatAsStreamSecurityRequirements =
            new global::OpenRouter.EndPointSecurityRequirement[]
            {                s_ChatAsStreamSecurityRequirement0,
            };
        partial void PrepareChatAsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string internId,
            global::OpenRouter.InternChatCompletionRequest request);
        partial void PrepareChatAsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string internId,
            global::OpenRouter.InternChatCompletionRequest request);
        partial void ProcessChatAsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

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
        public async global::System.Collections.Generic.IAsyncEnumerable<global::OpenRouter.InternChatStreamingResponse> ChatAsStreamAsync(
            string internId,

            global::OpenRouter.InternChatCompletionRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            request = new global::OpenRouter.InternChatCompletionRequest
            {
                ApprovalMode = request.ApprovalMode,
                Messages = request.Messages,
                Model = request.Model,
                SessionId = request.SessionId,
                Stream = true,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareChatAsStreamArguments(
                httpClient: HttpClient,
                internId: ref internId,
                request: request);


            var __authorizations = global::OpenRouter.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ChatAsStreamSecurityRequirements,
                operationName: "ChatAsStreamAsync");

            using var __timeoutCancellationTokenSource = global::OpenRouter.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::OpenRouter.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::OpenRouter.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::OpenRouter.PathBuilder(
                                path: $"/interns/{internId}/chat/completions",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::OpenRouter.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

                __httpRequest.Headers.TryAddWithoutValidation(
                    "Accept",
                    "text/event-stream");

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::OpenRouter.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareChatAsStreamRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    internId: internId,
                    request: request);

                global::OpenRouter.AutoSDKHttpRequestOptions.StampAuthorizationOverride(__httpRequest);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::OpenRouter.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::OpenRouter.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ChatAsStream",
                                methodName: "ChatAsStreamAsync",
                                pathTemplate: "$\"/interns/{internId}/chat/completions\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::OpenRouter.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::OpenRouter.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::OpenRouter.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ChatAsStream",
                                methodName: "ChatAsStreamAsync",
                                pathTemplate: "$\"/interns/{internId}/chat/completions\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::OpenRouter.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::OpenRouter.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::OpenRouter.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::OpenRouter.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::OpenRouter.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ChatAsStream",
                                methodName: "ChatAsStreamAsync",
                                pathTemplate: "$\"/interns/{internId}/chat/completions\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::OpenRouter.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessChatAsStreamResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::OpenRouter.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::OpenRouter.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ChatAsStream",
                                methodName: "ChatAsStreamAsync",
                                pathTemplate: "$\"/interns/{internId}/chat/completions\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::OpenRouter.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::OpenRouter.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ChatAsStream",
                                methodName: "ChatAsStreamAsync",
                                pathTemplate: "$\"/interns/{internId}/chat/completions\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            try
                            {
                                __response.EnsureSuccessStatusCode();
                            }
                            catch (global::System.Net.Http.HttpRequestException __ex)
                            {
                                string? __content = null;
                                try
                                {
                                    __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);
                                }
                                catch (global::System.Exception)
                                {
                                }

                                throw global::OpenRouter.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __ex,
                                    responseBody: __content,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            using var __stream = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                __effectiveCancellationToken
                #endif
                            ).ConfigureAwait(false);

                            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                                .Create(__stream).EnumerateAsync(__effectiveCancellationToken))
                            {
                                var __content = __sseEvent.Data;
                                if (__content == "[DONE]")
                                {
                                    yield break;
                                }

                                var __streamedResponse = global::OpenRouter.InternChatStreamingResponse.FromJson(__content, JsonSerializerContext) ??
                                                       throw global::OpenRouter.ApiException.Create(
                                                           statusCode: __response.StatusCode,
                                                           message: $"Response deserialization failed for \"{__content}\" ",
                                                           innerException: null,
                                                           responseBody: __content,
                                                           responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                                               __response.Headers,
                                                               h => h.Key,
                                                               h => h.Value));

                                yield return __streamedResponse;
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
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
        public async global::System.Collections.Generic.IAsyncEnumerable<global::OpenRouter.InternChatStreamingResponse> ChatAsStreamAsync(
            string internId,
            global::System.Collections.Generic.IList<global::OpenRouter.InternChatMessage> messages,
            global::OpenRouter.InternApprovalMode? approvalMode = default,
            string? model = default,
            string? sessionId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::OpenRouter.InternChatCompletionRequest
            {
                ApprovalMode = approvalMode,
                Messages = messages,
                Model = model,
                SessionId = sessionId,
                Stream = true,
            };

            var __enumerable = ChatAsStreamAsync(
                internId: internId,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}