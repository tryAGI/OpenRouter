
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnthropicSearchResultBlockParam
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
        public global::OpenRouter.AnthropicSearchResultBlockParamCitations? Citations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.AnthropicTextBlockParam> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicSearchResultBlockParamTypeJsonConverter))]
        public global::OpenRouter.AnthropicSearchResultBlockParamType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicSearchResultBlockParam" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="source"></param>
        /// <param name="title"></param>
        /// <param name="cacheControl"></param>
        /// <param name="citations"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicSearchResultBlockParam(
            global::System.Collections.Generic.IList<global::OpenRouter.AnthropicTextBlockParam> content,
            string source,
            string title,
            global::OpenRouter.AnthropicCacheControlDirective? cacheControl,
            global::OpenRouter.AnthropicSearchResultBlockParamCitations? citations,
            global::OpenRouter.AnthropicSearchResultBlockParamType type)
        {
            this.CacheControl = cacheControl;
            this.Citations = citations;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicSearchResultBlockParam" /> class.
        /// </summary>
        public AnthropicSearchResultBlockParam()
        {
        }
    }
}