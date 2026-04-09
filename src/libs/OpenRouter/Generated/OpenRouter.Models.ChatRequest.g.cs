
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Chat completion request parameters
    /// </summary>
    public sealed partial class ChatRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::OpenRouter.ChatRequestCacheControl? CacheControl { get; set; }

        /// <summary>
        /// Debug options for inspecting request transformations (streaming only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("debug")]
        public global::OpenRouter.ChatDebugOptions? Debug { get; set; }

        /// <summary>
        /// Frequency penalty (-2.0 to 2.0)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// Provider-specific image configuration options. Keys and values vary by model/provider. See https://openrouter.ai/docs/guides/overview/multimodal/image-generation for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_config")]
        public object? ImageConfig { get; set; }

        /// <summary>
        /// Token logit bias adjustments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logit_bias")]
        public global::System.Collections.Generic.Dictionary<string, double>? LogitBias { get; set; }

        /// <summary>
        /// Return log probabilities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public bool? Logprobs { get; set; }

        /// <summary>
        /// Maximum tokens in completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// Maximum tokens (deprecated, use max_completion_tokens). Note: some providers enforce a minimum of 16.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// List of messages for the conversation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ChatMessages> Messages { get; set; }

        /// <summary>
        /// Key-value pairs for additional object information (max 16 pairs, 64 char keys, 512 char values)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Output modalities for the response. Supported values are "text", "image", and "audio".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatRequestModalitiesItems>? Modalities { get; set; }

        /// <summary>
        /// Model to use for completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Models to use for completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatModelNamesItems>? Models { get; set; }

        /// <summary>
        /// Whether to enable parallel function calling during tool use. When true, the model may generate multiple tool calls in a single response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// Plugins you want to enable for this request, including their settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugins")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatRequestPluginsItems>? Plugins { get; set; }

        /// <summary>
        /// Presence penalty (-2.0 to 2.0)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// When multiple model providers are available, optionally indicate your routing preference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public global::OpenRouter.ProviderPreferences? Provider { get; set; }

        /// <summary>
        /// Configuration options for reasoning models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::OpenRouter.ChatRequestReasoning? Reasoning { get; set; }

        /// <summary>
        /// Response format configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatRequestResponseFormatJsonConverter))]
        public global::OpenRouter.ChatRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// Any type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route")]
        public object? Route { get; set; }

        /// <summary>
        /// Random seed for deterministic outputs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The service tier to use for processing this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ChatRequestServiceTier?, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.ChatRequestServiceTier?, object>? ServiceTier { get; set; }

        /// <summary>
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow) for observability. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Stop sequences (up to 4)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatRequestStopJsonConverter))]
        public global::OpenRouter.ChatRequestStop? Stop { get; set; }

        /// <summary>
        /// Enable streaming response<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Streaming configuration options
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_options")]
        public global::OpenRouter.ChatStreamOptions? StreamOptions { get; set; }

        /// <summary>
        /// Sampling temperature (0-2)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Tool choice configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatToolChoiceJsonConverter))]
        public global::OpenRouter.ChatToolChoice? ToolChoice { get; set; }

        /// <summary>
        /// Available tools for function calling
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatFunctionTool>? Tools { get; set; }

        /// <summary>
        /// Number of top log probabilities to return (0-20)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public int? TopLogprobs { get; set; }

        /// <summary>
        /// Nucleus sampling parameter (0-1)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace")]
        public global::OpenRouter.TraceConfig? Trace { get; set; }

        /// <summary>
        /// Unique user identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequest" /> class.
        /// </summary>
        /// <param name="messages">
        /// List of messages for the conversation
        /// </param>
        /// <param name="cacheControl"></param>
        /// <param name="debug">
        /// Debug options for inspecting request transformations (streaming only)
        /// </param>
        /// <param name="frequencyPenalty">
        /// Frequency penalty (-2.0 to 2.0)
        /// </param>
        /// <param name="imageConfig">
        /// Provider-specific image configuration options. Keys and values vary by model/provider. See https://openrouter.ai/docs/guides/overview/multimodal/image-generation for more details.
        /// </param>
        /// <param name="logitBias">
        /// Token logit bias adjustments
        /// </param>
        /// <param name="logprobs">
        /// Return log probabilities
        /// </param>
        /// <param name="maxCompletionTokens">
        /// Maximum tokens in completion
        /// </param>
        /// <param name="maxTokens">
        /// Maximum tokens (deprecated, use max_completion_tokens). Note: some providers enforce a minimum of 16.
        /// </param>
        /// <param name="metadata">
        /// Key-value pairs for additional object information (max 16 pairs, 64 char keys, 512 char values)
        /// </param>
        /// <param name="modalities">
        /// Output modalities for the response. Supported values are "text", "image", and "audio".
        /// </param>
        /// <param name="model">
        /// Model to use for completion
        /// </param>
        /// <param name="models">
        /// Models to use for completion
        /// </param>
        /// <param name="parallelToolCalls">
        /// Whether to enable parallel function calling during tool use. When true, the model may generate multiple tool calls in a single response.
        /// </param>
        /// <param name="plugins">
        /// Plugins you want to enable for this request, including their settings.
        /// </param>
        /// <param name="presencePenalty">
        /// Presence penalty (-2.0 to 2.0)
        /// </param>
        /// <param name="provider">
        /// When multiple model providers are available, optionally indicate your routing preference.
        /// </param>
        /// <param name="reasoning">
        /// Configuration options for reasoning models
        /// </param>
        /// <param name="responseFormat">
        /// Response format configuration
        /// </param>
        /// <param name="route">
        /// Any type
        /// </param>
        /// <param name="seed">
        /// Random seed for deterministic outputs
        /// </param>
        /// <param name="serviceTier">
        /// The service tier to use for processing this request.
        /// </param>
        /// <param name="sessionId">
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow) for observability. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.
        /// </param>
        /// <param name="stop">
        /// Stop sequences (up to 4)
        /// </param>
        /// <param name="stream">
        /// Enable streaming response<br/>
        /// Default Value: false
        /// </param>
        /// <param name="streamOptions">
        /// Streaming configuration options
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature (0-2)
        /// </param>
        /// <param name="toolChoice">
        /// Tool choice configuration
        /// </param>
        /// <param name="tools">
        /// Available tools for function calling
        /// </param>
        /// <param name="topLogprobs">
        /// Number of top log probabilities to return (0-20)
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling parameter (0-1)
        /// </param>
        /// <param name="trace">
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.
        /// </param>
        /// <param name="user">
        /// Unique user identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRequest(
            global::System.Collections.Generic.IList<global::OpenRouter.ChatMessages> messages,
            global::OpenRouter.ChatRequestCacheControl? cacheControl,
            global::OpenRouter.ChatDebugOptions? debug,
            double? frequencyPenalty,
            object? imageConfig,
            global::System.Collections.Generic.Dictionary<string, double>? logitBias,
            bool? logprobs,
            int? maxCompletionTokens,
            int? maxTokens,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.Collections.Generic.IList<global::OpenRouter.ChatRequestModalitiesItems>? modalities,
            string? model,
            global::System.Collections.Generic.IList<global::OpenRouter.ChatModelNamesItems>? models,
            bool? parallelToolCalls,
            global::System.Collections.Generic.IList<global::OpenRouter.ChatRequestPluginsItems>? plugins,
            double? presencePenalty,
            global::OpenRouter.ProviderPreferences? provider,
            global::OpenRouter.ChatRequestReasoning? reasoning,
            global::OpenRouter.ChatRequestResponseFormat? responseFormat,
            object? route,
            int? seed,
            global::OpenRouter.OneOf<global::OpenRouter.ChatRequestServiceTier?, object>? serviceTier,
            string? sessionId,
            global::OpenRouter.ChatRequestStop? stop,
            bool? stream,
            global::OpenRouter.ChatStreamOptions? streamOptions,
            double? temperature,
            global::OpenRouter.ChatToolChoice? toolChoice,
            global::System.Collections.Generic.IList<global::OpenRouter.ChatFunctionTool>? tools,
            int? topLogprobs,
            double? topP,
            global::OpenRouter.TraceConfig? trace,
            string? user)
        {
            this.CacheControl = cacheControl;
            this.Debug = debug;
            this.FrequencyPenalty = frequencyPenalty;
            this.ImageConfig = imageConfig;
            this.LogitBias = logitBias;
            this.Logprobs = logprobs;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.MaxTokens = maxTokens;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Metadata = metadata;
            this.Modalities = modalities;
            this.Model = model;
            this.Models = models;
            this.ParallelToolCalls = parallelToolCalls;
            this.Plugins = plugins;
            this.PresencePenalty = presencePenalty;
            this.Provider = provider;
            this.Reasoning = reasoning;
            this.ResponseFormat = responseFormat;
            this.Route = route;
            this.Seed = seed;
            this.ServiceTier = serviceTier;
            this.SessionId = sessionId;
            this.Stop = stop;
            this.Stream = stream;
            this.StreamOptions = streamOptions;
            this.Temperature = temperature;
            this.ToolChoice = toolChoice;
            this.Tools = tools;
            this.TopLogprobs = topLogprobs;
            this.TopP = topP;
            this.Trace = trace;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequest" /> class.
        /// </summary>
        public ChatRequest()
        {
        }
    }
}