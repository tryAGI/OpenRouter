
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Request schema for Anthropic Messages API endpoint<br/>
    /// Example: {"max_tokens":1024,"messages":[{"content":"Hello, how are you?","role":"user"}],"model":"anthropic/claude-4.5-sonnet-20250929","temperature":0.7}
    /// </summary>
    public sealed partial class MessagesRequest
    {
        /// <summary>
        /// Enable automatic prompt caching. When set at the top level, the system automatically applies cache breakpoints to the last cacheable block in the request. When set on an individual content block, it marks an explicit cache breakpoint; block-level markers also work on OpenAI models that support explicit prompt caching — OpenRouter converts them to the provider's native format.<br/>
        /// Example: {"type":"ephemeral"}
        /// </summary>
        /// <example>{"type":"ephemeral"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::OpenRouter.AnthropicCacheControlDirective? CacheControl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_management")]
        public global::OpenRouter.MessagesRequestContextManagement? ContextManagement { get; set; }

        /// <summary>
        /// Opt-in versioned router-level deferred-tool protocol. Replay assistant reasoning unchanged on continuation; keep the catalog unchanged.<br/>
        /// Example: {"profile":"portable","protocol":"v1","search":{"max_results":5,"type":"bm25"},"validation":"runtime"}
        /// </summary>
        /// <example>{"profile":"portable","protocol":"v1","search":{"max_results":5,"type":"bm25"},"validation":"runtime"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deferred_tools")]
        public global::OpenRouter.DeferredToolsControl? DeferredTools { get; set; }

        /// <summary>
        /// Fallback models to try if the primary model fails or refuses, in order. Handled by OpenRouter multi-model routing rather than Anthropic server-side fallbacks; cannot be combined with `models`. Each entry accepts only `model`. Maximum of 3 entries.<br/>
        /// Example: [{"model":"claude-opus-4-8"}]
        /// </summary>
        /// <example>[{"model":"claude-opus-4-8"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallbacks")]
        public global::System.Collections.Generic.IList<global::OpenRouter.MessagesFallbackParam>? Fallbacks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::OpenRouter.MessagesMessageParam>? Messages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::OpenRouter.MessagesRequestMetadata? Metadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// Configuration for controlling output behavior. Supports the effort parameter and structured output format.<br/>
        /// Example: {"effort":"medium"}
        /// </summary>
        /// <example>{"effort":"medium"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_config")]
        public global::OpenRouter.MessagesOutputConfig? OutputConfig { get; set; }

        /// <summary>
        /// Plugins you want to enable for this request, including their settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugins")]
        public global::System.Collections.Generic.IList<global::OpenRouter.PluginsItem2>? Plugins { get; set; }

        /// <summary>
        /// When multiple model providers are available, optionally indicate your routing preference.<br/>
        /// Example: {"allow_fallbacks":true}
        /// </summary>
        /// <example>{"allow_fallbacks":true}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public global::OpenRouter.ProviderPreferences? Provider { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safeguards")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicSafeguard>? Safeguards { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        public string? ServiceTier { get; set; }

        /// <summary>
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow). When provided, OpenRouter uses it as the sticky routing key, routing all requests in the session to the same provider to maximize prompt cache hits. Also used for observability grouping. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AllOfJsonConverter<global::OpenRouter.AnthropicSpeed?, object>))]
        public global::OpenRouter.AllOf<global::OpenRouter.AnthropicSpeed?, object>? Speed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_sequences")]
        public global::System.Collections.Generic.IList<string>? StopSequences { get; set; }

        /// <summary>
        /// Stop conditions for the server-tool agent loop. Any condition firing halts the loop (OR logic). When set, this overrides `max_tool_calls`. When a condition fires while the model is still emitting tool calls, the pending tool calls are executed and one final turn is made with tool calls disabled so the response ends with a natural-language answer instead of an unfinished tool call.<br/>
        /// Example: [{"step_count":5,"type":"step_count_is"}, {"max_cost_in_dollars":0.5,"type":"max_cost"}]
        /// </summary>
        /// <example>[{"step_count":5,"type":"step_count_is"}, {"max_cost_in_dollars":0.5,"type":"max_cost"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_server_tools_when")]
        public global::System.Collections.Generic.IList<global::OpenRouter.StopServerToolsWhenCondition>? StopServerToolsWhen { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::OpenRouter.AnthropicTextBlockParam>>))]
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.AnthropicTextBlockParam>>? System { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesRequestThinkingVariant1, global::OpenRouter.MessagesRequestThinkingVariant2, global::OpenRouter.MessagesRequestThinkingVariant3, global::OpenRouter.MessagesRequestThinkingVariant4>))]
        public global::OpenRouter.OneOf<global::OpenRouter.MessagesRequestThinkingVariant1, global::OpenRouter.MessagesRequestThinkingVariant2, global::OpenRouter.MessagesRequestThinkingVariant3, global::OpenRouter.MessagesRequestThinkingVariant4>? Thinking { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesRequestToolChoiceVariant1, global::OpenRouter.MessagesRequestToolChoiceVariant2, global::OpenRouter.MessagesRequestToolChoiceVariant3, global::OpenRouter.MessagesRequestToolChoiceVariant4>))]
        public global::OpenRouter.OneOf<global::OpenRouter.MessagesRequestToolChoiceVariant1, global::OpenRouter.MessagesRequestToolChoiceVariant2, global::OpenRouter.MessagesRequestToolChoiceVariant3, global::OpenRouter.MessagesRequestToolChoiceVariant4>? ToolChoice { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.MessagesRequestToolVariant1, global::OpenRouter.MessagesRequestToolVariant2, global::OpenRouter.MessagesRequestToolVariant3, global::OpenRouter.MessagesRequestToolVariant4, global::OpenRouter.MessagesRequestToolVariant5, global::OpenRouter.MessagesRequestToolVariant6, global::OpenRouter.BashServerTool, global::OpenRouter.DatetimeServerTool, global::OpenRouter.ImageGenerationServerToolOpenRouter, global::OpenRouter.MessagesSearchModelsServerTool, global::OpenRouter.WebFetchServerTool, global::OpenRouter.OpenRouterWebSearchServerTool, global::OpenRouter.MessagesRequestToolVariant13, global::OpenRouter.AnthropicToolSearchToolBm25, global::OpenRouter.AnthropicToolSearchToolRegex, global::OpenRouter.ShellServerToolOpenRouter, global::OpenRouter.ToolSearchServerTool>>? Tools { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

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
        /// Initializes a new instance of the <see cref="MessagesRequest" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="cacheControl">
        /// Enable automatic prompt caching. When set at the top level, the system automatically applies cache breakpoints to the last cacheable block in the request. When set on an individual content block, it marks an explicit cache breakpoint; block-level markers also work on OpenAI models that support explicit prompt caching — OpenRouter converts them to the provider's native format.<br/>
        /// Example: {"type":"ephemeral"}
        /// </param>
        /// <param name="contextManagement"></param>
        /// <param name="deferredTools">
        /// Opt-in versioned router-level deferred-tool protocol. Replay assistant reasoning unchanged on continuation; keep the catalog unchanged.<br/>
        /// Example: {"profile":"portable","protocol":"v1","search":{"max_results":5,"type":"bm25"},"validation":"runtime"}
        /// </param>
        /// <param name="fallbacks">
        /// Fallback models to try if the primary model fails or refuses, in order. Handled by OpenRouter multi-model routing rather than Anthropic server-side fallbacks; cannot be combined with `models`. Each entry accepts only `model`. Maximum of 3 entries.<br/>
        /// Example: [{"model":"claude-opus-4-8"}]
        /// </param>
        /// <param name="maxTokens"></param>
        /// <param name="messages"></param>
        /// <param name="metadata"></param>
        /// <param name="models"></param>
        /// <param name="outputConfig">
        /// Configuration for controlling output behavior. Supports the effort parameter and structured output format.<br/>
        /// Example: {"effort":"medium"}
        /// </param>
        /// <param name="plugins">
        /// Plugins you want to enable for this request, including their settings.
        /// </param>
        /// <param name="provider">
        /// When multiple model providers are available, optionally indicate your routing preference.<br/>
        /// Example: {"allow_fallbacks":true}
        /// </param>
        /// <param name="safeguards"></param>
        /// <param name="serviceTier"></param>
        /// <param name="sessionId">
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow). When provided, OpenRouter uses it as the sticky routing key, routing all requests in the session to the same provider to maximize prompt cache hits. Also used for observability grouping. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.
        /// </param>
        /// <param name="speed"></param>
        /// <param name="stopSequences"></param>
        /// <param name="stopServerToolsWhen">
        /// Stop conditions for the server-tool agent loop. Any condition firing halts the loop (OR logic). When set, this overrides `max_tool_calls`. When a condition fires while the model is still emitting tool calls, the pending tool calls are executed and one final turn is made with tool calls disabled so the response ends with a natural-language answer instead of an unfinished tool call.<br/>
        /// Example: [{"step_count":5,"type":"step_count_is"}, {"max_cost_in_dollars":0.5,"type":"max_cost"}]
        /// </param>
        /// <param name="stream"></param>
        /// <param name="system"></param>
        /// <param name="temperature"></param>
        /// <param name="thinking"></param>
        /// <param name="toolChoice"></param>
        /// <param name="tools"></param>
        /// <param name="topK"></param>
        /// <param name="topP"></param>
        /// <param name="trace">
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.<br/>
        /// Example: {"trace_id":"trace-abc123","trace_name":"my-app-trace"}
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which helps distinguish between different users of your app. This allows your app to identify specific users in case of abuse reports, preventing your entire app from being affected by the actions of individual users. Maximum of 256 characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequest(
            string model,
            global::OpenRouter.AnthropicCacheControlDirective? cacheControl,
            global::OpenRouter.MessagesRequestContextManagement? contextManagement,
            global::OpenRouter.DeferredToolsControl? deferredTools,
            global::System.Collections.Generic.IList<global::OpenRouter.MessagesFallbackParam>? fallbacks,
            int? maxTokens,
            global::System.Collections.Generic.IList<global::OpenRouter.MessagesMessageParam>? messages,
            global::OpenRouter.MessagesRequestMetadata? metadata,
            global::System.Collections.Generic.IList<string>? models,
            global::OpenRouter.MessagesOutputConfig? outputConfig,
            global::System.Collections.Generic.IList<global::OpenRouter.PluginsItem2>? plugins,
            global::OpenRouter.ProviderPreferences? provider,
            global::System.Collections.Generic.IList<global::OpenRouter.AnthropicSafeguard>? safeguards,
            string? serviceTier,
            string? sessionId,
            global::OpenRouter.AllOf<global::OpenRouter.AnthropicSpeed?, object>? speed,
            global::System.Collections.Generic.IList<string>? stopSequences,
            global::System.Collections.Generic.IList<global::OpenRouter.StopServerToolsWhenCondition>? stopServerToolsWhen,
            bool? stream,
            global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.AnthropicTextBlockParam>>? system,
            double? temperature,
            global::OpenRouter.OneOf<global::OpenRouter.MessagesRequestThinkingVariant1, global::OpenRouter.MessagesRequestThinkingVariant2, global::OpenRouter.MessagesRequestThinkingVariant3, global::OpenRouter.MessagesRequestThinkingVariant4>? thinking,
            global::OpenRouter.OneOf<global::OpenRouter.MessagesRequestToolChoiceVariant1, global::OpenRouter.MessagesRequestToolChoiceVariant2, global::OpenRouter.MessagesRequestToolChoiceVariant3, global::OpenRouter.MessagesRequestToolChoiceVariant4>? toolChoice,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.MessagesRequestToolVariant1, global::OpenRouter.MessagesRequestToolVariant2, global::OpenRouter.MessagesRequestToolVariant3, global::OpenRouter.MessagesRequestToolVariant4, global::OpenRouter.MessagesRequestToolVariant5, global::OpenRouter.MessagesRequestToolVariant6, global::OpenRouter.BashServerTool, global::OpenRouter.DatetimeServerTool, global::OpenRouter.ImageGenerationServerToolOpenRouter, global::OpenRouter.MessagesSearchModelsServerTool, global::OpenRouter.WebFetchServerTool, global::OpenRouter.OpenRouterWebSearchServerTool, global::OpenRouter.MessagesRequestToolVariant13, global::OpenRouter.AnthropicToolSearchToolBm25, global::OpenRouter.AnthropicToolSearchToolRegex, global::OpenRouter.ShellServerToolOpenRouter, global::OpenRouter.ToolSearchServerTool>>? tools,
            int? topK,
            double? topP,
            global::OpenRouter.TraceConfig? trace,
            string? user)
        {
            this.CacheControl = cacheControl;
            this.ContextManagement = contextManagement;
            this.DeferredTools = deferredTools;
            this.Fallbacks = fallbacks;
            this.MaxTokens = maxTokens;
            this.Messages = messages;
            this.Metadata = metadata;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Models = models;
            this.OutputConfig = outputConfig;
            this.Plugins = plugins;
            this.Provider = provider;
            this.Safeguards = safeguards;
            this.ServiceTier = serviceTier;
            this.SessionId = sessionId;
            this.Speed = speed;
            this.StopSequences = stopSequences;
            this.StopServerToolsWhen = stopServerToolsWhen;
            this.Stream = stream;
            this.System = system;
            this.Temperature = temperature;
            this.Thinking = thinking;
            this.ToolChoice = toolChoice;
            this.Tools = tools;
            this.TopK = topK;
            this.TopP = topP;
            this.Trace = trace;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequest" /> class.
        /// </summary>
        public MessagesRequest()
        {
        }

    }
}