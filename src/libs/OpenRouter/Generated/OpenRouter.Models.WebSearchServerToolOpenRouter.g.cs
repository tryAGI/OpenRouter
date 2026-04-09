
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// OpenRouter built-in server tool: searches the web for current information
    /// </summary>
    public sealed partial class WebSearchServerToolOpenRouter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::OpenRouter.WebSearchServerToolOpenRouterParameters? Parameters { get; set; }

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
        /// <param name="parameters"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchServerToolOpenRouter(
            global::OpenRouter.WebSearchServerToolOpenRouterParameters? parameters,
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