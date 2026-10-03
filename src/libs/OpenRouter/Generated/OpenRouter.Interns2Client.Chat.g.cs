
#nullable enable

namespace OpenRouter
{
    public partial class Interns2Client
    {


        private static readonly global::OpenRouter.EndPointSecurityRequirement s_ChatSecurityRequirement0 =
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
        private static readonly global::OpenRouter.EndPointSecurityRequirement[] s_ChatSecurityRequirements =
            new global::OpenRouter.EndPointSecurityRequirement[]
            {                s_ChatSecurityRequirement0,
            };
        partial void PrepareChatArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string internId,
            global::OpenRouter.InternChatCompletionRequest request);
        partial void PrepareChatRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string internId,
            global::OpenRouter.InternChatCompletionRequest request);
        partial void ProcessChatResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessChatResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::OpenRouter.InternChatCompletionChunk> ChatAsync(
            string internId,

            global::OpenRouter.InternChatCompletionRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ChatAsResponseAsync(
                internId: internId,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
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
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.InternChatCompletionChunk>> ChatAsResponseAsync(
            string internId,

            global::OpenRouter.InternChatCompletionRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            request = new global::OpenRouter.InternChatCompletionRequest
            {
                ApprovalMode = request.ApprovalMode,
                Messages = request.Messages,
                Model = request.Model,
                SessionId = request.SessionId,
                Stream = false,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareChatArguments(
                httpClient: HttpClient,
                internId: ref internId,
                request: request);


            var __authorizations = global::OpenRouter.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ChatSecurityRequirements,
                operationName: "ChatAsync");

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
                    "application/json");

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
                PrepareChatRequest(
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
                                operationId: "Chat",
                                methodName: "ChatAsync",
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
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
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
                                operationId: "Chat",
                                methodName: "ChatAsync",
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
                                operationId: "Chat",
                                methodName: "ChatAsync",
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
                ProcessChatResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::OpenRouter.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::OpenRouter.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Chat",
                                methodName: "ChatAsync",
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
                                operationId: "Chat",
                                methodName: "ChatAsync",
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
                            // The body is not a valid request (`bad_request`), or the intern did not accept the answer for the pending question, such as a permission option it did not offer.
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::OpenRouter.InternChatErrorResponse? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::OpenRouter.InternChatErrorResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::OpenRouter.InternChatErrorResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::OpenRouter.ApiException<global::OpenRouter.InternChatErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // No valid API key.
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::OpenRouter.InternChatErrorResponse? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::OpenRouter.InternChatErrorResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::OpenRouter.InternChatErrorResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::OpenRouter.ApiException<global::OpenRouter.InternChatErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    responseBody: __content_401,
                                    responseObject: __value_401,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // The key belongs to a member who has left the organization and holds no grant.
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                global::OpenRouter.InternChatErrorResponse? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::OpenRouter.InternChatErrorResponse.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::OpenRouter.InternChatErrorResponse.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }


                                throw global::OpenRouter.ApiException<global::OpenRouter.InternChatErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    responseBody: __content_403,
                                    responseObject: __value_403,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // The caller is outside the interns programme, the intern does not exist for this key (`not_found`), or no pending question has this `tool_call_id` in this session (`interaction_unknown`).
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                global::OpenRouter.InternChatErrorResponse? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::OpenRouter.InternChatErrorResponse.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::OpenRouter.InternChatErrorResponse.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::OpenRouter.ApiException<global::OpenRouter.InternChatErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseObject: __value_404,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // The request exceeded the route's own deadline before the handler answered (`timeout`). Distinct from the 504, which is the intern failing to answer within the turn budget.
                            if ((int)__response.StatusCode == 408)
                            {
                                string? __content_408 = null;
                                global::System.Exception? __exception_408 = null;
                                global::OpenRouter.InternChatErrorResponse? __value_408 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_408 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_408 = global::OpenRouter.InternChatErrorResponse.FromJson(__content_408, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_408 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_408 = global::OpenRouter.InternChatErrorResponse.FromJson(__content_408, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_408 = __ex;
                                }


                                throw global::OpenRouter.ApiException<global::OpenRouter.InternChatErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_408 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_408,
                                    responseBody: __content_408,
                                    responseObject: __value_408,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // The intern is not running (`intern_not_ready`), a turn is already running in this session and did not take the message within 15 seconds (`busy`, also sent when the turn is waiting on a question of its own), the question is no longer waiting (`interaction_not_pending`), or another request is already attached to the run (`attachment_failed`). Turns in different sessions on the same intern run in parallel. `intern_not_ready` and `busy` report `retryable: true`, and a `busy` refusal carries `Retry-After`.
                            if ((int)__response.StatusCode == 409)
                            {
                                string? __content_409 = null;
                                global::System.Exception? __exception_409 = null;
                                global::OpenRouter.InternChatErrorResponse? __value_409 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_409 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_409 = global::OpenRouter.InternChatErrorResponse.FromJson(__content_409, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_409 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_409 = global::OpenRouter.InternChatErrorResponse.FromJson(__content_409, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_409 = __ex;
                                }


                                throw global::OpenRouter.ApiException<global::OpenRouter.InternChatErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_409 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_409,
                                    responseBody: __content_409,
                                    responseObject: __value_409,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // The run produced more output than the intern retains, so the paused stream cannot be resumed (`attachment_failed`).
                            if ((int)__response.StatusCode == 410)
                            {
                                string? __content_410 = null;
                                global::System.Exception? __exception_410 = null;
                                global::OpenRouter.InternChatErrorResponse? __value_410 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_410 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_410 = global::OpenRouter.InternChatErrorResponse.FromJson(__content_410, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_410 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_410 = global::OpenRouter.InternChatErrorResponse.FromJson(__content_410, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_410 = __ex;
                                }


                                throw global::OpenRouter.ApiException<global::OpenRouter.InternChatErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_410 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_410,
                                    responseBody: __content_410,
                                    responseObject: __value_410,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // The body exceeds 1 MiB (`payload_too_large`).
                            if ((int)__response.StatusCode == 413)
                            {
                                string? __content_413 = null;
                                global::System.Exception? __exception_413 = null;
                                global::OpenRouter.InternChatErrorResponse? __value_413 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_413 = global::OpenRouter.InternChatErrorResponse.FromJson(__content_413, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_413 = global::OpenRouter.InternChatErrorResponse.FromJson(__content_413, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_413 = __ex;
                                }


                                throw global::OpenRouter.ApiException<global::OpenRouter.InternChatErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_413 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_413,
                                    responseBody: __content_413,
                                    responseObject: __value_413,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Too many turns for the user or organization this key acts as (`rate_limited`). It reports `retryable: true` and carries `Retry-After`.
                            if ((int)__response.StatusCode == 429)
                            {
                                string? __content_429 = null;
                                global::System.Exception? __exception_429 = null;
                                global::OpenRouter.InternChatErrorResponse? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::OpenRouter.InternChatErrorResponse.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::OpenRouter.InternChatErrorResponse.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }


                                throw global::OpenRouter.ApiException<global::OpenRouter.InternChatErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_429,
                                    responseBody: __content_429,
                                    responseObject: __value_429,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // The intern could not be reached or rejected the request (`intern_unreachable`, `intern_rejected`), the intern refused the turn before any output (`turn_failed`), or its stream ended before the turn started (`stream_severed`). `intern_unreachable` and `stream_severed` are transient and report `retryable: true`; `intern_rejected` reports `false`. A `turn_failed` varies by failure and carries the intern's own classification of what went wrong, so read `metadata.retryable` rather than assuming from the reason.
                            if ((int)__response.StatusCode == 502)
                            {
                                string? __content_502 = null;
                                global::System.Exception? __exception_502 = null;
                                global::OpenRouter.InternChatErrorResponse? __value_502 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_502 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_502 = global::OpenRouter.InternChatErrorResponse.FromJson(__content_502, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_502 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_502 = global::OpenRouter.InternChatErrorResponse.FromJson(__content_502, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_502 = __ex;
                                }


                                throw global::OpenRouter.ApiException<global::OpenRouter.InternChatErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_502 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_502,
                                    responseBody: __content_502,
                                    responseObject: __value_502,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // The intern cannot hold another run open across a question right now (`busy`). It reports `retryable: true` and carries `Retry-After`.
                            if ((int)__response.StatusCode == 503)
                            {
                                string? __content_503 = null;
                                global::System.Exception? __exception_503 = null;
                                global::OpenRouter.InternChatErrorResponse? __value_503 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_503 = global::OpenRouter.InternChatErrorResponse.FromJson(__content_503, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_503 = global::OpenRouter.InternChatErrorResponse.FromJson(__content_503, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_503 = __ex;
                                }


                                throw global::OpenRouter.ApiException<global::OpenRouter.InternChatErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_503 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_503,
                                    responseBody: __content_503,
                                    responseObject: __value_503,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // The intern did not answer within the request budget (`timeout`).
                            if ((int)__response.StatusCode == 504)
                            {
                                string? __content_504 = null;
                                global::System.Exception? __exception_504 = null;
                                global::OpenRouter.InternChatErrorResponse? __value_504 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_504 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_504 = global::OpenRouter.InternChatErrorResponse.FromJson(__content_504, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_504 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_504 = global::OpenRouter.InternChatErrorResponse.FromJson(__content_504, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_504 = __ex;
                                }


                                throw global::OpenRouter.ApiException<global::OpenRouter.InternChatErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_504 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_504,
                                    responseBody: __content_504,
                                    responseObject: __value_504,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessChatResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::OpenRouter.InternChatCompletionChunk.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.InternChatCompletionChunk>(
                                        statusCode: __response.StatusCode,
                                        headers: global::OpenRouter.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
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
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::OpenRouter.InternChatCompletionChunk.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.InternChatCompletionChunk>(
                                        statusCode: __response.StatusCode,
                                        headers: global::OpenRouter.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
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
        public async global::System.Threading.Tasks.Task<global::OpenRouter.InternChatCompletionChunk> ChatAsync(
            string internId,
            global::System.Collections.Generic.IList<global::OpenRouter.InternChatMessage> messages,
            global::OpenRouter.InternApprovalMode? approvalMode = default,
            string? model = default,
            string? sessionId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::OpenRouter.InternChatCompletionRequest
            {
                ApprovalMode = approvalMode,
                Messages = messages,
                Model = model,
                SessionId = sessionId,
                Stream = false,
            };

            return await ChatAsync(
                internId: internId,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}