
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// OpenRouter built-in server tool: fetches full content from a URL (web page or PDF)
    /// </summary>
    public sealed partial class WebFetchServerTool
    {
        /// <summary>
        /// Configuration for the openrouter:web_fetch server tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::OpenRouter.WebFetchServerToolConfig? Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.WebFetchServerToolTypeJsonConverter))]
        public global::OpenRouter.WebFetchServerToolType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebFetchServerTool" /> class.
        /// </summary>
        /// <param name="parameters">
        /// Configuration for the openrouter:web_fetch server tool
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebFetchServerTool(
            global::OpenRouter.WebFetchServerToolConfig? parameters,
            global::OpenRouter.WebFetchServerToolType type)
        {
            this.Parameters = parameters;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebFetchServerTool" /> class.
        /// </summary>
        public WebFetchServerTool()
        {
        }
    }
}