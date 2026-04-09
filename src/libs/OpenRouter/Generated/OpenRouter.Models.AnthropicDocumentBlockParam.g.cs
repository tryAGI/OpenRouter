
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnthropicDocumentBlockParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::OpenRouter.AnthropicCacheControlDirective? CacheControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.AnthropicDocumentBlockParamCitations, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.AnthropicDocumentBlockParamCitations, object>? Citations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicDocumentBlockParamSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnthropicDocumentBlockParamSource Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicDocumentBlockParamTypeJsonConverter))]
        public global::OpenRouter.AnthropicDocumentBlockParamType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicDocumentBlockParam" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="cacheControl"></param>
        /// <param name="citations"></param>
        /// <param name="context"></param>
        /// <param name="title"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicDocumentBlockParam(
            global::OpenRouter.AnthropicDocumentBlockParamSource source,
            global::OpenRouter.AnthropicCacheControlDirective? cacheControl,
            global::OpenRouter.OneOf<global::OpenRouter.AnthropicDocumentBlockParamCitations, object>? citations,
            string? context,
            string? title,
            global::OpenRouter.AnthropicDocumentBlockParamType type)
        {
            this.CacheControl = cacheControl;
            this.Citations = citations;
            this.Context = context;
            this.Source = source;
            this.Title = title;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicDocumentBlockParam" /> class.
        /// </summary>
        public AnthropicDocumentBlockParam()
        {
        }
    }
}