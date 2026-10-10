
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Request schema for Responses endpoint<br/>
    /// Example: {"input":[{"content":"Hello, how are you?","role":"user","type":"message"}],"model":"anthropic/claude-4.5-sonnet-20250929","temperature":0.7,"tools":[{"description":"Get the current weather in a given location","name":"get_current_weather","parameters":{"properties":{"location":{"type":"string"}},"type":"object"},"type":"function"}],"top_p":0.9}
    /// </summary>
    public sealed partial class ResponsesRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public bool? Background { get; set; }

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
        /// Opt-in versioned router-level deferred-tool protocol. Replay assistant reasoning unchanged on continuation; keep the catalog unchanged.<br/>
        /// Example: {"profile":"portable","protocol":"v1","search":{"max_results":5,"type":"bm25"},"validation":"runtime"}
        /// </summary>
        /// <example>{"profile":"portable","protocol":"v1","search":{"max_results":5,"type":"bm25"},"validation":"runtime"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deferred_tools")]
        public global::OpenRouter.DeferredToolsControl? DeferredTools { get; set; }

        /// <summary>
        ///
        /// </summary>
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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ResponseIncludesEnum>? Include { get; set; }

        /// <summary>
        /// Input for a response request - can be a string or array of items<br/>
        /// Example: [{"content":"What is the weather today?","role":"user"}]
        /// </summary>
        /// <example>[{"content":"What is the weather today?","role":"user"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InputsJsonConverter))]
        public global::OpenRouter.Inputs? Input { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// Maximum number of server-tool (e.g. `openrouter:web_search`) agent steps the model may take during a request. Defaults to 30, which is also the maximum. Ignored when `stop_server_tools_when` is set.<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tool_calls")]
        public int? MaxToolCalls { get; set; }

        /// <summary>
        /// Metadata key-value pairs for the request. Keys must be ≤64 characters and cannot contain brackets. Values must be ≤512 characters. Maximum 16 pairs allowed.<br/>
        /// Example: {"session_id":"abc-def-ghi","user_id":"123"}
        /// </summary>
        /// <example>{"session_id":"abc-def-ghi","user_id":"123"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Output modalities for the response. Supported values are "text" and "image".<br/>
        /// Example: [text, image]
        /// </summary>
        /// <example>[text, image]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputModalityEnum>? Modalities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// Plugins you want to enable for this request, including their settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugins")]
        public global::System.Collections.Generic.IList<global::OpenRouter.PluginsItem3>? Plugins { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// Not supported on this proxy. Each response request is independent: no responses are stored, so a previous response cannot be referenced. Requests with a non-null value are rejected with a 400 error. Send the full conversation history in `input` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_response_id")]
        public object? PreviousResponseId { get; set; }

        /// <summary>
        /// Example: {"id":"prompt-abc123","variables":{"name":"John"}}
        /// </summary>
        /// <example>{"id":"prompt-abc123","variables":{"name":"John"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::OpenRouter.StoredPromptTemplate? Prompt { get; set; }

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
        /// Configuration for reasoning mode in the response<br/>
        /// Example: {"enabled":true,"summary":"auto"}
        /// </summary>
        /// <example>{"enabled":true,"summary":"auto"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::OpenRouter.AllOf<global::OpenRouter.BaseReasoningConfig, global::OpenRouter.ReasoningConfigVariant12>? Reasoning { get; set; }

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
        /// Recommended per-end-user identifier for abuse isolation. Use a stable ID, hash, or pseudonym. When a provider requires a user identity, OpenRouter folds it into the hashed identity sent upstream and never forwards it raw. If omitted, requests use an account-level identity, so provider policy blocks can affect the whole account.<br/>
        /// Example: user-123
        /// </summary>
        /// <example>user-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_identifier")]
        public string? SafetyIdentifier { get; set; }

        /// <summary>
        /// The service tier to use for processing this request. `fast` is accepted as an alias for `priority`. `ultrafast` prefers ultrafast endpoints and falls back to `priority`, then default endpoints.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ResponsesRequestServiceTierJsonConverter))]
        public global::OpenRouter.ResponsesRequestServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow). When provided, OpenRouter uses it as the sticky routing key, routing all requests in the session to the same provider to maximize prompt cache hits. Also used for observability grouping. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Stop conditions for the server-tool agent loop. Any condition firing halts the loop (OR logic). When set, this overrides `max_tool_calls`. When a condition fires while the model is still emitting tool calls, the pending tool calls are executed and one final turn is made with tool calls disabled so the response ends with a natural-language answer instead of an unfinished tool call.<br/>
        /// Example: [{"step_count":5,"type":"step_count_is"}, {"max_cost_in_dollars":0.5,"type":"max_cost"}]
        /// </summary>
        /// <example>[{"step_count":5,"type":"step_count_is"}, {"max_cost_in_dollars":0.5,"type":"max_cost"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_server_tools_when")]
        public global::System.Collections.Generic.IList<global::OpenRouter.StopServerToolsWhenCondition>? StopServerToolsWhen { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        public bool? Store { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Text output configuration including format and verbosity<br/>
        /// Example: {"format":{"type":"text"}}
        /// </summary>
        /// <example>{"format":{"type":"text"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.TextExtendedConfigJsonConverter))]
        public global::OpenRouter.TextExtendedConfig? Text { get; set; }

        /// <summary>
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenAIResponsesToolChoiceJsonConverter))]
        public global::OpenRouter.OpenAIResponsesToolChoice? ToolChoice { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.AllOf<global::OpenRouter.FunctionTool, global::OpenRouter.ResponsesRequestToolVariant1>?, global::OpenRouter.PreviewWebSearchServerTool, global::OpenRouter.Preview20250311WebSearchServerTool, global::OpenRouter.LegacyWebSearchServerTool, global::OpenRouter.WebSearchServerTool, global::OpenRouter.FileSearchServerTool, global::OpenRouter.ComputerUseServerTool, global::OpenRouter.CodeInterpreterServerTool, global::OpenRouter.McpServerTool, global::OpenRouter.ImageGenerationServerTool, global::OpenRouter.CodexLocalShellTool, global::OpenRouter.ShellServerTool, global::OpenRouter.ApplyPatchServerTool, global::OpenRouter.CustomTool, global::OpenRouter.NamespaceTool, global::OpenRouter.AdvisorServerToolOpenRouter, global::OpenRouter.SubagentServerToolOpenRouter, global::OpenRouter.DatetimeServerTool, global::OpenRouter.FilesServerTool, global::OpenRouter.FusionServerToolOpenRouter, global::OpenRouter.ImageGenerationServerToolOpenRouter, global::OpenRouter.SearchModelsServerToolOpenRouter, global::OpenRouter.WebFetchServerTool, global::OpenRouter.WebSearchServerToolOpenRouter, global::OpenRouter.ApplyPatchServerToolOpenRouter, global::OpenRouter.BashServerTool, global::OpenRouter.ShellServerToolOpenRouter, global::OpenRouter.ToolSearchServerTool>>? Tools { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public int? TopLogprobs { get; set; }

        /// <summary>
        ///
        /// </summary>
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
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenAIResponsesTruncationJsonConverter))]
        public global::OpenRouter.OpenAIResponsesTruncation? Truncation { get; set; }

        /// <summary>
        /// A unique identifier representing your end-user, which helps distinguish between different users of your app. This allows your app to identify specific users in case of abuse reports, preventing your entire app from being affected by the actions of individual users. Maximum of 256 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequest" /> class.
        /// </summary>
        /// <param name="background"></param>
        /// <param name="cacheControl">
        /// Enable automatic prompt caching. When set at the top level, the system automatically applies cache breakpoints to the last cacheable block in the request. When set on an individual content block, it marks an explicit cache breakpoint; block-level markers also work on OpenAI models that support explicit prompt caching — OpenRouter converts them to the provider's native format.<br/>
        /// Example: {"type":"ephemeral"}
        /// </param>
        /// <param name="debug">
        /// Debug options for inspecting request transformations (streaming only)<br/>
        /// Example: {"echo_upstream_body":true}
        /// </param>
        /// <param name="deferredTools">
        /// Opt-in versioned router-level deferred-tool protocol. Replay assistant reasoning unchanged on continuation; keep the catalog unchanged.<br/>
        /// Example: {"profile":"portable","protocol":"v1","search":{"max_results":5,"type":"bm25"},"validation":"runtime"}
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
        /// <param name="stream">
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesRequest(
            bool? background,
            global::OpenRouter.AnthropicCacheControlDirective? cacheControl,
            global::OpenRouter.ChatDebugOptions? debug,
            global::OpenRouter.DeferredToolsControl? deferredTools,
            double? frequencyPenalty,
            global::OpenRouter.ImageConfig? imageConfig,
            global::System.Collections.Generic.IList<global::OpenRouter.ResponseIncludesEnum>? include,
            global::OpenRouter.Inputs? input,
            string? instructions,
            int? maxOutputTokens,
            int? maxToolCalls,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.Collections.Generic.IList<global::OpenRouter.OutputModalityEnum>? modalities,
            string? model,
            global::System.Collections.Generic.IList<string>? models,
            bool? parallelToolCalls,
            global::System.Collections.Generic.IList<global::OpenRouter.PluginsItem3>? plugins,
            double? presencePenalty,
            object? previousResponseId,
            global::OpenRouter.StoredPromptTemplate? prompt,
            string? promptCacheKey,
            global::OpenRouter.PromptCacheOptions? promptCacheOptions,
            global::OpenRouter.ProviderPreferences? provider,
            global::OpenRouter.AllOf<global::OpenRouter.BaseReasoningConfig, global::OpenRouter.ReasoningConfigVariant12>? reasoning,
            string? safetyIdentifier,
            global::OpenRouter.ResponsesRequestServiceTier? serviceTier,
            string? sessionId,
            global::System.Collections.Generic.IList<global::OpenRouter.StopServerToolsWhenCondition>? stopServerToolsWhen,
            bool? store,
            bool? stream,
            double? temperature,
            global::OpenRouter.TextExtendedConfig? text,
            global::OpenRouter.OpenAIResponsesToolChoice? toolChoice,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.AllOf<global::OpenRouter.FunctionTool, global::OpenRouter.ResponsesRequestToolVariant1>?, global::OpenRouter.PreviewWebSearchServerTool, global::OpenRouter.Preview20250311WebSearchServerTool, global::OpenRouter.LegacyWebSearchServerTool, global::OpenRouter.WebSearchServerTool, global::OpenRouter.FileSearchServerTool, global::OpenRouter.ComputerUseServerTool, global::OpenRouter.CodeInterpreterServerTool, global::OpenRouter.McpServerTool, global::OpenRouter.ImageGenerationServerTool, global::OpenRouter.CodexLocalShellTool, global::OpenRouter.ShellServerTool, global::OpenRouter.ApplyPatchServerTool, global::OpenRouter.CustomTool, global::OpenRouter.NamespaceTool, global::OpenRouter.AdvisorServerToolOpenRouter, global::OpenRouter.SubagentServerToolOpenRouter, global::OpenRouter.DatetimeServerTool, global::OpenRouter.FilesServerTool, global::OpenRouter.FusionServerToolOpenRouter, global::OpenRouter.ImageGenerationServerToolOpenRouter, global::OpenRouter.SearchModelsServerToolOpenRouter, global::OpenRouter.WebFetchServerTool, global::OpenRouter.WebSearchServerToolOpenRouter, global::OpenRouter.ApplyPatchServerToolOpenRouter, global::OpenRouter.BashServerTool, global::OpenRouter.ShellServerToolOpenRouter, global::OpenRouter.ToolSearchServerTool>>? tools,
            int? topK,
            int? topLogprobs,
            double? topP,
            global::OpenRouter.TraceConfig? trace,
            global::OpenRouter.OpenAIResponsesTruncation? truncation,
            string? user)
        {
            this.Background = background;
            this.CacheControl = cacheControl;
            this.Debug = debug;
            this.DeferredTools = deferredTools;
            this.FrequencyPenalty = frequencyPenalty;
            this.ImageConfig = imageConfig;
            this.Include = include;
            this.Input = input;
            this.Instructions = instructions;
            this.MaxOutputTokens = maxOutputTokens;
            this.MaxToolCalls = maxToolCalls;
            this.Metadata = metadata;
            this.Modalities = modalities;
            this.Model = model;
            this.Models = models;
            this.ParallelToolCalls = parallelToolCalls;
            this.Plugins = plugins;
            this.PresencePenalty = presencePenalty;
            this.PreviousResponseId = previousResponseId;
            this.Prompt = prompt;
            this.PromptCacheKey = promptCacheKey;
            this.PromptCacheOptions = promptCacheOptions;
            this.Provider = provider;
            this.Reasoning = reasoning;
            this.SafetyIdentifier = safetyIdentifier;
            this.ServiceTier = serviceTier;
            this.SessionId = sessionId;
            this.StopServerToolsWhen = stopServerToolsWhen;
            this.Store = store;
            this.Stream = stream;
            this.Temperature = temperature;
            this.Text = text;
            this.ToolChoice = toolChoice;
            this.Tools = tools;
            this.TopK = topK;
            this.TopLogprobs = topLogprobs;
            this.TopP = topP;
            this.Trace = trace;
            this.Truncation = truncation;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequest" /> class.
        /// </summary>
        public ResponsesRequest()
        {
        }

    }
}