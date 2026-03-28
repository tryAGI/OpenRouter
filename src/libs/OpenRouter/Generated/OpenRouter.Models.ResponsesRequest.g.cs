
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Request schema for Responses endpoint
    /// </summary>
    public sealed partial class ResponsesRequest
    {
        /// <summary>
        /// Input for a response request - can be a string or array of items
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InputsJsonConverter))]
        public global::OpenRouter.Inputs? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Metadata key-value pairs for the request. Keys must be ≤64 characters and cannot contain brackets. Values must be ≤512 characters. Maximum 16 pairs allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestToolsItems>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenAIResponsesToolChoiceJsonConverter))]
        public global::OpenRouter.OpenAIResponsesToolChoice? ToolChoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

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
        /// Text output configuration including format and verbosity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::OpenRouter.TextExtendedConfig? Text { get; set; }

        /// <summary>
        /// Configuration for reasoning mode in the response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::OpenRouter.ReasoningConfig? Reasoning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        public double? MaxOutputTokens { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public int? TopLogprobs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tool_calls")]
        public int? MaxToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public double? TopK { get; set; }

        /// <summary>
        /// Provider-specific image configuration options. Keys and values vary by model/provider. See https://openrouter.ai/docs/features/multimodal/image-generation for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_config")]
        public object? ImageConfig { get; set; }

        /// <summary>
        /// Output modalities for the response. Supported values are "text" and "image".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputModalityEnum>? Modalities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_key")]
        public string? PromptCacheKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_response_id")]
        public string? PreviousResponseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::OpenRouter.StoredPromptTemplate? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ResponseIncludesEnum>? Include { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public bool? Background { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_identifier")]
        public string? SafetyIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        public bool? Store { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ResponsesRequestServiceTier?, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.ResponsesRequestServiceTier?, object>? ServiceTier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenAIResponsesTruncationJsonConverter))]
        public global::OpenRouter.OpenAIResponsesTruncation? Truncation { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// When multiple model providers are available, optionally indicate your routing preference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ResponsesRequestProvider, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.ResponsesRequestProvider, object>? Provider { get; set; }

        /// <summary>
        /// Plugins you want to enable for this request, including their settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugins")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestPluginsItems>? Plugins { get; set; }

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
        public global::OpenRouter.ResponsesRequestTrace? Trace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Input for a response request - can be a string or array of items
        /// </param>
        /// <param name="instructions"></param>
        /// <param name="metadata">
        /// Metadata key-value pairs for the request. Keys must be ≤64 characters and cannot contain brackets. Values must be ≤512 characters. Maximum 16 pairs allowed.
        /// </param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="model"></param>
        /// <param name="models"></param>
        /// <param name="text">
        /// Text output configuration including format and verbosity
        /// </param>
        /// <param name="reasoning">
        /// Configuration for reasoning mode in the response
        /// </param>
        /// <param name="maxOutputTokens"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="topLogprobs"></param>
        /// <param name="maxToolCalls"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="topK"></param>
        /// <param name="imageConfig">
        /// Provider-specific image configuration options. Keys and values vary by model/provider. See https://openrouter.ai/docs/features/multimodal/image-generation for more details.
        /// </param>
        /// <param name="modalities">
        /// Output modalities for the response. Supported values are "text" and "image".
        /// </param>
        /// <param name="promptCacheKey"></param>
        /// <param name="previousResponseId"></param>
        /// <param name="prompt"></param>
        /// <param name="include"></param>
        /// <param name="background"></param>
        /// <param name="safetyIdentifier"></param>
        /// <param name="store"></param>
        /// <param name="serviceTier"></param>
        /// <param name="truncation"></param>
        /// <param name="stream">
        /// Default Value: false
        /// </param>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesRequest(
            global::OpenRouter.Inputs? input,
            string? instructions,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestToolsItems>? tools,
            global::OpenRouter.OpenAIResponsesToolChoice? toolChoice,
            bool? parallelToolCalls,
            string? model,
            global::System.Collections.Generic.IList<string>? models,
            global::OpenRouter.TextExtendedConfig? text,
            global::OpenRouter.ReasoningConfig? reasoning,
            double? maxOutputTokens,
            double? temperature,
            double? topP,
            int? topLogprobs,
            int? maxToolCalls,
            double? presencePenalty,
            double? frequencyPenalty,
            double? topK,
            object? imageConfig,
            global::System.Collections.Generic.IList<global::OpenRouter.OutputModalityEnum>? modalities,
            string? promptCacheKey,
            string? previousResponseId,
            global::OpenRouter.StoredPromptTemplate? prompt,
            global::System.Collections.Generic.IList<global::OpenRouter.ResponseIncludesEnum>? include,
            bool? background,
            string? safetyIdentifier,
            bool? store,
            global::OpenRouter.OneOf<global::OpenRouter.ResponsesRequestServiceTier?, object>? serviceTier,
            global::OpenRouter.OpenAIResponsesTruncation? truncation,
            bool? stream,
            global::OpenRouter.OneOf<global::OpenRouter.ResponsesRequestProvider, object>? provider,
            global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestPluginsItems>? plugins,
            string? user,
            string? sessionId,
            global::OpenRouter.ResponsesRequestTrace? trace)
        {
            this.Input = input;
            this.Instructions = instructions;
            this.Metadata = metadata;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.ParallelToolCalls = parallelToolCalls;
            this.Model = model;
            this.Models = models;
            this.Text = text;
            this.Reasoning = reasoning;
            this.MaxOutputTokens = maxOutputTokens;
            this.Temperature = temperature;
            this.TopP = topP;
            this.TopLogprobs = topLogprobs;
            this.MaxToolCalls = maxToolCalls;
            this.PresencePenalty = presencePenalty;
            this.FrequencyPenalty = frequencyPenalty;
            this.TopK = topK;
            this.ImageConfig = imageConfig;
            this.Modalities = modalities;
            this.PromptCacheKey = promptCacheKey;
            this.PreviousResponseId = previousResponseId;
            this.Prompt = prompt;
            this.Include = include;
            this.Background = background;
            this.SafetyIdentifier = safetyIdentifier;
            this.Store = store;
            this.ServiceTier = serviceTier;
            this.Truncation = truncation;
            this.Stream = stream;
            this.Provider = provider;
            this.Plugins = plugins;
            this.User = user;
            this.SessionId = sessionId;
            this.Trace = trace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequest" /> class.
        /// </summary>
        public ResponsesRequest()
        {
        }
    }
}