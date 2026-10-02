
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Generation data
    /// </summary>
    public sealed partial class GenerationResponseData
    {
        /// <summary>
        /// Type of API used for the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.GenerationResponseDataApiTypeJsonConverter))]
        public global::OpenRouter.GenerationResponseDataApiType? ApiType { get; set; }

        /// <summary>
        /// ID of the app that made the request<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public int? AppId { get; set; }

        /// <summary>
        /// Discount applied due to caching<br/>
        /// Example: 0.0002F
        /// </summary>
        /// <example>0.0002F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_discount")]
        public double? CacheDiscount { get; set; }

        /// <summary>
        /// Whether the generation was cancelled<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelled")]
        public bool? Cancelled { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the generation was created<br/>
        /// Example: 2024-07-15T23:33:19.433273+00:00
        /// </summary>
        /// <example>2024-07-15T23:33:19.433273+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// The data region this generation was routed through: 'global', 'europe', or 'us'.<br/>
        /// Example: global
        /// </summary>
        /// <example>global</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.GenerationResponseDataDataRegionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.GenerationResponseDataDataRegion DataRegion { get; set; }

        /// <summary>
        /// External user identifier<br/>
        /// Example: user-123
        /// </summary>
        /// <example>user-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_user")]
        public string? ExternalUser { get; set; }

        /// <summary>
        /// Reason the generation finished<br/>
        /// Example: stop
        /// </summary>
        /// <example>stop</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        public string? FinishReason { get; set; }

        /// <summary>
        /// Time taken for generation in milliseconds<br/>
        /// Example: 1200
        /// </summary>
        /// <example>1200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_time")]
        public double? GenerationTime { get; set; }

        /// <summary>
        /// Referer header from the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("http_referer")]
        public string? HttpReferer { get; set; }

        /// <summary>
        /// Unique identifier for the generation<br/>
        /// Example: gen-3bhGkxlo4XFrqiabUM7NDtwDzWwG
        /// </summary>
        /// <example>gen-3bhGkxlo4XFrqiabUM7NDtwDzWwG</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Whether this used bring-your-own-key<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_byok")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsByok { get; set; }

        /// <summary>
        /// Total latency in milliseconds<br/>
        /// Example: 1250
        /// </summary>
        /// <example>1250</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        public double? Latency { get; set; }

        /// <summary>
        /// Model used for the generation<br/>
        /// Example: sao10k/l3-stheno-8b
        /// </summary>
        /// <example>sao10k/l3-stheno-8b</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Moderation latency in milliseconds<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderation_latency")]
        public double? ModerationLatency { get; set; }

        /// <summary>
        /// Native finish reason as reported by provider<br/>
        /// Example: stop
        /// </summary>
        /// <example>stop</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("native_finish_reason")]
        public string? NativeFinishReason { get; set; }

        /// <summary>
        /// Native cached tokens as reported by provider<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("native_tokens_cached")]
        public int? NativeTokensCached { get; set; }

        /// <summary>
        /// Native completion tokens as reported by provider<br/>
        /// Example: 25
        /// </summary>
        /// <example>25</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("native_tokens_completion")]
        public int? NativeTokensCompletion { get; set; }

        /// <summary>
        /// Native completion image tokens as reported by provider<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("native_tokens_completion_images")]
        public int? NativeTokensCompletionImages { get; set; }

        /// <summary>
        /// Native prompt tokens as reported by provider<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("native_tokens_prompt")]
        public int? NativeTokensPrompt { get; set; }

        /// <summary>
        /// Native reasoning tokens as reported by provider<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("native_tokens_reasoning")]
        public int? NativeTokensReasoning { get; set; }

        /// <summary>
        /// Number of web fetches performed<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_fetches")]
        public int? NumFetches { get; set; }

        /// <summary>
        /// Number of audio inputs in the prompt<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_input_audio_prompt")]
        public int? NumInputAudioPrompt { get; set; }

        /// <summary>
        /// Number of media items in the completion<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_media_completion")]
        public int? NumMediaCompletion { get; set; }

        /// <summary>
        /// Number of media items in the prompt<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_media_prompt")]
        public int? NumMediaPrompt { get; set; }

        /// <summary>
        /// Number of search results included<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_search_results")]
        public int? NumSearchResults { get; set; }

        /// <summary>
        /// Origin URL of the request<br/>
        /// Example: https://openrouter.ai/
        /// </summary>
        /// <example>https://openrouter.ai/</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Origin { get; set; }

        /// <summary>
        /// ID of the preset used for this generation, null if no preset was used<br/>
        /// Example: a9e8d400-592a-494f-908c-375efa66cafd
        /// </summary>
        /// <example>a9e8d400-592a-494f-908c-375efa66cafd</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset_id")]
        public string? PresetId { get; set; }

        /// <summary>
        /// Name of the provider that served the request<br/>
        /// Example: Infermatic
        /// </summary>
        /// <example>Infermatic</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        public string? ProviderName { get; set; }

        /// <summary>
        /// List of provider responses for this generation, including fallback attempts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_responses")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ProviderResponse>? ProviderResponses { get; set; }

        /// <summary>
        /// Unique identifier grouping all generations from a single API request<br/>
        /// Example: req-1727282430-aBcDeFgHiJkLmNoPqRsT
        /// </summary>
        /// <example>req-1727282430-aBcDeFgHiJkLmNoPqRsT</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// If this generation was served from response cache, contains the original generation ID. Null otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_cache_source_id")]
        public string? ResponseCacheSourceId { get; set; }

        /// <summary>
        /// Router used for the request (e.g., openrouter/auto)<br/>
        /// Example: openrouter/auto
        /// </summary>
        /// <example>openrouter/auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("router")]
        public string? Router { get; set; }

        /// <summary>
        /// Service tier the upstream provider reported running this request on, or null if it did not report one.<br/>
        /// Example: priority
        /// </summary>
        /// <example>priority</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        public string? ServiceTier { get; set; }

        /// <summary>
        /// Session identifier grouping multiple generations in the same session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Whether the response was streamed<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("streamed")]
        public bool? Streamed { get; set; }

        /// <summary>
        /// Number of tokens in the completion<br/>
        /// Example: 25
        /// </summary>
        /// <example>25</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens_completion")]
        public int? TokensCompletion { get; set; }

        /// <summary>
        /// Number of tokens in the prompt<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens_prompt")]
        public int? TokensPrompt { get; set; }

        /// <summary>
        /// Total cost of the generation in USD<br/>
        /// Example: 0.0015F
        /// </summary>
        /// <example>0.0015F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCost { get; set; }

        /// <summary>
        /// Upstream provider's identifier for this generation<br/>
        /// Example: chatcmpl-791bcf62-080e-4568-87d0-94c72e3b4946
        /// </summary>
        /// <example>chatcmpl-791bcf62-080e-4568-87d0-94c72e3b4946</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_id")]
        public string? UpstreamId { get; set; }

        /// <summary>
        /// Cost charged by the upstream provider<br/>
        /// Example: 0.0012F
        /// </summary>
        /// <example>0.0012F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_inference_cost")]
        public double? UpstreamInferenceCost { get; set; }

        /// <summary>
        /// Usage amount in USD<br/>
        /// Example: 0.0015F
        /// </summary>
        /// <example>0.0015F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Usage { get; set; }

        /// <summary>
        /// User-Agent header from the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_agent")]
        public string? UserAgent { get; set; }

        /// <summary>
        /// The resolved web search engine used for this generation (e.g. exa, firecrawl, parallel)<br/>
        /// Example: exa
        /// </summary>
        /// <example>exa</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search_engine")]
        public string? WebSearchEngine { get; set; }

        /// <summary>
        /// ID of the workspace this generation is attributed to. Null for accounts without workspaces. Generations created before workspace resolution existed are attributed to the account default workspace.<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationResponseData" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the generation was created<br/>
        /// Example: 2024-07-15T23:33:19.433273+00:00
        /// </param>
        /// <param name="dataRegion">
        /// The data region this generation was routed through: 'global', 'europe', or 'us'.<br/>
        /// Example: global
        /// </param>
        /// <param name="id">
        /// Unique identifier for the generation<br/>
        /// Example: gen-3bhGkxlo4XFrqiabUM7NDtwDzWwG
        /// </param>
        /// <param name="isByok">
        /// Whether this used bring-your-own-key<br/>
        /// Example: false
        /// </param>
        /// <param name="model">
        /// Model used for the generation<br/>
        /// Example: sao10k/l3-stheno-8b
        /// </param>
        /// <param name="origin">
        /// Origin URL of the request<br/>
        /// Example: https://openrouter.ai/
        /// </param>
        /// <param name="totalCost">
        /// Total cost of the generation in USD<br/>
        /// Example: 0.0015F
        /// </param>
        /// <param name="usage">
        /// Usage amount in USD<br/>
        /// Example: 0.0015F
        /// </param>
        /// <param name="apiType">
        /// Type of API used for the generation
        /// </param>
        /// <param name="appId">
        /// ID of the app that made the request<br/>
        /// Example: 12345
        /// </param>
        /// <param name="cacheDiscount">
        /// Discount applied due to caching<br/>
        /// Example: 0.0002F
        /// </param>
        /// <param name="cancelled">
        /// Whether the generation was cancelled<br/>
        /// Example: false
        /// </param>
        /// <param name="externalUser">
        /// External user identifier<br/>
        /// Example: user-123
        /// </param>
        /// <param name="finishReason">
        /// Reason the generation finished<br/>
        /// Example: stop
        /// </param>
        /// <param name="generationTime">
        /// Time taken for generation in milliseconds<br/>
        /// Example: 1200
        /// </param>
        /// <param name="httpReferer">
        /// Referer header from the request
        /// </param>
        /// <param name="latency">
        /// Total latency in milliseconds<br/>
        /// Example: 1250
        /// </param>
        /// <param name="moderationLatency">
        /// Moderation latency in milliseconds<br/>
        /// Example: 50
        /// </param>
        /// <param name="nativeFinishReason">
        /// Native finish reason as reported by provider<br/>
        /// Example: stop
        /// </param>
        /// <param name="nativeTokensCached">
        /// Native cached tokens as reported by provider<br/>
        /// Example: 3
        /// </param>
        /// <param name="nativeTokensCompletion">
        /// Native completion tokens as reported by provider<br/>
        /// Example: 25
        /// </param>
        /// <param name="nativeTokensCompletionImages">
        /// Native completion image tokens as reported by provider<br/>
        /// Example: 0
        /// </param>
        /// <param name="nativeTokensPrompt">
        /// Native prompt tokens as reported by provider<br/>
        /// Example: 10
        /// </param>
        /// <param name="nativeTokensReasoning">
        /// Native reasoning tokens as reported by provider<br/>
        /// Example: 5
        /// </param>
        /// <param name="numFetches">
        /// Number of web fetches performed<br/>
        /// Example: 0
        /// </param>
        /// <param name="numInputAudioPrompt">
        /// Number of audio inputs in the prompt<br/>
        /// Example: 0
        /// </param>
        /// <param name="numMediaCompletion">
        /// Number of media items in the completion<br/>
        /// Example: 0
        /// </param>
        /// <param name="numMediaPrompt">
        /// Number of media items in the prompt<br/>
        /// Example: 1
        /// </param>
        /// <param name="numSearchResults">
        /// Number of search results included<br/>
        /// Example: 5
        /// </param>
        /// <param name="presetId">
        /// ID of the preset used for this generation, null if no preset was used<br/>
        /// Example: a9e8d400-592a-494f-908c-375efa66cafd
        /// </param>
        /// <param name="providerName">
        /// Name of the provider that served the request<br/>
        /// Example: Infermatic
        /// </param>
        /// <param name="providerResponses">
        /// List of provider responses for this generation, including fallback attempts
        /// </param>
        /// <param name="requestId">
        /// Unique identifier grouping all generations from a single API request<br/>
        /// Example: req-1727282430-aBcDeFgHiJkLmNoPqRsT
        /// </param>
        /// <param name="responseCacheSourceId">
        /// If this generation was served from response cache, contains the original generation ID. Null otherwise.
        /// </param>
        /// <param name="router">
        /// Router used for the request (e.g., openrouter/auto)<br/>
        /// Example: openrouter/auto
        /// </param>
        /// <param name="serviceTier">
        /// Service tier the upstream provider reported running this request on, or null if it did not report one.<br/>
        /// Example: priority
        /// </param>
        /// <param name="sessionId">
        /// Session identifier grouping multiple generations in the same session
        /// </param>
        /// <param name="streamed">
        /// Whether the response was streamed<br/>
        /// Example: true
        /// </param>
        /// <param name="tokensCompletion">
        /// Number of tokens in the completion<br/>
        /// Example: 25
        /// </param>
        /// <param name="tokensPrompt">
        /// Number of tokens in the prompt<br/>
        /// Example: 10
        /// </param>
        /// <param name="upstreamId">
        /// Upstream provider's identifier for this generation<br/>
        /// Example: chatcmpl-791bcf62-080e-4568-87d0-94c72e3b4946
        /// </param>
        /// <param name="upstreamInferenceCost">
        /// Cost charged by the upstream provider<br/>
        /// Example: 0.0012F
        /// </param>
        /// <param name="userAgent">
        /// User-Agent header from the request
        /// </param>
        /// <param name="webSearchEngine">
        /// The resolved web search engine used for this generation (e.g. exa, firecrawl, parallel)<br/>
        /// Example: exa
        /// </param>
        /// <param name="workspaceId">
        /// ID of the workspace this generation is attributed to. Null for accounts without workspaces. Generations created before workspace resolution existed are attributed to the account default workspace.<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationResponseData(
            string createdAt,
            global::OpenRouter.GenerationResponseDataDataRegion dataRegion,
            string id,
            bool isByok,
            string model,
            string origin,
            double totalCost,
            double usage,
            global::OpenRouter.GenerationResponseDataApiType? apiType,
            int? appId,
            double? cacheDiscount,
            bool? cancelled,
            string? externalUser,
            string? finishReason,
            double? generationTime,
            string? httpReferer,
            double? latency,
            double? moderationLatency,
            string? nativeFinishReason,
            int? nativeTokensCached,
            int? nativeTokensCompletion,
            int? nativeTokensCompletionImages,
            int? nativeTokensPrompt,
            int? nativeTokensReasoning,
            int? numFetches,
            int? numInputAudioPrompt,
            int? numMediaCompletion,
            int? numMediaPrompt,
            int? numSearchResults,
            string? presetId,
            string? providerName,
            global::System.Collections.Generic.IList<global::OpenRouter.ProviderResponse>? providerResponses,
            string? requestId,
            string? responseCacheSourceId,
            string? router,
            string? serviceTier,
            string? sessionId,
            bool? streamed,
            int? tokensCompletion,
            int? tokensPrompt,
            string? upstreamId,
            double? upstreamInferenceCost,
            string? userAgent,
            string? webSearchEngine,
            string? workspaceId)
        {
            this.ApiType = apiType;
            this.AppId = appId;
            this.CacheDiscount = cacheDiscount;
            this.Cancelled = cancelled;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.DataRegion = dataRegion;
            this.ExternalUser = externalUser;
            this.FinishReason = finishReason;
            this.GenerationTime = generationTime;
            this.HttpReferer = httpReferer;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IsByok = isByok;
            this.Latency = latency;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.ModerationLatency = moderationLatency;
            this.NativeFinishReason = nativeFinishReason;
            this.NativeTokensCached = nativeTokensCached;
            this.NativeTokensCompletion = nativeTokensCompletion;
            this.NativeTokensCompletionImages = nativeTokensCompletionImages;
            this.NativeTokensPrompt = nativeTokensPrompt;
            this.NativeTokensReasoning = nativeTokensReasoning;
            this.NumFetches = numFetches;
            this.NumInputAudioPrompt = numInputAudioPrompt;
            this.NumMediaCompletion = numMediaCompletion;
            this.NumMediaPrompt = numMediaPrompt;
            this.NumSearchResults = numSearchResults;
            this.Origin = origin ?? throw new global::System.ArgumentNullException(nameof(origin));
            this.PresetId = presetId;
            this.ProviderName = providerName;
            this.ProviderResponses = providerResponses;
            this.RequestId = requestId;
            this.ResponseCacheSourceId = responseCacheSourceId;
            this.Router = router;
            this.ServiceTier = serviceTier;
            this.SessionId = sessionId;
            this.Streamed = streamed;
            this.TokensCompletion = tokensCompletion;
            this.TokensPrompt = tokensPrompt;
            this.TotalCost = totalCost;
            this.UpstreamId = upstreamId;
            this.UpstreamInferenceCost = upstreamInferenceCost;
            this.Usage = usage;
            this.UserAgent = userAgent;
            this.WebSearchEngine = webSearchEngine;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationResponseData" /> class.
        /// </summary>
        public GenerationResponseData()
        {
        }

    }
}