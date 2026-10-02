
#nullable enable

namespace OpenRouter
{
    public partial class ModelsClient
    {


        private static readonly global::OpenRouter.EndPointSecurityRequirement s_ListSecurityRequirement0 =
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
        private static readonly global::OpenRouter.EndPointSecurityRequirement[] s_ListSecurityRequirements =
            new global::OpenRouter.EndPointSecurityRequirement[]
            {                s_ListSecurityRequirement0,
            };
        partial void PrepareListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? offset,
            ref int? limit,
            ref global::OpenRouter.GetModelsCategory? category,
            ref string? supportedParameters,
            ref string? outputModalities,
            ref global::OpenRouter.GetModelsSort? sort,
            ref string? q,
            ref string? inputModalities,
            ref int? context,
            ref double? minPrice,
            ref double? maxPrice,
            ref string? arch,
            ref string? modelAuthors,
            ref string? providers,
            ref global::OpenRouter.GetModelsDistillable? distillable,
            ref global::OpenRouter.GetModelsZdr? zdr,
            ref global::OpenRouter.GetModelsRegion? region,
            ref double? minOutputPrice,
            ref double? maxOutputPrice,
            ref int? minAgeDays,
            ref int? maxAgeDays,
            ref double? minIntelligenceIndex,
            ref double? maxIntelligenceIndex,
            ref double? minCodingIndex,
            ref double? maxCodingIndex,
            ref double? minAgenticIndex,
            ref double? maxAgenticIndex,
            ref double? minToolSuccessRate,
            ref double? maxToolSuccessRate);
        partial void PrepareListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? offset,
            int? limit,
            global::OpenRouter.GetModelsCategory? category,
            string? supportedParameters,
            string? outputModalities,
            global::OpenRouter.GetModelsSort? sort,
            string? q,
            string? inputModalities,
            int? context,
            double? minPrice,
            double? maxPrice,
            string? arch,
            string? modelAuthors,
            string? providers,
            global::OpenRouter.GetModelsDistillable? distillable,
            global::OpenRouter.GetModelsZdr? zdr,
            global::OpenRouter.GetModelsRegion? region,
            double? minOutputPrice,
            double? maxOutputPrice,
            int? minAgeDays,
            int? maxAgeDays,
            double? minIntelligenceIndex,
            double? maxIntelligenceIndex,
            double? minCodingIndex,
            double? maxCodingIndex,
            double? minAgenticIndex,
            double? maxAgenticIndex,
            double? minToolSuccessRate,
            double? maxToolSuccessRate);
        partial void ProcessListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List all models and their properties
        /// </summary>
        /// <param name="offset">
        /// Number of records to skip for pagination. When both offset and limit are omitted, the full list is returned<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="limit">
        /// Maximum number of records to return (max 1000). When both offset and limit are omitted, the full list is returned<br/>
        /// Default Value: 500<br/>
        /// Example: 500
        /// </param>
        /// <param name="category">
        /// Filter models by use case category<br/>
        /// Example: programming
        /// </param>
        /// <param name="supportedParameters">
        /// Filter models by supported parameter (comma-separated)<br/>
        /// Example: temperature
        /// </param>
        /// <param name="outputModalities">
        /// Filter models by output modality. Accepts a comma-separated list of modalities (text, image, embeddings, audio, video, rerank, decisions, speech, transcription) or "all" to include all models. Defaults to "text".<br/>
        /// Example: text
        /// </param>
        /// <param name="sort">
        /// Sort the returned models server-side. Prefer this over fetching the full list and sorting client-side. Options: pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low, coding-high-to-low, agentic-high-to-low (Artificial Analysis indices), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.<br/>
        /// Example: newest
        /// </param>
        /// <param name="q">
        /// Free-text search by model name or slug.<br/>
        /// Example: gpt-4
        /// </param>
        /// <param name="inputModalities">
        /// Filter models by input modality. Comma-separated list of: text, image, audio, file.<br/>
        /// Example: text,image
        /// </param>
        /// <param name="context">
        /// Minimum context length (tokens). Models with smaller context are excluded.<br/>
        /// Example: 128000
        /// </param>
        /// <param name="minPrice">
        /// Minimum prompt price in $/M tokens.<br/>
        /// Example: 0
        /// </param>
        /// <param name="maxPrice">
        /// Maximum prompt price in $/M tokens.<br/>
        /// Example: 10
        /// </param>
        /// <param name="arch">
        /// Filter models by architecture/model family (e.g. GPT, Claude, Gemini, Llama).<br/>
        /// Example: GPT
        /// </param>
        /// <param name="modelAuthors">
        /// Filter models by the organization that created the model. Comma-separated list of author slugs.<br/>
        /// Example: openai,anthropic
        /// </param>
        /// <param name="providers">
        /// Filter models by hosting provider. Comma-separated list of provider names.<br/>
        /// Example: OpenAI,Anthropic
        /// </param>
        /// <param name="distillable">
        /// Filter by distillation capability. "true" returns only distillable models, "false" excludes them.<br/>
        /// Example: true
        /// </param>
        /// <param name="zdr">
        /// When set to "true", return only models with zero data retention endpoints.<br/>
        /// Example: true
        /// </param>
        /// <param name="region">
        /// Filter to models with endpoints in the given data region ("eu" or "us").<br/>
        /// Example: eu
        /// </param>
        /// <param name="minOutputPrice">
        /// Minimum completion (output) price in $/M tokens.<br/>
        /// Example: 0
        /// </param>
        /// <param name="maxOutputPrice">
        /// Maximum completion (output) price in $/M tokens.<br/>
        /// Example: 10
        /// </param>
        /// <param name="minAgeDays">
        /// Minimum model age in days since its creation date.<br/>
        /// Example: 0
        /// </param>
        /// <param name="maxAgeDays">
        /// Maximum model age in days since its creation date.<br/>
        /// Example: 90
        /// </param>
        /// <param name="minIntelligenceIndex">
        /// Minimum Artificial Analysis intelligence index.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxIntelligenceIndex">
        /// Maximum Artificial Analysis intelligence index.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minCodingIndex">
        /// Minimum Artificial Analysis coding index.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxCodingIndex">
        /// Maximum Artificial Analysis coding index.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minAgenticIndex">
        /// Minimum Artificial Analysis agentic index.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxAgenticIndex">
        /// Maximum Artificial Analysis agentic index.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minToolSuccessRate">
        /// Minimum tool-calling success rate, as a fraction in [0, 1] (e.g. 0.9 = 90% of requests finishing with a tool_calls finish reason).<br/>
        /// Example: 0.9F
        /// </param>
        /// <param name="maxToolSuccessRate">
        /// Maximum tool-calling success rate, as a fraction in [0, 1].<br/>
        /// Example: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenRouter.ModelsListResponse> ListAsync(
            int? offset = default,
            int? limit = default,
            global::OpenRouter.GetModelsCategory? category = default,
            string? supportedParameters = default,
            string? outputModalities = default,
            global::OpenRouter.GetModelsSort? sort = default,
            string? q = default,
            string? inputModalities = default,
            int? context = default,
            double? minPrice = default,
            double? maxPrice = default,
            string? arch = default,
            string? modelAuthors = default,
            string? providers = default,
            global::OpenRouter.GetModelsDistillable? distillable = default,
            global::OpenRouter.GetModelsZdr? zdr = default,
            global::OpenRouter.GetModelsRegion? region = default,
            double? minOutputPrice = default,
            double? maxOutputPrice = default,
            int? minAgeDays = default,
            int? maxAgeDays = default,
            double? minIntelligenceIndex = default,
            double? maxIntelligenceIndex = default,
            double? minCodingIndex = default,
            double? maxCodingIndex = default,
            double? minAgenticIndex = default,
            double? maxAgenticIndex = default,
            double? minToolSuccessRate = default,
            double? maxToolSuccessRate = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ListAsResponseAsync(
                offset: offset,
                limit: limit,
                category: category,
                supportedParameters: supportedParameters,
                outputModalities: outputModalities,
                sort: sort,
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
                minOutputPrice: minOutputPrice,
                maxOutputPrice: maxOutputPrice,
                minAgeDays: minAgeDays,
                maxAgeDays: maxAgeDays,
                minIntelligenceIndex: minIntelligenceIndex,
                maxIntelligenceIndex: maxIntelligenceIndex,
                minCodingIndex: minCodingIndex,
                maxCodingIndex: maxCodingIndex,
                minAgenticIndex: minAgenticIndex,
                maxAgenticIndex: maxAgenticIndex,
                minToolSuccessRate: minToolSuccessRate,
                maxToolSuccessRate: maxToolSuccessRate,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// List all models and their properties
        /// </summary>
        /// <param name="offset">
        /// Number of records to skip for pagination. When both offset and limit are omitted, the full list is returned<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="limit">
        /// Maximum number of records to return (max 1000). When both offset and limit are omitted, the full list is returned<br/>
        /// Default Value: 500<br/>
        /// Example: 500
        /// </param>
        /// <param name="category">
        /// Filter models by use case category<br/>
        /// Example: programming
        /// </param>
        /// <param name="supportedParameters">
        /// Filter models by supported parameter (comma-separated)<br/>
        /// Example: temperature
        /// </param>
        /// <param name="outputModalities">
        /// Filter models by output modality. Accepts a comma-separated list of modalities (text, image, embeddings, audio, video, rerank, decisions, speech, transcription) or "all" to include all models. Defaults to "text".<br/>
        /// Example: text
        /// </param>
        /// <param name="sort">
        /// Sort the returned models server-side. Prefer this over fetching the full list and sorting client-side. Options: pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low, coding-high-to-low, agentic-high-to-low (Artificial Analysis indices), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.<br/>
        /// Example: newest
        /// </param>
        /// <param name="q">
        /// Free-text search by model name or slug.<br/>
        /// Example: gpt-4
        /// </param>
        /// <param name="inputModalities">
        /// Filter models by input modality. Comma-separated list of: text, image, audio, file.<br/>
        /// Example: text,image
        /// </param>
        /// <param name="context">
        /// Minimum context length (tokens). Models with smaller context are excluded.<br/>
        /// Example: 128000
        /// </param>
        /// <param name="minPrice">
        /// Minimum prompt price in $/M tokens.<br/>
        /// Example: 0
        /// </param>
        /// <param name="maxPrice">
        /// Maximum prompt price in $/M tokens.<br/>
        /// Example: 10
        /// </param>
        /// <param name="arch">
        /// Filter models by architecture/model family (e.g. GPT, Claude, Gemini, Llama).<br/>
        /// Example: GPT
        /// </param>
        /// <param name="modelAuthors">
        /// Filter models by the organization that created the model. Comma-separated list of author slugs.<br/>
        /// Example: openai,anthropic
        /// </param>
        /// <param name="providers">
        /// Filter models by hosting provider. Comma-separated list of provider names.<br/>
        /// Example: OpenAI,Anthropic
        /// </param>
        /// <param name="distillable">
        /// Filter by distillation capability. "true" returns only distillable models, "false" excludes them.<br/>
        /// Example: true
        /// </param>
        /// <param name="zdr">
        /// When set to "true", return only models with zero data retention endpoints.<br/>
        /// Example: true
        /// </param>
        /// <param name="region">
        /// Filter to models with endpoints in the given data region ("eu" or "us").<br/>
        /// Example: eu
        /// </param>
        /// <param name="minOutputPrice">
        /// Minimum completion (output) price in $/M tokens.<br/>
        /// Example: 0
        /// </param>
        /// <param name="maxOutputPrice">
        /// Maximum completion (output) price in $/M tokens.<br/>
        /// Example: 10
        /// </param>
        /// <param name="minAgeDays">
        /// Minimum model age in days since its creation date.<br/>
        /// Example: 0
        /// </param>
        /// <param name="maxAgeDays">
        /// Maximum model age in days since its creation date.<br/>
        /// Example: 90
        /// </param>
        /// <param name="minIntelligenceIndex">
        /// Minimum Artificial Analysis intelligence index.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxIntelligenceIndex">
        /// Maximum Artificial Analysis intelligence index.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minCodingIndex">
        /// Minimum Artificial Analysis coding index.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxCodingIndex">
        /// Maximum Artificial Analysis coding index.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minAgenticIndex">
        /// Minimum Artificial Analysis agentic index.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxAgenticIndex">
        /// Maximum Artificial Analysis agentic index.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minToolSuccessRate">
        /// Minimum tool-calling success rate, as a fraction in [0, 1] (e.g. 0.9 = 90% of requests finishing with a tool_calls finish reason).<br/>
        /// Example: 0.9F
        /// </param>
        /// <param name="maxToolSuccessRate">
        /// Maximum tool-calling success rate, as a fraction in [0, 1].<br/>
        /// Example: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ModelsListResponse>> ListAsResponseAsync(
            int? offset = default,
            int? limit = default,
            global::OpenRouter.GetModelsCategory? category = default,
            string? supportedParameters = default,
            string? outputModalities = default,
            global::OpenRouter.GetModelsSort? sort = default,
            string? q = default,
            string? inputModalities = default,
            int? context = default,
            double? minPrice = default,
            double? maxPrice = default,
            string? arch = default,
            string? modelAuthors = default,
            string? providers = default,
            global::OpenRouter.GetModelsDistillable? distillable = default,
            global::OpenRouter.GetModelsZdr? zdr = default,
            global::OpenRouter.GetModelsRegion? region = default,
            double? minOutputPrice = default,
            double? maxOutputPrice = default,
            int? minAgeDays = default,
            int? maxAgeDays = default,
            double? minIntelligenceIndex = default,
            double? maxIntelligenceIndex = default,
            double? minCodingIndex = default,
            double? maxCodingIndex = default,
            double? minAgenticIndex = default,
            double? maxAgenticIndex = default,
            double? minToolSuccessRate = default,
            double? maxToolSuccessRate = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListArguments(
                httpClient: HttpClient,
                offset: ref offset,
                limit: ref limit,
                category: ref category,
                supportedParameters: ref supportedParameters,
                outputModalities: ref outputModalities,
                sort: ref sort,
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
                region: ref region,
                minOutputPrice: ref minOutputPrice,
                maxOutputPrice: ref maxOutputPrice,
                minAgeDays: ref minAgeDays,
                maxAgeDays: ref maxAgeDays,
                minIntelligenceIndex: ref minIntelligenceIndex,
                maxIntelligenceIndex: ref maxIntelligenceIndex,
                minCodingIndex: ref minCodingIndex,
                maxCodingIndex: ref maxCodingIndex,
                minAgenticIndex: ref minAgenticIndex,
                maxAgenticIndex: ref maxAgenticIndex,
                minToolSuccessRate: ref minToolSuccessRate,
                maxToolSuccessRate: ref maxToolSuccessRate);


            var __authorizations = global::OpenRouter.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListSecurityRequirements,
                operationName: "ListAsync");

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
                                .AddOptionalParameter("offset", offset?.ToString())
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("category", category?.ToValueString())
                                .AddOptionalParameter("supported_parameters", supportedParameters)
                                .AddOptionalParameter("output_modalities", outputModalities)
                                .AddOptionalParameter("sort", sort?.ToValueString())
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
                                .AddOptionalParameter("min_output_price", minOutputPrice?.ToString())
                                .AddOptionalParameter("max_output_price", maxOutputPrice?.ToString())
                                .AddOptionalParameter("min_age_days", minAgeDays?.ToString())
                                .AddOptionalParameter("max_age_days", maxAgeDays?.ToString())
                                .AddOptionalParameter("min_intelligence_index", minIntelligenceIndex?.ToString())
                                .AddOptionalParameter("max_intelligence_index", maxIntelligenceIndex?.ToString())
                                .AddOptionalParameter("min_coding_index", minCodingIndex?.ToString())
                                .AddOptionalParameter("max_coding_index", maxCodingIndex?.ToString())
                                .AddOptionalParameter("min_agentic_index", minAgenticIndex?.ToString())
                                .AddOptionalParameter("max_agentic_index", maxAgenticIndex?.ToString())
                                .AddOptionalParameter("min_tool_success_rate", minToolSuccessRate?.ToString())
                                .AddOptionalParameter("max_tool_success_rate", maxToolSuccessRate?.ToString())
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
                PrepareListRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    offset: offset,
                    limit: limit,
                    category: category,
                    supportedParameters: supportedParameters,
                    outputModalities: outputModalities,
                    sort: sort,
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
                    minOutputPrice: minOutputPrice,
                    maxOutputPrice: maxOutputPrice,
                    minAgeDays: minAgeDays,
                    maxAgeDays: maxAgeDays,
                    minIntelligenceIndex: minIntelligenceIndex,
                    maxIntelligenceIndex: maxIntelligenceIndex,
                    minCodingIndex: minCodingIndex,
                    maxCodingIndex: maxCodingIndex,
                    minAgenticIndex: minAgenticIndex,
                    maxAgenticIndex: maxAgenticIndex,
                    minToolSuccessRate: minToolSuccessRate,
                    maxToolSuccessRate: maxToolSuccessRate);

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
                                operationId: "List",
                                methodName: "ListAsync",
                                pathTemplate: "\"/models\"",
                                httpMethod: "GET",
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
                                operationId: "List",
                                methodName: "ListAsync",
                                pathTemplate: "\"/models\"",
                                httpMethod: "GET",
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
                                operationId: "List",
                                methodName: "ListAsync",
                                pathTemplate: "\"/models\"",
                                httpMethod: "GET",
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
                ProcessListResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::OpenRouter.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::OpenRouter.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "List",
                                methodName: "ListAsync",
                                pathTemplate: "\"/models\"",
                                httpMethod: "GET",
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
                                operationId: "List",
                                methodName: "ListAsync",
                                pathTemplate: "\"/models\"",
                                httpMethod: "GET",
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
                            // Forbidden - Authentication successful but insufficient permissions
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
                                ProcessListResponseContent(
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