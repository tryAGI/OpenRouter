
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.GenerationResponseDataApiType?, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OneOf<global::OpenRouter.GenerationResponseDataApiType?, object> ApiType { get; set; }

        /// <summary>
        /// ID of the app that made the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public int? AppId { get; set; }

        /// <summary>
        /// Discount applied due to caching
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_discount")]
        public double? CacheDiscount { get; set; }

        /// <summary>
        /// Whether the generation was cancelled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelled")]
        public bool? Cancelled { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the generation was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// External user identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_user")]
        public string? ExternalUser { get; set; }

        /// <summary>
        /// Reason the generation finished
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        public string? FinishReason { get; set; }

        /// <summary>
        /// Time taken for generation in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_time")]
        public double? GenerationTime { get; set; }

        /// <summary>
        /// Referer header from the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("http_referer")]
        public string? HttpReferer { get; set; }

        /// <summary>
        /// Unique identifier for the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Whether this used bring-your-own-key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_byok")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsByok { get; set; }

        /// <summary>
        /// Total latency in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        public double? Latency { get; set; }

        /// <summary>
        /// Model used for the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Moderation latency in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderation_latency")]
        public double? ModerationLatency { get; set; }

        /// <summary>
        /// Native finish reason as reported by provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("native_finish_reason")]
        public string? NativeFinishReason { get; set; }

        /// <summary>
        /// Native cached tokens as reported by provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("native_tokens_cached")]
        public int? NativeTokensCached { get; set; }

        /// <summary>
        /// Native completion tokens as reported by provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("native_tokens_completion")]
        public int? NativeTokensCompletion { get; set; }

        /// <summary>
        /// Native completion image tokens as reported by provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("native_tokens_completion_images")]
        public int? NativeTokensCompletionImages { get; set; }

        /// <summary>
        /// Native prompt tokens as reported by provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("native_tokens_prompt")]
        public int? NativeTokensPrompt { get; set; }

        /// <summary>
        /// Native reasoning tokens as reported by provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("native_tokens_reasoning")]
        public int? NativeTokensReasoning { get; set; }

        /// <summary>
        /// Number of web fetches performed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_fetches")]
        public int? NumFetches { get; set; }

        /// <summary>
        /// Number of audio inputs in the prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_input_audio_prompt")]
        public int? NumInputAudioPrompt { get; set; }

        /// <summary>
        /// Number of media items in the completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_media_completion")]
        public int? NumMediaCompletion { get; set; }

        /// <summary>
        /// Number of media items in the prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_media_prompt")]
        public int? NumMediaPrompt { get; set; }

        /// <summary>
        /// Number of search results included
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_search_results")]
        public int? NumSearchResults { get; set; }

        /// <summary>
        /// Origin URL of the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Origin { get; set; }

        /// <summary>
        /// Name of the provider that served the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        public string? ProviderName { get; set; }

        /// <summary>
        /// List of provider responses for this generation, including fallback attempts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_responses")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ProviderResponse>? ProviderResponses { get; set; }

        /// <summary>
        /// Unique identifier grouping all generations from a single API request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Router used for the request (e.g., openrouter/auto)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("router")]
        public string? Router { get; set; }

        /// <summary>
        /// Session identifier grouping multiple generations in the same session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Whether the response was streamed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streamed")]
        public bool? Streamed { get; set; }

        /// <summary>
        /// Number of tokens in the completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens_completion")]
        public int? TokensCompletion { get; set; }

        /// <summary>
        /// Number of tokens in the prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens_prompt")]
        public int? TokensPrompt { get; set; }

        /// <summary>
        /// Total cost of the generation in USD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCost { get; set; }

        /// <summary>
        /// Upstream provider's identifier for this generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_id")]
        public string? UpstreamId { get; set; }

        /// <summary>
        /// Cost charged by the upstream provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_inference_cost")]
        public double? UpstreamInferenceCost { get; set; }

        /// <summary>
        /// Usage amount in USD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Usage { get; set; }

        /// <summary>
        /// User-Agent header from the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_agent")]
        public string? UserAgent { get; set; }

        /// <summary>
        /// The resolved web search engine used for this generation (e.g. exa, firecrawl, parallel)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search_engine")]
        public string? WebSearchEngine { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationResponseData" /> class.
        /// </summary>
        /// <param name="apiType">
        /// Type of API used for the generation
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the generation was created
        /// </param>
        /// <param name="id">
        /// Unique identifier for the generation
        /// </param>
        /// <param name="isByok">
        /// Whether this used bring-your-own-key
        /// </param>
        /// <param name="model">
        /// Model used for the generation
        /// </param>
        /// <param name="origin">
        /// Origin URL of the request
        /// </param>
        /// <param name="totalCost">
        /// Total cost of the generation in USD
        /// </param>
        /// <param name="usage">
        /// Usage amount in USD
        /// </param>
        /// <param name="appId">
        /// ID of the app that made the request
        /// </param>
        /// <param name="cacheDiscount">
        /// Discount applied due to caching
        /// </param>
        /// <param name="cancelled">
        /// Whether the generation was cancelled
        /// </param>
        /// <param name="externalUser">
        /// External user identifier
        /// </param>
        /// <param name="finishReason">
        /// Reason the generation finished
        /// </param>
        /// <param name="generationTime">
        /// Time taken for generation in milliseconds
        /// </param>
        /// <param name="httpReferer">
        /// Referer header from the request
        /// </param>
        /// <param name="latency">
        /// Total latency in milliseconds
        /// </param>
        /// <param name="moderationLatency">
        /// Moderation latency in milliseconds
        /// </param>
        /// <param name="nativeFinishReason">
        /// Native finish reason as reported by provider
        /// </param>
        /// <param name="nativeTokensCached">
        /// Native cached tokens as reported by provider
        /// </param>
        /// <param name="nativeTokensCompletion">
        /// Native completion tokens as reported by provider
        /// </param>
        /// <param name="nativeTokensCompletionImages">
        /// Native completion image tokens as reported by provider
        /// </param>
        /// <param name="nativeTokensPrompt">
        /// Native prompt tokens as reported by provider
        /// </param>
        /// <param name="nativeTokensReasoning">
        /// Native reasoning tokens as reported by provider
        /// </param>
        /// <param name="numFetches">
        /// Number of web fetches performed
        /// </param>
        /// <param name="numInputAudioPrompt">
        /// Number of audio inputs in the prompt
        /// </param>
        /// <param name="numMediaCompletion">
        /// Number of media items in the completion
        /// </param>
        /// <param name="numMediaPrompt">
        /// Number of media items in the prompt
        /// </param>
        /// <param name="numSearchResults">
        /// Number of search results included
        /// </param>
        /// <param name="providerName">
        /// Name of the provider that served the request
        /// </param>
        /// <param name="providerResponses">
        /// List of provider responses for this generation, including fallback attempts
        /// </param>
        /// <param name="requestId">
        /// Unique identifier grouping all generations from a single API request
        /// </param>
        /// <param name="router">
        /// Router used for the request (e.g., openrouter/auto)
        /// </param>
        /// <param name="sessionId">
        /// Session identifier grouping multiple generations in the same session
        /// </param>
        /// <param name="streamed">
        /// Whether the response was streamed
        /// </param>
        /// <param name="tokensCompletion">
        /// Number of tokens in the completion
        /// </param>
        /// <param name="tokensPrompt">
        /// Number of tokens in the prompt
        /// </param>
        /// <param name="upstreamId">
        /// Upstream provider's identifier for this generation
        /// </param>
        /// <param name="upstreamInferenceCost">
        /// Cost charged by the upstream provider
        /// </param>
        /// <param name="userAgent">
        /// User-Agent header from the request
        /// </param>
        /// <param name="webSearchEngine">
        /// The resolved web search engine used for this generation (e.g. exa, firecrawl, parallel)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationResponseData(
            global::OpenRouter.OneOf<global::OpenRouter.GenerationResponseDataApiType?, object> apiType,
            string createdAt,
            string id,
            bool isByok,
            string model,
            string origin,
            double totalCost,
            double usage,
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
            string? providerName,
            global::System.Collections.Generic.IList<global::OpenRouter.ProviderResponse>? providerResponses,
            string? requestId,
            string? router,
            string? sessionId,
            bool? streamed,
            int? tokensCompletion,
            int? tokensPrompt,
            string? upstreamId,
            double? upstreamInferenceCost,
            string? userAgent,
            string? webSearchEngine)
        {
            this.ApiType = apiType;
            this.AppId = appId;
            this.CacheDiscount = cacheDiscount;
            this.Cancelled = cancelled;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
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
            this.ProviderName = providerName;
            this.ProviderResponses = providerResponses;
            this.RequestId = requestId;
            this.Router = router;
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationResponseData" /> class.
        /// </summary>
        public GenerationResponseData()
        {
        }
    }
}