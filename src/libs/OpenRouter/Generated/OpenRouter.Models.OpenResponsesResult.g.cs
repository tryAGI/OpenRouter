
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Complete non-streaming response from the Responses API
    /// </summary>
    public sealed partial class OpenResponsesResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public bool? Background { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// Error information returned from the API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ResponsesErrorField Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FrequencyPenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("incomplete_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.IncompleteDetails IncompleteDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BaseInputsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.BaseInputs Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tool_calls")]
        public int? MaxToolCalls { get; set; }

        /// <summary>
        /// Metadata key-value pairs for the request. Keys must be ≤64 characters and cannot contain brackets. Values must be ≤512 characters. Maximum 16 pairs allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BaseResponsesResultObjectJsonConverter))]
        public global::OpenRouter.BaseResponsesResultObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.OutputItems> Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_text")]
        public string? OutputText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ParallelToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PresencePenalty { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_key")]
        public string? PromptCacheKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::OpenRouter.BaseReasoningConfig? Reasoning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_identifier")]
        public string? SafetyIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        public string? ServiceTier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenAIResponsesResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OpenAIResponsesResponseStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        public bool? Store { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Temperature { get; set; }

        /// <summary>
        /// Text output configuration including format and verbosity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::OpenRouter.TextConfig? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenAIResponsesToolChoiceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OpenAIResponsesToolChoice ToolChoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.BaseResponsesResultToolsItems> Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public int? TopLogprobs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TopP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.TruncationJsonConverter))]
        public global::OpenRouter.Truncation? Truncation { get; set; }

        /// <summary>
        /// Token usage information for the response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::OpenRouter.Usage? Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenResponsesResult" /> class.
        /// </summary>
        /// <param name="completedAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="error">
        /// Error information returned from the API
        /// </param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="id"></param>
        /// <param name="incompleteDetails"></param>
        /// <param name="instructions"></param>
        /// <param name="metadata">
        /// Metadata key-value pairs for the request. Keys must be ≤64 characters and cannot contain brackets. Values must be ≤512 characters. Maximum 16 pairs allowed.
        /// </param>
        /// <param name="model"></param>
        /// <param name="output"></param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="status"></param>
        /// <param name="temperature"></param>
        /// <param name="toolChoice"></param>
        /// <param name="tools"></param>
        /// <param name="topP"></param>
        /// <param name="background"></param>
        /// <param name="maxOutputTokens"></param>
        /// <param name="maxToolCalls"></param>
        /// <param name="object"></param>
        /// <param name="outputText"></param>
        /// <param name="previousResponseId"></param>
        /// <param name="prompt"></param>
        /// <param name="promptCacheKey"></param>
        /// <param name="reasoning"></param>
        /// <param name="safetyIdentifier"></param>
        /// <param name="serviceTier"></param>
        /// <param name="store"></param>
        /// <param name="text">
        /// Text output configuration including format and verbosity
        /// </param>
        /// <param name="topLogprobs"></param>
        /// <param name="truncation"></param>
        /// <param name="usage">
        /// Token usage information for the response
        /// </param>
        /// <param name="user"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenResponsesResult(
            int completedAt,
            int createdAt,
            global::OpenRouter.ResponsesErrorField error,
            double frequencyPenalty,
            string id,
            global::OpenRouter.IncompleteDetails incompleteDetails,
            global::OpenRouter.BaseInputs instructions,
            global::System.Collections.Generic.Dictionary<string, string> metadata,
            string model,
            global::System.Collections.Generic.IList<global::OpenRouter.OutputItems> output,
            bool parallelToolCalls,
            double presencePenalty,
            global::OpenRouter.OpenAIResponsesResponseStatus status,
            double temperature,
            global::OpenRouter.OpenAIResponsesToolChoice toolChoice,
            global::System.Collections.Generic.IList<global::OpenRouter.BaseResponsesResultToolsItems> tools,
            double topP,
            bool? background,
            int? maxOutputTokens,
            int? maxToolCalls,
            global::OpenRouter.BaseResponsesResultObject @object,
            string? outputText,
            string? previousResponseId,
            global::OpenRouter.StoredPromptTemplate? prompt,
            string? promptCacheKey,
            global::OpenRouter.BaseReasoningConfig? reasoning,
            string? safetyIdentifier,
            string? serviceTier,
            bool? store,
            global::OpenRouter.TextConfig? text,
            int? topLogprobs,
            global::OpenRouter.Truncation? truncation,
            global::OpenRouter.Usage? usage,
            string? user)
        {
            this.Background = background;
            this.CompletedAt = completedAt;
            this.CreatedAt = createdAt;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.FrequencyPenalty = frequencyPenalty;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IncompleteDetails = incompleteDetails ?? throw new global::System.ArgumentNullException(nameof(incompleteDetails));
            this.Instructions = instructions;
            this.MaxOutputTokens = maxOutputTokens;
            this.MaxToolCalls = maxToolCalls;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Object = @object;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.OutputText = outputText;
            this.ParallelToolCalls = parallelToolCalls;
            this.PresencePenalty = presencePenalty;
            this.PreviousResponseId = previousResponseId;
            this.Prompt = prompt;
            this.PromptCacheKey = promptCacheKey;
            this.Reasoning = reasoning;
            this.SafetyIdentifier = safetyIdentifier;
            this.ServiceTier = serviceTier;
            this.Status = status;
            this.Store = store;
            this.Temperature = temperature;
            this.Text = text;
            this.ToolChoice = toolChoice;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.TopLogprobs = topLogprobs;
            this.TopP = topP;
            this.Truncation = truncation;
            this.Usage = usage;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenResponsesResult" /> class.
        /// </summary>
        public OpenResponsesResult()
        {
        }
    }
}