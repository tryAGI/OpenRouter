
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Request schema for Anthropic Messages API endpoint
    /// </summary>
    public sealed partial class MessagesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestSystemJsonConverter))]
        public global::OpenRouter.MessagesRequestSystem? System { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::OpenRouter.MessagesRequestMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_sequences")]
        public global::System.Collections.Generic.IList<string>? StopSequences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::OpenRouter.MessagesRequestToolsItems>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestToolChoiceJsonConverter))]
        public global::OpenRouter.MessagesRequestToolChoice? ToolChoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestThinkingJsonConverter))]
        public global::OpenRouter.MessagesRequestThinking? Thinking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestServiceTierJsonConverter))]
        public global::OpenRouter.MessagesRequestServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// Configuration for controlling output behavior. Supports the effort parameter and structured output format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_config")]
        public global::OpenRouter.MessagesOutputConfig? OutputConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::OpenRouter.AnthropicCacheControlDirective? CacheControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_management")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesRequestContextManagement, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.MessagesRequestContextManagement, object>? ContextManagement { get; set; }

        /// <summary>
        /// When multiple model providers are available, optionally indicate your routing preference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesRequestProvider, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.MessagesRequestProvider, object>? Provider { get; set; }

        /// <summary>
        /// Plugins you want to enable for this request, including their settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugins")]
        public global::System.Collections.Generic.IList<global::OpenRouter.MessagesRequestPluginsItems>? Plugins { get; set; }

        /// <summary>
        /// A unique identifier representing your end-user, which helps distinguish between different users of your app. This allows your app to identify specific users in case of abuse reports, preventing your entire app from being affected by the actions of individual users. Maximum of 256 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow) for observability. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace")]
        public global::OpenRouter.MessagesRequestTrace? Trace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// Controls output generation speed. When set to `fast`, uses a higher-speed inference configuration at premium pricing. Defaults to `standard` when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesRequestSpeedJsonConverter))]
        public global::OpenRouter.MessagesRequestSpeed? Speed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequest" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="maxTokens"></param>
        /// <param name="messages"></param>
        /// <param name="system"></param>
        /// <param name="metadata"></param>
        /// <param name="stopSequences"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="topK"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="thinking"></param>
        /// <param name="serviceTier"></param>
        /// <param name="outputConfig">
        /// Configuration for controlling output behavior. Supports the effort parameter and structured output format.
        /// </param>
        /// <param name="cacheControl"></param>
        /// <param name="stream"></param>
        /// <param name="contextManagement"></param>
        /// <param name="provider">
        /// When multiple model providers are available, optionally indicate your routing preference.
        /// </param>
        /// <param name="plugins">
        /// Plugins you want to enable for this request, including their settings.
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which helps distinguish between different users of your app. This allows your app to identify specific users in case of abuse reports, preventing your entire app from being affected by the actions of individual users. Maximum of 256 characters.
        /// </param>
        /// <param name="sessionId">
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow) for observability. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.
        /// </param>
        /// <param name="trace">
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.
        /// </param>
        /// <param name="models"></param>
        /// <param name="speed">
        /// Controls output generation speed. When set to `fast`, uses a higher-speed inference configuration at premium pricing. Defaults to `standard` when omitted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequest(
            string model,
            int? maxTokens,
            global::System.Collections.Generic.IList<global::OpenRouter.MessagesMessageParam>? messages,
            global::OpenRouter.MessagesRequestSystem? system,
            global::OpenRouter.MessagesRequestMetadata? metadata,
            global::System.Collections.Generic.IList<string>? stopSequences,
            double? temperature,
            double? topP,
            int? topK,
            global::System.Collections.Generic.IList<global::OpenRouter.MessagesRequestToolsItems>? tools,
            global::OpenRouter.MessagesRequestToolChoice? toolChoice,
            global::OpenRouter.MessagesRequestThinking? thinking,
            global::OpenRouter.MessagesRequestServiceTier? serviceTier,
            global::OpenRouter.MessagesOutputConfig? outputConfig,
            global::OpenRouter.AnthropicCacheControlDirective? cacheControl,
            bool? stream,
            global::OpenRouter.OneOf<global::OpenRouter.MessagesRequestContextManagement, object>? contextManagement,
            global::OpenRouter.OneOf<global::OpenRouter.MessagesRequestProvider, object>? provider,
            global::System.Collections.Generic.IList<global::OpenRouter.MessagesRequestPluginsItems>? plugins,
            string? user,
            string? sessionId,
            global::OpenRouter.MessagesRequestTrace? trace,
            global::System.Collections.Generic.IList<string>? models,
            global::OpenRouter.MessagesRequestSpeed? speed)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.MaxTokens = maxTokens;
            this.Messages = messages;
            this.System = system;
            this.Metadata = metadata;
            this.StopSequences = stopSequences;
            this.Temperature = temperature;
            this.TopP = topP;
            this.TopK = topK;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Thinking = thinking;
            this.ServiceTier = serviceTier;
            this.OutputConfig = outputConfig;
            this.CacheControl = cacheControl;
            this.Stream = stream;
            this.ContextManagement = contextManagement;
            this.Provider = provider;
            this.Plugins = plugins;
            this.User = user;
            this.SessionId = sessionId;
            this.Trace = trace;
            this.Models = models;
            this.Speed = speed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequest" /> class.
        /// </summary>
        public MessagesRequest()
        {
        }
    }
}