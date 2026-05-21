
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// text variant
    /// </summary>
    public sealed partial class AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicTextBlockParamTypeJsonConverter))]
        public global::OpenRouter.AnthropicTextBlockParamType Type { get; set; }

        /// <summary>
        /// Enable automatic prompt caching. When set at the top level, the system automatically applies cache breakpoints to the last cacheable block in the request. Currently supported for Anthropic Claude models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::OpenRouter.AnthropicCacheControlDirective? CacheControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicTextBlockParamCitationsItems>? Citations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant2" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type"></param>
        /// <param name="cacheControl">
        /// Enable automatic prompt caching. When set at the top level, the system automatically applies cache breakpoints to the last cacheable block in the request. Currently supported for Anthropic Claude models.
        /// </param>
        /// <param name="citations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant2(
            string text,
            global::OpenRouter.AnthropicTextBlockParamType type,
            global::OpenRouter.AnthropicCacheControlDirective? cacheControl,
            global::System.Collections.Generic.IList<global::OpenRouter.AnthropicTextBlockParamCitationsItems>? citations)
        {
            this.Type = type;
            this.CacheControl = cacheControl;
            this.Citations = citations;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant2" /> class.
        /// </summary>
        public AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant2()
        {
        }

    }
}