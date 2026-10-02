
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// OpenRouter built-in server tool: consults a higher-intelligence advisor model (any OpenRouter model) for guidance mid-generation and returns its response. Include multiple entries to offer several named advisors; at most one entry may omit `name` to act as the default advisor.<br/>
    /// Example: {"parameters":{"model":"~anthropic/claude-opus-latest","name":"reviewer"},"type":"openrouter:advisor"}
    /// </summary>
    public sealed partial class AdvisorServerToolOpenRouter
    {
        /// <summary>
        /// Configuration for one openrouter:advisor server tool entry.<br/>
        /// Example: {"model":"~anthropic/claude-opus-latest","name":"reviewer"}
        /// </summary>
        /// <example>{"model":"~anthropic/claude-opus-latest","name":"reviewer"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::OpenRouter.AdvisorServerToolConfig? Parameters { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AdvisorServerToolOpenRouterTypeJsonConverter))]
        public global::OpenRouter.AdvisorServerToolOpenRouterType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvisorServerToolOpenRouter" /> class.
        /// </summary>
        /// <param name="parameters">
        /// Configuration for one openrouter:advisor server tool entry.<br/>
        /// Example: {"model":"~anthropic/claude-opus-latest","name":"reviewer"}
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdvisorServerToolOpenRouter(
            global::OpenRouter.AdvisorServerToolConfig? parameters,
            global::OpenRouter.AdvisorServerToolOpenRouterType type)
        {
            this.Parameters = parameters;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvisorServerToolOpenRouter" /> class.
        /// </summary>
        public AdvisorServerToolOpenRouter()
        {
        }

    }
}