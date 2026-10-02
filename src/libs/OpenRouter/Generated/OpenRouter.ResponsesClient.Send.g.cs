
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter
{
    public partial class ResponsesClient
    {


        private static readonly global::OpenRouter.EndPointSecurityRequirement s_SendSecurityRequirement0 =
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
        private static readonly global::OpenRouter.EndPointSecurityRequirement[] s_SendSecurityRequirements =
            new global::OpenRouter.EndPointSecurityRequirement[]
            {                s_SendSecurityRequirement0,
            };
        partial void PrepareSendArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::OpenRouter.MetadataLevel? xOpenRouterMetadata,
            global::OpenRouter.ResponsesRequest request);
        partial void PrepareSendRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::OpenRouter.MetadataLevel? xOpenRouterMetadata,
            global::OpenRouter.ResponsesRequest request);
        partial void ProcessSendResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSendResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a response<br/>
        /// Creates a streaming or non-streaming response using OpenResponses API format
        /// </summary>
        /// <param name="xOpenRouterMetadata">
        /// Opt-in level for surfacing routing metadata on the response under `openrouter_metadata`.<br/>
        /// Example: enabled
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenRouter.OpenResponsesResult> SendAsync(

            global::OpenRouter.ResponsesRequest request,
            global::OpenRouter.MetadataLevel? xOpenRouterMetadata = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await SendAsResponseAsync(

                request: request,
                xOpenRouterMetadata: xOpenRouterMetadata,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Create a response<br/>
        /// Creates a streaming or non-streaming response using OpenResponses API format
        /// </summary>
        /// <param name="xOpenRouterMetadata">
        /// Opt-in level for surfacing routing metadata on the response under `openrouter_metadata`.<br/>
        /// Example: enabled
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.OpenResponsesResult>> SendAsResponseAsync(

            global::OpenRouter.ResponsesRequest request,
            global::OpenRouter.MetadataLevel? xOpenRouterMetadata = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            request = new global::OpenRouter.ResponsesRequest
            {
                Background = request.Background,
                CacheControl = request.CacheControl,
                Debug = request.Debug,
                FrequencyPenalty = request.FrequencyPenalty,
                ImageConfig = request.ImageConfig,
                Include = request.Include,
                Input = request.Input,
                Instructions = request.Instructions,
                MaxOutputTokens = request.MaxOutputTokens,
                MaxToolCalls = request.MaxToolCalls,
                Metadata = request.Metadata,
                Modalities = request.Modalities,
                Model = request.Model,
                Models = request.Models,
                ParallelToolCalls = request.ParallelToolCalls,
                Plugins = request.Plugins,
                PresencePenalty = request.PresencePenalty,
                PreviousResponseId = request.PreviousResponseId,
                Prompt = request.Prompt,
                PromptCacheKey = request.PromptCacheKey,
                PromptCacheOptions = request.PromptCacheOptions,
                Provider = request.Provider,
                Reasoning = request.Reasoning,
                SafetyIdentifier = request.SafetyIdentifier,
                ServiceTier = request.ServiceTier,
                SessionId = request.SessionId,
                StopServerToolsWhen = request.StopServerToolsWhen,
                Store = request.Store,
                Stream = false,
                Temperature = request.Temperature,
                Text = request.Text,
                ToolChoice = request.ToolChoice,
                Tools = request.Tools,
                TopK = request.TopK,
                TopLogprobs = request.TopLogprobs,
                TopP = request.TopP,
                Trace = request.Trace,
                Truncation = request.Truncation,
                User = request.User,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareSendArguments(
                httpClient: HttpClient,
                xOpenRouterMetadata: ref xOpenRouterMetadata,
                request: request);


            var __authorizations = global::OpenRouter.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_SendSecurityRequirements,
                operationName: "SendAsync");

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
                                path: "/responses",
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

            if (xOpenRouterMetadata != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("X-OpenRouter-Metadata", xOpenRouterMetadata?.ToValueString() ?? string.Empty);
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
                PrepareSendRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    xOpenRouterMetadata: xOpenRouterMetadata,
                    request: request);

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
                                operationId: "Send",
                                methodName: "SendAsync",
                                pathTemplate: "\"/responses\"",
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
                                operationId: "Send",
                                methodName: "SendAsync",
                                pathTemplate: "\"/responses\"",
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
                                operationId: "Send",
                                methodName: "SendAsync",
                                pathTemplate: "\"/responses\"",
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
                ProcessSendResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::OpenRouter.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::OpenRouter.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Send",
                                methodName: "SendAsync",
                                pathTemplate: "\"/responses\"",
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
                                operationId: "Send",
                                methodName: "SendAsync",
                                pathTemplate: "\"/responses\"",
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
                            // Bad Request - Invalid request parameters or malformed input
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::OpenRouter.BadRequestResponse? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::OpenRouter.BadRequestResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::OpenRouter.BadRequestResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::OpenRouter.ApiException<global::OpenRouter.BadRequestResponse>.Create(
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
                            // Unauthorized - Authentication required or invalid credentials
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::OpenRouter.UnauthorizedResponse? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::OpenRouter.UnauthorizedResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::OpenRouter.UnauthorizedResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::OpenRouter.ApiException<global::OpenRouter.UnauthorizedResponse>.Create(
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
                            // Payment Required - Insufficient credits or quota to complete request
                            if ((int)__response.StatusCode == 402)
                            {
                                string? __content_402 = null;
                                global::System.Exception? __exception_402 = null;
                                global::OpenRouter.PaymentRequiredResponse? __value_402 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_402 = global::OpenRouter.PaymentRequiredResponse.FromJson(__content_402, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_402 = global::OpenRouter.PaymentRequiredResponse.FromJson(__content_402, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_402 = __ex;
                                }


                                throw global::OpenRouter.ApiException<global::OpenRouter.PaymentRequiredResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_402 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_402,
                                    responseBody: __content_402,
                                    responseObject: __value_402,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Forbidden - Authentication successful but insufficient permissions, or a guardrail blocked the request. When guardrails block and the `X-OpenRouter-Metadata: enabled` header is present, the response includes `openrouter_metadata` with full routing context and a `pipeline` array containing guardrail stage details.
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                global::OpenRouter.ForbiddenResponse? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::OpenRouter.ForbiddenResponse.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::OpenRouter.ForbiddenResponse.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }


                                throw global::OpenRouter.ApiException<global::OpenRouter.ForbiddenResponse>.Create(
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
                            // Not Found - Resource does not exist
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                global::OpenRouter.NotFoundResponse? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::OpenRouter.NotFoundResponse.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::OpenRouter.NotFoundResponse.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::OpenRouter.ApiException<global::OpenRouter.NotFoundResponse>.Create(
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
                            // Request Timeout - Operation exceeded time limit
                            if ((int)__response.StatusCode == 408)
                            {
                                string? __content_408 = null;
                                global::System.Exception? __exception_408 = null;
                                global::OpenRouter.RequestTimeoutResponse? __value_408 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_408 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_408 = global::OpenRouter.RequestTimeoutResponse.FromJson(__content_408, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_408 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_408 = global::OpenRouter.RequestTimeoutResponse.FromJson(__content_408, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_408 = __ex;
                                }


                                throw global::OpenRouter.ApiException<global::OpenRouter.RequestTimeoutResponse>.Create(
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
                            // Payload Too Large - Request payload exceeds size limits
                            if ((int)__response.StatusCode == 413)
                            {
                                string? __content_413 = null;
                                global::System.Exception? __exception_413 = null;
                                global::OpenRouter.PayloadTooLargeResponse? __value_413 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_413 = global::OpenRouter.PayloadTooLargeResponse.FromJson(__content_413, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_413 = global::OpenRouter.PayloadTooLargeResponse.FromJson(__content_413, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_413 = __ex;
                                }


                                throw global::OpenRouter.ApiException<global::OpenRouter.PayloadTooLargeResponse>.Create(
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
                            // Unprocessable Entity - Semantic validation failure
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::OpenRouter.UnprocessableEntityResponse? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::OpenRouter.UnprocessableEntityResponse.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::OpenRouter.UnprocessableEntityResponse.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }


                                throw global::OpenRouter.ApiException<global::OpenRouter.UnprocessableEntityResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseObject: __value_422,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Too Many Requests - Rate limit exceeded
                            if ((int)__response.StatusCode == 429)
                            {
                                string? __content_429 = null;
                                global::System.Exception? __exception_429 = null;
                                global::OpenRouter.TooManyRequestsResponse? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::OpenRouter.TooManyRequestsResponse.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::OpenRouter.TooManyRequestsResponse.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }


                                throw global::OpenRouter.ApiException<global::OpenRouter.TooManyRequestsResponse>.Create(
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
                            // Internal Server Error - Unexpected server error
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                global::OpenRouter.InternalServerResponse? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::OpenRouter.InternalServerResponse.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::OpenRouter.InternalServerResponse.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::OpenRouter.ApiException<global::OpenRouter.InternalServerResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    responseBody: __content_500,
                                    responseObject: __value_500,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Bad Gateway - Provider/upstream API failure
                            if ((int)__response.StatusCode == 502)
                            {
                                string? __content_502 = null;
                                global::System.Exception? __exception_502 = null;
                                global::OpenRouter.BadGatewayResponse? __value_502 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_502 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_502 = global::OpenRouter.BadGatewayResponse.FromJson(__content_502, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_502 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_502 = global::OpenRouter.BadGatewayResponse.FromJson(__content_502, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_502 = __ex;
                                }


                                throw global::OpenRouter.ApiException<global::OpenRouter.BadGatewayResponse>.Create(
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
                            // Service Unavailable - Service temporarily unavailable
                            if ((int)__response.StatusCode == 503)
                            {
                                string? __content_503 = null;
                                global::System.Exception? __exception_503 = null;
                                global::OpenRouter.ServiceUnavailableResponse? __value_503 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_503 = global::OpenRouter.ServiceUnavailableResponse.FromJson(__content_503, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_503 = global::OpenRouter.ServiceUnavailableResponse.FromJson(__content_503, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_503 = __ex;
                                }


                                throw global::OpenRouter.ApiException<global::OpenRouter.ServiceUnavailableResponse>.Create(
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
                            // Infrastructure Timeout - Provider request timed out at edge network
                            if ((int)__response.StatusCode == 524)
                            {
                                string? __content_524 = null;
                                global::System.Exception? __exception_524 = null;
                                global::OpenRouter.EdgeNetworkTimeoutResponse? __value_524 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_524 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_524 = global::OpenRouter.EdgeNetworkTimeoutResponse.FromJson(__content_524, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_524 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_524 = global::OpenRouter.EdgeNetworkTimeoutResponse.FromJson(__content_524, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_524 = __ex;
                                }


                                throw global::OpenRouter.ApiException<global::OpenRouter.EdgeNetworkTimeoutResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_524 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_524,
                                    responseBody: __content_524,
                                    responseObject: __value_524,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Provider Overloaded - Provider is temporarily overloaded
                            if ((int)__response.StatusCode == 529)
                            {
                                string? __content_529 = null;
                                global::System.Exception? __exception_529 = null;
                                global::OpenRouter.ProviderOverloadedResponse? __value_529 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_529 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_529 = global::OpenRouter.ProviderOverloadedResponse.FromJson(__content_529, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_529 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_529 = global::OpenRouter.ProviderOverloadedResponse.FromJson(__content_529, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_529 = __ex;
                                }


                                throw global::OpenRouter.ApiException<global::OpenRouter.ProviderOverloadedResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_529 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_529,
                                    responseBody: __content_529,
                                    responseObject: __value_529,
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
                                ProcessSendResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::OpenRouter.OpenResponsesResult.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.OpenResponsesResult>(
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

                                    var __value = await global::OpenRouter.OpenResponsesResult.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.OpenResponsesResult>(
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
        /// Create a response<br/>
        /// Creates a streaming or non-streaming response using OpenResponses API format
        /// </summary>
        /// <param name="xOpenRouterMetadata">
        /// Opt-in level for surfacing routing metadata on the response under `openrouter_metadata`.<br/>
        /// Example: enabled
        /// </param>
        /// <param name="background"></param>
        /// <param name="cacheControl">
        /// Enable automatic prompt caching. When set at the top level, the system automatically applies cache breakpoints to the last cacheable block in the request. When set on an individual content block, it marks an explicit cache breakpoint; block-level markers also work on OpenAI models that support explicit prompt caching — OpenRouter converts them to the provider's native format.<br/>
        /// Example: {"type":"ephemeral"}
        /// </param>
        /// <param name="debug">
        /// Debug options for inspecting request transformations (streaming only)<br/>
        /// Example: {"echo_upstream_body":true}
        /// </param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="imageConfig">
        /// Provider-specific image configuration options. Keys and values vary by model/provider. See https://openrouter.ai/docs/guides/overview/multimodal/image-generation for more details.<br/>
        /// Example: {"aspect_ratio":"16:9","quality":"high"}
        /// </param>
        /// <param name="include"></param>
        /// <param name="input">
        /// Input for a response request - can be a string or array of items<br/>
        /// Example: [{"content":"What is the weather today?","role":"user"}]
        /// </param>
        /// <param name="instructions"></param>
        /// <param name="maxOutputTokens"></param>
        /// <param name="maxToolCalls">
        /// Maximum number of server-tool (e.g. `openrouter:web_search`) agent steps the model may take during a request. Defaults to 30, which is also the maximum. Ignored when `stop_server_tools_when` is set.<br/>
        /// Example: 30
        /// </param>
        /// <param name="metadata">
        /// Metadata key-value pairs for the request. Keys must be ≤64 characters and cannot contain brackets. Values must be ≤512 characters. Maximum 16 pairs allowed.<br/>
        /// Example: {"session_id":"abc-def-ghi","user_id":"123"}
        /// </param>
        /// <param name="modalities">
        /// Output modalities for the response. Supported values are "text" and "image".<br/>
        /// Example: [text, image]
        /// </param>
        /// <param name="model"></param>
        /// <param name="models"></param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="plugins">
        /// Plugins you want to enable for this request, including their settings.
        /// </param>
        /// <param name="presencePenalty"></param>
        /// <param name="previousResponseId">
        /// Not supported on this proxy. Each response request is independent: no responses are stored, so a previous response cannot be referenced. Requests with a non-null value are rejected with a 400 error. Send the full conversation history in `input` instead.
        /// </param>
        /// <param name="prompt">
        /// Example: {"id":"prompt-abc123","variables":{"name":"John"}}
        /// </param>
        /// <param name="promptCacheKey"></param>
        /// <param name="promptCacheOptions">
        /// Request-level prompt-cache controls. `mode: "explicit"` disables OpenAI-managed breakpoints so only blocks marked with `prompt_cache_breakpoint` are cached. Only supported by OpenAI GPT-5.6 and newer.<br/>
        /// Example: {"mode":"explicit","ttl":"30m"}
        /// </param>
        /// <param name="provider">
        /// When multiple model providers are available, optionally indicate your routing preference.<br/>
        /// Example: {"allow_fallbacks":true}
        /// </param>
        /// <param name="reasoning">
        /// Configuration for reasoning mode in the response<br/>
        /// Example: {"enabled":true,"summary":"auto"}
        /// </param>
        /// <param name="safetyIdentifier">
        /// Recommended per-end-user identifier for abuse isolation. Use a stable ID, hash, or pseudonym. When a provider requires a user identity, OpenRouter folds it into the hashed identity sent upstream and never forwards it raw. If omitted, requests use an account-level identity, so provider policy blocks can affect the whole account.<br/>
        /// Example: user-123
        /// </param>
        /// <param name="serviceTier">
        /// The service tier to use for processing this request. `fast` is accepted as an alias for `priority`. `ultrafast` prefers ultrafast endpoints and falls back to `priority`, then default endpoints.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="sessionId">
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow). When provided, OpenRouter uses it as the sticky routing key, routing all requests in the session to the same provider to maximize prompt cache hits. Also used for observability grouping. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.
        /// </param>
        /// <param name="stopServerToolsWhen">
        /// Stop conditions for the server-tool agent loop. Any condition firing halts the loop (OR logic). When set, this overrides `max_tool_calls`. When a condition fires while the model is still emitting tool calls, the pending tool calls are executed and one final turn is made with tool calls disabled so the response ends with a natural-language answer instead of an unfinished tool call.<br/>
        /// Example: [{"step_count":5,"type":"step_count_is"}, {"max_cost_in_dollars":0.5,"type":"max_cost"}]
        /// </param>
        /// <param name="store">
        /// Default Value: false
        /// </param>
        /// <param name="temperature"></param>
        /// <param name="text">
        /// Text output configuration including format and verbosity<br/>
        /// Example: {"format":{"type":"text"}}
        /// </param>
        /// <param name="toolChoice">
        /// Example: auto
        /// </param>
        /// <param name="tools"></param>
        /// <param name="topK"></param>
        /// <param name="topLogprobs"></param>
        /// <param name="topP"></param>
        /// <param name="trace">
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.<br/>
        /// Example: {"trace_id":"trace-abc123","trace_name":"my-app-trace"}
        /// </param>
        /// <param name="truncation">
        /// Example: auto
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which helps distinguish between different users of your app. This allows your app to identify specific users in case of abuse reports, preventing your entire app from being affected by the actions of individual users. Maximum of 256 characters.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenRouter.OpenResponsesResult> SendAsync(
            global::OpenRouter.MetadataLevel? xOpenRouterMetadata = default,
            bool? background = default,
            global::OpenRouter.AnthropicCacheControlDirective? cacheControl = default,
            global::OpenRouter.ChatDebugOptions? debug = default,
            double? frequencyPenalty = default,
            global::OpenRouter.ImageConfig? imageConfig = default,
            global::System.Collections.Generic.IList<global::OpenRouter.ResponseIncludesEnum>? include = default,
            global::OpenRouter.Inputs? input = default,
            string? instructions = default,
            int? maxOutputTokens = default,
            int? maxToolCalls = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::System.Collections.Generic.IList<global::OpenRouter.OutputModalityEnum>? modalities = default,
            string? model = default,
            global::System.Collections.Generic.IList<string>? models = default,
            bool? parallelToolCalls = default,
            global::System.Collections.Generic.IList<global::OpenRouter.PluginsItem3>? plugins = default,
            double? presencePenalty = default,
            object? previousResponseId = default,
            global::OpenRouter.StoredPromptTemplate? prompt = default,
            string? promptCacheKey = default,
            global::OpenRouter.PromptCacheOptions? promptCacheOptions = default,
            global::OpenRouter.ProviderPreferences? provider = default,
            global::OpenRouter.AllOf<global::OpenRouter.BaseReasoningConfig, global::OpenRouter.ReasoningConfigVariant12>? reasoning = default,
            string? safetyIdentifier = default,
            global::OpenRouter.ResponsesRequestServiceTier? serviceTier = default,
            string? sessionId = default,
            global::System.Collections.Generic.IList<global::OpenRouter.StopServerToolsWhenCondition>? stopServerToolsWhen = default,
            bool? store = default,
            double? temperature = default,
            global::OpenRouter.TextExtendedConfig? text = default,
            global::OpenRouter.OpenAIResponsesToolChoice? toolChoice = default,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.AllOf<global::OpenRouter.FunctionTool, global::OpenRouter.ResponsesRequestToolVariant1>?, global::OpenRouter.PreviewWebSearchServerTool, global::OpenRouter.Preview20250311WebSearchServerTool, global::OpenRouter.LegacyWebSearchServerTool, global::OpenRouter.WebSearchServerTool, global::OpenRouter.FileSearchServerTool, global::OpenRouter.ComputerUseServerTool, global::OpenRouter.CodeInterpreterServerTool, global::OpenRouter.McpServerTool, global::OpenRouter.ImageGenerationServerTool, global::OpenRouter.CodexLocalShellTool, global::OpenRouter.ShellServerTool, global::OpenRouter.ApplyPatchServerTool, global::OpenRouter.CustomTool, global::OpenRouter.NamespaceTool, global::OpenRouter.AdvisorServerToolOpenRouter, global::OpenRouter.SubagentServerToolOpenRouter, global::OpenRouter.DatetimeServerTool, global::OpenRouter.FilesServerTool, global::OpenRouter.FusionServerToolOpenRouter, global::OpenRouter.ImageGenerationServerToolOpenRouter, global::OpenRouter.SearchModelsServerToolOpenRouter, global::OpenRouter.WebFetchServerTool, global::OpenRouter.WebSearchServerToolOpenRouter, global::OpenRouter.ApplyPatchServerToolOpenRouter, global::OpenRouter.BashServerTool, global::OpenRouter.ShellServerToolOpenRouter, global::OpenRouter.ToolSearchServerTool>>? tools = default,
            int? topK = default,
            int? topLogprobs = default,
            double? topP = default,
            global::OpenRouter.TraceConfig? trace = default,
            global::OpenRouter.OpenAIResponsesTruncation? truncation = default,
            string? user = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::OpenRouter.ResponsesRequest
            {
                Background = background,
                CacheControl = cacheControl,
                Debug = debug,
                FrequencyPenalty = frequencyPenalty,
                ImageConfig = imageConfig,
                Include = include,
                Input = input,
                Instructions = instructions,
                MaxOutputTokens = maxOutputTokens,
                MaxToolCalls = maxToolCalls,
                Metadata = metadata,
                Modalities = modalities,
                Model = model,
                Models = models,
                ParallelToolCalls = parallelToolCalls,
                Plugins = plugins,
                PresencePenalty = presencePenalty,
                PreviousResponseId = previousResponseId,
                Prompt = prompt,
                PromptCacheKey = promptCacheKey,
                PromptCacheOptions = promptCacheOptions,
                Provider = provider,
                Reasoning = reasoning,
                SafetyIdentifier = safetyIdentifier,
                ServiceTier = serviceTier,
                SessionId = sessionId,
                StopServerToolsWhen = stopServerToolsWhen,
                Store = store,
                Stream = false,
                Temperature = temperature,
                Text = text,
                ToolChoice = toolChoice,
                Tools = tools,
                TopK = topK,
                TopLogprobs = topLogprobs,
                TopP = topP,
                Trace = trace,
                Truncation = truncation,
                User = user,
            };

            return await SendAsync(
                xOpenRouterMetadata: xOpenRouterMetadata,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}