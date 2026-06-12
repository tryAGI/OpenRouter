
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Configuration for the openrouter:subagent server tool.
    /// </summary>
    public sealed partial class SubagentServerToolConfig
    {
        /// <summary>
        /// System instructions for the subagent. When omitted, the subagent responds with no system prompt of its own.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Maximum number of output tokens (including reasoning) the subagent may produce. When omitted, the provider's default applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// Maximum number of tool-calling steps the subagent may take during its agentic loop. Capped at 25. Only relevant when the subagent is given tools. Accepted and validated but not yet enforced on the subagent call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tool_calls")]
        public int? MaxToolCalls { get; set; }

        /// <summary>
        /// Slug of the model that executes delegated tasks (any OpenRouter model). Typically a smaller, cheaper, faster model than the one delegating. When omitted, the model from the outer API request is used. The subagent tool itself cannot be the subagent model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Reasoning configuration forwarded to the subagent call. Use this to control reasoning effort and token budget for models that support extended thinking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::OpenRouter.SubagentReasoning? Reasoning { get; set; }

        /// <summary>
        /// Sampling temperature forwarded to the subagent call. When omitted, the provider's default applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Tools the subagent may use while executing a delegated task. The subagent runs as an agentic sub-agent over these tools, then returns its outcome. Only OpenRouter server tools are supported — function tools are rejected — and the list must not include the subagent tool itself.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::OpenRouter.SubagentNestedTool>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubagentServerToolConfig" /> class.
        /// </summary>
        /// <param name="instructions">
        /// System instructions for the subagent. When omitted, the subagent responds with no system prompt of its own.
        /// </param>
        /// <param name="maxCompletionTokens">
        /// Maximum number of output tokens (including reasoning) the subagent may produce. When omitted, the provider's default applies.
        /// </param>
        /// <param name="maxToolCalls">
        /// Maximum number of tool-calling steps the subagent may take during its agentic loop. Capped at 25. Only relevant when the subagent is given tools. Accepted and validated but not yet enforced on the subagent call.
        /// </param>
        /// <param name="model">
        /// Slug of the model that executes delegated tasks (any OpenRouter model). Typically a smaller, cheaper, faster model than the one delegating. When omitted, the model from the outer API request is used. The subagent tool itself cannot be the subagent model.
        /// </param>
        /// <param name="reasoning">
        /// Reasoning configuration forwarded to the subagent call. Use this to control reasoning effort and token budget for models that support extended thinking.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature forwarded to the subagent call. When omitted, the provider's default applies.
        /// </param>
        /// <param name="tools">
        /// Tools the subagent may use while executing a delegated task. The subagent runs as an agentic sub-agent over these tools, then returns its outcome. Only OpenRouter server tools are supported — function tools are rejected — and the list must not include the subagent tool itself.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubagentServerToolConfig(
            string? instructions,
            int? maxCompletionTokens,
            int? maxToolCalls,
            string? model,
            global::OpenRouter.SubagentReasoning? reasoning,
            double? temperature,
            global::System.Collections.Generic.IList<global::OpenRouter.SubagentNestedTool>? tools)
        {
            this.Instructions = instructions;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.MaxToolCalls = maxToolCalls;
            this.Model = model;
            this.Reasoning = reasoning;
            this.Temperature = temperature;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubagentServerToolConfig" /> class.
        /// </summary>
        public SubagentServerToolConfig()
        {
        }

    }
}