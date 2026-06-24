
#nullable enable

namespace OpenRouter
{
    public partial class SubpackageModelsClient
    {


        private static readonly global::OpenRouter.EndPointSecurityRequirement s_GetModelsSecurityRequirement0 =
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
        private static readonly global::OpenRouter.EndPointSecurityRequirement[] s_GetModelsSecurityRequirements =
            new global::OpenRouter.EndPointSecurityRequirement[]
            {                s_GetModelsSecurityRequirement0,
            };
        partial void PrepareGetModelsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::OpenRouter.ModelsGetParametersCategory? category,
            ref string? supportedParameters,
            ref string? outputModalities,
            ref global::OpenRouter.ModelsGetParametersSort? sort,
            ref string? useRss,
            ref string? useRssChatLinks,
            ref string? q,
            ref string? inputModalities,
            ref int? context,
            ref double? minPrice,
            ref double? maxPrice,
            ref string? arch,
            ref string? modelAuthors,
            ref string? providers,
            ref global::OpenRouter.ModelsGetParametersDistillable? distillable,
            ref global::OpenRouter.ModelsGetParametersZdr? zdr,
            ref global::OpenRouter.ModelsGetParametersRegion? region);
        partial void PrepareGetModelsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::OpenRouter.ModelsGetParametersCategory? category,
            string? supportedParameters,
            string? outputModalities,
            global::OpenRouter.ModelsGetParametersSort? sort,
            string? useRss,
            string? useRssChatLinks,
            string? q,
            string? inputModalities,
            int? context,
            double? minPrice,
            double? maxPrice,
            string? arch,
            string? modelAuthors,
            string? providers,
            global::OpenRouter.ModelsGetParametersDistillable? distillable,
            global::OpenRouter.ModelsGetParametersZdr? zdr,
            global::OpenRouter.ModelsGetParametersRegion? region);
        partial void ProcessGetModelsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetModelsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List all models and their properties
        /// </summary>
        /// <param name="category">
        /// Filter models by use case category
        /// </param>
        /// <param name="supportedParameters"></param>
        /// <param name="outputModalities"></param>
        /// <param name="sort">
        /// Sort the returned models server-side. Prefer this over fetching the full list and sorting client-side. Options: pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low (Artificial Analysis intelligence index), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.
        /// </param>
        /// <param name="useRss"></param>
        /// <param name="useRssChatLinks"></param>
        /// <param name="q"></param>
        /// <param name="inputModalities"></param>
        /// <param name="context"></param>
        /// <param name="minPrice"></param>
        /// <param name="maxPrice"></param>
        /// <param name="arch"></param>
        /// <param name="modelAuthors"></param>
        /// <param name="providers"></param>
        /// <param name="distillable">
        /// Filter by distillation capability. "true" returns only distillable models, "false" excludes them.
        /// </param>
        /// <param name="zdr">
        /// When set to "true", return only models with zero data retention endpoints.
        /// </param>
        /// <param name="region">
        /// Filter to models with endpoints in the given data region. Currently only "eu" is supported.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenRouter.ModelsListResponse> GetModelsAsync(
            global::OpenRouter.ModelsGetParametersCategory? category = default,
            string? supportedParameters = default,
            string? outputModalities = default,
            global::OpenRouter.ModelsGetParametersSort? sort = default,
            string? useRss = default,
            string? useRssChatLinks = default,
            string? q = default,
            string? inputModalities = default,
            int? context = default,
            double? minPrice = default,
            double? maxPrice = default,
            string? arch = default,
            string? modelAuthors = default,
            string? providers = default,
            global::OpenRouter.ModelsGetParametersDistillable? distillable = default,
            global::OpenRouter.ModelsGetParametersZdr? zdr = default,
            global::OpenRouter.ModelsGetParametersRegion? region = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetModelsAsResponseAsync(
                category: category,
                supportedParameters: supportedParameters,
                outputModalities: outputModalities,
                sort: sort,
                useRss: useRss,
                useRssChatLinks: useRssChatLinks,
                q: q,
                inputModalities: inputModalities,
                context: context,
                minPrice: minPrice,
                maxPrice: maxPrice,
                arch: arch,
                modelAuthors: modelAuthors,
                providers: providers,
                distillable: distillable,
                zdr: zdr,
                region: region,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// List all models and their properties
        /// </summary>
        /// <param name="category">
        /// Filter models by use case category
        /// </param>
        /// <param name="supportedParameters"></param>
        /// <param name="outputModalities"></param>
        /// <param name="sort">
        /// Sort the returned models server-side. Prefer this over fetching the full list and sorting client-side. Options: pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low (Artificial Analysis intelligence index), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.
        /// </param>
        /// <param name="useRss"></param>
        /// <param name="useRssChatLinks"></param>
        /// <param name="q"></param>
        /// <param name="inputModalities"></param>
        /// <param name="context"></param>
        /// <param name="minPrice"></param>
        /// <param name="maxPrice"></param>
        /// <param name="arch"></param>
        /// <param name="modelAuthors"></param>
        /// <param name="providers"></param>
        /// <param name="distillable">
        /// Filter by distillation capability. "true" returns only distillable models, "false" excludes them.
        /// </param>
        /// <param name="zdr">
        /// When set to "true", return only models with zero data retention endpoints.
        /// </param>
        /// <param name="region">
        /// Filter to models with endpoints in the given data region. Currently only "eu" is supported.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ModelsListResponse>> GetModelsAsResponseAsync(
            global::OpenRouter.ModelsGetParametersCategory? category = default,
            string? supportedParameters = default,
            string? outputModalities = default,
            global::OpenRouter.ModelsGetParametersSort? sort = default,
            string? useRss = default,
            string? useRssChatLinks = default,
            string? q = default,
            string? inputModalities = default,
            int? context = default,
            double? minPrice = default,
            double? maxPrice = default,
            string? arch = default,
            string? modelAuthors = default,
            string? providers = default,
            global::OpenRouter.ModelsGetParametersDistillable? distillable = default,
            global::OpenRouter.ModelsGetParametersZdr? zdr = default,
            global::OpenRouter.ModelsGetParametersRegion? region = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetModelsArguments(
                httpClient: HttpClient,
                category: ref category,
                supportedParameters: ref supportedParameters,
                outputModalities: ref outputModalities,
                sort: ref sort,
                useRss: ref useRss,
                useRssChatLinks: ref useRssChatLinks,
                q: ref q,
                inputModalities: ref inputModalities,
                context: ref context,
                minPrice: ref minPrice,
                maxPrice: ref maxPrice,
                arch: ref arch,
                modelAuthors: ref modelAuthors,
                providers: ref providers,
                distillable: ref distillable,
                zdr: ref zdr,
                region: ref region);


            var __authorizations = global::OpenRouter.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetModelsSecurityRequirements,
                operationName: "GetModelsAsync");

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
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::OpenRouter.PathBuilder(
                                path: "/models",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("category", category?.ToValueString())
                                .AddOptionalParameter("supported_parameters", supportedParameters)
                                .AddOptionalParameter("output_modalities", outputModalities)
                                .AddOptionalParameter("sort", sort?.ToValueString())
                                .AddOptionalParameter("use_rss", useRss)
                                .AddOptionalParameter("use_rss_chat_links", useRssChatLinks)
                                .AddOptionalParameter("q", q)
                                .AddOptionalParameter("input_modalities", inputModalities)
                                .AddOptionalParameter("context", context?.ToString())
                                .AddOptionalParameter("min_price", minPrice?.ToString())
                                .AddOptionalParameter("max_price", maxPrice?.ToString())
                                .AddOptionalParameter("arch", arch)
                                .AddOptionalParameter("model_authors", modelAuthors)
                                .AddOptionalParameter("providers", providers)
                                .AddOptionalParameter("distillable", distillable?.ToValueString())
                                .AddOptionalParameter("zdr", zdr?.ToValueString())
                                .AddOptionalParameter("region", region?.ToValueString())
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::OpenRouter.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

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
                global::OpenRouter.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGetModelsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    category: category,
                    supportedParameters: supportedParameters,
                    outputModalities: outputModalities,
                    sort: sort,
                    useRss: useRss,
                    useRssChatLinks: useRssChatLinks,
                    q: q,
                    inputModalities: inputModalities,
                    context: context,
                    minPrice: minPrice,
                    maxPrice: maxPrice,
                    arch: arch,
                    modelAuthors: modelAuthors,
                    providers: providers,
                    distillable: distillable,
                    zdr: zdr,
                    region: region);

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
                                operationId: "GetModels",
                                methodName: "GetModelsAsync",
                                pathTemplate: "\"/models\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
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
                                operationId: "GetModels",
                                methodName: "GetModelsAsync",
                                pathTemplate: "\"/models\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
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
                                operationId: "GetModels",
                                methodName: "GetModelsAsync",
                                pathTemplate: "\"/models\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
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
                ProcessGetModelsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::OpenRouter.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::OpenRouter.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetModels",
                                methodName: "GetModelsAsync",
                                pathTemplate: "\"/models\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
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
                                operationId: "GetModels",
                                methodName: "GetModelsAsync",
                                pathTemplate: "\"/models\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
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
                                ProcessGetModelsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::OpenRouter.ModelsListResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ModelsListResponse>(
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

                                    var __value = await global::OpenRouter.ModelsListResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ModelsListResponse>(
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
    }
}