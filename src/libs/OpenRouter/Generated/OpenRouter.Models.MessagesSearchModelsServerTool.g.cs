
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// OpenRouter built-in server tool: searches and filters AI models available on OpenRouter
    /// </summary>
    public sealed partial class MessagesSearchModelsServerTool
    {
        /// <summary>
        /// Configuration for the openrouter:experimental__search_models server tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::OpenRouter.SearchModelsServerToolConfig? Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesSearchModelsServerToolTypeJsonConverter))]
        public global::OpenRouter.MessagesSearchModelsServerToolType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesSearchModelsServerTool" /> class.
        /// </summary>
        /// <param name="parameters">
        /// Configuration for the openrouter:experimental__search_models server tool
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesSearchModelsServerTool(
            global::OpenRouter.SearchModelsServerToolConfig? parameters,
            global::OpenRouter.MessagesSearchModelsServerToolType type)
        {
            this.Parameters = parameters;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesSearchModelsServerTool" /> class.
        /// </summary>
        public MessagesSearchModelsServerTool()
        {
        }

    }
}