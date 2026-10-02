
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"completed_at":1704067210,"created_at":1704067200,"error":null,"frequency_penalty":null,"id":"resp-abc123","incomplete_details":null,"instructions":null,"max_output_tokens":null,"metadata":null,"model":"gpt-4","object":"response","output":[],"parallel_tool_calls":true,"presence_penalty":null,"status":"completed","temperature":null,"tool_choice":"auto","tools":[],"top_p":null}
    /// </summary>
    public sealed partial class BaseResponsesResult
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
        public int? CompletedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// Error information returned from the API<br/>
        /// Example: {"code":"rate_limit_exceeded","message":"Rate limit exceeded. Please try again later."}
        /// </summary>
        /// <example>{"code":"rate_limit_exceeded","message":"Rate limit exceeded. Please try again later."}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::OpenRouter.ResponsesErrorField? Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Example: {"reason":"max_output_tokens"}
        /// </summary>
        /// <example>{"reason":"max_output_tokens"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("incomplete_details")]
        public global::OpenRouter.IncompleteDetails? IncompleteDetails { get; set; }

        /// <summary>
        /// Example: [{"content":"What is the weather today?","role":"user"}]
        /// </summary>
        /// <example>[{"content":"What is the weather today?","role":"user"}]</example>
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
        /// Metadata key-value pairs for the request. Keys must be ≤64 characters and cannot contain brackets. Values must be ≤512 characters. Maximum 16 pairs allowed.<br/>
        /// Example: {"session_id":"abc-def-ghi","user_id":"123"}
        /// </summary>
        /// <example>{"session_id":"abc-def-ghi","user_id":"123"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

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
        public required global::System.Collections.Generic.IList<global::OpenRouter.OutputItem> Output { get; set; }

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
        public double? PresencePenalty { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_response_id")]
        public string? PreviousResponseId { get; set; }

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
        /// Example: {"effort":"medium","summary":"auto"}
        /// </summary>
        /// <example>{"effort":"medium","summary":"auto"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::OpenRouter.BaseReasoningConfig? Reasoning { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_identifier")]
        public string? SafetyIdentifier { get; set; }

        /// <summary>
        /// Example: default
        /// </summary>
        /// <example>default</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ServiceTierJsonConverter))]
        public global::OpenRouter.ServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// Example: completed
        /// </summary>
        /// <example>completed</example>
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
        public double? Temperature { get; set; }

        /// <summary>
        /// Text output configuration including format and verbosity<br/>
        /// Example: {"format":{"type":"text"},"verbosity":"medium"}
        /// </summary>
        /// <example>{"format":{"type":"text"},"verbosity":"medium"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::OpenRouter.TextConfig? Text { get; set; }

        /// <summary>
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenAIResponsesToolChoiceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OpenAIResponsesToolChoice ToolChoice { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.AllOf<global::OpenRouter.FunctionTool, global::OpenRouter.BaseResponsesResultToolVariant1>?, global::OpenRouter.PreviewWebSearchServerTool, global::OpenRouter.Preview20250311WebSearchServerTool, global::OpenRouter.LegacyWebSearchServerTool, global::OpenRouter.WebSearchServerTool, global::OpenRouter.FileSearchServerTool, global::OpenRouter.ComputerUseServerTool, global::OpenRouter.CodeInterpreterServerTool, global::OpenRouter.McpServerTool, global::OpenRouter.ImageGenerationServerTool, global::OpenRouter.CodexLocalShellTool, global::OpenRouter.ShellServerTool, global::OpenRouter.ApplyPatchServerTool, global::OpenRouter.CustomTool, global::OpenRouter.NamespaceTool>> Tools { get; set; }

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
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.TruncationJsonConverter))]
        public global::OpenRouter.Truncation? Truncation { get; set; }

        /// <summary>
        /// Example: {"input_tokens":100,"input_tokens_details":{"cached_tokens":0},"output_tokens":50,"output_tokens_details":{"reasoning_tokens":0},"total_tokens":150}
        /// </summary>
        /// <example>{"input_tokens":100,"input_tokens_details":{"cached_tokens":0},"output_tokens":50,"output_tokens_details":{"reasoning_tokens":0},"total_tokens":150}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::OpenRouter.OpenAIResponsesUsage? Usage { get; set; }

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
        /// Initializes a new instance of the <see cref="BaseResponsesResult" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="instructions">
        /// Example: [{"content":"What is the weather today?","role":"user"}]
        /// </param>
        /// <param name="model"></param>
        /// <param name="output"></param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="status">
        /// Example: completed
        /// </param>
        /// <param name="toolChoice">
        /// Example: auto
        /// </param>
        /// <param name="tools"></param>
        /// <param name="background"></param>
        /// <param name="completedAt"></param>
        /// <param name="error">
        /// Error information returned from the API<br/>
        /// Example: {"code":"rate_limit_exceeded","message":"Rate limit exceeded. Please try again later."}
        /// </param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="incompleteDetails">
        /// Example: {"reason":"max_output_tokens"}
        /// </param>
        /// <param name="maxOutputTokens"></param>
        /// <param name="maxToolCalls"></param>
        /// <param name="metadata">
        /// Metadata key-value pairs for the request. Keys must be ≤64 characters and cannot contain brackets. Values must be ≤512 characters. Maximum 16 pairs allowed.<br/>
        /// Example: {"session_id":"abc-def-ghi","user_id":"123"}
        /// </param>
        /// <param name="object"></param>
        /// <param name="outputText"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="previousResponseId"></param>
        /// <param name="prompt">
        /// Example: {"id":"prompt-abc123","variables":{"name":"John"}}
        /// </param>
        /// <param name="promptCacheKey"></param>
        /// <param name="promptCacheOptions">
        /// Request-level prompt-cache controls. `mode: "explicit"` disables OpenAI-managed breakpoints so only blocks marked with `prompt_cache_breakpoint` are cached. Only supported by OpenAI GPT-5.6 and newer.<br/>
        /// Example: {"mode":"explicit","ttl":"30m"}
        /// </param>
        /// <param name="reasoning">
        /// Example: {"effort":"medium","summary":"auto"}
        /// </param>
        /// <param name="safetyIdentifier"></param>
        /// <param name="serviceTier">
        /// Example: default
        /// </param>
        /// <param name="store"></param>
        /// <param name="temperature"></param>
        /// <param name="text">
        /// Text output configuration including format and verbosity<br/>
        /// Example: {"format":{"type":"text"},"verbosity":"medium"}
        /// </param>
        /// <param name="topLogprobs"></param>
        /// <param name="topP"></param>
        /// <param name="truncation">
        /// Example: auto
        /// </param>
        /// <param name="usage">
        /// Example: {"input_tokens":100,"input_tokens_details":{"cached_tokens":0},"output_tokens":50,"output_tokens_details":{"reasoning_tokens":0},"total_tokens":150}
        /// </param>
        /// <param name="user"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseResponsesResult(
            int createdAt,
            string id,
            global::OpenRouter.BaseInputs instructions,
            string model,
            global::System.Collections.Generic.IList<global::OpenRouter.OutputItem> output,
            bool parallelToolCalls,
            global::OpenRouter.OpenAIResponsesResponseStatus status,
            global::OpenRouter.OpenAIResponsesToolChoice toolChoice,
            global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.AllOf<global::OpenRouter.FunctionTool, global::OpenRouter.BaseResponsesResultToolVariant1>?, global::OpenRouter.PreviewWebSearchServerTool, global::OpenRouter.Preview20250311WebSearchServerTool, global::OpenRouter.LegacyWebSearchServerTool, global::OpenRouter.WebSearchServerTool, global::OpenRouter.FileSearchServerTool, global::OpenRouter.ComputerUseServerTool, global::OpenRouter.CodeInterpreterServerTool, global::OpenRouter.McpServerTool, global::OpenRouter.ImageGenerationServerTool, global::OpenRouter.CodexLocalShellTool, global::OpenRouter.ShellServerTool, global::OpenRouter.ApplyPatchServerTool, global::OpenRouter.CustomTool, global::OpenRouter.NamespaceTool>> tools,
            bool? background,
            int? completedAt,
            global::OpenRouter.ResponsesErrorField? error,
            double? frequencyPenalty,
            global::OpenRouter.IncompleteDetails? incompleteDetails,
            int? maxOutputTokens,
            int? maxToolCalls,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::OpenRouter.BaseResponsesResultObject @object,
            string? outputText,
            double? presencePenalty,
            string? previousResponseId,
            global::OpenRouter.StoredPromptTemplate? prompt,
            string? promptCacheKey,
            global::OpenRouter.PromptCacheOptions? promptCacheOptions,
            global::OpenRouter.BaseReasoningConfig? reasoning,
            string? safetyIdentifier,
            global::OpenRouter.ServiceTier? serviceTier,
            bool? store,
            double? temperature,
            global::OpenRouter.TextConfig? text,
            int? topLogprobs,
            double? topP,
            global::OpenRouter.Truncation? truncation,
            global::OpenRouter.OpenAIResponsesUsage? usage,
            string? user)
        {
            this.Background = background;
            this.CompletedAt = completedAt;
            this.CreatedAt = createdAt;
            this.Error = error;
            this.FrequencyPenalty = frequencyPenalty;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IncompleteDetails = incompleteDetails;
            this.Instructions = instructions;
            this.MaxOutputTokens = maxOutputTokens;
            this.MaxToolCalls = maxToolCalls;
            this.Metadata = metadata;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Object = @object;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.OutputText = outputText;
            this.ParallelToolCalls = parallelToolCalls;
            this.PresencePenalty = presencePenalty;
            this.PreviousResponseId = previousResponseId;
            this.Prompt = prompt;
            this.PromptCacheKey = promptCacheKey;
            this.PromptCacheOptions = promptCacheOptions;
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
        /// Initializes a new instance of the <see cref="BaseResponsesResult" /> class.
        /// </summary>
        public BaseResponsesResult()
        {
        }

    }
}