
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Chat completion request parameters<br/>
    /// Example: {"max_tokens":150,"messages":[{"content":"You are a helpful assistant.","role":"system"},{"content":"What is the capital of France?","role":"user"}],"model":"openai/gpt-4","temperature":0.7}
    /// </summary>
    public sealed partial class ChatRequest
    {
        /// <summary>
        /// Enable automatic prompt caching. When set at the top level, the system automatically applies cache breakpoints to the last cacheable block in the request. When set on an individual content block, it marks an explicit cache breakpoint; block-level markers also work on OpenAI models that support explicit prompt caching — OpenRouter converts them to the provider's native format.<br/>
        /// Example: {"type":"ephemeral"}
        /// </summary>
        /// <example>{"type":"ephemeral"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::OpenRouter.AnthropicCacheControlDirective? CacheControl { get; set; }

        /// <summary>
        /// Debug options for inspecting request transformations (streaming only)<br/>
        /// Example: {"echo_upstream_body":true}
        /// </summary>
        /// <example>{"echo_upstream_body":true}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("debug")]
        public global::OpenRouter.ChatDebugOptions? Debug { get; set; }

        /// <summary>
        /// Frequency penalty (-2.0 to 2.0)<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// Provider-specific image configuration options. Keys and values vary by model/provider. See https://openrouter.ai/docs/guides/overview/multimodal/image-generation for more details.<br/>
        /// Example: {"aspect_ratio":"16:9","quality":"high"}
        /// </summary>
        /// <example>{"aspect_ratio":"16:9","quality":"high"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_config")]
        public global::OpenRouter.ImageConfig? ImageConfig { get; set; }

        /// <summary>
        /// Token logit bias adjustments<br/>
        /// Example: {"50256":-100}
        /// </summary>
        /// <example>{"50256":-100}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("logit_bias")]
        public global::System.Collections.Generic.Dictionary<string, double>? LogitBias { get; set; }

        /// <summary>
        /// Return log probabilities<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public bool? Logprobs { get; set; }

        /// <summary>
        /// Maximum tokens in completion<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// Maximum tokens (deprecated, use max_completion_tokens). Note: some providers enforce a minimum of 16.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// List of messages for the conversation<br/>
        /// Example: [{"content":"Hello!","role":"user"}]
        /// </summary>
        /// <example>[{"content":"Hello!","role":"user"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ChatMessages> Messages { get; set; }

        /// <summary>
        /// Key-value pairs for additional object information (max 16 pairs, 64 char keys, 512 char values)<br/>
        /// Example: {"session_id":"session-456","user_id":"user-123"}
        /// </summary>
        /// <example>{"session_id":"session-456","user_id":"user-123"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Minimum probability threshold relative to the most likely token. Tokens with probability below min_p * (probability of top token) are filtered out. Not all providers support this parameter.<br/>
        /// Example: 0.1F
        /// </summary>
        /// <example>0.1F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_p")]
        public double? MinP { get; set; }

        /// <summary>
        /// Output modalities for the response. Supported values are "text", "image", and "audio".<br/>
        /// Example: [text, image]
        /// </summary>
        /// <example>[text, image]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatRequestModalitie>? Modalities { get; set; }

        /// <summary>
        /// Model to use for completion<br/>
        /// Example: openai/gpt-4
        /// </summary>
        /// <example>openai/gpt-4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Models to use for completion<br/>
        /// Example: [openai/gpt-4, openai/gpt-4o]
        /// </summary>
        /// <example>[openai/gpt-4, openai/gpt-4o]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AllOf<string, object>>? Models { get; set; }

        /// <summary>
        /// Whether to enable parallel function calling during tool use. When true, the model may generate multiple tool calls in a single response.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// Plugins you want to enable for this request, including their settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugins")]
        public global::System.Collections.Generic.IList<global::OpenRouter.PluginsItem>? Plugins { get; set; }

        /// <summary>
        /// Static predicted output content. Supported models can use this to reduce latency when much of the response is known in advance.<br/>
        /// Example: {"content":"Expected response","type":"content"}
        /// </summary>
        /// <example>{"content":"Expected response","type":"content"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prediction")]
        public global::OpenRouter.Prediction? Prediction { get; set; }

        /// <summary>
        /// Presence penalty (-2.0 to 2.0)<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_key")]
        public string? PromptCacheKey { get; set; }

        /// <summary>
        /// Request-level prompt-cache controls. `mode: "explicit"` disables OpenAI-managed breakpoints so only blocks marked with `prompt_cache_breakpoint` are cached. Only supported by OpenAI GPT-5.6 and newer.<br/>
        /// Example: {"mode":"explicit","ttl":"30m"}
        /// </summary>
        /// <example>{"mode":"explicit","ttl":"30m"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_options")]
        public global::OpenRouter.PromptCacheOptions? PromptCacheOptions { get; set; }

        /// <summary>
        /// When multiple model providers are available, optionally indicate your routing preference.<br/>
        /// Example: {"allow_fallbacks":true}
        /// </summary>
        /// <example>{"allow_fallbacks":true}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public global::OpenRouter.ProviderPreferences? Provider { get; set; }

        /// <summary>
        /// Configuration options for reasoning models<br/>
        /// Example: {"effort":"medium","summary":"concise"}
        /// </summary>
        /// <example>{"effort":"medium","summary":"concise"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::OpenRouter.ChatRequestReasoning? Reasoning { get; set; }

        /// <summary>
        /// Shorthand for setting reasoning effort. Equivalent to setting reasoning.effort. Cannot be used simultaneously with reasoning.effort if they differ.<br/>
        /// Example: medium
        /// </summary>
        /// <example>medium</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatRequestReasoningEffort2JsonConverter))]
        public global::OpenRouter.ChatRequestReasoningEffort2? ReasoningEffort { get; set; }

        /// <summary>
        /// Penalizes tokens based on how much they have already appeared in the text. A value of 1.0 means no penalty. Values above 1.0 penalize repeated tokens more strongly. Not all providers support this parameter.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repetition_penalty")]
        public double? RepetitionPenalty { get; set; }

        /// <summary>
        /// Response format configuration<br/>
        /// Example: {"type":"json_object"}
        /// </summary>
        /// <example>{"type":"json_object"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ResponseFormatJsonConverter))]
        public global::OpenRouter.ResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// **DEPRECATED** Use providers.sort.partition instead. Backwards-compatible alias for providers.sort.partition. Accepts legacy values: "fallback" (maps to "model"), "sort" (maps to "none").<br/>
        /// Example: fallback
        /// </summary>
        /// <example>fallback</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("route")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DeprecatedRouteJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::OpenRouter.DeprecatedRoute? Route { get; set; }

        /// <summary>
        /// Random seed for deterministic outputs<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The service tier to use for processing this request. `fast` is accepted as an alias for `priority`. `ultrafast` prefers ultrafast endpoints and falls back to `priority`, then default endpoints.<br/>
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatRequestServiceTierJsonConverter))]
        public global::OpenRouter.ChatRequestServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow). When provided, OpenRouter uses it as the sticky routing key, routing all requests in the session to the same provider to maximize prompt cache hits. Also used for observability grouping. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Stop sequences (up to 4)<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>))]
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? Stop { get; set; }

        /// <summary>
        /// Stop conditions for the server-tool agent loop. Any condition firing halts the loop (OR logic). When set, this overrides `max_tool_calls`. When a condition fires while the model is still emitting tool calls, the pending tool calls are executed and one final turn is made with tool calls disabled so the response ends with a natural-language answer instead of an unfinished tool call.<br/>
        /// Example: [{"step_count":5,"type":"step_count_is"}, {"max_cost_in_dollars":0.5,"type":"max_cost"}]
        /// </summary>
        /// <example>[{"step_count":5,"type":"step_count_is"}, {"max_cost_in_dollars":0.5,"type":"max_cost"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_server_tools_when")]
        public global::System.Collections.Generic.IList<global::OpenRouter.StopServerToolsWhenCondition>? StopServerToolsWhen { get; set; }

        /// <summary>
        /// Enable streaming response<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Streaming configuration options<br/>
        /// Example: {"include_usage":true}
        /// </summary>
        /// <example>{"include_usage":true}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_options")]
        public global::OpenRouter.ChatStreamOptions? StreamOptions { get; set; }

        /// <summary>
        /// Sampling temperature (0-2)<br/>
        /// Example: 0.7F
        /// </summary>
        /// <example>0.7F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Tool choice configuration<br/>
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatToolChoiceJsonConverter))]
        public global::OpenRouter.ChatToolChoice? ToolChoice { get; set; }

        /// <summary>
        /// Available tools for function calling<br/>
        /// Example: [{"function":{"description":"Get weather","name":"get_weather"},"type":"function"}]
        /// </summary>
        /// <example>[{"function":{"description":"Get weather","name":"get_weather"},"type":"function"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatFunctionTool>? Tools { get; set; }

        /// <summary>
        /// Consider only tokens with "sufficiently high" probabilities based on the probability of the most likely token. Not all providers support this parameter.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_a")]
        public double? TopA { get; set; }

        /// <summary>
        /// Limits the model to choose from the top K most likely tokens at each step. A value of 1 means the model will always pick the most likely next token. Not all providers support this parameter.<br/>
        /// Example: 40
        /// </summary>
        /// <example>40</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Number of top log probabilities to return (0-20)<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public int? TopLogprobs { get; set; }

        /// <summary>
        /// Nucleus sampling parameter (0-1)<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.<br/>
        /// Example: {"trace_id":"trace-abc123","trace_name":"my-app-trace"}
        /// </summary>
        /// <example>{"trace_id":"trace-abc123","trace_name":"my-app-trace"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace")]
        public global::OpenRouter.TraceConfig? Trace { get; set; }

        /// <summary>
        /// Per-end-user identifier for abuse isolation. Use a stable ID, hash, or pseudonym. When a provider requires a user identity, OpenRouter folds it into the hashed identity sent upstream and never forwards it raw. If omitted, requests use an account-level identity, so provider policy blocks can affect the whole account.<br/>
        /// Example: user-123
        /// </summary>
        /// <example>user-123</example>
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
        /// List of messages for the conversation<br/>
        /// Example: [{"content":"Hello!","role":"user"}]
        /// </param>
        /// <param name="cacheControl">
        /// Enable automatic prompt caching. When set at the top level, the system automatically applies cache breakpoints to the last cacheable block in the request. When set on an individual content block, it marks an explicit cache breakpoint; block-level markers also work on OpenAI models that support explicit prompt caching — OpenRouter converts them to the provider's native format.<br/>
        /// Example: {"type":"ephemeral"}
        /// </param>
        /// <param name="debug">
        /// Debug options for inspecting request transformations (streaming only)<br/>
        /// Example: {"echo_upstream_body":true}
        /// </param>
        /// <param name="frequencyPenalty">
        /// Frequency penalty (-2.0 to 2.0)<br/>
        /// Example: 0
        /// </param>
        /// <param name="imageConfig">
        /// Provider-specific image configuration options. Keys and values vary by model/provider. See https://openrouter.ai/docs/guides/overview/multimodal/image-generation for more details.<br/>
        /// Example: {"aspect_ratio":"16:9","quality":"high"}
        /// </param>
        /// <param name="logitBias">
        /// Token logit bias adjustments<br/>
        /// Example: {"50256":-100}
        /// </param>
        /// <param name="logprobs">
        /// Return log probabilities<br/>
        /// Example: false
        /// </param>
        /// <param name="maxCompletionTokens">
        /// Maximum tokens in completion<br/>
        /// Example: 100
        /// </param>
        /// <param name="maxTokens">
        /// Maximum tokens (deprecated, use max_completion_tokens). Note: some providers enforce a minimum of 16.<br/>
        /// Example: 100
        /// </param>
        /// <param name="metadata">
        /// Key-value pairs for additional object information (max 16 pairs, 64 char keys, 512 char values)<br/>
        /// Example: {"session_id":"session-456","user_id":"user-123"}
        /// </param>
        /// <param name="minP">
        /// Minimum probability threshold relative to the most likely token. Tokens with probability below min_p * (probability of top token) are filtered out. Not all providers support this parameter.<br/>
        /// Example: 0.1F
        /// </param>
        /// <param name="modalities">
        /// Output modalities for the response. Supported values are "text", "image", and "audio".<br/>
        /// Example: [text, image]
        /// </param>
        /// <param name="model">
        /// Model to use for completion<br/>
        /// Example: openai/gpt-4
        /// </param>
        /// <param name="models">
        /// Models to use for completion<br/>
        /// Example: [openai/gpt-4, openai/gpt-4o]
        /// </param>
        /// <param name="parallelToolCalls">
        /// Whether to enable parallel function calling during tool use. When true, the model may generate multiple tool calls in a single response.<br/>
        /// Example: true
        /// </param>
        /// <param name="plugins">
        /// Plugins you want to enable for this request, including their settings.
        /// </param>
        /// <param name="prediction">
        /// Static predicted output content. Supported models can use this to reduce latency when much of the response is known in advance.<br/>
        /// Example: {"content":"Expected response","type":"content"}
        /// </param>
        /// <param name="presencePenalty">
        /// Presence penalty (-2.0 to 2.0)<br/>
        /// Example: 0
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
        /// Configuration options for reasoning models<br/>
        /// Example: {"effort":"medium","summary":"concise"}
        /// </param>
        /// <param name="reasoningEffort">
        /// Shorthand for setting reasoning effort. Equivalent to setting reasoning.effort. Cannot be used simultaneously with reasoning.effort if they differ.<br/>
        /// Example: medium
        /// </param>
        /// <param name="repetitionPenalty">
        /// Penalizes tokens based on how much they have already appeared in the text. A value of 1.0 means no penalty. Values above 1.0 penalize repeated tokens more strongly. Not all providers support this parameter.<br/>
        /// Example: 1
        /// </param>
        /// <param name="responseFormat">
        /// Response format configuration<br/>
        /// Example: {"type":"json_object"}
        /// </param>
        /// <param name="seed">
        /// Random seed for deterministic outputs<br/>
        /// Example: 42
        /// </param>
        /// <param name="serviceTier">
        /// The service tier to use for processing this request. `fast` is accepted as an alias for `priority`. `ultrafast` prefers ultrafast endpoints and falls back to `priority`, then default endpoints.<br/>
        /// Example: auto
        /// </param>
        /// <param name="sessionId">
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow). When provided, OpenRouter uses it as the sticky routing key, routing all requests in the session to the same provider to maximize prompt cache hits. Also used for observability grouping. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.
        /// </param>
        /// <param name="stop">
        /// Stop sequences (up to 4)<br/>
        /// Example: []
        /// </param>
        /// <param name="stopServerToolsWhen">
        /// Stop conditions for the server-tool agent loop. Any condition firing halts the loop (OR logic). When set, this overrides `max_tool_calls`. When a condition fires while the model is still emitting tool calls, the pending tool calls are executed and one final turn is made with tool calls disabled so the response ends with a natural-language answer instead of an unfinished tool call.<br/>
        /// Example: [{"step_count":5,"type":"step_count_is"}, {"max_cost_in_dollars":0.5,"type":"max_cost"}]
        /// </param>
        /// <param name="stream">
        /// Enable streaming response<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="streamOptions">
        /// Streaming configuration options<br/>
        /// Example: {"include_usage":true}
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature (0-2)<br/>
        /// Example: 0.7F
        /// </param>
        /// <param name="toolChoice">
        /// Tool choice configuration<br/>
        /// Example: auto
        /// </param>
        /// <param name="tools">
        /// Available tools for function calling<br/>
        /// Example: [{"function":{"description":"Get weather","name":"get_weather"},"type":"function"}]
        /// </param>
        /// <param name="topA">
        /// Consider only tokens with "sufficiently high" probabilities based on the probability of the most likely token. Not all providers support this parameter.<br/>
        /// Example: 0
        /// </param>
        /// <param name="topK">
        /// Limits the model to choose from the top K most likely tokens at each step. A value of 1 means the model will always pick the most likely next token. Not all providers support this parameter.<br/>
        /// Example: 40
        /// </param>
        /// <param name="topLogprobs">
        /// Number of top log probabilities to return (0-20)<br/>
        /// Example: 5
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling parameter (0-1)<br/>
        /// Example: 1
        /// </param>
        /// <param name="trace">
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.<br/>
        /// Example: {"trace_id":"trace-abc123","trace_name":"my-app-trace"}
        /// </param>
        /// <param name="user">
        /// Per-end-user identifier for abuse isolation. Use a stable ID, hash, or pseudonym. When a provider requires a user identity, OpenRouter folds it into the hashed identity sent upstream and never forwards it raw. If omitted, requests use an account-level identity, so provider policy blocks can affect the whole account.<br/>
        /// Example: user-123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRequest(
            global::System.Collections.Generic.IList<global::OpenRouter.ChatMessages> messages,
            global::OpenRouter.AnthropicCacheControlDirective? cacheControl,
            global::OpenRouter.ChatDebugOptions? debug,
            double? frequencyPenalty,
            global::OpenRouter.ImageConfig? imageConfig,
            global::System.Collections.Generic.Dictionary<string, double>? logitBias,
            bool? logprobs,
            int? maxCompletionTokens,
            int? maxTokens,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            double? minP,
            global::System.Collections.Generic.IList<global::OpenRouter.ChatRequestModalitie>? modalities,
            string? model,
            global::System.Collections.Generic.IList<global::OpenRouter.AllOf<string, object>>? models,
            bool? parallelToolCalls,
            global::System.Collections.Generic.IList<global::OpenRouter.PluginsItem>? plugins,
            global::OpenRouter.Prediction? prediction,
            double? presencePenalty,
            string? promptCacheKey,
            global::OpenRouter.PromptCacheOptions? promptCacheOptions,
            global::OpenRouter.ProviderPreferences? provider,
            global::OpenRouter.ChatRequestReasoning? reasoning,
            global::OpenRouter.ChatRequestReasoningEffort2? reasoningEffort,
            double? repetitionPenalty,
            global::OpenRouter.ResponseFormat? responseFormat,
            int? seed,
            global::OpenRouter.ChatRequestServiceTier? serviceTier,
            string? sessionId,
            global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? stop,
            global::System.Collections.Generic.IList<global::OpenRouter.StopServerToolsWhenCondition>? stopServerToolsWhen,
            bool? stream,
            global::OpenRouter.ChatStreamOptions? streamOptions,
            double? temperature,
            global::OpenRouter.ChatToolChoice? toolChoice,
            global::System.Collections.Generic.IList<global::OpenRouter.ChatFunctionTool>? tools,
            double? topA,
            int? topK,
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
            this.MinP = minP;
            this.Modalities = modalities;
            this.Model = model;
            this.Models = models;
            this.ParallelToolCalls = parallelToolCalls;
            this.Plugins = plugins;
            this.Prediction = prediction;
            this.PresencePenalty = presencePenalty;
            this.PromptCacheKey = promptCacheKey;
            this.PromptCacheOptions = promptCacheOptions;
            this.Provider = provider;
            this.Reasoning = reasoning;
            this.ReasoningEffort = reasoningEffort;
            this.RepetitionPenalty = repetitionPenalty;
            this.ResponseFormat = responseFormat;
            this.Seed = seed;
            this.ServiceTier = serviceTier;
            this.SessionId = sessionId;
            this.Stop = stop;
            this.StopServerToolsWhen = stopServerToolsWhen;
            this.Stream = stream;
            this.StreamOptions = streamOptions;
            this.Temperature = temperature;
            this.ToolChoice = toolChoice;
            this.Tools = tools;
            this.TopA = topA;
            this.TopK = topK;
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