
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Configuration for the openrouter:advisor server tool.
    /// </summary>
    public sealed partial class AdvisorServerToolConfig
    {
        /// <summary>
        /// Roster of named advisor profiles. When set, the executor model selects one by passing its `name` to the advisor tool; the chosen profile's config overrides the request-wide advisor parameters. Profile names must be unique.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advisors")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AdvisorProfile>? Advisors { get; set; }

        /// <summary>
        /// When true, the full parent conversation is forwarded to the advisor so it sees the same context the executor does (and the tool-call `prompt`, if given, is appended as a final user turn). When false or omitted, the advisor receives only the `prompt` the executor passes in the tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forward_transcript")]
        public bool? ForwardTranscript { get; set; }

        /// <summary>
        /// System instructions for the advisor sub-agent. When omitted, the advisor responds with no system prompt of its own.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Maximum number of output tokens (including reasoning) the advisor may produce. When omitted, the provider's default applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// Maximum number of tool-calling steps the advisor sub-agent may take during its agentic loop. Capped at 25. Only relevant when the advisor is given tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tool_calls")]
        public int? MaxToolCalls { get; set; }

        /// <summary>
        /// Slug of the advisor model to consult (any OpenRouter model). When omitted, the executor can choose it via the tool call's `model` argument; if neither is set, the model from the outer API request is used. The advisor tool itself cannot be the advisor model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Reasoning configuration forwarded to the advisor call. Use this to control reasoning effort and token budget for models that support extended thinking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::OpenRouter.AdvisorReasoning? Reasoning { get; set; }

        /// <summary>
        /// Sampling temperature forwarded to the advisor call. When omitted, the provider's default applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Tools the advisor sub-agent may use while forming its advice. The advisor runs as an agentic sub-agent over these tools, then returns its text. Must not include the advisor tool itself.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AdvisorNestedTool>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvisorServerToolConfig" /> class.
        /// </summary>
        /// <param name="advisors">
        /// Roster of named advisor profiles. When set, the executor model selects one by passing its `name` to the advisor tool; the chosen profile's config overrides the request-wide advisor parameters. Profile names must be unique.
        /// </param>
        /// <param name="forwardTranscript">
        /// When true, the full parent conversation is forwarded to the advisor so it sees the same context the executor does (and the tool-call `prompt`, if given, is appended as a final user turn). When false or omitted, the advisor receives only the `prompt` the executor passes in the tool call.
        /// </param>
        /// <param name="instructions">
        /// System instructions for the advisor sub-agent. When omitted, the advisor responds with no system prompt of its own.
        /// </param>
        /// <param name="maxCompletionTokens">
        /// Maximum number of output tokens (including reasoning) the advisor may produce. When omitted, the provider's default applies.
        /// </param>
        /// <param name="maxToolCalls">
        /// Maximum number of tool-calling steps the advisor sub-agent may take during its agentic loop. Capped at 25. Only relevant when the advisor is given tools.
        /// </param>
        /// <param name="model">
        /// Slug of the advisor model to consult (any OpenRouter model). When omitted, the executor can choose it via the tool call's `model` argument; if neither is set, the model from the outer API request is used. The advisor tool itself cannot be the advisor model.
        /// </param>
        /// <param name="reasoning">
        /// Reasoning configuration forwarded to the advisor call. Use this to control reasoning effort and token budget for models that support extended thinking.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature forwarded to the advisor call. When omitted, the provider's default applies.
        /// </param>
        /// <param name="tools">
        /// Tools the advisor sub-agent may use while forming its advice. The advisor runs as an agentic sub-agent over these tools, then returns its text. Must not include the advisor tool itself.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdvisorServerToolConfig(
            global::System.Collections.Generic.IList<global::OpenRouter.AdvisorProfile>? advisors,
            bool? forwardTranscript,
            string? instructions,
            int? maxCompletionTokens,
            int? maxToolCalls,
            string? model,
            global::OpenRouter.AdvisorReasoning? reasoning,
            double? temperature,
            global::System.Collections.Generic.IList<global::OpenRouter.AdvisorNestedTool>? tools)
        {
            this.Advisors = advisors;
            this.ForwardTranscript = forwardTranscript;
            this.Instructions = instructions;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.MaxToolCalls = maxToolCalls;
            this.Model = model;
            this.Reasoning = reasoning;
            this.Temperature = temperature;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvisorServerToolConfig" /> class.
        /// </summary>
        public AdvisorServerToolConfig()
        {
        }

    }
}