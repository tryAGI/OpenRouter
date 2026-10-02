
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// OpenRouter built-in server tool: searches the web for current information<br/>
    /// Example: {"parameters":{"max_results":5},"type":"openrouter:web_search"}
    /// </summary>
    public sealed partial class WebSearchServerToolOpenRouter
    {
        /// <summary>
        /// Configuration for the openrouter:web_search server tool<br/>
        /// Example: {"max_results":5,"search_context_size":"medium"}
        /// </summary>
        /// <example>{"max_results":5,"search_context_size":"medium"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::OpenRouter.WebSearchServerToolConfig? Parameters { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.WebSearchServerToolOpenRouterTypeJsonConverter))]
        public global::OpenRouter.WebSearchServerToolOpenRouterType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchServerToolOpenRouter" /> class.
        /// </summary>
        /// <param name="parameters">
        /// Configuration for the openrouter:web_search server tool<br/>
        /// Example: {"max_results":5,"search_context_size":"medium"}
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchServerToolOpenRouter(
            global::OpenRouter.WebSearchServerToolConfig? parameters,
            global::OpenRouter.WebSearchServerToolOpenRouterType type)
        {
            this.Parameters = parameters;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchServerToolOpenRouter" /> class.
        /// </summary>
        public WebSearchServerToolOpenRouter()
        {
        }

    }
}