
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// OpenRouter built-in server tool: delegates self-contained tasks to a smaller, cheaper, faster worker model (any OpenRouter model) mid-generation and returns its outcome. The worker may run as a sub-agent with its own tools.<br/>
    /// Example: {"parameters":{"model":"~anthropic/claude-haiku-latest"},"type":"openrouter:subagent"}
    /// </summary>
    public sealed partial class SubagentServerToolOpenRouter
    {
        /// <summary>
        /// Configuration for one openrouter:subagent server tool entry.<br/>
        /// Example: {"model":"~anthropic/claude-haiku-latest","name":"summarizer"}
        /// </summary>
        /// <example>{"model":"~anthropic/claude-haiku-latest","name":"summarizer"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::OpenRouter.SubagentServerToolConfig? Parameters { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SubagentServerToolOpenRouterTypeJsonConverter))]
        public global::OpenRouter.SubagentServerToolOpenRouterType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubagentServerToolOpenRouter" /> class.
        /// </summary>
        /// <param name="parameters">
        /// Configuration for one openrouter:subagent server tool entry.<br/>
        /// Example: {"model":"~anthropic/claude-haiku-latest","name":"summarizer"}
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubagentServerToolOpenRouter(
            global::OpenRouter.SubagentServerToolConfig? parameters,
            global::OpenRouter.SubagentServerToolOpenRouterType type)
        {
            this.Parameters = parameters;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubagentServerToolOpenRouter" /> class.
        /// </summary>
        public SubagentServerToolOpenRouter()
        {
        }

    }
}