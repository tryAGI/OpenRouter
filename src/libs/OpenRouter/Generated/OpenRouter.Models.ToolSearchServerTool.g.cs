
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// OpenRouter built-in server tool: finds tools marked `defer_loading` and makes them callable<br/>
    /// Example: {"parameters":{"max_results":5},"type":"openrouter:tool_search"}
    /// </summary>
    public sealed partial class ToolSearchServerTool
    {
        /// <summary>
        /// Configuration for the openrouter:tool_search server tool<br/>
        /// Example: {"max_results":5}
        /// </summary>
        /// <example>{"max_results":5}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::OpenRouter.ToolSearchServerToolConfig? Parameters { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ToolSearchServerToolTypeJsonConverter))]
        public global::OpenRouter.ToolSearchServerToolType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearchServerTool" /> class.
        /// </summary>
        /// <param name="parameters">
        /// Configuration for the openrouter:tool_search server tool<br/>
        /// Example: {"max_results":5}
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolSearchServerTool(
            global::OpenRouter.ToolSearchServerToolConfig? parameters,
            global::OpenRouter.ToolSearchServerToolType type)
        {
            this.Parameters = parameters;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearchServerTool" /> class.
        /// </summary>
        public ToolSearchServerTool()
        {
        }

    }
}