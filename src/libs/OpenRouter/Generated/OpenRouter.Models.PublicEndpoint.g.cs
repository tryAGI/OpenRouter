
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Information about a specific model endpoint<br/>
    /// Example: {"context_length":8192,"latency_last_30m":{"p50":0.25,"p75":0.35,"p90":0.48,"p99":0.85},"max_completion_tokens":4096,"max_prompt_tokens":8192,"model_id":"openai/gpt-4","model_name":"GPT-4","name":"OpenAI: GPT-4","native_tools":{"openrouter:web_search":{"type":"web_search_20260209"}},"perf_last_30m_by_workload":{"text_generation":{"latency":{"p50":250,"p75":350,"p90":480,"p99":850},"request_count":1000,"throughput":{"p50":45.2,"p75":38.5,"p90":28.3,"p99":15.1}}},"pricing":{"completion":"0.00006","image":"0","prompt":"0.00003","request":"0"},"provider_name":"OpenAI","quantization":"fp16","status":0,"supported_parameters":["temperature","top_p","max_tokens"],"supports_image_reference":false,"supports_implicit_caching":true,"supports_multiple_audio_references":false,"supports_tool_choice":{"auto":true,"function":true,"none":true,"required":true},"supports_voice_cloning":false,"tag":"openai","throughput_last_30m":{"p50":45.2,"p75":38.5,"p90":28.3,"p99":15.1},"uptime_last_1d":99.8,"uptime_last_30m":99.5,"uptime_last_5m":100}
    /// </summary>
    public sealed partial class PublicEndpoint
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContextLength { get; set; }

        /// <summary>
        /// Latency percentiles in milliseconds over the last 30 minutes. Latency measures time to first token. Only visible when authenticated with an API key or cookie; returns null for unauthenticated requests.<br/>
        /// Example: {"p50":25.5,"p75":35.2,"p90":48.7,"p99":85.3}
        /// </summary>
        /// <example>{"p50":25.5,"p75":35.2,"p90":48.7,"p99":85.3}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_last_30m")]
        public global::OpenRouter.PercentileStats? LatencyLast30m { get; set; }

        /// <summary>
        /// Maximum completion tokens for this endpoint. Input and output tokens share the context window, so the effective maximum output for a request is further limited by the context remaining after input tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_prompt_tokens")]
        public int? MaxPromptTokens { get; set; }

        /// <summary>
        /// The unique identifier for the model (permaslug)<br/>
        /// Example: openai/gpt-4
        /// </summary>
        /// <example>openai/gpt-4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The server tools this endpoint accepts as the provider's own built-in tool (`engine: "native"`) instead of an OpenRouter engine, keyed by canonical `openrouter:*` name. Each value names the provider tool type the request is translated to. Where that tool runs (provider-side, or returned to the client as with Anthropic bash) is documented per tool. Empty when the provider has none.<br/>
        /// Example: {"openrouter:web_search":{"type":"web_search_20260209"}}
        /// </summary>
        /// <example>{"openrouter:web_search":{"type":"web_search_20260209"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("native_tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::OpenRouter.PublicEndpointNativeTools2> NativeTools { get; set; }

        /// <summary>
        /// Endpoint performance over the last 30 minutes, keyed by the kind of request served (e.g. `text_generation`, `image_generation`). Additive to the legacy singular latency and throughput fields; image and video generation report end-to-end latency. Only visible when authenticated with an API key or cookie.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("perf_last_30m_by_workload")]
        public global::OpenRouter.PublicEndpointPerfLast30mByWorkload? PerfLast30mByWorkload { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.PublicEndpointPricing Pricing { get; set; }

        /// <summary>
        /// Example: OpenAI
        /// </summary>
        /// <example>OpenAI</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ProviderNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ProviderName ProviderName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantization")]
        public global::OpenRouter.Quantization? Quantization { get; set; }

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.Parameter> SupportedParameters { get; set; }

        /// <summary>
        /// Whether this TTS endpoint accepts an `image_url` reference describing the desired voice. Requests carrying an image reference are only routed to endpoints where this is true.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_image_reference")]
        public bool? SupportsImageReference { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_implicit_caching")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsImplicitCaching { get; set; }

        /// <summary>
        /// Whether this TTS endpoint accepts more than one `input_audio` reference clip per request. Requests carrying several clips are only routed to endpoints where this is true.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_multiple_audio_references")]
        public bool? SupportsMultipleAudioReferences { get; set; }

        /// <summary>
        /// Per-variant `tool_choice` support. `tool_choice` in `supported_parameters` only says the parameter is accepted; these flags say which of its values passed testing.<br/>
        /// Example: {"auto":true,"function":true,"none":true,"required":true}
        /// </summary>
        /// <example>{"auto":true,"function":true,"none":true,"required":true}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_tool_choice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ToolChoiceSupport SupportsToolChoice { get; set; }

        /// <summary>
        /// Whether this TTS endpoint accepts inline reference audio (`input_references`) for stateless voice cloning. Requests carrying reference audio are only routed to endpoints where this is true.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_voice_cloning")]
        public bool? SupportsVoiceCloning { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tag { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("throughput_last_30m")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AllOfJsonConverter<global::OpenRouter.PercentileStats, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AllOf<global::OpenRouter.PercentileStats, object> ThroughputLast30m { get; set; }

        /// <summary>
        /// Uptime percentage over the last 1 day, calculated as successful requests / (successful + error requests) * 100. Rate-limited requests are excluded. Returns null if insufficient data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uptime_last_1d")]
        public double? UptimeLast1d { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uptime_last_30m")]
        public double? UptimeLast30m { get; set; }

        /// <summary>
        /// Uptime percentage over the last 5 minutes, calculated as successful requests / (successful + error requests) * 100. Rate-limited requests are excluded. Returns null if insufficient data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uptime_last_5m")]
        public double? UptimeLast5m { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicEndpoint" /> class.
        /// </summary>
        /// <param name="contextLength"></param>
        /// <param name="modelId">
        /// The unique identifier for the model (permaslug)<br/>
        /// Example: openai/gpt-4
        /// </param>
        /// <param name="modelName"></param>
        /// <param name="name"></param>
        /// <param name="nativeTools">
        /// The server tools this endpoint accepts as the provider's own built-in tool (`engine: "native"`) instead of an OpenRouter engine, keyed by canonical `openrouter:*` name. Each value names the provider tool type the request is translated to. Where that tool runs (provider-side, or returned to the client as with Anthropic bash) is documented per tool. Empty when the provider has none.<br/>
        /// Example: {"openrouter:web_search":{"type":"web_search_20260209"}}
        /// </param>
        /// <param name="pricing"></param>
        /// <param name="providerName">
        /// Example: OpenAI
        /// </param>
        /// <param name="supportedParameters"></param>
        /// <param name="supportsImplicitCaching"></param>
        /// <param name="supportsToolChoice">
        /// Per-variant `tool_choice` support. `tool_choice` in `supported_parameters` only says the parameter is accepted; these flags say which of its values passed testing.<br/>
        /// Example: {"auto":true,"function":true,"none":true,"required":true}
        /// </param>
        /// <param name="tag"></param>
        /// <param name="throughputLast30m"></param>
        /// <param name="latencyLast30m">
        /// Latency percentiles in milliseconds over the last 30 minutes. Latency measures time to first token. Only visible when authenticated with an API key or cookie; returns null for unauthenticated requests.<br/>
        /// Example: {"p50":25.5,"p75":35.2,"p90":48.7,"p99":85.3}
        /// </param>
        /// <param name="maxCompletionTokens">
        /// Maximum completion tokens for this endpoint. Input and output tokens share the context window, so the effective maximum output for a request is further limited by the context remaining after input tokens.
        /// </param>
        /// <param name="maxPromptTokens"></param>
        /// <param name="perfLast30mByWorkload">
        /// Endpoint performance over the last 30 minutes, keyed by the kind of request served (e.g. `text_generation`, `image_generation`). Additive to the legacy singular latency and throughput fields; image and video generation report end-to-end latency. Only visible when authenticated with an API key or cookie.
        /// </param>
        /// <param name="quantization"></param>
        /// <param name="status">
        /// Example: 0
        /// </param>
        /// <param name="supportsImageReference">
        /// Whether this TTS endpoint accepts an `image_url` reference describing the desired voice. Requests carrying an image reference are only routed to endpoints where this is true.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="supportsMultipleAudioReferences">
        /// Whether this TTS endpoint accepts more than one `input_audio` reference clip per request. Requests carrying several clips are only routed to endpoints where this is true.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="supportsVoiceCloning">
        /// Whether this TTS endpoint accepts inline reference audio (`input_references`) for stateless voice cloning. Requests carrying reference audio are only routed to endpoints where this is true.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="uptimeLast1d">
        /// Uptime percentage over the last 1 day, calculated as successful requests / (successful + error requests) * 100. Rate-limited requests are excluded. Returns null if insufficient data.
        /// </param>
        /// <param name="uptimeLast30m"></param>
        /// <param name="uptimeLast5m">
        /// Uptime percentage over the last 5 minutes, calculated as successful requests / (successful + error requests) * 100. Rate-limited requests are excluded. Returns null if insufficient data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicEndpoint(
            int contextLength,
            string modelId,
            string modelName,
            string name,
            global::System.Collections.Generic.Dictionary<string, global::OpenRouter.PublicEndpointNativeTools2> nativeTools,
            global::OpenRouter.PublicEndpointPricing pricing,
            global::OpenRouter.ProviderName providerName,
            global::System.Collections.Generic.IList<global::OpenRouter.Parameter> supportedParameters,
            bool supportsImplicitCaching,
            global::OpenRouter.ToolChoiceSupport supportsToolChoice,
            string tag,
            global::OpenRouter.AllOf<global::OpenRouter.PercentileStats, object> throughputLast30m,
            global::OpenRouter.PercentileStats? latencyLast30m,
            int? maxCompletionTokens,
            int? maxPromptTokens,
            global::OpenRouter.PublicEndpointPerfLast30mByWorkload? perfLast30mByWorkload,
            global::OpenRouter.Quantization? quantization,
            int? status,
            bool? supportsImageReference,
            bool? supportsMultipleAudioReferences,
            bool? supportsVoiceCloning,
            double? uptimeLast1d,
            double? uptimeLast30m,
            double? uptimeLast5m)
        {
            this.ContextLength = contextLength;
            this.LatencyLast30m = latencyLast30m;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.MaxPromptTokens = maxPromptTokens;
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NativeTools = nativeTools ?? throw new global::System.ArgumentNullException(nameof(nativeTools));
            this.PerfLast30mByWorkload = perfLast30mByWorkload;
            this.Pricing = pricing ?? throw new global::System.ArgumentNullException(nameof(pricing));
            this.ProviderName = providerName;
            this.Quantization = quantization;
            this.Status = status;
            this.SupportedParameters = supportedParameters ?? throw new global::System.ArgumentNullException(nameof(supportedParameters));
            this.SupportsImageReference = supportsImageReference;
            this.SupportsImplicitCaching = supportsImplicitCaching;
            this.SupportsMultipleAudioReferences = supportsMultipleAudioReferences;
            this.SupportsToolChoice = supportsToolChoice ?? throw new global::System.ArgumentNullException(nameof(supportsToolChoice));
            this.SupportsVoiceCloning = supportsVoiceCloning;
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
            this.ThroughputLast30m = throughputLast30m;
            this.UptimeLast1d = uptimeLast1d;
            this.UptimeLast30m = uptimeLast30m;
            this.UptimeLast5m = uptimeLast5m;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicEndpoint" /> class.
        /// </summary>
        public PublicEndpoint()
        {
        }

    }
}