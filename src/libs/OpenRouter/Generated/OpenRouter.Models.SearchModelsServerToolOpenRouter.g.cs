
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// OpenRouter built-in server tool: searches and filters AI models available on OpenRouter<br/>
    /// Example: {"parameters":{"max_results":5},"type":"openrouter:experimental__search_models"}
    /// </summary>
    public sealed partial class SearchModelsServerToolOpenRouter
    {
        /// <summary>
        /// Configuration for the openrouter:experimental__search_models server tool<br/>
        /// Example: {"max_results":5}
        /// </summary>
        /// <example>{"max_results":5}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::OpenRouter.SearchModelsServerToolConfig? Parameters { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SearchModelsServerToolOpenRouterTypeJsonConverter))]
        public global::OpenRouter.SearchModelsServerToolOpenRouterType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchModelsServerToolOpenRouter" /> class.
        /// </summary>
        /// <param name="parameters">
        /// Configuration for the openrouter:experimental__search_models server tool<br/>
        /// Example: {"max_results":5}
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchModelsServerToolOpenRouter(
            global::OpenRouter.SearchModelsServerToolConfig? parameters,
            global::OpenRouter.SearchModelsServerToolOpenRouterType type)
        {
            this.Parameters = parameters;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchModelsServerToolOpenRouter" /> class.
        /// </summary>
        public SearchModelsServerToolOpenRouter()
        {
        }

    }
}