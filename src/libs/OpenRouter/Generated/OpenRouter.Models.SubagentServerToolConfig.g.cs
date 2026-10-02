
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Configuration for one openrouter:subagent server tool entry.<br/>
    /// Example: {"model":"~anthropic/claude-haiku-latest","name":"summarizer"}
    /// </summary>
    public sealed partial class SubagentServerToolConfig
    {
        /// <summary>
        /// EXPERIMENTAL — subject to change without notice. When true, the subagent inherits every client function defined in the request's top-level `tools` list. Supported on the Responses API (`/api/v1/responses`) only; other APIs reject it with a `400`.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inherit_functions")]
        public bool? InheritFunctions { get; set; }

        /// <summary>
        /// EXPERIMENTAL — subject to change without notice. Names of the top-level function tools that the subagent will inherit. Any tool that matches by name will be copied fully into the tools array of the subagent. When `inherit_functions` is `true`, this list does nothing, because every client function will be inherited by default. Names are trimmed before validation, so a whitespace-only name is rejected with a `400`. Supported on the Responses API (`/api/v1/responses`) only; other APIs reject it with a `400`.<br/>
        /// Example: [lookup_order]
        /// </summary>
        /// <example>[lookup_order]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inherited_function_names")]
        public global::System.Collections.Generic.IList<string>? InheritedFunctionNames { get; set; }

        /// <summary>
        /// System instructions for the subagent. When omitted, the subagent responds with no system prompt of its own.<br/>
        /// Example: You are a fast, focused worker. Complete the task exactly as described.
        /// </summary>
        /// <example>You are a fast, focused worker. Complete the task exactly as described.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Maximum number of output tokens (including reasoning) the subagent may produce. When omitted, the provider's default applies.<br/>
        /// Example: 2048
        /// </summary>
        /// <example>2048</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// Maximum number of tool-calling steps the subagent may take during its agentic loop. Capped at 25. Only relevant when the subagent is given tools. Forwarded to the subagent call as `max_tool_calls`.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tool_calls")]
        public int? MaxToolCalls { get; set; }

        /// <summary>
        /// Slug of the model that executes delegated tasks (any OpenRouter model). Typically a smaller, cheaper, faster model than the one delegating. When omitted, the model from the outer API request is used. The subagent tool itself cannot be the subagent model.<br/>
        /// Example: ~anthropic/claude-haiku-latest
        /// </summary>
        /// <example>~anthropic/claude-haiku-latest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Optional name for this subagent. The model sees one tool per named subagent (and one default for an unnamed entry). Names must be unique across subagent entries. Letters, digits, spaces, underscores, and dashes; trimmed; 1–64 chars.<br/>
        /// Example: summarizer
        /// </summary>
        /// <example>summarizer</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Reasoning configuration forwarded to the subagent call. Use this to control reasoning effort and token budget for models that support extended thinking.<br/>
        /// Example: {"effort":"low"}
        /// </summary>
        /// <example>{"effort":"low"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::OpenRouter.SubagentReasoning? Reasoning { get; set; }

        /// <summary>
        /// Sampling temperature forwarded to the subagent call. When omitted, the provider's default applies.<br/>
        /// Example: 0.7F
        /// </summary>
        /// <example>0.7F</example>
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
        /// <param name="inheritFunctions">
        /// EXPERIMENTAL — subject to change without notice. When true, the subagent inherits every client function defined in the request's top-level `tools` list. Supported on the Responses API (`/api/v1/responses`) only; other APIs reject it with a `400`.<br/>
        /// Example: true
        /// </param>
        /// <param name="inheritedFunctionNames">
        /// EXPERIMENTAL — subject to change without notice. Names of the top-level function tools that the subagent will inherit. Any tool that matches by name will be copied fully into the tools array of the subagent. When `inherit_functions` is `true`, this list does nothing, because every client function will be inherited by default. Names are trimmed before validation, so a whitespace-only name is rejected with a `400`. Supported on the Responses API (`/api/v1/responses`) only; other APIs reject it with a `400`.<br/>
        /// Example: [lookup_order]
        /// </param>
        /// <param name="instructions">
        /// System instructions for the subagent. When omitted, the subagent responds with no system prompt of its own.<br/>
        /// Example: You are a fast, focused worker. Complete the task exactly as described.
        /// </param>
        /// <param name="maxCompletionTokens">
        /// Maximum number of output tokens (including reasoning) the subagent may produce. When omitted, the provider's default applies.<br/>
        /// Example: 2048
        /// </param>
        /// <param name="maxToolCalls">
        /// Maximum number of tool-calling steps the subagent may take during its agentic loop. Capped at 25. Only relevant when the subagent is given tools. Forwarded to the subagent call as `max_tool_calls`.<br/>
        /// Example: 5
        /// </param>
        /// <param name="model">
        /// Slug of the model that executes delegated tasks (any OpenRouter model). Typically a smaller, cheaper, faster model than the one delegating. When omitted, the model from the outer API request is used. The subagent tool itself cannot be the subagent model.<br/>
        /// Example: ~anthropic/claude-haiku-latest
        /// </param>
        /// <param name="name">
        /// Optional name for this subagent. The model sees one tool per named subagent (and one default for an unnamed entry). Names must be unique across subagent entries. Letters, digits, spaces, underscores, and dashes; trimmed; 1–64 chars.<br/>
        /// Example: summarizer
        /// </param>
        /// <param name="reasoning">
        /// Reasoning configuration forwarded to the subagent call. Use this to control reasoning effort and token budget for models that support extended thinking.<br/>
        /// Example: {"effort":"low"}
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature forwarded to the subagent call. When omitted, the provider's default applies.<br/>
        /// Example: 0.7F
        /// </param>
        /// <param name="tools">
        /// Tools the subagent may use while executing a delegated task. The subagent runs as an agentic sub-agent over these tools, then returns its outcome. Only OpenRouter server tools are supported — function tools are rejected — and the list must not include the subagent tool itself.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubagentServerToolConfig(
            bool? inheritFunctions,
            global::System.Collections.Generic.IList<string>? inheritedFunctionNames,
            string? instructions,
            int? maxCompletionTokens,
            int? maxToolCalls,
            string? model,
            string? name,
            global::OpenRouter.SubagentReasoning? reasoning,
            double? temperature,
            global::System.Collections.Generic.IList<global::OpenRouter.SubagentNestedTool>? tools)
        {
            this.InheritFunctions = inheritFunctions;
            this.InheritedFunctionNames = inheritedFunctionNames;
            this.Instructions = instructions;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.MaxToolCalls = maxToolCalls;
            this.Model = model;
            this.Name = name;
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