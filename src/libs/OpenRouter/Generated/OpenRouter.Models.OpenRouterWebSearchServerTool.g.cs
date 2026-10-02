
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// OpenRouter built-in server tool: searches the web for current information<br/>
    /// Example: {"parameters":{"max_results":5},"type":"openrouter:web_search"}
    /// </summary>
    public sealed partial class OpenRouterWebSearchServerTool
    {
        /// <summary>
        /// Example: {"max_results":5,"search_context_size":"medium"}
        /// </summary>
        /// <example>{"max_results":5,"search_context_size":"medium"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::OpenRouter.WebSearchConfig? Parameters { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenRouterWebSearchServerToolTypeJsonConverter))]
        public global::OpenRouter.OpenRouterWebSearchServerToolType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenRouterWebSearchServerTool" /> class.
        /// </summary>
        /// <param name="parameters">
        /// Example: {"max_results":5,"search_context_size":"medium"}
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenRouterWebSearchServerTool(
            global::OpenRouter.WebSearchConfig? parameters,
            global::OpenRouter.OpenRouterWebSearchServerToolType type)
        {
            this.Parameters = parameters;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenRouterWebSearchServerTool" /> class.
        /// </summary>
        public OpenRouterWebSearchServerTool()
        {
        }

    }
}