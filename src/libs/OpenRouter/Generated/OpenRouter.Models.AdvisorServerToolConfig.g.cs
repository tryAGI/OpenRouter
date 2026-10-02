
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Configuration for one openrouter:advisor server tool entry.<br/>
    /// Example: {"model":"~anthropic/claude-opus-latest","name":"reviewer"}
    /// </summary>
    public sealed partial class AdvisorServerToolConfig
    {
        /// <summary>
        /// When true, the full parent conversation is forwarded to the advisor so it sees the same context the executor does (and the tool-call `prompt`, if given, is appended as a final user turn). When false or omitted, the advisor receives only the `prompt` the executor passes in the tool call.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("forward_transcript")]
        public bool? ForwardTranscript { get; set; }

        /// <summary>
        /// System instructions for the advisor sub-agent. When omitted, the advisor responds with no system prompt of its own.<br/>
        /// Example: You are a senior staff engineer. Give a focused, decisive plan.
        /// </summary>
        /// <example>You are a senior staff engineer. Give a focused, decisive plan.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Maximum number of output tokens (including reasoning) the advisor may produce. When omitted, the provider's default applies.<br/>
        /// Example: 2048
        /// </summary>
        /// <example>2048</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// Slug of the advisor model to consult (any OpenRouter model). When omitted, the executor can choose it via the tool call's `model` argument; if neither is set, the model from the outer API request is used.<br/>
        /// Example: ~anthropic/claude-opus-latest
        /// </summary>
        /// <example>~anthropic/claude-opus-latest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Optional name for this advisor. The model sees one tool per named advisor (and one default for an unnamed entry). Names must be unique across advisor entries. Letters, digits, spaces, underscores, and dashes; trimmed; 1–64 chars.<br/>
        /// Example: reviewer
        /// </summary>
        /// <example>reviewer</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Reasoning configuration forwarded to the advisor call. Use this to control reasoning effort and token budget for models that support extended thinking.<br/>
        /// Example: {"effort":"high"}
        /// </summary>
        /// <example>{"effort":"high"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::OpenRouter.AdvisorReasoning? Reasoning { get; set; }

        /// <summary>
        /// When true, the advisor's advice streams incrementally as it is produced. In the Responses API this emits `response.output_text.delta` events targeting the advisor output item; the final `advice` field is still set on the completed item. Has no effect on the Chat Completions API (where the advice arrives only as the final tool result). When false or omitted, the advice arrives only as the final result.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Sampling temperature forwarded to the advisor call. When omitted, the provider's default applies.<br/>
        /// Example: 0.7F
        /// </summary>
        /// <example>0.7F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvisorServerToolConfig" /> class.
        /// </summary>
        /// <param name="forwardTranscript">
        /// When true, the full parent conversation is forwarded to the advisor so it sees the same context the executor does (and the tool-call `prompt`, if given, is appended as a final user turn). When false or omitted, the advisor receives only the `prompt` the executor passes in the tool call.<br/>
        /// Example: false
        /// </param>
        /// <param name="instructions">
        /// System instructions for the advisor sub-agent. When omitted, the advisor responds with no system prompt of its own.<br/>
        /// Example: You are a senior staff engineer. Give a focused, decisive plan.
        /// </param>
        /// <param name="maxCompletionTokens">
        /// Maximum number of output tokens (including reasoning) the advisor may produce. When omitted, the provider's default applies.<br/>
        /// Example: 2048
        /// </param>
        /// <param name="model">
        /// Slug of the advisor model to consult (any OpenRouter model). When omitted, the executor can choose it via the tool call's `model` argument; if neither is set, the model from the outer API request is used.<br/>
        /// Example: ~anthropic/claude-opus-latest
        /// </param>
        /// <param name="name">
        /// Optional name for this advisor. The model sees one tool per named advisor (and one default for an unnamed entry). Names must be unique across advisor entries. Letters, digits, spaces, underscores, and dashes; trimmed; 1–64 chars.<br/>
        /// Example: reviewer
        /// </param>
        /// <param name="reasoning">
        /// Reasoning configuration forwarded to the advisor call. Use this to control reasoning effort and token budget for models that support extended thinking.<br/>
        /// Example: {"effort":"high"}
        /// </param>
        /// <param name="stream">
        /// When true, the advisor's advice streams incrementally as it is produced. In the Responses API this emits `response.output_text.delta` events targeting the advisor output item; the final `advice` field is still set on the completed item. Has no effect on the Chat Completions API (where the advice arrives only as the final tool result). When false or omitted, the advice arrives only as the final result.<br/>
        /// Example: false
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature forwarded to the advisor call. When omitted, the provider's default applies.<br/>
        /// Example: 0.7F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdvisorServerToolConfig(
            bool? forwardTranscript,
            string? instructions,
            int? maxCompletionTokens,
            string? model,
            string? name,
            global::OpenRouter.AdvisorReasoning? reasoning,
            bool? stream,
            double? temperature)
        {
            this.ForwardTranscript = forwardTranscript;
            this.Instructions = instructions;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.Model = model;
            this.Name = name;
            this.Reasoning = reasoning;
            this.Stream = stream;
            this.Temperature = temperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvisorServerToolConfig" /> class.
        /// </summary>
        public AdvisorServerToolConfig()
        {
        }

    }
}